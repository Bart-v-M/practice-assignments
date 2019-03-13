namespace Transportbedrijf
{
    partial class inputForm
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
            this.loadType_label = new System.Windows.Forms.Label();
            this.cargoType_comboBox = new System.Windows.Forms.ComboBox();
            this.foreignTransport_label = new System.Windows.Forms.Label();
            this.foreignTransport_comboBox = new System.Windows.Forms.ComboBox();
            this.cargoValue_label = new System.Windows.Forms.Label();
            this.cargoValue_textBox = new System.Windows.Forms.TextBox();
            this.euro_label = new System.Windows.Forms.Label();
            this.numOfKilometresDomestic_label = new System.Windows.Forms.Label();
            this.numOfKilometersDomestic_textBox = new System.Windows.Forms.TextBox();
            this.kilometre_label1 = new System.Windows.Forms.Label();
            this.kilometre_label2 = new System.Windows.Forms.Label();
            this.numOfKilometersForeign_textBox = new System.Windows.Forms.TextBox();
            this.numOfKilometresForeign_label = new System.Windows.Forms.Label();
            this.calculate_button = new System.Windows.Forms.Button();
            this.transportationCost_label = new System.Windows.Forms.Label();
            this.cost_label = new System.Windows.Forms.Label();
            this.euro_label1 = new System.Windows.Forms.Label();
            this.truck_pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.truck_pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // loadType_label
            // 
            this.loadType_label.AutoSize = true;
            this.loadType_label.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.loadType_label.Font = new System.Drawing.Font("Segoe WP", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadType_label.Location = new System.Drawing.Point(25, 35);
            this.loadType_label.Name = "loadType_label";
            this.loadType_label.Size = new System.Drawing.Size(215, 15);
            this.loadType_label.TabIndex = 0;
            this.loadType_label.Text = "Type lading (niet-vloeibaar of vloeibaar)";
            this.loadType_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cargoType_comboBox
            // 
            this.cargoType_comboBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.cargoType_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cargoType_comboBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cargoType_comboBox.Font = new System.Drawing.Font("Segoe WP", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cargoType_comboBox.FormattingEnabled = true;
            this.cargoType_comboBox.Items.AddRange(new object[] {
            "niet-vloeibaar",
            "vloeibaar"});
            this.cargoType_comboBox.Location = new System.Drawing.Point(365, 32);
            this.cargoType_comboBox.Name = "cargoType_comboBox";
            this.cargoType_comboBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cargoType_comboBox.Size = new System.Drawing.Size(120, 23);
            this.cargoType_comboBox.TabIndex = 2;
            // 
            // foreignTransport_label
            // 
            this.foreignTransport_label.AutoSize = true;
            this.foreignTransport_label.Font = new System.Drawing.Font("Segoe WP", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foreignTransport_label.Location = new System.Drawing.Point(25, 95);
            this.foreignTransport_label.Name = "foreignTransport_label";
            this.foreignTransport_label.Size = new System.Drawing.Size(134, 15);
            this.foreignTransport_label.TabIndex = 8;
            this.foreignTransport_label.Text = "Buitenlandse rit (ja/nee)";
            this.foreignTransport_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // foreignTransport_comboBox
            // 
            this.foreignTransport_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.foreignTransport_comboBox.Font = new System.Drawing.Font("Segoe WP", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foreignTransport_comboBox.FormattingEnabled = true;
            this.foreignTransport_comboBox.ItemHeight = 15;
            this.foreignTransport_comboBox.Items.AddRange(new object[] {
            "nee",
            "ja"});
            this.foreignTransport_comboBox.Location = new System.Drawing.Point(365, 92);
            this.foreignTransport_comboBox.Name = "foreignTransport_comboBox";
            this.foreignTransport_comboBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.foreignTransport_comboBox.Size = new System.Drawing.Size(121, 23);
            this.foreignTransport_comboBox.TabIndex = 9;
            this.foreignTransport_comboBox.SelectedIndexChanged += new System.EventHandler(this.ForeignTransport_comboBox_SelectedIndexChanged);
            // 
            // cargoValue_label
            // 
            this.cargoValue_label.AutoSize = true;
            this.cargoValue_label.Font = new System.Drawing.Font("Segoe WP", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cargoValue_label.Location = new System.Drawing.Point(25, 255);
            this.cargoValue_label.Name = "cargoValue_label";
            this.cargoValue_label.Size = new System.Drawing.Size(121, 15);
            this.cargoValue_label.TabIndex = 10;
            this.cargoValue_label.Text = "Waarde van de lading";
            this.cargoValue_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cargoValue_label.Visible = false;
            // 
            // cargoValue_textBox
            // 
            this.cargoValue_textBox.Font = new System.Drawing.Font("Segoe WP", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cargoValue_textBox.Location = new System.Drawing.Point(364, 252);
            this.cargoValue_textBox.Name = "cargoValue_textBox";
            this.cargoValue_textBox.Size = new System.Drawing.Size(120, 23);
            this.cargoValue_textBox.TabIndex = 11;
            this.cargoValue_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.cargoValue_textBox.Visible = false;
            // 
            // euro_label
            // 
            this.euro_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.euro_label.AutoSize = true;
            this.euro_label.Font = new System.Drawing.Font("Segoe WP", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.euro_label.Location = new System.Drawing.Point(352, 155);
            this.euro_label.Name = "euro_label";
            this.euro_label.Size = new System.Drawing.Size(0, 15);
            this.euro_label.TabIndex = 12;
            this.euro_label.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.euro_label.Visible = false;
            // 
            // numOfKilometresDomestic_label
            // 
            this.numOfKilometresDomestic_label.AutoSize = true;
            this.numOfKilometresDomestic_label.Font = new System.Drawing.Font("Segoe WP", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numOfKilometresDomestic_label.Location = new System.Drawing.Point(25, 155);
            this.numOfKilometresDomestic_label.Name = "numOfKilometresDomestic_label";
            this.numOfKilometresDomestic_label.Size = new System.Drawing.Size(144, 15);
            this.numOfKilometresDomestic_label.TabIndex = 15;
            this.numOfKilometresDomestic_label.Text = "Aantal gereden kilometers";
            this.numOfKilometresDomestic_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numOfKilometersDomestic_textBox
            // 
            this.numOfKilometersDomestic_textBox.Font = new System.Drawing.Font("Segoe WP", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numOfKilometersDomestic_textBox.Location = new System.Drawing.Point(364, 152);
            this.numOfKilometersDomestic_textBox.Name = "numOfKilometersDomestic_textBox";
            this.numOfKilometersDomestic_textBox.Size = new System.Drawing.Size(120, 23);
            this.numOfKilometersDomestic_textBox.TabIndex = 16;
            this.numOfKilometersDomestic_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // kilometre_label1
            // 
            this.kilometre_label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kilometre_label1.AutoSize = true;
            this.kilometre_label1.Font = new System.Drawing.Font("Segoe WP", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kilometre_label1.Location = new System.Drawing.Point(485, 155);
            this.kilometre_label1.Name = "kilometre_label1";
            this.kilometre_label1.Size = new System.Drawing.Size(23, 15);
            this.kilometre_label1.TabIndex = 17;
            this.kilometre_label1.Text = "km";
            this.kilometre_label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // kilometre_label2
            // 
            this.kilometre_label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kilometre_label2.AutoSize = true;
            this.kilometre_label2.Font = new System.Drawing.Font("Segoe WP", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kilometre_label2.Location = new System.Drawing.Point(485, 205);
            this.kilometre_label2.Name = "kilometre_label2";
            this.kilometre_label2.Size = new System.Drawing.Size(23, 15);
            this.kilometre_label2.TabIndex = 20;
            this.kilometre_label2.Text = "km";
            this.kilometre_label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.kilometre_label2.Visible = false;
            // 
            // numOfKilometersForeign_textBox
            // 
            this.numOfKilometersForeign_textBox.Font = new System.Drawing.Font("Segoe WP", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numOfKilometersForeign_textBox.Location = new System.Drawing.Point(364, 202);
            this.numOfKilometersForeign_textBox.Name = "numOfKilometersForeign_textBox";
            this.numOfKilometersForeign_textBox.Size = new System.Drawing.Size(120, 23);
            this.numOfKilometersForeign_textBox.TabIndex = 19;
            this.numOfKilometersForeign_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numOfKilometersForeign_textBox.Visible = false;
            // 
            // numOfKilometresForeign_label
            // 
            this.numOfKilometresForeign_label.AutoSize = true;
            this.numOfKilometresForeign_label.Font = new System.Drawing.Font("Segoe WP", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numOfKilometresForeign_label.Location = new System.Drawing.Point(25, 205);
            this.numOfKilometresForeign_label.Name = "numOfKilometresForeign_label";
            this.numOfKilometresForeign_label.Size = new System.Drawing.Size(237, 15);
            this.numOfKilometresForeign_label.TabIndex = 18;
            this.numOfKilometresForeign_label.Text = "Aantal gereden kilometers in het buitenland";
            this.numOfKilometresForeign_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.numOfKilometresForeign_label.Visible = false;
            // 
            // calculate_button
            // 
            this.calculate_button.AutoSize = true;
            this.calculate_button.BackColor = System.Drawing.Color.SteelBlue;
            this.calculate_button.Font = new System.Drawing.Font("Segoe WP", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculate_button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.calculate_button.Location = new System.Drawing.Point(25, 325);
            this.calculate_button.Name = "calculate_button";
            this.calculate_button.Size = new System.Drawing.Size(165, 37);
            this.calculate_button.TabIndex = 21;
            this.calculate_button.Text = "Bereken transportkosten";
            this.calculate_button.UseVisualStyleBackColor = false;
            this.calculate_button.Click += new System.EventHandler(this.Calculate_button_Click);
            // 
            // transportationCost_label
            // 
            this.transportationCost_label.AutoSize = true;
            this.transportationCost_label.Font = new System.Drawing.Font("Segoe WP", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transportationCost_label.Location = new System.Drawing.Point(25, 385);
            this.transportationCost_label.Name = "transportationCost_label";
            this.transportationCost_label.Size = new System.Drawing.Size(224, 20);
            this.transportationCost_label.TabIndex = 22;
            this.transportationCost_label.Text = "Transportkosten voor de klant:";
            // 
            // cost_label
            // 
            this.cost_label.AutoSize = true;
            this.cost_label.Font = new System.Drawing.Font("Segoe WP", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cost_label.Location = new System.Drawing.Point(250, 385);
            this.cost_label.Name = "cost_label";
            this.cost_label.Size = new System.Drawing.Size(15, 20);
            this.cost_label.TabIndex = 23;
            this.cost_label.Text = "-";
            // 
            // euro_label1
            // 
            this.euro_label1.AutoSize = true;
            this.euro_label1.Font = new System.Drawing.Font("Segoe WP", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.euro_label1.Location = new System.Drawing.Point(351, 257);
            this.euro_label1.Name = "euro_label1";
            this.euro_label1.Size = new System.Drawing.Size(13, 15);
            this.euro_label1.TabIndex = 24;
            this.euro_label1.Text = "€";
            this.euro_label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.euro_label1.Visible = false;
            // 
            // truck_pictureBox1
            // 
            this.truck_pictureBox1.Image = global::Transportbedrijf.Properties.Resources.Truck_Symbol__black_control_version_1;
            this.truck_pictureBox1.Location = new System.Drawing.Point(396, 368);
            this.truck_pictureBox1.Name = "truck_pictureBox1";
            this.truck_pictureBox1.Size = new System.Drawing.Size(112, 37);
            this.truck_pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.truck_pictureBox1.TabIndex = 25;
            this.truck_pictureBox1.TabStop = false;
            // 
            // inputForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(544, 436);
            this.Controls.Add(this.truck_pictureBox1);
            this.Controls.Add(this.euro_label1);
            this.Controls.Add(this.cost_label);
            this.Controls.Add(this.transportationCost_label);
            this.Controls.Add(this.calculate_button);
            this.Controls.Add(this.kilometre_label2);
            this.Controls.Add(this.numOfKilometersForeign_textBox);
            this.Controls.Add(this.numOfKilometresForeign_label);
            this.Controls.Add(this.kilometre_label1);
            this.Controls.Add(this.numOfKilometersDomestic_textBox);
            this.Controls.Add(this.numOfKilometresDomestic_label);
            this.Controls.Add(this.cargoValue_textBox);
            this.Controls.Add(this.cargoValue_label);
            this.Controls.Add(this.foreignTransport_comboBox);
            this.Controls.Add(this.foreignTransport_label);
            this.Controls.Add(this.cargoType_comboBox);
            this.Controls.Add(this.loadType_label);
            this.Controls.Add(this.euro_label);
            this.Font = new System.Drawing.Font("Segoe WP", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "inputForm";
            this.Text = "Transportbedrijf \'Fully Loaded\' - Transportkostencalculator";
            ((System.ComponentModel.ISupportInitialize)(this.truck_pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loadType_label;
        private System.Windows.Forms.ComboBox cargoType_comboBox;
        private System.Windows.Forms.Label foreignTransport_label;
        private System.Windows.Forms.ComboBox foreignTransport_comboBox;
        private System.Windows.Forms.Label cargoValue_label;
        private System.Windows.Forms.TextBox cargoValue_textBox;
        private System.Windows.Forms.Label euro_label;
        private System.Windows.Forms.Label numOfKilometresDomestic_label;
        private System.Windows.Forms.TextBox numOfKilometersDomestic_textBox;
        private System.Windows.Forms.Label kilometre_label1;
        private System.Windows.Forms.Label kilometre_label2;
        private System.Windows.Forms.TextBox numOfKilometersForeign_textBox;
        private System.Windows.Forms.Label numOfKilometresForeign_label;
        private System.Windows.Forms.Button calculate_button;
        private System.Windows.Forms.Label transportationCost_label;
        private System.Windows.Forms.Label cost_label;
        private System.Windows.Forms.Label euro_label1;
        private System.Windows.Forms.PictureBox truck_pictureBox1;
    }
}

