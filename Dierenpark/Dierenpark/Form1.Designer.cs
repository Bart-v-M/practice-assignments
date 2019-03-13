namespace Dierenpark
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
            this.topText_label = new System.Windows.Forms.Label();
            this.subscriberDOB_label = new System.Windows.Forms.Label();
            this.subscriberDOB_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.subscriberAge_label = new System.Windows.Forms.Label();
            this.subscriberAge = new System.Windows.Forms.Label();
            this.subscriptionType_label = new System.Windows.Forms.Label();
            this.subscriptionType_comboBox = new System.Windows.Forms.ComboBox();
            this.partnerAge = new System.Windows.Forms.Label();
            this.partnerAge_label = new System.Windows.Forms.Label();
            this.partnerDOB_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.partnerDOB_label = new System.Windows.Forms.Label();
            this.numOfKids_label = new System.Windows.Forms.Label();
            this.numOfKids_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.subscriptionPrice_label = new System.Windows.Forms.Label();
            this.subscriptionPrice = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.giraffe_pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numOfKids_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giraffe_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // topText_label
            // 
            this.topText_label.AutoSize = true;
            this.topText_label.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topText_label.Location = new System.Drawing.Point(25, 35);
            this.topText_label.Name = "topText_label";
            this.topText_label.Size = new System.Drawing.Size(196, 21);
            this.topText_label.TabIndex = 0;
            this.topText_label.Text = "Invoer abonneegegevens";
            // 
            // subscriberDOB_label
            // 
            this.subscriberDOB_label.AutoSize = true;
            this.subscriberDOB_label.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subscriberDOB_label.Location = new System.Drawing.Point(25, 160);
            this.subscriberDOB_label.Name = "subscriberDOB_label";
            this.subscriberDOB_label.Size = new System.Drawing.Size(164, 17);
            this.subscriberDOB_label.TabIndex = 1;
            this.subscriberDOB_label.Text = "Geboortedatum aanvrager";
            // 
            // subscriberDOB_dateTimePicker
            // 
            this.subscriberDOB_dateTimePicker.CalendarTitleBackColor = System.Drawing.SystemColors.Window;
            this.subscriberDOB_dateTimePicker.CustomFormat = "dd-MM-yyyy";
            this.subscriberDOB_dateTimePicker.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subscriberDOB_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.subscriberDOB_dateTimePicker.Location = new System.Drawing.Point(210, 154);
            this.subscriberDOB_dateTimePicker.MaxDate = new System.DateTime(2018, 12, 16, 0, 0, 0, 0);
            this.subscriberDOB_dateTimePicker.MinDate = new System.DateTime(1910, 1, 1, 0, 0, 0, 0);
            this.subscriberDOB_dateTimePicker.Name = "subscriberDOB_dateTimePicker";
            this.subscriberDOB_dateTimePicker.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.subscriberDOB_dateTimePicker.Size = new System.Drawing.Size(100, 25);
            this.subscriberDOB_dateTimePicker.TabIndex = 2;
            this.subscriberDOB_dateTimePicker.TabStop = false;
            this.subscriberDOB_dateTimePicker.Value = new System.DateTime(2018, 12, 16, 0, 0, 0, 0);
            this.subscriberDOB_dateTimePicker.ValueChanged += new System.EventHandler(this.SubscriberDOB_dateTimePicker_ValueChanged);
            // 
            // subscriberAge_label
            // 
            this.subscriberAge_label.AutoSize = true;
            this.subscriberAge_label.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subscriberAge_label.Location = new System.Drawing.Point(25, 180);
            this.subscriberAge_label.Name = "subscriberAge_label";
            this.subscriberAge_label.Size = new System.Drawing.Size(53, 17);
            this.subscriberAge_label.TabIndex = 3;
            this.subscriberAge_label.Text = "Leeftijd:";
            // 
            // subscriberAge
            // 
            this.subscriberAge.AutoSize = true;
            this.subscriberAge.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subscriberAge.Location = new System.Drawing.Point(74, 180);
            this.subscriberAge.Name = "subscriberAge";
            this.subscriberAge.Size = new System.Drawing.Size(13, 17);
            this.subscriberAge.TabIndex = 4;
            this.subscriberAge.Text = "-";
            // 
            // subscriptionType_label
            // 
            this.subscriptionType_label.AutoSize = true;
            this.subscriptionType_label.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subscriptionType_label.Location = new System.Drawing.Point(25, 95);
            this.subscriptionType_label.Name = "subscriptionType_label";
            this.subscriptionType_label.Size = new System.Drawing.Size(112, 17);
            this.subscriptionType_label.TabIndex = 5;
            this.subscriptionType_label.Text = "Type abonnement";
            // 
            // subscriptionType_comboBox
            // 
            this.subscriptionType_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.subscriptionType_comboBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subscriptionType_comboBox.FormattingEnabled = true;
            this.subscriptionType_comboBox.Items.AddRange(new object[] {
            "persoonlijk",
            "echtpaar"});
            this.subscriptionType_comboBox.Location = new System.Drawing.Point(210, 92);
            this.subscriptionType_comboBox.Name = "subscriptionType_comboBox";
            this.subscriptionType_comboBox.Size = new System.Drawing.Size(100, 25);
            this.subscriptionType_comboBox.TabIndex = 6;
            this.subscriptionType_comboBox.SelectedIndexChanged += new System.EventHandler(this.SubscriptionType_comboBox_SelectedIndexChanged);
            // 
            // partnerAge
            // 
            this.partnerAge.AutoSize = true;
            this.partnerAge.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partnerAge.Location = new System.Drawing.Point(74, 250);
            this.partnerAge.Name = "partnerAge";
            this.partnerAge.Size = new System.Drawing.Size(13, 17);
            this.partnerAge.TabIndex = 10;
            this.partnerAge.Text = "-";
            // 
            // partnerAge_label
            // 
            this.partnerAge_label.AutoSize = true;
            this.partnerAge_label.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partnerAge_label.Location = new System.Drawing.Point(25, 250);
            this.partnerAge_label.Name = "partnerAge_label";
            this.partnerAge_label.Size = new System.Drawing.Size(53, 17);
            this.partnerAge_label.TabIndex = 9;
            this.partnerAge_label.Text = "Leeftijd:";
            // 
            // partnerDOB_dateTimePicker
            // 
            this.partnerDOB_dateTimePicker.CalendarTitleBackColor = System.Drawing.SystemColors.Window;
            this.partnerDOB_dateTimePicker.CustomFormat = "dd-MM-yyyy";
            this.partnerDOB_dateTimePicker.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partnerDOB_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.partnerDOB_dateTimePicker.Location = new System.Drawing.Point(210, 224);
            this.partnerDOB_dateTimePicker.MaxDate = new System.DateTime(2018, 12, 16, 0, 0, 0, 0);
            this.partnerDOB_dateTimePicker.MinDate = new System.DateTime(1910, 1, 1, 0, 0, 0, 0);
            this.partnerDOB_dateTimePicker.Name = "partnerDOB_dateTimePicker";
            this.partnerDOB_dateTimePicker.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.partnerDOB_dateTimePicker.Size = new System.Drawing.Size(100, 25);
            this.partnerDOB_dateTimePicker.TabIndex = 8;
            this.partnerDOB_dateTimePicker.TabStop = false;
            this.partnerDOB_dateTimePicker.Value = new System.DateTime(2018, 12, 16, 0, 0, 0, 0);
            this.partnerDOB_dateTimePicker.ValueChanged += new System.EventHandler(this.PartnerDOB_dateTimePicker_ValueChanged);
            // 
            // partnerDOB_label
            // 
            this.partnerDOB_label.AutoSize = true;
            this.partnerDOB_label.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partnerDOB_label.Location = new System.Drawing.Point(25, 230);
            this.partnerDOB_label.Name = "partnerDOB_label";
            this.partnerDOB_label.Size = new System.Drawing.Size(148, 17);
            this.partnerDOB_label.TabIndex = 7;
            this.partnerDOB_label.Text = "Geboortedatum partner";
            // 
            // numOfKids_label
            // 
            this.numOfKids_label.AutoSize = true;
            this.numOfKids_label.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numOfKids_label.Location = new System.Drawing.Point(25, 300);
            this.numOfKids_label.Name = "numOfKids_label";
            this.numOfKids_label.Size = new System.Drawing.Size(98, 17);
            this.numOfKids_label.TabIndex = 11;
            this.numOfKids_label.Text = "Aantal kinderen";
            // 
            // numOfKids_numericUpDown
            // 
            this.numOfKids_numericUpDown.BackColor = System.Drawing.SystemColors.Window;
            this.numOfKids_numericUpDown.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numOfKids_numericUpDown.Location = new System.Drawing.Point(210, 298);
            this.numOfKids_numericUpDown.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numOfKids_numericUpDown.Name = "numOfKids_numericUpDown";
            this.numOfKids_numericUpDown.Size = new System.Drawing.Size(35, 25);
            this.numOfKids_numericUpDown.TabIndex = 12;
            // 
            // subscriptionPrice_label
            // 
            this.subscriptionPrice_label.AutoSize = true;
            this.subscriptionPrice_label.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subscriptionPrice_label.Location = new System.Drawing.Point(25, 435);
            this.subscriptionPrice_label.Name = "subscriptionPrice_label";
            this.subscriptionPrice_label.Size = new System.Drawing.Size(208, 21);
            this.subscriptionPrice_label.TabIndex = 13;
            this.subscriptionPrice_label.Text = "Abonnementsprijs per jaar:";
            // 
            // subscriptionPrice
            // 
            this.subscriptionPrice.AutoSize = true;
            this.subscriptionPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subscriptionPrice.Location = new System.Drawing.Point(230, 435);
            this.subscriptionPrice.Name = "subscriptionPrice";
            this.subscriptionPrice.Size = new System.Drawing.Size(16, 21);
            this.subscriptionPrice.TabIndex = 14;
            this.subscriptionPrice.Text = "-";
            // 
            // calculateButton
            // 
            this.calculateButton.BackColor = System.Drawing.Color.MediumAquamarine;
            this.calculateButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.calculateButton.Location = new System.Drawing.Point(25, 385);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(182, 32);
            this.calculateButton.TabIndex = 15;
            this.calculateButton.Text = "Bereken abonnementsprijs";
            this.calculateButton.UseVisualStyleBackColor = false;
            this.calculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // giraffe_pictureBox
            // 
            this.giraffe_pictureBox.Image = global::Dierenpark.Properties.Resources.Giraffe_Symbol__control_version_;
            this.giraffe_pictureBox.Location = new System.Drawing.Point(310, 375);
            this.giraffe_pictureBox.Name = "giraffe_pictureBox";
            this.giraffe_pictureBox.Size = new System.Drawing.Size(75, 81);
            this.giraffe_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.giraffe_pictureBox.TabIndex = 16;
            this.giraffe_pictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(409, 511);
            this.Controls.Add(this.giraffe_pictureBox);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.subscriptionPrice);
            this.Controls.Add(this.subscriptionPrice_label);
            this.Controls.Add(this.numOfKids_numericUpDown);
            this.Controls.Add(this.numOfKids_label);
            this.Controls.Add(this.partnerAge);
            this.Controls.Add(this.partnerAge_label);
            this.Controls.Add(this.partnerDOB_dateTimePicker);
            this.Controls.Add(this.partnerDOB_label);
            this.Controls.Add(this.subscriptionType_comboBox);
            this.Controls.Add(this.subscriptionType_label);
            this.Controls.Add(this.subscriberAge);
            this.Controls.Add(this.subscriberAge_label);
            this.Controls.Add(this.subscriberDOB_dateTimePicker);
            this.Controls.Add(this.subscriberDOB_label);
            this.Controls.Add(this.topText_label);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Noorder Dierenpark Emmen  -  Abonnementsprijsberekening";
            ((System.ComponentModel.ISupportInitialize)(this.numOfKids_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giraffe_pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label topText_label;
        private System.Windows.Forms.Label subscriberDOB_label;
        private System.Windows.Forms.DateTimePicker subscriberDOB_dateTimePicker;
        private System.Windows.Forms.Label subscriberAge_label;
        private System.Windows.Forms.Label subscriberAge;
        private System.Windows.Forms.Label subscriptionType_label;
        private System.Windows.Forms.ComboBox subscriptionType_comboBox;
        private System.Windows.Forms.Label partnerAge;
        private System.Windows.Forms.Label partnerAge_label;
        private System.Windows.Forms.DateTimePicker partnerDOB_dateTimePicker;
        private System.Windows.Forms.Label partnerDOB_label;
        private System.Windows.Forms.Label numOfKids_label;
        private System.Windows.Forms.NumericUpDown numOfKids_numericUpDown;
        private System.Windows.Forms.Label subscriptionPrice_label;
        private System.Windows.Forms.Label subscriptionPrice;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.PictureBox giraffe_pictureBox;
    }
}

