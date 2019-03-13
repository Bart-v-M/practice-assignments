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

namespace Autoverhuur
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // VARIABLES FOR PRICE CALCULUS
        public double dayPrice_Car = 50.00;
        public double dayPrice_Van = 95.00;

        public double kilometrePrice_Car = 0.20;
        public double kilometrePrice_Van = 0.30;

        public int numOfKilometres_Start;
        public int numOfKilometres_End;
        public int numOfKilometresDriven;

        public DateTime startDate;
        public DateTime endDate;
        public int numOfDaysRented;

        public double fuelCostsOnTheRoad;

        public double rentalPrice;

        public bool correctEntry = true;

        // CHECK FOR EMPTY STRING EXCEPTIONS
        private void CheckForEmptyStringExceptions()
        {
            if (comboBox_carType.Text == "") { MessageBox.Show("Voer type auto in."); correctEntry = false; }
            else { } // Ignore

            if (textBox_startDate.Text == "" && correctEntry == true) { MessageBox.Show("Voer een vertrekdatum in."); correctEntry = false; }
            else { } // Ignore

            if (textBox_endDate.Text == "" && correctEntry == true) { MessageBox.Show("Voer een aankomstdatum in."); correctEntry = false; }
            else { } // Ignore

            if (textBox_startKilometres.Text == "" && correctEntry == true) { MessageBox.Show("Voer een kilometerstand bij vertrek in."); correctEntry = false; }
            else { } // Ignore

            if (textBox_endKilometres.Text == "" && correctEntry == true) { MessageBox.Show("Voer een kilometerstand bij aankomst in."); correctEntry = false; }
            else { } // Ignore

            if (textBox_fuelCostsOnTheRoad.Text == "" && correctEntry == true) { textBox_fuelCostsOnTheRoad.Text = "0"; }
            else { } // Ignore
            
        }

        // CHECK DATE ENTRY
        private void CheckDateEntry(string input, DateTime date)
        {
            if (correctEntry == true)
            {
                // Check format
                var isValidFormat = DateTime.TryParseExact(input, "dd-MM-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out date);

                if (isValidFormat)
                {
                    string.Format("{0:dd-MM-yyyy}", date);
                }
                else
                {
                    MessageBox.Show("Ongeldige datuminvoer. Voer de vertrek- en aankomstdatum correct in.");
                    correctEntry = false;
                }

                if (correctEntry == true)
                {
                    // Check if start date is before end date or not
                    if (startDate > endDate)
                    {
                        MessageBox.Show("De einddatum ligt op een vroeger tijdstip dan de begindatum. Dit is niet mogelijk. " +
                                        "Voer de datums correct in.");
                        correctEntry = false;
                    }
                    else
                    {
                        // Ignore
                    }
                }
            }
        }

        // CALCULATE NUMBER OF DAYS RENTED
        private void CalculateNumOfDaysRented()
        {
            startDate = DateTime.ParseExact(textBox_startDate.Text, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            endDate = DateTime.ParseExact(textBox_endDate.Text, "dd-MM-yyyy", CultureInfo.InvariantCulture);

            numOfDaysRented = 1 + (endDate - startDate).Days;
        }

        // CHECK KILOMETRE ENTRY
        private void CheckKilometreEntry1(string input, int numOfKilometres)
        {
            if (correctEntry == true)
            {
                // Check format
                if (int.TryParse(input, out numOfKilometres))
                {
                    string.Format("{0,6}", numOfKilometres);
                }
                else
                {
                    MessageBox.Show("Ongeldige of te hoge kilometerstand ingevoerd. " +
                                    "Voer voor de kilometerstand een getal in van maximaal 6 cijfers (zonder komma's of andere tekens).");
                    correctEntry = false;
                }
            }
        }

        private void CheckKilometreEntry2()
        {
            if (correctEntry == true)
            {
                // Check if number of start kilometres is lower than number of end kilometres
                numOfKilometres_Start = Convert.ToInt32(textBox_startKilometres.Text);
                numOfKilometres_End = Convert.ToInt32(textBox_endKilometres.Text);

                if (numOfKilometres_Start > numOfKilometres_End)
                {
                    MessageBox.Show("De ingevoerde beginkilometerstand is hoger dan de eindkilometerstand. " +
                                    "Dit is niet mogelijk. Voer de kilometerstanden correct in.");
                    correctEntry = false;
                }
                else
                {
                    // Ignore
                }
            }
        }

        // CHECK FUEL COSTS PAID BY RENTER ON THE ROAD
        private void CheckEntryFuelCostsOnTheRoad(string input, double fuelCostsOnTheRoad)
        {
            if (correctEntry == true)
            {
                // Check format
                input = textBox_fuelCostsOnTheRoad.Text.Replace(",", ".");

                if (double.TryParse(input, out fuelCostsOnTheRoad))
                {
                    string.Format("{0:0.##########}", fuelCostsOnTheRoad);
                }
                else
                {
                    MessageBox.Show("Ongeldige invoer bij 'door huurder gemaakte brandstofkosten onderweg'. Voer hier een correct geldbedrag in. " +
                                    "Indien u niets invult, dan wordt er van uitgegaan dat de gemaakte kosten €0,00 geweest zijn.");
                    correctEntry = false;
                }
            }
        }

        // DETERMINE FUEL COSTS
        private void DetermineFuelCostsOnTheRoad()
        {
            string input = textBox_fuelCostsOnTheRoad.Text.Replace(",", ".");
            fuelCostsOnTheRoad = Convert.ToDouble(input);
        }

        // CALCULATE KILOMETRES DRIVEN
        private void CalculateNumOfKilometresDriven()
        {
            numOfKilometres_Start = Convert.ToInt32(textBox_startKilometres.Text);
            numOfKilometres_End = Convert.ToInt32(textBox_endKilometres.Text);

            numOfKilometresDriven = numOfKilometres_End - numOfKilometres_Start;
        }

        // CALCULATE RENTAL PRICE CAR
        private void CalculateRentalPrice_Car()
        {
            CalculateNumOfDaysRented();
            CalculateNumOfKilometresDriven();
            DetermineFuelCostsOnTheRoad();

            int numOfFreeKilometres = numOfDaysRented * 100;

            rentalPrice =
            numOfDaysRented * dayPrice_Car
            + (numOfKilometresDriven - numOfFreeKilometres) * kilometrePrice_Car
            - fuelCostsOnTheRoad;  
        }

        // CALCULATE RENTAL PRICE VAN
        private void CalculateRentalPrice_Van()
        {
            CalculateNumOfDaysRented();
            CalculateNumOfKilometresDriven();
            DetermineFuelCostsOnTheRoad();

            rentalPrice =
            numOfDaysRented * dayPrice_Van
            + numOfKilometresDriven * kilometrePrice_Van
            - fuelCostsOnTheRoad;
        }

        // SHOW PRICE METHOD
        private void ShowRentalPrice(double rentalPrice)
        {
            label_rentalPrice.Text = rentalPrice.ToString("C", CultureInfo.GetCultureInfo("nl-NL")); 
        }

        // BUTTON CALCULATE RENTAL PRICE
        private void Button_calculateRentalPrice_Click(object sender, EventArgs e)
        {
            // Exception handling:
            CheckForEmptyStringExceptions();
            CheckDateEntry(textBox_startDate.Text, startDate);
            CheckDateEntry(textBox_endDate.Text, endDate);
            CheckKilometreEntry1(textBox_startKilometres.Text, numOfKilometres_Start);
            CheckKilometreEntry1(textBox_endKilometres.Text, numOfKilometres_End);
            CheckKilometreEntry2();
            CheckEntryFuelCostsOnTheRoad(textBox_fuelCostsOnTheRoad.Text, fuelCostsOnTheRoad);
           
            // Calculation of rental price:
            if (correctEntry == true)
            {
                if (comboBox_carType.Text == "personenauto") { CalculateRentalPrice_Car(); }
                else if (comboBox_carType.Text == "personenbus") { CalculateRentalPrice_Van(); }
                
                ShowRentalPrice(rentalPrice);
            }

            // Reset:
            correctEntry = true;
        }
    }
}