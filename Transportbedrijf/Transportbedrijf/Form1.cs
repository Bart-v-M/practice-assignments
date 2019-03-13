using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Date: January, 2019

namespace Transportbedrijf
{
    public partial class inputForm : Form
    {
        public inputForm()
        {
            InitializeComponent();

            numOfKilometresDomestic_label.Text = "Aantal gereden kilometers";

            numOfKilometresForeign_label.Visible = false;
            numOfKilometersForeign_textBox.Visible = false;
            kilometre_label2.Visible = false;

            cargoValue_label.Visible = false;
            euro_label1.Visible = false;
            cargoValue_textBox.Visible = false;

            calculate_button.Location = new Point(25, 235);

            transportationCost_label.Location = new Point(25, 295);
            cost_label.Location = new Point(250, 295);

            truck_pictureBox1.Location = new Point(396, 278);

            Size = new Size(560, 400);  // Form size
        }

        // Method that adapts the form if foreign transportation is true.
        public void ForeignTransport()
        {
            if (foreignTransport_comboBox.Text == "ja") 
            {
                numOfKilometresDomestic_label.Text = "Aantal gereden kilometers in Nederland";

                numOfKilometresForeign_label.Visible = true;
                numOfKilometersForeign_textBox.Visible = true;
                kilometre_label2.Visible = true;

                cargoValue_label.Visible = true;
                euro_label1.Visible = true;
                cargoValue_textBox.Visible = true;

                calculate_button.Location = new Point(25, 325);

                transportationCost_label.Location = new Point(25, 385);
                cost_label.Location = new Point(250, 385);

                truck_pictureBox1.Location = new Point(396, 368);

                Size = new Size(560, 500);  // Form size
            }
            else if (foreignTransport_comboBox.Text == "nee")  
            {
                numOfKilometresDomestic_label.Text = "Aantal gereden kilometers";

                numOfKilometresForeign_label.Visible = false;
                numOfKilometersForeign_textBox.Visible = false;
                kilometre_label2.Visible = false;

                cargoValue_label.Visible = false;
                euro_label1.Visible = false;
                cargoValue_textBox.Visible = false;

                calculate_button.Location = new Point(25, 235);

                transportationCost_label.Location = new Point(25, 295);
                cost_label.Location = new Point(250, 295);

                truck_pictureBox1.Location = new Point(396, 278);

                Size = new Size(560, 400);  // Form size
            }
        } 

        private void ForeignTransport_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ForeignTransport();
        }

        // For total cost of transportation:
        decimal costOfTransportation;

        // Cost variables dependent on cargo type
        decimal costPerKm_NonLiquid_Volume = 0.80M;
        decimal costPerKm_NonLiquid_Weight = 0.55M;
        decimal costPerKm_Liquid_Volume = 1.25M;
        decimal costPerKm_Liquid_Weight = 0.45M;

        // Number of kilometers
        decimal numOfKilometersDomestic;
        decimal numOfKilometersForeign;

        // 45% premium on foreign kilometers
        decimal premiumOnForeignKm = 1.45M;            

        // Cost of customs
        decimal costOfCustoms;
        decimal cargoValue;
        decimal premiumOnCargoValue_Customs = 0.035M;   // 3.5% premium on cargo value
        decimal premiumMinimum_Customs = 45.00M;        // minimum amount of premium for customs

        // CALCULATE BUTTON
        private void Calculate_button_Click(object sender, EventArgs e)
        {
            // Bool variable for checking the list below with possible errors:
            bool check = false;

            // Check if cargo type is given:
            if (cargoType_comboBox.Text == "")
            {
                MessageBox.Show("Voer het type lading in.");
                check = true;
            }
            else 
            {
                // Check if foreign transport is given:
                if (foreignTransport_comboBox.Text == "")
                {
                    MessageBox.Show("Voer in of het transport een buitenlandse rit betreft: ja of nee.");
                    check = true;
                }
            }

            // Check if number of domestic kilometers is given in the correct format:
            if (!decimal.TryParse(numOfKilometersDomestic_textBox.Text.Replace(",", "."), out numOfKilometersDomestic)) 
            {
                numOfKilometersDomestic_textBox.Text = "";

                if (foreignTransport_comboBox.Text == "nee")
                {
                    MessageBox.Show("Geen of incorrecte invoer van het aantal gereden kilometers. " +
                                    "Voer hiervoor een correcte getalwaarde in.");
                }
                if (foreignTransport_comboBox.Text == "ja")
                {
                    MessageBox.Show("Geen of incorrecte invoer van het aantal gereden kilometers in Nederland. " +
                                    "Voer hiervoor een correcte getalwaarde in.");
                }
                check = true;
            }
            else if (numOfKilometersDomestic_textBox.Text.Contains("."))
            {
                numOfKilometersDomestic_textBox.Text = "";

                if (foreignTransport_comboBox.Text == "nee")
                {
                    MessageBox.Show("Geen of incorrecte invoer van het aantal gereden kilometers. " +
                                    "Voer hiervoor een correcte getalwaarde in.");
                }
                if (foreignTransport_comboBox.Text == "ja")
                {
                    MessageBox.Show("Geen of incorrecte invoer van het aantal gereden kilometers in Nederland. " +
                                     "Voer hiervoor een correcte getalwaarde in.");
                }
                check = true;
            }
            else
            {
                // Check if number of foreign kilometers is given in the correct format:
                if (!decimal.TryParse(numOfKilometersForeign_textBox.Text.Replace(",", "."), out numOfKilometersForeign) && foreignTransport_comboBox.Text == "ja")
                {
                    numOfKilometersForeign_textBox.Text = "";
                    MessageBox.Show("Geen of incorrecte invoer van het aantal gereden kilometers in het buitenland. " +
                                    "Voer hiervoor een correcte getalwaarde in.");
                    check = true;
                }
                else if (numOfKilometersForeign_textBox.Text.Contains("."))
                {
                    numOfKilometersForeign_textBox.Text = "";
                    MessageBox.Show("Geen of incorrecte invoer van het aantal gereden kilometers in het buitenland. " +
                                    "Voer hiervoor een correcte getalwaarde in.");
                    check = true;
                }
                else
                {
                    // Check if cargo value is given in the correct format:
                    if (!decimal.TryParse(cargoValue_textBox.Text.Replace(",", "."), out cargoValue) && foreignTransport_comboBox.Text == "ja")  
                    {
                        cargoValue_textBox.Text = "";
                        MessageBox.Show("Geen of incorrecte invoer van de lading. Voer hiervoor een correcte getalwaarde in.");
                        check = true;
                    }
                    else if (cargoValue_textBox.Text.Contains("."))
                    {
                        cargoValue_textBox.Text = "";
                        MessageBox.Show("Geen of incorrecte invoer van de lading. Voer hiervoor een correcte getalwaarde in.");
                        check = true;
                    }
                }
            }

            // Calculate output:
            if (check == false)
            {
                if (foreignTransport_comboBox.Text == "nee")   
                {
                    if (cargoType_comboBox.Text == "niet-vloeibaar")   
                    {
                        costOfTransportation = numOfKilometersDomestic * (costPerKm_NonLiquid_Volume + costPerKm_NonLiquid_Weight);
                    }
                    else if (cargoType_comboBox.Text == "vloeibaar")   
                    {
                        costOfTransportation = numOfKilometersDomestic * (costPerKm_Liquid_Volume + costPerKm_Liquid_Weight);
                    }
                }
                else if (foreignTransport_comboBox.Text == "ja") 
                {
                    if ((cargoValue * premiumOnCargoValue_Customs) < premiumMinimum_Customs)
                    {
                        costOfCustoms = premiumMinimum_Customs;
                    }
                    else if ((cargoValue * premiumOnCargoValue_Customs) >= premiumMinimum_Customs)
                    {
                        costOfCustoms = cargoValue * premiumOnCargoValue_Customs;
                    }

                    if (cargoType_comboBox.Text == "niet-vloeibaar")  
                    {
                        costOfTransportation = (numOfKilometersDomestic * (costPerKm_NonLiquid_Volume + costPerKm_NonLiquid_Weight))
                                             + (numOfKilometersForeign * (costPerKm_NonLiquid_Volume + costPerKm_NonLiquid_Weight) * premiumOnForeignKm)
                                             + costOfCustoms;
                    }
                    else if (cargoType_comboBox.Text == "vloeibaar")
                    {
                        costOfTransportation = (numOfKilometersDomestic * (costPerKm_Liquid_Volume + costPerKm_Liquid_Weight))
                                            + (numOfKilometersForeign * (costPerKm_Liquid_Volume + costPerKm_Liquid_Weight) * premiumOnForeignKm)
                                            + costOfCustoms;
                    }
                }
                // Show total cost of transportation for customer on costlabel:
                cost_label.Text = costOfTransportation.ToString("C", CultureInfo.GetCultureInfo("nl-NL"));
            }
        }
    }
}
