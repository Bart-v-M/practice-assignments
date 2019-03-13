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

// Date: January 2019
// In this assignment I have experimented with datetimepickers for the Zoo in Emmen ;-)

namespace Dierenpark
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            partnerDOB_label.Visible = false;
            partnerDOB_dateTimePicker.Visible = false;
            partnerAge_label.Visible = false;
            partnerAge.Visible = false;

            numOfKids_label.Location = new Point(25, 230);
            numOfKids_numericUpDown.Location = new Point(210, 228);

            calculateButton.Location = new Point(25, 315);

            subscriptionPrice_label.Location = new Point(25, 365);
            subscriptionPrice.Location = new Point(230, 365);

            giraffe_pictureBox.Location = new Point(310, 305);

            Size = new Size(425, 480);  // Form size

            // Combobox standard setting
            subscriptionType_comboBox.SelectedIndex = 0;

            // Only adults (18+) can get a subscription for the zoo
            subscriberDOB_dateTimePicker.MaxDate = today.AddYears(-18);
            partnerDOB_dateTimePicker.MaxDate = today.AddYears(-18);
        }

        // Method to adapt program screen to selection of subscription type
        public void AdaptScreenToSubscriptionType()
        {
            if (subscriptionType_comboBox.Text == "persoonlijk")
            {
                partnerDOB_label.Visible = false;
                partnerDOB_dateTimePicker.Visible = false;
                partnerAge_label.Visible = false;
                partnerAge.Visible = false;

                numOfKids_label.Location = new Point(25, 230);
                numOfKids_numericUpDown.Location = new Point(210, 228);

                calculateButton.Location = new Point(25, 315);

                subscriptionPrice_label.Location = new Point(25, 365);
                subscriptionPrice.Location = new Point(230, 365);

                giraffe_pictureBox.Location = new Point(310, 305);

                Size = new Size(425, 480);  // Form size
            }
            else if (subscriptionType_comboBox.Text == "echtpaar")
            {
                partnerDOB_label.Visible = true;
                partnerDOB_dateTimePicker.Visible = true;
                partnerAge_label.Visible = true;
                partnerAge.Visible = true;

                numOfKids_label.Location = new Point(25, 300);
                numOfKids_numericUpDown.Location = new Point(210, 298);

                calculateButton.Location = new Point(25, 385);

                subscriptionPrice_label.Location = new Point(25, 435);
                subscriptionPrice.Location = new Point(230, 435);

                giraffe_pictureBox.Location = new Point(310, 375);

                Size = new Size(425, 550);  // Form size
            }
        }

        // Adapt program screen to selection of subscription type
        private void SubscriptionType_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            AdaptScreenToSubscriptionType();
        }

        // Variables for calculating subscriber and partner age
        int ageSubscriber;
        int agePartner;
        DateTime today = DateTime.Now;

        // Calculate subscriber age
        private void SubscriberDOB_dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            ageSubscriber = today.Year - subscriberDOB_dateTimePicker.Value.Year;

            if (DateTime.Now.DayOfYear < subscriberDOB_dateTimePicker.Value.DayOfYear)
            {
                ageSubscriber = ageSubscriber - 1;
            }

            subscriberAge.Text = ageSubscriber.ToString();
        }

        // Calculate partner age
        private void PartnerDOB_dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            agePartner = today.Year - partnerDOB_dateTimePicker.Value.Year;

            if (DateTime.Now.DayOfYear < partnerDOB_dateTimePicker.Value.DayOfYear)
            {
                agePartner = agePartner - 1;
            }

            partnerAge.Text = agePartner.ToString();
        }

        // Price variable
        int price;


        private void CalculateButton_Click(object sender, EventArgs e)
        {
            // PRICE CALCULATION

            // Variable for the number of kids
            byte numOfKids = Convert.ToByte(numOfKids_numericUpDown.Text);

            // Personal subscription, age < 65
            if (subscriptionType_comboBox.Text == "persoonlijk"
                && ageSubscriber < 65)
            {
                price = 30 + (numOfKids * 11);
            }

            // Personal subscription, age >= 65
            if (subscriptionType_comboBox.Text == "persoonlijk"
                && ageSubscriber >= 65)
            {
                price = 26 + (numOfKids * 11);
            }

            // Couple subscription, age < 65 (both partners)
            if (subscriptionType_comboBox.Text == "echtpaar"
                && (ageSubscriber < 65 && agePartner < 65))
            {
                price = 58 + (numOfKids * 11);
            }

            // Couple subscription, age >= 65 (for at least one partner)
            if (subscriptionType_comboBox.Text == "echtpaar"
                && (ageSubscriber >= 65 || agePartner >= 65))
            {
                price = 50 + (numOfKids * 11);
            }

            // Print price to screen:
            subscriptionPrice.Text = price.ToString("C", CultureInfo.GetCultureInfo("nl-NL"));
        }
    }
}


// ADDITIONAL CODE FOR CALCULATE BUTTON THAT CAN BE USED IF YOU DON'T WANT TO USE STANDARD SETTINGS
// FOR SUBSCRIPTION TYPE AND BIRTHDATES IN THE PROGRAM
/*
       private void CalculateButton_Click(object sender, EventArgs e)
       {
           bool check = false;

           // CHECKS

           // Check if choice for subscription type is made
           if (subscriptionType_comboBox.Text == "")
           {
               MessageBox.Show("Kies voor een type abonnement.");
               check = true;
           }

           // Check if subscriber DOB is given
           if (subscriberAge.Text == "-" 
               && subscriptionType_comboBox.Text != "")
           {
               MessageBox.Show("Voer de geboortedatum van de aanvrager in.");
               check = true;
           }

           if (subscriberAge.Text != "-" 
               && ageSubscriber < 18 
               && subscriptionType_comboBox.Text != "")
           {
               MessageBox.Show("De leeftijd van de aanvrager is onder de 18." +
                               " De aanvrager van een abonnement dient tenminste 18 jaar te zijn.");
               check = true;
           }

           // Check if subscriber and partner DOB is given
           if (subscriberAge.Text != "-" 
               && ageSubscriber >= 18 
               && subscriptionType_comboBox.Text == "echtpaar")
           {
               if (partnerAge.Text == "-")
               {
                   MessageBox.Show("Voer de geboortedatum van de partner in.");
                   check = true;
               }
               else if (partnerAge.Text != "-" && agePartner < 18)
               {
                   MessageBox.Show("De leeftijd van de partner is onder de 18." +
                                   " De partner van de aanvrager dient tenminste 18 jaar te zijn.");
                   check = true;
               } 
           }

           // PRICE CALCULATION

           // Variable for the number of kids
           byte numOfKids = Convert.ToByte(numOfKids_numericUpDown.Text);

           if (check == false)
           {
               // Personal subscription, age < 65
               if (subscriptionType_comboBox.Text == "persoonlijk"
                   && ageSubscriber < 65)
               {
                   price = 30 + (numOfKids * 11);
               }

               // Personal subscription, age >= 65
               if (subscriptionType_comboBox.Text == "persoonlijk"
                        && ageSubscriber >= 65)
               {
                   price = 26 + (numOfKids * 11);
               }

               // Couple subscription, age < 65 (both partners)
               if (subscriptionType_comboBox.Text == "echtpaar"
                        && (ageSubscriber < 65 && agePartner < 65))
               {
                   price = 58 + (numOfKids * 11);
               }

               // Couple subscription, age >= 65 (for at least one partner)
               if (subscriptionType_comboBox.Text == "echtpaar"
                        && (ageSubscriber >= 65 || agePartner >= 65))
               {
                   price = 50 + (numOfKids * 11);
               }

               // Print price to screen:
               subscriptionPrice.Text = price.ToString("C", CultureInfo.GetCultureInfo("nl-NL"));
           }  
       }
       */
