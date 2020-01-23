using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace FinalPet
{
    public partial class Form1 : Form
    {
        //fields
        public Pet myPet;

        protected int currentFood = 10;
        protected int currentWater = 10;

        BinaryFormatter formatter = new BinaryFormatter();

        string typeOfStateClass;

        //Timer Stuff
        Timer mainLoopTimer;


        //Constructor
        public Form1()
        {
            InitializeComponent();


            mainLoopTimer = new Timer();
            mainLoopTimer.Interval = 17;
            mainLoopTimer.Tick += MainLoopTimer_Tick; //subscribe
                                                      //this method to the event
                                    
            // don't start the timer until a pet is selected
                                                      //mainLoopTimer.Start();
        }
        private void MainLoopTimer_Tick(object sender, EventArgs e)
        {
            myPet.IncreaseNeedCounters();
            myPet.Updateneeds();
            myPet.CallState();
            //check if pet has been neglected before UpdateView
            if (myPet.TakeAway())
                mainLoopTimer.Stop();
            petImageState.Image = myPet.GetImage();
            UpdateView();

            
        }

        public void AfterButton(string inputaction)
        {
            switch (inputaction)
            {
                case "Feed":
                          myPet.PetCurrentFood++;
                         break;
                case "Drink":
                         myPet.PetCurrentWater++;
                         break;
                case "Play":
                    //button is only visible and enabled
                    //during time that pet wants to play
                    //see playing.cs
                    if (myPet.PetBoredom > 0)
                        myPet.PetBoredom--;
                    if (myPet.PetBoredom == myPet.Min_Boredom)
                        myPet.PetBoredom = 0;
                     //MessageBox.Show("PetBoredom is " + myPet.PetBoredom);
                     break;
                case "Hug":
                    //button is only visible and enabled
                    //during time that pet is still to be hugged
                    //see Affectioning.cs
                    if (myPet.PetLonely > 0)
                        myPet.PetLonely--;
                    if (myPet.PetLonely == myPet.Min_Lonely)
                        myPet.PetLonely = 0;
                    //MessageBox.Show("PetLonely is " + myPet.PetLonely);
                    break;

                default: break;



            }


        }
        private void FeedButton_Click(object sender, EventArgs e)
        {
            if (myPet == null)
                MessageBox.Show("Please select a pet first");
            else
                AfterButton("Feed");

        }

        private void DrinkButton_Click(object sender, EventArgs e)
        {
            if (myPet == null)
                MessageBox.Show("Please select a pet first");
            else
                AfterButton("Drink");
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            AfterButton("Play");
        }

        private void PetButton_Click(object sender, EventArgs e)
        {
            AfterButton("Hug");
        }
        //old button
        private void DogBox_Click(object sender, EventArgs e)
        {
        }
        //old button
        private void CatBox_Click(object sender, EventArgs e)
        {
            
        }
        //old button
        private void BirdBox_Click(object sender, EventArgs e)
        {
            
        }
        public void UpdateView()
        {
            hungerMeter.Value = myPet.PetHunger;
            thirstMeter.Value = myPet.PetThirst;
            sleepMeter.Value = myPet.PetTired;
            boredomMeter.Value = myPet.PetBoredom;
            lonelyMeter.Value = myPet.PetLonely;
            PlayButton.Enabled = myPet.PetEnabled;
            PlayButton.Visible = myPet.PetVisible;
            PetButton.Enabled = myPet.PetHugEnabled;
            PetButton.Visible = myPet.PetHugVisible;
            waterAmountBar.Value = myPet.PetCurrentWater;
            foodAmountBar.Value = myPet.PetCurrentFood;

            typeOfStateClass = myPet.State.GetType().Name;
            switch (typeOfStateClass)
            {
                case "Neutral":
                    stateTextBox.Text = "Your pet.";
                    myPet.CurrentImage = myPet.PetImage;
                    break;

                case "Eating":  
                    stateTextBox.Text = "The pet is eating.";
                    break;
                case "Drinking":
                    stateTextBox.Text = "The pet is drinking.";
                    break;
                case "Sleeping":
                    stateTextBox.Text = "The pet is sleeping.";
                    break;
                case "Praying":
                    stateTextBox.Text = "The pet is praying.";
                    break;
                case "Playing":
                    stateTextBox.Text = "The pet is playing. Hit Play button to play.";
                    break;
                case "Affectioning":
                    stateTextBox.Text = "Hit Hug button to give the pet a big hug!";
                    break;
                default:
                    stateTextBox.Text = "The pet is away.";
                    break;
            }
        }//end of UpdateView

        private void PetLoadButton_Click(object sender, EventArgs e)
        {
            

                    if (openPetDialog.ShowDialog() == DialogResult.OK)
                    {
                        using (Stream input = File.OpenRead(openPetDialog.FileName))
                        {
                            try
                            {
                                myPet = (Pet)formatter.Deserialize(input);
                                MessageBox.Show("Pet loaded from " + openPetDialog.FileName);
                                PetSelectedLabel.Text = "Pet being loaded.";
                                catBox.Enabled = false; //prevent more clicks
                                birdBox.Enabled = false;
                                dogBox.Enabled = false;
                                mainLoopTimer.Start();
                            }
                            catch (SerializationException)
                            {
                                MessageBox.Show("File error, Pet not loaded");
                            }
                        }//end using
                    }//end if
                    

        }//end of PetLoadButton

        private void PetSaveButton_Click(object sender, EventArgs e)
        {
            if (myPet != null)
            {
                        if (savePetDialog.ShowDialog() == DialogResult.OK)
                        {
                            using (Stream output = File.Create(savePetDialog.FileName))
                            {
                                try
                                {
                                    formatter.Serialize(output, myPet);
                                    MessageBox.Show("Pet saved at " + savePetDialog.FileName);
                                }
                                catch (SerializationException)
                                {
                                    MessageBox.Show("File error, Pet not saved");
                                }

                            }
                        }// if (savePetDialog..
                        
                
            }// end of myPet is not null (they have selected a pet)
            else
            {
                MessageBox.Show("Please select a pet");
            }

        }//PetSaveButton

        private void CatBox_Click_1(object sender, EventArgs e)
        {
            myPet = new Cat(currentFood, currentWater, catBox.Image);
            // Begin in a neutral state (not Eating)
            myPet.State = new Neutral(myPet);
            catBox.Enabled = false; //prevent more clicks
            birdBox.Enabled = false;
            dogBox.Enabled = false;
            petImageState.Image = catBox.Image;
            petImageState.Visible = true;
            mainLoopTimer.Start();

        }//end of CatBox_Click_1

        private void DogBox_Click_1(object sender, EventArgs e)
        {
            myPet = new Dog(currentFood, currentWater, dogBox.Image);
            // Begin in a neutral state (not Eating)
            myPet.State = new Neutral(myPet);
            catBox.Enabled = false; //prevent more clicks
            birdBox.Enabled = false;
            dogBox.Enabled = false;
            petImageState.Image = dogBox.Image;
            petImageState.Visible = true;
            mainLoopTimer.Start();

        }

        private void BirdBox_Click_1(object sender, EventArgs e)
        {
            myPet = new Bird(currentFood, currentWater, birdBox.Image);
            // Begin in a neutral state (not Eating)
            myPet.State = new Neutral(myPet);
            catBox.Enabled = false; //prevent more clicks
            birdBox.Enabled = false;
            dogBox.Enabled = false;
            petImageState.Image = birdBox.Image;
            petImageState.Visible = true;
            mainLoopTimer.Start();

        }
    }
    
}
