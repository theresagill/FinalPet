namespace FinalPet
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PetButton = new System.Windows.Forms.Button();
            this.PlayButton = new System.Windows.Forms.Button();
            this.DrinkButton = new System.Windows.Forms.Button();
            this.FeedButton = new System.Windows.Forms.Button();
            this.PetSelectedLabel = new System.Windows.Forms.Label();
            this.petFacts = new System.Windows.Forms.GroupBox();
            this.boredomMeter = new System.Windows.Forms.ProgressBar();
            this.label7 = new System.Windows.Forms.Label();
            this.sleepMeter = new System.Windows.Forms.ProgressBar();
            this.label6 = new System.Windows.Forms.Label();
            this.thirstMeter = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.hungerMeter = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.foodAmountBar = new System.Windows.Forms.ProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.waterAmountBar = new System.Windows.Forms.ProgressBar();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.PetSaveButton = new System.Windows.Forms.Button();
            this.PetLoadButton = new System.Windows.Forms.Button();
            this.openPetDialog = new System.Windows.Forms.OpenFileDialog();
            this.savePetDialog = new System.Windows.Forms.SaveFileDialog();
            this.petStateBox = new System.Windows.Forms.GroupBox();
            this.birdBox = new System.Windows.Forms.PictureBox();
            this.catBox = new System.Windows.Forms.PictureBox();
            this.dogBox = new System.Windows.Forms.PictureBox();
            this.stateTextBox = new System.Windows.Forms.TextBox();
            this.petImageState = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lonelyMeter = new System.Windows.Forms.ProgressBar();
            this.groupBox1.SuspendLayout();
            this.petFacts.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.petStateBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.birdBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petImageState)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PetButton);
            this.groupBox1.Controls.Add(this.PlayButton);
            this.groupBox1.Controls.Add(this.DrinkButton);
            this.groupBox1.Controls.Add(this.FeedButton);
            this.groupBox1.Location = new System.Drawing.Point(425, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(155, 142);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pet Controls";
            // 
            // PetButton
            // 
            this.PetButton.Enabled = false;
            this.PetButton.Location = new System.Drawing.Point(29, 106);
            this.PetButton.Name = "PetButton";
            this.PetButton.Size = new System.Drawing.Size(112, 23);
            this.PetButton.TabIndex = 3;
            this.PetButton.Text = "Hug the Pet";
            this.PetButton.UseVisualStyleBackColor = true;
            this.PetButton.Visible = false;
            this.PetButton.Click += new System.EventHandler(this.PetButton_Click);
            // 
            // PlayButton
            // 
            this.PlayButton.Enabled = false;
            this.PlayButton.Location = new System.Drawing.Point(29, 77);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(112, 23);
            this.PlayButton.TabIndex = 2;
            this.PlayButton.Text = "Play with Pet";
            this.PlayButton.UseVisualStyleBackColor = false;
            this.PlayButton.Visible = false;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // DrinkButton
            // 
            this.DrinkButton.Location = new System.Drawing.Point(29, 51);
            this.DrinkButton.Name = "DrinkButton";
            this.DrinkButton.Size = new System.Drawing.Size(112, 20);
            this.DrinkButton.TabIndex = 1;
            this.DrinkButton.Text = "Put water in pet dish";
            this.DrinkButton.UseVisualStyleBackColor = true;
            this.DrinkButton.Click += new System.EventHandler(this.DrinkButton_Click);
            // 
            // FeedButton
            // 
            this.FeedButton.Location = new System.Drawing.Point(29, 22);
            this.FeedButton.Name = "FeedButton";
            this.FeedButton.Size = new System.Drawing.Size(112, 23);
            this.FeedButton.TabIndex = 0;
            this.FeedButton.Text = "Put food in pet dish";
            this.FeedButton.UseVisualStyleBackColor = true;
            this.FeedButton.Click += new System.EventHandler(this.FeedButton_Click);
            // 
            // PetSelectedLabel
            // 
            this.PetSelectedLabel.AutoSize = true;
            this.PetSelectedLabel.Location = new System.Drawing.Point(33, 128);
            this.PetSelectedLabel.Name = "PetSelectedLabel";
            this.PetSelectedLabel.Size = new System.Drawing.Size(211, 13);
            this.PetSelectedLabel.TabIndex = 5;
            this.PetSelectedLabel.Text = "                                                                    ";
            // 
            // petFacts
            // 
            this.petFacts.Controls.Add(this.lonelyMeter);
            this.petFacts.Controls.Add(this.label1);
            this.petFacts.Controls.Add(this.boredomMeter);
            this.petFacts.Controls.Add(this.label7);
            this.petFacts.Controls.Add(this.sleepMeter);
            this.petFacts.Controls.Add(this.label6);
            this.petFacts.Controls.Add(this.thirstMeter);
            this.petFacts.Controls.Add(this.label3);
            this.petFacts.Controls.Add(this.hungerMeter);
            this.petFacts.Controls.Add(this.label2);
            this.petFacts.Location = new System.Drawing.Point(406, 260);
            this.petFacts.Name = "petFacts";
            this.petFacts.Size = new System.Drawing.Size(190, 169);
            this.petFacts.TabIndex = 7;
            this.petFacts.TabStop = false;
            this.petFacts.Text = "Pet Facts";
            // 
            // boredomMeter
            // 
            this.boredomMeter.Location = new System.Drawing.Point(64, 91);
            this.boredomMeter.Name = "boredomMeter";
            this.boredomMeter.Size = new System.Drawing.Size(100, 20);
            this.boredomMeter.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Boredom";
            // 
            // sleepMeter
            // 
            this.sleepMeter.Location = new System.Drawing.Point(64, 66);
            this.sleepMeter.Name = "sleepMeter";
            this.sleepMeter.Size = new System.Drawing.Size(100, 19);
            this.sleepMeter.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Tiredness";
            // 
            // thirstMeter
            // 
            this.thirstMeter.Location = new System.Drawing.Point(64, 43);
            this.thirstMeter.Name = "thirstMeter";
            this.thirstMeter.Size = new System.Drawing.Size(100, 17);
            this.thirstMeter.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Thirst";
            // 
            // hungerMeter
            // 
            this.hungerMeter.Location = new System.Drawing.Point(64, 19);
            this.hungerMeter.Name = "hungerMeter";
            this.hungerMeter.Size = new System.Drawing.Size(100, 18);
            this.hungerMeter.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Hunger";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.foodAmountBar);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.waterAmountBar);
            this.groupBox2.Location = new System.Drawing.Point(48, 273);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(269, 68);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resources";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(128, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Food Dish";
            // 
            // foodAmountBar
            // 
            this.foodAmountBar.Location = new System.Drawing.Point(122, 19);
            this.foodAmountBar.Name = "foodAmountBar";
            this.foodAmountBar.Size = new System.Drawing.Size(100, 23);
            this.foodAmountBar.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Water Dish";
            // 
            // waterAmountBar
            // 
            this.waterAmountBar.Location = new System.Drawing.Point(6, 19);
            this.waterAmountBar.Name = "waterAmountBar";
            this.waterAmountBar.Size = new System.Drawing.Size(100, 23);
            this.waterAmountBar.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.PetSaveButton);
            this.groupBox3.Controls.Add(this.PetLoadButton);
            this.groupBox3.Location = new System.Drawing.Point(42, 354);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(256, 75);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pet Management";
            // 
            // PetSaveButton
            // 
            this.PetSaveButton.Location = new System.Drawing.Point(127, 19);
            this.PetSaveButton.Name = "PetSaveButton";
            this.PetSaveButton.Size = new System.Drawing.Size(100, 25);
            this.PetSaveButton.TabIndex = 1;
            this.PetSaveButton.Text = "Save Pet";
            this.PetSaveButton.UseVisualStyleBackColor = true;
            this.PetSaveButton.Click += new System.EventHandler(this.PetSaveButton_Click);
            // 
            // PetLoadButton
            // 
            this.PetLoadButton.Location = new System.Drawing.Point(6, 19);
            this.PetLoadButton.Name = "PetLoadButton";
            this.PetLoadButton.Size = new System.Drawing.Size(96, 25);
            this.PetLoadButton.TabIndex = 0;
            this.PetLoadButton.Text = "Load Pet";
            this.PetLoadButton.UseVisualStyleBackColor = true;
            this.PetLoadButton.Click += new System.EventHandler(this.PetLoadButton_Click);
            // 
            // openPetDialog
            // 
            this.openPetDialog.FileName = "openFileDialog1";
            this.openPetDialog.Filter = "pet files(*.pet)|*.pet|all files(*.*)|*.*";
            // 
            // savePetDialog
            // 
            this.savePetDialog.DefaultExt = "pet";
            this.savePetDialog.Filter = "pet files|*.pet";
            // 
            // petStateBox
            // 
            this.petStateBox.Controls.Add(this.birdBox);
            this.petStateBox.Controls.Add(this.catBox);
            this.petStateBox.Controls.Add(this.dogBox);
            this.petStateBox.Location = new System.Drawing.Point(436, 12);
            this.petStateBox.Name = "petStateBox";
            this.petStateBox.Size = new System.Drawing.Size(160, 65);
            this.petStateBox.TabIndex = 10;
            this.petStateBox.TabStop = false;
            this.petStateBox.Text = "Please select your pet";
            // 
            // birdBox
            // 
            this.birdBox.Image = ((System.Drawing.Image)(resources.GetObject("birdBox.Image")));
            this.birdBox.Location = new System.Drawing.Point(107, 19);
            this.birdBox.Name = "birdBox";
            this.birdBox.Size = new System.Drawing.Size(38, 38);
            this.birdBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.birdBox.TabIndex = 2;
            this.birdBox.TabStop = false;
            this.birdBox.Click += new System.EventHandler(this.BirdBox_Click_1);
            // 
            // catBox
            // 
            this.catBox.Image = global::FinalPet.Properties.Resources.cat;
            this.catBox.Location = new System.Drawing.Point(54, 19);
            this.catBox.Name = "catBox";
            this.catBox.Size = new System.Drawing.Size(47, 38);
            this.catBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.catBox.TabIndex = 1;
            this.catBox.TabStop = false;
            this.catBox.Click += new System.EventHandler(this.CatBox_Click_1);
            // 
            // dogBox
            // 
            this.dogBox.Image = ((System.Drawing.Image)(resources.GetObject("dogBox.Image")));
            this.dogBox.Location = new System.Drawing.Point(13, 19);
            this.dogBox.Name = "dogBox";
            this.dogBox.Size = new System.Drawing.Size(35, 38);
            this.dogBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dogBox.TabIndex = 0;
            this.dogBox.TabStop = false;
            this.dogBox.Click += new System.EventHandler(this.DogBox_Click_1);
            // 
            // stateTextBox
            // 
            this.stateTextBox.Location = new System.Drawing.Point(22, 7);
            this.stateTextBox.Name = "stateTextBox";
            this.stateTextBox.Size = new System.Drawing.Size(247, 20);
            this.stateTextBox.TabIndex = 13;
            this.stateTextBox.Text = "Your pet";
            // 
            // petImageState
            // 
            this.petImageState.Image = global::FinalPet.Properties.Resources.catdrinking;
            this.petImageState.Location = new System.Drawing.Point(12, 31);
            this.petImageState.Name = "petImageState";
            this.petImageState.Size = new System.Drawing.Size(317, 226);
            this.petImageState.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.petImageState.TabIndex = 12;
            this.petImageState.TabStop = false;
            this.petImageState.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Loneliness";
            // 
            // lonelyMeter
            // 
            this.lonelyMeter.Location = new System.Drawing.Point(64, 117);
            this.lonelyMeter.Name = "lonelyMeter";
            this.lonelyMeter.Size = new System.Drawing.Size(100, 21);
            this.lonelyMeter.TabIndex = 9;
            // 
            // Form1
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.stateTextBox);
            this.Controls.Add(this.petImageState);
            this.Controls.Add(this.petStateBox);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.petFacts);
            this.Controls.Add(this.PetSelectedLabel);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.petFacts.ResumeLayout(false);
            this.petFacts.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.petStateBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.birdBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petImageState)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button PetButton;
        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.Button DrinkButton;
        private System.Windows.Forms.Button FeedButton;
        private System.Windows.Forms.Label PetSelectedLabel;
        private System.Windows.Forms.GroupBox petFacts;
        private System.Windows.Forms.ProgressBar thirstMeter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar hungerMeter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar foodAmountBar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar waterAmountBar;
        private System.Windows.Forms.ProgressBar sleepMeter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button PetSaveButton;
        private System.Windows.Forms.Button PetLoadButton;
        private System.Windows.Forms.OpenFileDialog openPetDialog;
        private System.Windows.Forms.SaveFileDialog savePetDialog;
        private System.Windows.Forms.ProgressBar boredomMeter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox petStateBox;
        private System.Windows.Forms.PictureBox birdBox;
        private System.Windows.Forms.PictureBox catBox;
        private System.Windows.Forms.PictureBox dogBox;
        private System.Windows.Forms.PictureBox petImageState;
        private System.Windows.Forms.TextBox stateTextBox;
        private System.Windows.Forms.ProgressBar lonelyMeter;
        private System.Windows.Forms.Label label1;
    }
}

