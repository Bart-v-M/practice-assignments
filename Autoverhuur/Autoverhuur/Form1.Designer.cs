namespace Autoverhuur
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
            this.label_carType = new System.Windows.Forms.Label();
            this.comboBox_carType = new System.Windows.Forms.ComboBox();
            this.label_startDate = new System.Windows.Forms.Label();
            this.textBox_startDate = new System.Windows.Forms.TextBox();
            this.textBox_endDate = new System.Windows.Forms.TextBox();
            this.label_endDate = new System.Windows.Forms.Label();
            this.label_startKilometres = new System.Windows.Forms.Label();
            this.textBox_startKilometres = new System.Windows.Forms.TextBox();
            this.button_calculateRentalPrice = new System.Windows.Forms.Button();
            this.label_rentalPrice = new System.Windows.Forms.Label();
            this.label_endKilometres = new System.Windows.Forms.Label();
            this.textBox_endKilometres = new System.Windows.Forms.TextBox();
            this.label_rentalPriceText = new System.Windows.Forms.Label();
            this.label_FuelCostsOnTheRoad = new System.Windows.Forms.Label();
            this.textBox_fuelCostsOnTheRoad = new System.Windows.Forms.TextBox();
            this.label_eurosign = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_carType
            // 
            this.label_carType.AutoSize = true;
            this.label_carType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_carType.Location = new System.Drawing.Point(60, 77);
            this.label_carType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_carType.Name = "label_carType";
            this.label_carType.Size = new System.Drawing.Size(135, 31);
            this.label_carType.TabIndex = 0;
            this.label_carType.Text = "Type auto";
            // 
            // comboBox_carType
            // 
            this.comboBox_carType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_carType.FormattingEnabled = true;
            this.comboBox_carType.Items.AddRange(new object[] {
            "personenauto",
            "personenbus"});
            this.comboBox_carType.Location = new System.Drawing.Point(626, 73);
            this.comboBox_carType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox_carType.Name = "comboBox_carType";
            this.comboBox_carType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBox_carType.Size = new System.Drawing.Size(184, 33);
            this.comboBox_carType.TabIndex = 1;
            // 
            // label_startDate
            // 
            this.label_startDate.AutoSize = true;
            this.label_startDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_startDate.Location = new System.Drawing.Point(60, 146);
            this.label_startDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_startDate.Name = "label_startDate";
            this.label_startDate.Size = new System.Drawing.Size(318, 31);
            this.label_startDate.TabIndex = 2;
            this.label_startDate.Text = "Vertrekdatum (dd-mm-jjjj)";
            // 
            // textBox_startDate
            // 
            this.textBox_startDate.Location = new System.Drawing.Point(680, 146);
            this.textBox_startDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_startDate.Name = "textBox_startDate";
            this.textBox_startDate.Size = new System.Drawing.Size(130, 31);
            this.textBox_startDate.TabIndex = 2;
            this.textBox_startDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox_endDate
            // 
            this.textBox_endDate.Location = new System.Drawing.Point(680, 215);
            this.textBox_endDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_endDate.Name = "textBox_endDate";
            this.textBox_endDate.Size = new System.Drawing.Size(130, 31);
            this.textBox_endDate.TabIndex = 3;
            this.textBox_endDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label_endDate
            // 
            this.label_endDate.AutoSize = true;
            this.label_endDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_endDate.Location = new System.Drawing.Point(60, 215);
            this.label_endDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_endDate.Name = "label_endDate";
            this.label_endDate.Size = new System.Drawing.Size(351, 31);
            this.label_endDate.TabIndex = 5;
            this.label_endDate.Text = "Aankomstdatum (dd-mm-jjjj)";
            // 
            // label_startKilometres
            // 
            this.label_startKilometres.AutoSize = true;
            this.label_startKilometres.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_startKilometres.Location = new System.Drawing.Point(60, 287);
            this.label_startKilometres.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_startKilometres.Name = "label_startKilometres";
            this.label_startKilometres.Size = new System.Drawing.Size(286, 31);
            this.label_startKilometres.TabIndex = 6;
            this.label_startKilometres.Text = "Kilometerstand vertrek";
            // 
            // textBox_startKilometres
            // 
            this.textBox_startKilometres.Location = new System.Drawing.Point(680, 287);
            this.textBox_startKilometres.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_startKilometres.Name = "textBox_startKilometres";
            this.textBox_startKilometres.Size = new System.Drawing.Size(130, 31);
            this.textBox_startKilometres.TabIndex = 4;
            this.textBox_startKilometres.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button_calculateRentalPrice
            // 
            this.button_calculateRentalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_calculateRentalPrice.Location = new System.Drawing.Point(60, 556);
            this.button_calculateRentalPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_calculateRentalPrice.Name = "button_calculateRentalPrice";
            this.button_calculateRentalPrice.Size = new System.Drawing.Size(356, 65);
            this.button_calculateRentalPrice.TabIndex = 7;
            this.button_calculateRentalPrice.Text = "Bereken huurprijs";
            this.button_calculateRentalPrice.UseVisualStyleBackColor = true;
            this.button_calculateRentalPrice.Click += new System.EventHandler(this.Button_calculateRentalPrice_Click);
            // 
            // label_rentalPrice
            // 
            this.label_rentalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_rentalPrice.Location = new System.Drawing.Point(200, 696);
            this.label_rentalPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_rentalPrice.Name = "label_rentalPrice";
            this.label_rentalPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label_rentalPrice.Size = new System.Drawing.Size(216, 31);
            this.label_rentalPrice.TabIndex = 10;
            this.label_rentalPrice.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label_endKilometres
            // 
            this.label_endKilometres.AutoSize = true;
            this.label_endKilometres.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_endKilometres.Location = new System.Drawing.Point(60, 356);
            this.label_endKilometres.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_endKilometres.Name = "label_endKilometres";
            this.label_endKilometres.Size = new System.Drawing.Size(320, 31);
            this.label_endKilometres.TabIndex = 11;
            this.label_endKilometres.Text = "Kilometerstand aankomst";
            // 
            // textBox_endKilometres
            // 
            this.textBox_endKilometres.Location = new System.Drawing.Point(678, 356);
            this.textBox_endKilometres.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_endKilometres.Name = "textBox_endKilometres";
            this.textBox_endKilometres.Size = new System.Drawing.Size(130, 31);
            this.textBox_endKilometres.TabIndex = 5;
            this.textBox_endKilometres.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label_rentalPriceText
            // 
            this.label_rentalPriceText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_rentalPriceText.Location = new System.Drawing.Point(60, 696);
            this.label_rentalPriceText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_rentalPriceText.Name = "label_rentalPriceText";
            this.label_rentalPriceText.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label_rentalPriceText.Size = new System.Drawing.Size(160, 50);
            this.label_rentalPriceText.TabIndex = 13;
            this.label_rentalPriceText.Text = "Huurprijs:";
            // 
            // label_FuelCostsOnTheRoad
            // 
            this.label_FuelCostsOnTheRoad.AutoSize = true;
            this.label_FuelCostsOnTheRoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_FuelCostsOnTheRoad.Location = new System.Drawing.Point(60, 427);
            this.label_FuelCostsOnTheRoad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_FuelCostsOnTheRoad.Name = "label_FuelCostsOnTheRoad";
            this.label_FuelCostsOnTheRoad.Size = new System.Drawing.Size(508, 62);
            this.label_FuelCostsOnTheRoad.TabIndex = 14;
            this.label_FuelCostsOnTheRoad.Text = "Door huurder gemaakte brandstofkosten \r\nonderweg\r\n";
            // 
            // textBox_fuelCostsOnTheRoad
            // 
            this.textBox_fuelCostsOnTheRoad.Location = new System.Drawing.Point(678, 427);
            this.textBox_fuelCostsOnTheRoad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_fuelCostsOnTheRoad.Name = "textBox_fuelCostsOnTheRoad";
            this.textBox_fuelCostsOnTheRoad.Size = new System.Drawing.Size(130, 31);
            this.textBox_fuelCostsOnTheRoad.TabIndex = 6;
            this.textBox_fuelCostsOnTheRoad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label_eurosign
            // 
            this.label_eurosign.AutoSize = true;
            this.label_eurosign.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_eurosign.Location = new System.Drawing.Point(648, 431);
            this.label_eurosign.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_eurosign.Name = "label_eurosign";
            this.label_eurosign.Size = new System.Drawing.Size(36, 31);
            this.label_eurosign.TabIndex = 16;
            this.label_eurosign.Text = "€ ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(874, 810);
            this.Controls.Add(this.textBox_fuelCostsOnTheRoad);
            this.Controls.Add(this.label_FuelCostsOnTheRoad);
            this.Controls.Add(this.label_rentalPriceText);
            this.Controls.Add(this.textBox_endKilometres);
            this.Controls.Add(this.label_endKilometres);
            this.Controls.Add(this.button_calculateRentalPrice);
            this.Controls.Add(this.textBox_startKilometres);
            this.Controls.Add(this.label_startKilometres);
            this.Controls.Add(this.label_endDate);
            this.Controls.Add(this.textBox_endDate);
            this.Controls.Add(this.textBox_startDate);
            this.Controls.Add(this.label_startDate);
            this.Controls.Add(this.comboBox_carType);
            this.Controls.Add(this.label_carType);
            this.Controls.Add(this.label_rentalPrice);
            this.Controls.Add(this.label_eurosign);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Autoverhuur - huurprijsberekening";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_carType;
        private System.Windows.Forms.ComboBox comboBox_carType;
        private System.Windows.Forms.Label label_startDate;
        private System.Windows.Forms.TextBox textBox_startDate;
        private System.Windows.Forms.TextBox textBox_endDate;
        private System.Windows.Forms.Label label_endDate;
        private System.Windows.Forms.Label label_startKilometres;
        private System.Windows.Forms.TextBox textBox_startKilometres;
        private System.Windows.Forms.Button button_calculateRentalPrice;
        private System.Windows.Forms.Label label_rentalPrice;
        private System.Windows.Forms.Label label_endKilometres;
        private System.Windows.Forms.TextBox textBox_endKilometres;
        private System.Windows.Forms.Label label_rentalPriceText;
        private System.Windows.Forms.Label label_FuelCostsOnTheRoad;
        private System.Windows.Forms.TextBox textBox_fuelCostsOnTheRoad;
        private System.Windows.Forms.Label label_eurosign;
    }
}

