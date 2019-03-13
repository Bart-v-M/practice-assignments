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

namespace Ouderbijdrage_school
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetStartScreen();
        }

        // SET START SCREEN
        private void SetStartScreen()
        {
            // Set the status of objects correctly for the start of the program 
            label_child2.Visible = false; textBox_DOB_Child2.Visible = false; label_ageChild2.Visible = false;
            label_child3.Visible = false; textBox_DOB_Child3.Visible = false; label_ageChild3.Visible = false;
            label_child4.Visible = false; textBox_DOB_Child4.Visible = false; label_ageChild4.Visible = false;
            label_child5.Visible = false; textBox_DOB_Child5.Visible = false; label_ageChild5.Visible = false;
            label_child6.Visible = false; textBox_DOB_Child6.Visible = false; label_ageChild6.Visible = false;
            label_child7.Visible = false; textBox_DOB_Child7.Visible = false; label_ageChild7.Visible = false;
            label_child8.Visible = false; textBox_DOB_Child8.Visible = false; label_ageChild8.Visible = false;
            label_child9.Visible = false; textBox_DOB_Child9.Visible = false; label_ageChild9.Visible = false;
            label_child10.Visible = false; textBox_DOB_Child10.Visible = false; label_ageChild10.Visible = false;

            label_keyDate.Location = new Point(25, 200);
            textBox_keyDate.Location = new Point(25, 230);

            button_calculateParentalContribution.Location = new Point(25, 294);
            label_parentalContribution.Location = new Point(25, 344);
            label_parentalContributionToBePaid.Location = new Point(110, 344);

            RemoveAgeLabels();
            Size = new Size(310, 432);  // Form size
        }

        // METHOD TO REMOVE ALL AGE LABELS
        private void RemoveAgeLabels()
        {
            //label_age.Visible = false; label_ageChild1.Visible = false;
            label_ageChild2.Visible = false; label_ageChild3.Visible = false; label_ageChild4.Visible = false;
            label_ageChild5.Visible = false; label_ageChild6.Visible = false; label_ageChild7.Visible = false;
            label_ageChild8.Visible = false; label_ageChild9.Visible = false; label_ageChild10.Visible = false;
        }

        // ADAPT SCREEN TO THE NUMBER OF CHILDREN
        private void AdaptScreenToNumOfChildren()
        {
            if (numericUpDown_numOfChildren.Value == 1)
            {
                SetStartScreen();
            }

            if (numericUpDown_numOfChildren.Value == 2)
            {
                label_child1.Visible = true; textBox_DOB_Child1.Visible = true; label_ageChild1.Visible = true;
                label_child2.Visible = true; textBox_DOB_Child2.Visible = true; label_ageChild2.Visible = true;
                label_child3.Visible = false; textBox_DOB_Child3.Visible = false; label_ageChild3.Visible = false;
                label_child4.Visible = false; textBox_DOB_Child4.Visible = false; label_ageChild4.Visible = false;
                label_child5.Visible = false; textBox_DOB_Child5.Visible = false; label_ageChild5.Visible = false;
                label_child6.Visible = false; textBox_DOB_Child6.Visible = false; label_ageChild6.Visible = false;
                label_child7.Visible = false; textBox_DOB_Child7.Visible = false; label_ageChild7.Visible = false;
                label_child8.Visible = false; textBox_DOB_Child8.Visible = false; label_ageChild8.Visible = false;
                label_child9.Visible = false; textBox_DOB_Child9.Visible = false; label_ageChild9.Visible = false;
                label_child10.Visible = false; textBox_DOB_Child10.Visible = false; label_ageChild10.Visible = false;

                label_keyDate.Location = new Point(25, 229);
                textBox_keyDate.Location = new Point(25, 259);
                button_calculateParentalContribution.Location = new Point(25, 323);
                label_parentalContribution.Location = new Point(25, 373);
                label_parentalContributionToBePaid.Location = new Point(110, 373);
                Size = new Size(310, 461);  // Form size
            }

            if (numericUpDown_numOfChildren.Value == 3)
            {
                label_child1.Visible = true; textBox_DOB_Child1.Visible = true; label_ageChild1.Visible = true;
                label_child2.Visible = true; textBox_DOB_Child2.Visible = true; label_ageChild2.Visible = true;
                label_child3.Visible = true; textBox_DOB_Child3.Visible = true; label_ageChild3.Visible = true;
                label_child4.Visible = false; textBox_DOB_Child4.Visible = false; label_ageChild4.Visible = false;
                label_child5.Visible = false; textBox_DOB_Child5.Visible = false; label_ageChild5.Visible = false;
                label_child6.Visible = false; textBox_DOB_Child6.Visible = false; label_ageChild6.Visible = false;
                label_child7.Visible = false; textBox_DOB_Child7.Visible = false; label_ageChild7.Visible = false;
                label_child8.Visible = false; textBox_DOB_Child8.Visible = false; label_ageChild8.Visible = false;
                label_child9.Visible = false; textBox_DOB_Child9.Visible = false; label_ageChild9.Visible = false;
                label_child10.Visible = false; textBox_DOB_Child10.Visible = false; label_ageChild10.Visible = false;

                label_keyDate.Location = new Point(25, 258);
                textBox_keyDate.Location = new Point(25, 288);
                button_calculateParentalContribution.Location = new Point(25, 352);
                label_parentalContribution.Location = new Point(25, 402);
                label_parentalContributionToBePaid.Location = new Point(110, 402);
                Size = new Size(310, 490);  // Form size
            }

            if (numericUpDown_numOfChildren.Value == 4)
            {
                label_child1.Visible = true; textBox_DOB_Child1.Visible = true; label_ageChild1.Visible = true;
                label_child2.Visible = true; textBox_DOB_Child2.Visible = true; label_ageChild2.Visible = true;
                label_child3.Visible = true; textBox_DOB_Child3.Visible = true; label_ageChild3.Visible = true;
                label_child4.Visible = true; textBox_DOB_Child4.Visible = true; label_ageChild4.Visible = true;
                label_child5.Visible = false; textBox_DOB_Child5.Visible = false; label_ageChild5.Visible = false;
                label_child6.Visible = false; textBox_DOB_Child6.Visible = false; label_ageChild6.Visible = false;
                label_child7.Visible = false; textBox_DOB_Child7.Visible = false; label_ageChild7.Visible = false;
                label_child8.Visible = false; textBox_DOB_Child8.Visible = false; label_ageChild8.Visible = false;
                label_child9.Visible = false; textBox_DOB_Child9.Visible = false; label_ageChild9.Visible = false;
                label_child10.Visible = false; textBox_DOB_Child10.Visible = false; label_ageChild10.Visible = false;

                label_keyDate.Location = new Point(25, 287);
                textBox_keyDate.Location = new Point(25, 317);
                button_calculateParentalContribution.Location = new Point(25, 381);
                label_parentalContribution.Location = new Point(25, 431);
                label_parentalContributionToBePaid.Location = new Point(110, 431);
                Size = new Size(310, 519);  // Form size
            }

            if (numericUpDown_numOfChildren.Value == 5)
            {
                label_child1.Visible = true; textBox_DOB_Child1.Visible = true; label_ageChild1.Visible = true;
                label_child2.Visible = true; textBox_DOB_Child2.Visible = true; label_ageChild2.Visible = true;
                label_child3.Visible = true; textBox_DOB_Child3.Visible = true; label_ageChild3.Visible = true;
                label_child4.Visible = true; textBox_DOB_Child4.Visible = true; label_ageChild4.Visible = true;
                label_child5.Visible = true; textBox_DOB_Child5.Visible = true; label_ageChild5.Visible = true;
                label_child6.Visible = false; textBox_DOB_Child6.Visible = false; label_ageChild6.Visible = false;
                label_child7.Visible = false; textBox_DOB_Child7.Visible = false; label_ageChild7.Visible = false;
                label_child8.Visible = false; textBox_DOB_Child8.Visible = false; label_ageChild8.Visible = false;
                label_child9.Visible = false; textBox_DOB_Child9.Visible = false; label_ageChild9.Visible = false;
                label_child10.Visible = false; textBox_DOB_Child10.Visible = false; label_ageChild10.Visible = false;

                label_keyDate.Location = new Point(25, 316);
                textBox_keyDate.Location = new Point(25, 346);
                button_calculateParentalContribution.Location = new Point(25, 410);
                label_parentalContribution.Location = new Point(25, 460);
                label_parentalContributionToBePaid.Location = new Point(110, 460);
                Size = new Size(310, 548);  // Form size
            }

            if (numericUpDown_numOfChildren.Value == 6)
            {
                label_child1.Visible = true; textBox_DOB_Child1.Visible = true; label_ageChild1.Visible = true;
                label_child2.Visible = true; textBox_DOB_Child2.Visible = true; label_ageChild2.Visible = true;
                label_child3.Visible = true; textBox_DOB_Child3.Visible = true; label_ageChild3.Visible = true;
                label_child4.Visible = true; textBox_DOB_Child4.Visible = true; label_ageChild4.Visible = true;
                label_child5.Visible = true; textBox_DOB_Child5.Visible = true; label_ageChild5.Visible = true;
                label_child6.Visible = true; textBox_DOB_Child6.Visible = true; label_ageChild6.Visible = true;
                label_child7.Visible = false; textBox_DOB_Child7.Visible = false; label_ageChild7.Visible = false;
                label_child8.Visible = false; textBox_DOB_Child8.Visible = false; label_ageChild8.Visible = false;
                label_child9.Visible = false; textBox_DOB_Child9.Visible = false; label_ageChild9.Visible = false;
                label_child10.Visible = false; textBox_DOB_Child10.Visible = false; label_ageChild10.Visible = false;

                label_keyDate.Location = new Point(25, 345);
                textBox_keyDate.Location = new Point(25, 375);
                button_calculateParentalContribution.Location = new Point(25, 439);
                label_parentalContribution.Location = new Point(25, 489);
                label_parentalContributionToBePaid.Location = new Point(110, 489);
                Size = new Size(310, 577);  // Form size
            }

            if (numericUpDown_numOfChildren.Value == 7)
            {
                label_child1.Visible = true; textBox_DOB_Child1.Visible = true; label_ageChild1.Visible = true;
                label_child2.Visible = true; textBox_DOB_Child2.Visible = true; label_ageChild2.Visible = true;
                label_child3.Visible = true; textBox_DOB_Child3.Visible = true; label_ageChild3.Visible = true;
                label_child4.Visible = true; textBox_DOB_Child4.Visible = true; label_ageChild4.Visible = true;
                label_child5.Visible = true; textBox_DOB_Child5.Visible = true; label_ageChild5.Visible = true;
                label_child6.Visible = true; textBox_DOB_Child6.Visible = true; label_ageChild6.Visible = true;
                label_child7.Visible = true; textBox_DOB_Child7.Visible = true; label_ageChild7.Visible = true;
                label_child8.Visible = false; textBox_DOB_Child8.Visible = false; label_ageChild8.Visible = false;
                label_child9.Visible = false; textBox_DOB_Child9.Visible = false; label_ageChild9.Visible = false;
                label_child10.Visible = false; textBox_DOB_Child10.Visible = false; label_ageChild10.Visible = false;

                label_keyDate.Location = new Point(25, 374);
                textBox_keyDate.Location = new Point(25, 404);
                button_calculateParentalContribution.Location = new Point(25, 468);
                label_parentalContribution.Location = new Point(25, 518);
                label_parentalContributionToBePaid.Location = new Point(110, 518);
                Size = new Size(310, 606);  // Form size
            }

            if (numericUpDown_numOfChildren.Value == 8)
            {
                label_child1.Visible = true; textBox_DOB_Child1.Visible = true; label_ageChild1.Visible = true;
                label_child2.Visible = true; textBox_DOB_Child2.Visible = true; label_ageChild2.Visible = true;
                label_child3.Visible = true; textBox_DOB_Child3.Visible = true; label_ageChild3.Visible = true;
                label_child4.Visible = true; textBox_DOB_Child4.Visible = true; label_ageChild4.Visible = true;
                label_child5.Visible = true; textBox_DOB_Child5.Visible = true; label_ageChild5.Visible = true;
                label_child6.Visible = true; textBox_DOB_Child6.Visible = true; label_ageChild6.Visible = true;
                label_child7.Visible = true; textBox_DOB_Child7.Visible = true; label_ageChild7.Visible = true;
                label_child8.Visible = true; textBox_DOB_Child8.Visible = true; label_ageChild8.Visible = true;
                label_child9.Visible = false; textBox_DOB_Child9.Visible = false; label_ageChild9.Visible = false;
                label_child10.Visible = false; textBox_DOB_Child10.Visible = false; label_ageChild10.Visible = false;

                label_keyDate.Location = new Point(25, 403);
                textBox_keyDate.Location = new Point(25, 433);
                button_calculateParentalContribution.Location = new Point(25, 497);
                label_parentalContribution.Location = new Point(25, 547);
                label_parentalContributionToBePaid.Location = new Point(110, 547);
                Size = new Size(310, 635);  // Form size
            }

            if (numericUpDown_numOfChildren.Value == 9)
            {
                label_child1.Visible = true; textBox_DOB_Child1.Visible = true; label_ageChild1.Visible = true;
                label_child2.Visible = true; textBox_DOB_Child2.Visible = true; label_ageChild2.Visible = true;
                label_child3.Visible = true; textBox_DOB_Child3.Visible = true; label_ageChild3.Visible = true;
                label_child4.Visible = true; textBox_DOB_Child4.Visible = true; label_ageChild4.Visible = true;
                label_child5.Visible = true; textBox_DOB_Child5.Visible = true; label_ageChild5.Visible = true;
                label_child6.Visible = true; textBox_DOB_Child6.Visible = true; label_ageChild6.Visible = true;
                label_child7.Visible = true; textBox_DOB_Child7.Visible = true; label_ageChild7.Visible = true;
                label_child8.Visible = true; textBox_DOB_Child8.Visible = true; label_ageChild8.Visible = true;
                label_child9.Visible = true; textBox_DOB_Child9.Visible = true; label_ageChild9.Visible = true;
                label_child10.Visible = false; textBox_DOB_Child10.Visible = false; label_ageChild10.Visible = false;

                label_keyDate.Location = new Point(25, 432);
                textBox_keyDate.Location = new Point(25, 462);
                button_calculateParentalContribution.Location = new Point(25, 526);
                label_parentalContribution.Location = new Point(25, 576);
                label_parentalContributionToBePaid.Location = new Point(110, 576);
                Size = new Size(310, 664);  // Form size
            }

            if (numericUpDown_numOfChildren.Value == 10)
            {
                label_child1.Visible = true; textBox_DOB_Child1.Visible = true; label_ageChild1.Visible = true;
                label_child2.Visible = true; textBox_DOB_Child2.Visible = true; label_ageChild2.Visible = true;
                label_child3.Visible = true; textBox_DOB_Child3.Visible = true; label_ageChild3.Visible = true;
                label_child4.Visible = true; textBox_DOB_Child4.Visible = true; label_ageChild4.Visible = true;
                label_child5.Visible = true; textBox_DOB_Child5.Visible = true; label_ageChild5.Visible = true;
                label_child6.Visible = true; textBox_DOB_Child6.Visible = true; label_ageChild6.Visible = true;
                label_child7.Visible = true; textBox_DOB_Child7.Visible = true; label_ageChild7.Visible = true;
                label_child8.Visible = true; textBox_DOB_Child8.Visible = true; label_ageChild8.Visible = true;
                label_child9.Visible = true; textBox_DOB_Child9.Visible = true; label_ageChild9.Visible = true;
                label_child10.Visible = true; textBox_DOB_Child10.Visible = true; label_ageChild10.Visible = true;

                label_keyDate.Location = new Point(25, 461);
                textBox_keyDate.Location = new Point(25, 491);
                button_calculateParentalContribution.Location = new Point(25, 555);
                label_parentalContribution.Location = new Point(25, 605);
                label_parentalContributionToBePaid.Location = new Point(110, 605);
                Size = new Size(310, 693);  // Form size
            }
        }

        // NUMERIC UP-DOWN CONTROL
        private void NumericUpDown_numOfChildren_ValueChanged(object sender, EventArgs e)
        {
            AdaptScreenToNumOfChildren();
        }

        // CHECKBOX "YES"
        private void CheckBoxYes_singleParentFamily_Click(object sender, EventArgs e)
        {
            checkBoxNo_singleParentFamily.Checked = false;
            correctEntry = true;
        }

        // CHECKBOX "NO"
        private void CheckBoxNo_singleParentFamily_Click(object sender, EventArgs e)
        {
            checkBoxYes_singleParentFamily.Checked = false;
            correctEntry = true;
        }

        // CHECK IF A CHECKBOX IS CHECKED
        private void CheckCheckBoxes()
        {
            if (correctEntry == true)
            {
                if (checkBoxYes_singleParentFamily.Checked == false && checkBoxNo_singleParentFamily.Checked == false)
                {
                    MessageBox.Show("Geen invoer bij 'Eénoudergezin'. Vink aan of er sprake is van een éénoudergezin of niet.");
                    correctEntry = false;
                }
                else
                {
                    // Ignore
                }
            }
        }


        // PUBLIC VARIABLES
        public bool correctEntry = true;

        public DateTime birthdate_child1 = DateTime.MinValue; public DateTime birthdate_child2 = DateTime.MinValue;
        public DateTime birthdate_child3 = DateTime.MinValue; public DateTime birthdate_child4 = DateTime.MinValue;
        public DateTime birthdate_child5 = DateTime.MinValue; public DateTime birthdate_child6 = DateTime.MinValue;
        public DateTime birthdate_child7 = DateTime.MinValue; public DateTime birthdate_child8 = DateTime.MinValue;
        public DateTime birthdate_child9 = DateTime.MinValue; public DateTime birthdate_child10 = DateTime.MinValue;
        public DateTime keydate = DateTime.MinValue;

        public int age_child1 = 0; public int age_child2 = 0; public int age_child3 = 0; public int age_child4 = 0; public int age_child5 = 0;
        public int age_child6 = 0; public int age_child7 = 0; public int age_child8 = 0; public int age_child9 = 0; public int age_child10 = 0;


        // SET BIRTHDATES TO 'ZERO TIME'
        private void SetBirthdatesToZeroTime()
        {
            birthdate_child1 = DateTime.MinValue; birthdate_child2 = DateTime.MinValue;
            birthdate_child3 = DateTime.MinValue; birthdate_child4 = DateTime.MinValue;
            birthdate_child5 = DateTime.MinValue; birthdate_child6 = DateTime.MinValue;
            birthdate_child7 = DateTime.MinValue; birthdate_child8 = DateTime.MinValue;
            birthdate_child9 = DateTime.MinValue; birthdate_child10 = DateTime.MinValue;
            keydate = DateTime.MinValue;
        }

        // SET AGES TO ZERO
        private void SetAgesToZero()
        {
            age_child1 = 0; age_child2 = 0; age_child3 = 0; age_child4 = 0; age_child5 = 0;
            age_child6 = 0; age_child7 = 0; age_child8 = 0; age_child9 = 0; age_child10 = 0;
        }

        // METHOD FOR CHECKING DATES FROM USER INPUT
        private void CheckAndAssignBirthdate(string input)
        {
            if (correctEntry == true)
            {
                string[] formats = { "d-MM-yyyy", "d-M-yyyy", "dd-MM-yyyy", "dd-MM-yyyy" };

                // Check date format
                var isValidFormat = DateTime.TryParseExact(input, formats, CultureInfo.InvariantCulture, 
                                    DateTimeStyles.None, out DateTime birthdate);

                if (isValidFormat)
                {
                    string.Format("{0:dd-MM-yyyy}", birthdate);

                    DateTime zT = DateTime.MinValue; // 'zT' is an abbreviation of 'zeroTime', for which 'DateTime.MinValue' is used
                    bool assigned = false;

                    if (assigned == false && birthdate_child1 == zT) { birthdate_child1 = birthdate; assigned = true; }
                    if (assigned == false && birthdate_child1 != zT && birthdate_child2 == zT) { birthdate_child2 = birthdate; assigned = true; }
                    if (assigned == false && birthdate_child2 != zT && birthdate_child3 == zT) { birthdate_child3 = birthdate; assigned = true; }
                    if (assigned == false && birthdate_child3 != zT && birthdate_child4 == zT) { birthdate_child4 = birthdate; assigned = true; }
                    if (assigned == false && birthdate_child4 != zT && birthdate_child5 == zT) { birthdate_child5 = birthdate; assigned = true; }
                    if (assigned == false && birthdate_child5 != zT && birthdate_child6 == zT) { birthdate_child6 = birthdate; assigned = true; }
                    if (assigned == false && birthdate_child6 != zT && birthdate_child7 == zT) { birthdate_child7 = birthdate; assigned = true; }
                    if (assigned == false && birthdate_child7 != zT && birthdate_child8 == zT) { birthdate_child8 = birthdate; assigned = true; }
                    if (assigned == false && birthdate_child8 != zT && birthdate_child9 == zT) { birthdate_child9 = birthdate; assigned = true; }
                    if (assigned == false && birthdate_child9 != zT && birthdate_child10 == zT) { birthdate_child10 = birthdate; assigned = true; }
                }
                else
                {
                    if (input == textBox_DOB_Child1.Text && input != "") { MessageBox.Show("Ongeldige invoer geboortedatum kind 1. Voer de datum in volgens het format \"dd-MM-jjjj\"."); correctEntry = false; }
                    if (correctEntry == true && input == textBox_DOB_Child2.Text && input != "") { MessageBox.Show("Ongeldige invoer geboortedatum kind 2. Voer de datum in volgens het format \"dd-MM-jjjj\"."); correctEntry = false; }
                    if (correctEntry == true && input == textBox_DOB_Child3.Text && input != "") { MessageBox.Show("Ongeldige invoer geboortedatum kind 3. Voer de datum in volgens het format \"dd-MM-jjjj\"."); correctEntry = false; }
                    if (correctEntry == true && input == textBox_DOB_Child4.Text && input != "") { MessageBox.Show("Ongeldige invoer geboortedatum kind 4. Voer de datum in volgens het format \"dd-MM-jjjj\"."); correctEntry = false; }
                    if (correctEntry == true && input == textBox_DOB_Child5.Text && input != "") { MessageBox.Show("Ongeldige invoer geboortedatum kind 5. Voer de datum in volgens het format \"dd-MM-jjjj\"."); correctEntry = false; }
                    if (correctEntry == true && input == textBox_DOB_Child6.Text && input != "") { MessageBox.Show("Ongeldige invoer geboortedatum kind 6. Voer de datum in volgens het format \"dd-MM-jjjj\"."); correctEntry = false; }
                    if (correctEntry == true && input == textBox_DOB_Child7.Text && input != "") { MessageBox.Show("Ongeldige invoer geboortedatum kind 7. Voer de datum in volgens het format \"dd-MM-jjjj\"."); correctEntry = false; }
                    if (correctEntry == true && input == textBox_DOB_Child8.Text && input != "") { MessageBox.Show("Ongeldige invoer geboortedatum kind 8. Voer de datum in volgens het format \"dd-MM-jjjj\"."); correctEntry = false; }
                    if (correctEntry == true && input == textBox_DOB_Child9.Text && input != "") { MessageBox.Show("Ongeldige invoer geboortedatum kind 9. Voer de datum in volgens het format \"dd-MM-jjjj\"."); correctEntry = false; }
                    if (correctEntry == true && input == textBox_DOB_Child10.Text && input != "") { MessageBox.Show("Ongeldige invoer geboortedatum kind 10. Voer de datum in volgens het format \"dd-MM-jjjj\"."); correctEntry = false; }

                    if (correctEntry == true && input == textBox_DOB_Child1.Text && input == "") { MessageBox.Show("Voer een geboortedatum in voor kind 1."); correctEntry = false; }
                    if (correctEntry == true && input == textBox_DOB_Child2.Text && input == "") { MessageBox.Show("Voer een geboortedatum in voor kind 2."); correctEntry = false; }
                    if (correctEntry == true && input == textBox_DOB_Child3.Text && input == "") { MessageBox.Show("Voer een geboortedatum in voor kind 3."); correctEntry = false; }
                    if (correctEntry == true && input == textBox_DOB_Child4.Text && input == "") { MessageBox.Show("Voer een geboortedatum in voor kind 4."); correctEntry = false; }
                    if (correctEntry == true && input == textBox_DOB_Child5.Text && input == "") { MessageBox.Show("Voer een geboortedatum in voor kind 5."); correctEntry = false; }
                    if (correctEntry == true && input == textBox_DOB_Child6.Text && input == "") { MessageBox.Show("Voer een geboortedatum in voor kind 6."); correctEntry = false; }
                    if (correctEntry == true && input == textBox_DOB_Child7.Text && input == "") { MessageBox.Show("Voer een geboortedatum in voor kind 7."); correctEntry = false; }
                    if (correctEntry == true && input == textBox_DOB_Child8.Text && input == "") { MessageBox.Show("Voer een geboortedatum in voor kind 8."); correctEntry = false; }
                    if (correctEntry == true && input == textBox_DOB_Child9.Text && input == "") { MessageBox.Show("Voer een geboortedatum in voor kind 9."); correctEntry = false; }
                    if (correctEntry == true && input == textBox_DOB_Child10.Text && input == "") { MessageBox.Show("Voer een geboortedatum in voor kind 10."); correctEntry = false; }
                }
            }
        }

        // CHECK KEYDATE FORMAT
        private void CheckKeyDateFormat(string input)
        {
            if (correctEntry == true)
            {
                string[] formats = { "d-MM-yyyy", "d-M-yyyy", "dd-MM-yyyy", "dd-MM-yyyy" };

                // Check date format
                var isValidFormat = DateTime.TryParseExact(input, formats, CultureInfo.InvariantCulture,
                                    DateTimeStyles.None, out DateTime date);

                if (isValidFormat)
                {
                    string.Format("{0:dd-MM-yyyy}", date);

                    DateTime zT = DateTime.MinValue; // 'zT' is an abbreviation of 'zeroTime', for which 'DateTime.MinValue' is used
                    
                    if (keydate == zT) { keydate = date; }
                }
                else
                {
                    if (correctEntry == true)
                    {
                        MessageBox.Show("Geen of ongeldige invoer peildatum. Voer de datum in volgens het format \"dd-MM-jjjj\".");
                        correctEntry = false;
                    }
                }
            }
        }


        // METHOD TO DETERMINE AGE FROM A BIRTHDAY
        private void AssignAndCheckAge()
        {
            //DateTime today = DateTime.Now; // reference date for age calculation is set as today

            if (correctEntry == true && numericUpDown_numOfChildren.Value >= 1
                && age_child1 == 0)
            {
                age_child1 = keydate.Year - birthdate_child1.Year;

                if (keydate.DayOfYear < birthdate_child1.DayOfYear)
                { age_child1 -= 1; };

                if (age_child1 < 4)
                {
                    MessageBox.Show("Leeftijd kind 1 ligt onder de leeftijd voor toelating tot het basisonderwijs. " +
                                    "Alleen kinderen van 4 tot 14 jaar kunnen les krijgen op de basisschool.");
                    correctEntry = false;
                }

                if (age_child1 > 14)
                {
                    MessageBox.Show("Leeftijd kind 1 ligt boven de leeftijd voor toelating tot de basisschool. " +
                                    "Alleen kinderen van 4 tot 14 jaar kunnen les krijgen.");
                    correctEntry = false;
                }
            }

            if (correctEntry == true && numericUpDown_numOfChildren.Value >= 2
                && age_child1 != 0 && age_child2 == 0)
            {
                age_child2 = keydate.Year - birthdate_child2.Year;
                if (keydate.DayOfYear < birthdate_child2.DayOfYear) { age_child2 -= 1; };

                if (age_child2 < 4)
                {
                    MessageBox.Show("Leeftijd kind 2 ligt onder de leeftijd voor toelating tot het basisonderwijs. " +
                                    "Alleen kinderen van 4 tot 14 jaar kunnen les krijgen op de basisschool.");
                    correctEntry = false;
                }

                if (age_child2 > 14)
                {
                    MessageBox.Show("Leeftijd kind 2 ligt boven de leeftijd voor toelating tot de basisschool. " +
                                    "Alleen kinderen van 4 tot 14 jaar kunnen les krijgen.");
                    correctEntry = false;
                }
            }

            if (correctEntry == true && numericUpDown_numOfChildren.Value >= 3
                && age_child2 != 0 && age_child3 == 0)
            {
                age_child3 = keydate.Year - birthdate_child3.Year;
                if (keydate.DayOfYear < birthdate_child3.DayOfYear) { age_child3 -= 1; };

                if (age_child3 < 4)
                {
                    MessageBox.Show("Leeftijd kind 3 ligt onder de leeftijd voor toelating tot het basisonderwijs. " +
                                    "Alleen kinderen van 4 tot 14 jaar kunnen les krijgen op de basisschool.");
                    correctEntry = false;
                }

                if (age_child3 > 14)
                {
                    MessageBox.Show("Leeftijd kind 3 ligt boven de leeftijd voor toelating tot de basisschool. " +
                                    "Alleen kinderen van 4 tot 14 jaar kunnen les krijgen.");
                    correctEntry = false;
                }
            }

            if (correctEntry == true && numericUpDown_numOfChildren.Value >= 4
                && age_child3 != 0 && age_child4 == 0)
            {
                age_child4 = keydate.Year - birthdate_child4.Year;
                if (keydate.DayOfYear < birthdate_child4.DayOfYear) { age_child4 -= 1; };

                if (age_child4 < 4)
                {
                    MessageBox.Show("Leeftijd kind 4 ligt onder de leeftijd voor toelating tot het basisonderwijs. " +
                                    "Alleen kinderen van 4 tot 14 jaar kunnen les krijgen op de basisschool.");
                    correctEntry = false;
                }

                if (age_child4 > 14)
                {
                    MessageBox.Show("Leeftijd kind 4 ligt boven de leeftijd voor toelating tot de basisschool. " +
                                    "Alleen kinderen van 4 tot 14 jaar kunnen les krijgen.");
                    correctEntry = false;
                }
            }

            if (correctEntry == true && numericUpDown_numOfChildren.Value >= 5
                && age_child4 != 0 && age_child5 == 0)
            {
                age_child5 = keydate.Year - birthdate_child5.Year;
                if (keydate.DayOfYear < birthdate_child5.DayOfYear) { age_child5 -= 1; };

                if (age_child5 < 4)
                {
                    MessageBox.Show("Leeftijd kind 5 ligt onder de leeftijd voor toelating tot het basisonderwijs. " +
                                    "Alleen kinderen van 4 tot 14 jaar kunnen les krijgen op de basisschool.");
                    correctEntry = false;
                }

                if (age_child5 > 14)
                {
                    MessageBox.Show("Leeftijd kind 5 ligt boven de leeftijd voor toelating tot de basisschool. " +
                                    "Alleen kinderen van 4 tot 14 jaar kunnen les krijgen.");
                    correctEntry = false;
                }
            }

            if (correctEntry == true && numericUpDown_numOfChildren.Value >= 6
                && age_child5 != 0 && age_child6 == 0)
            {
                age_child6 = keydate.Year - birthdate_child6.Year;
                if (keydate.DayOfYear < birthdate_child6.DayOfYear) { age_child6 -= 1; };

                if (age_child6 < 4)
                {
                    MessageBox.Show("Leeftijd kind 6 ligt onder de leeftijd voor toelating tot het basisonderwijs. " +
                                    "Alleen kinderen van 4 tot 14 jaar kunnen les krijgen op de basisschool.");
                    correctEntry = false;
                }

                if (age_child6 > 14)
                {
                    MessageBox.Show("Leeftijd kind 6 ligt boven de leeftijd voor toelating tot de basisschool. " +
                                    "Alleen kinderen van 4 tot 14 jaar kunnen les krijgen.");
                    correctEntry = false;
                }
            }

            if (correctEntry == true && numericUpDown_numOfChildren.Value >= 7
                && age_child6 != 0 && age_child7 == 0)
            {
                age_child7 = keydate.Year - birthdate_child7.Year;
                if (keydate.DayOfYear < birthdate_child7.DayOfYear) { age_child7 -= 1; };

                if (age_child7 < 4)
                {
                    MessageBox.Show("Leeftijd kind 7 ligt onder de leeftijd voor toelating tot het basisonderwijs. " +
                                    "Alleen kinderen van 4 tot 14 jaar kunnen les krijgen op de basisschool.");
                    correctEntry = false;
                }

                if (age_child7 > 14)
                {
                    MessageBox.Show("Leeftijd kind 7 ligt boven de leeftijd voor toelating tot de basisschool. " +
                                    "Alleen kinderen van 4 tot 14 jaar kunnen les krijgen.");
                    correctEntry = false;
                }
            }

            if (correctEntry == true && numericUpDown_numOfChildren.Value >= 8
                && age_child7 != 0 && age_child8 == 0)
            {
                age_child8 = keydate.Year - birthdate_child8.Year;
                if (keydate.DayOfYear < birthdate_child8.DayOfYear) { age_child8 -= 1; };

                if (age_child8 < 4)
                {
                    MessageBox.Show("Leeftijd kind 8 ligt onder de leeftijd voor toelating tot het basisonderwijs. " +
                                    "Alleen kinderen van 4 tot 14 jaar kunnen les krijgen op de basisschool.");
                    correctEntry = false;
                }

                if (age_child8 > 14)
                {
                    MessageBox.Show("Leeftijd kind 8 ligt boven de leeftijd voor toelating tot de basisschool. " +
                                    "Alleen kinderen van 4 tot 14 jaar kunnen les krijgen.");
                    correctEntry = false;
                }
            }

            if (correctEntry == true && numericUpDown_numOfChildren.Value >= 9
                && age_child8 != 0 && age_child9 == 0)
            {
                age_child9 = keydate.Year - birthdate_child9.Year;
                if (DateTime.Now.DayOfYear < birthdate_child9.DayOfYear) { age_child9 -= 1; };

                if (age_child9 < 4)
                {
                    MessageBox.Show("Leeftijd kind 9 ligt onder de leeftijd voor toelating tot het basisonderwijs. " +
                                    "Alleen kinderen van 4 tot 14 jaar kunnen les krijgen op de basisschool.");
                    correctEntry = false;
                }

                if (age_child9 > 14)
                {
                    MessageBox.Show("Leeftijd kind 9 ligt boven de leeftijd voor toelating tot de basisschool. " +
                                    "Alleen kinderen van 4 tot 14 jaar kunnen les krijgen.");
                    correctEntry = false;
                }
            }

            if (correctEntry == true && numericUpDown_numOfChildren.Value == 10
                && age_child9 != 0 && age_child10 == 0)
            {
                age_child10 = keydate.Year - birthdate_child10.Year;
                if (keydate.DayOfYear < birthdate_child10.DayOfYear) { age_child10 -= 1; };

                if (age_child10 < 4)
                {
                    MessageBox.Show("Leeftijd kind 10 ligt onder de leeftijd voor toelating tot het basisonderwijs. " +
                                    "Alleen kinderen van 4 tot 14 jaar kunnen les krijgen op de basisschool.");
                    correctEntry = false;
                }

                if (age_child10 > 14)
                {
                    MessageBox.Show("Leeftijd kind 10 ligt boven de leeftijd voor toelating tot de basisschool. " +
                                    "Alleen kinderen van 4 tot 14 jaar kunnen les krijgen.");
                    correctEntry = false;
                }
            }
        }


        // PRINT AGE TO SCREEN
        private void PrintAgeToScreen(int childNr)
        {
            if (childNr == 1) { label_ageChild1.Text = "" + age_child1; }
            if (age_child1 < 10) { label_ageChild1.Text = "  " + age_child1; }
            if (childNr == 2) { label_ageChild2.Text = "" + age_child2; }
            if (age_child2 < 10) { label_ageChild2.Text = "  " + age_child2; }
            if (childNr == 3) { label_ageChild3.Text = "" + age_child3; }
            if (age_child3 < 10) { label_ageChild3.Text = "  " + age_child3; }
            if (childNr == 4) { label_ageChild4.Text = "" + age_child4; }
            if (age_child4 < 10) { label_ageChild4.Text = "  " + age_child4; }
            if (childNr == 5) { label_ageChild5.Text = "" + age_child5; }
            if (age_child5 < 10) { label_ageChild5.Text = "  " + age_child5; }
            if (childNr == 6) { label_ageChild6.Text = "" + age_child6; }
            if (age_child6 < 10) { label_ageChild6.Text = "  " + age_child6; }
            if (childNr == 7) { label_ageChild7.Text = "" + age_child7; }
            if (age_child7 < 10) { label_ageChild7.Text = "  " + age_child7; }
            if (childNr == 8) { label_ageChild8.Text = "" + age_child8; }
            if (age_child8 < 10) { label_ageChild8.Text = "  " + age_child8; }
            if (childNr == 9) { label_ageChild9.Text = "" + age_child9; }
            if (age_child9 < 10) { label_ageChild9.Text = "  " + age_child9; }
            if (childNr == 10) { label_ageChild10.Text = "" + age_child10; }
            if (age_child10 < 10) { label_ageChild10.Text = "  " + age_child10; }
        }


        // METHOD TO CALCULATE TOTAL PARENTAL CONTRIBUTION
        private void CalculateParentalContribution()
        {
            double contribution = 0;
            double contributionChildrenUnder10 = 0;
            double contributionChildrenAbove10 = 0;

            double contribution_base = 50.00;
            double contribution_childUnder10 = 25.00;
            double contribution_childAbove10 = 37.00;
            double contribution_max = 150.00;

            double singleParentReduction = 0.25; // 25% reduction

            // Add all children's ages to a list with ages
            List<int> ages = new List<int>();

            if (numericUpDown_numOfChildren.Value == 1)
            {
                ages.Add(age_child1);
            }

            if (numericUpDown_numOfChildren.Value == 2)
            {
                ages.Add(age_child1); ages.Add(age_child2);
            }

            if (numericUpDown_numOfChildren.Value == 3)
            {
                ages.Add(age_child1); ages.Add(age_child2); ages.Add(age_child3);
            }

            if (numericUpDown_numOfChildren.Value == 4)
            {
                ages.Add(age_child1); ages.Add(age_child2); ages.Add(age_child3); ages.Add(age_child4);
            }

            if (numericUpDown_numOfChildren.Value == 5)
            {
                ages.Add(age_child1); ages.Add(age_child2); ages.Add(age_child3); ages.Add(age_child4); ages.Add(age_child5);
            }

            if (numericUpDown_numOfChildren.Value == 6)
            {
                ages.Add(age_child1); ages.Add(age_child2); ages.Add(age_child3); ages.Add(age_child4); ages.Add(age_child5);
                ages.Add(age_child6);
            }

            if (numericUpDown_numOfChildren.Value == 7)
            {
                ages.Add(age_child1); ages.Add(age_child2); ages.Add(age_child3); ages.Add(age_child4); ages.Add(age_child5);
                ages.Add(age_child6); ages.Add(age_child7);
            }

            if (numericUpDown_numOfChildren.Value == 8)
            {
                ages.Add(age_child1); ages.Add(age_child2); ages.Add(age_child3); ages.Add(age_child4); ages.Add(age_child5);
                ages.Add(age_child6); ages.Add(age_child7); ages.Add(age_child8);
            }

            if (numericUpDown_numOfChildren.Value == 9)
            {
                ages.Add(age_child1); ages.Add(age_child2); ages.Add(age_child3); ages.Add(age_child4); ages.Add(age_child5);
                ages.Add(age_child6); ages.Add(age_child7); ages.Add(age_child8); ages.Add(age_child9);
            }

            if (numericUpDown_numOfChildren.Value == 10)
            {
                ages.Add(age_child1); ages.Add(age_child2); ages.Add(age_child3); ages.Add(age_child4); ages.Add(age_child5);
                ages.Add(age_child6); ages.Add(age_child7); ages.Add(age_child8); ages.Add(age_child9); ages.Add(age_child10);
            }

            // Calculate number of children under and above the age of 10
            int numOfChildrenUnder10 = 0;
            int numOfChildrenAbove10 = 0;

            foreach (int age in ages)
            {
                if (age < 10)
                {
                    numOfChildrenUnder10 = numOfChildrenUnder10 + 1;
                }

                if (age >= 10)
                {
                    numOfChildrenAbove10 = numOfChildrenAbove10 + 1;
                }
            }

            // Calculate contribution for children under and above the age of 10
            contributionChildrenUnder10 = numOfChildrenUnder10 * contribution_childUnder10;
            contributionChildrenAbove10 = numOfChildrenAbove10 * contribution_childAbove10;

            // Maximum total contribution for children under and above the age of 10
            if (numOfChildrenUnder10 >= 3)
            {
                contributionChildrenUnder10 = 3 * contribution_childUnder10;
            }

            if (numOfChildrenAbove10 >= 2)
            {
                contributionChildrenAbove10 = 2 * contribution_childAbove10;
            }

            // Total contribution
            contribution = contribution_base + contributionChildrenUnder10 + contributionChildrenAbove10;

            // Maximum total contribution
            if (contribution > contribution_max)
            {
                contribution = contribution_max;
            }

            // Single parent reduction
            if (checkBoxYes_singleParentFamily.Checked == true)
            {
                contribution = contribution * (1 - singleParentReduction);
            }

            // Print calculated contribution to screen
            label_parentalContributionToBePaid.Text = contribution.ToString("C", CultureInfo.GetCultureInfo("nl-NL"));
        }


        // RESET AGE LABEL TEXT AFTER CHANGED TEXT IN TEXTBOX
        private void TextBox_DOB_Child1_TextChanged(object sender, EventArgs e) { label_ageChild1.Text = "-"; }
        private void TextBox_DOB_Child2_TextChanged(object sender, EventArgs e) { label_ageChild2.Text = "-"; }
        private void TextBox_DOB_Child3_TextChanged(object sender, EventArgs e) { label_ageChild3.Text = "-"; }
        private void TextBox_DOB_Child4_TextChanged(object sender, EventArgs e) { label_ageChild4.Text = "-"; }
        private void TextBox_DOB_Child5_TextChanged(object sender, EventArgs e) { label_ageChild5.Text = "-"; }
        private void TextBox_DOB_Child6_TextChanged(object sender, EventArgs e) { label_ageChild6.Text = "-"; }
        private void TextBox_DOB_Child7_TextChanged(object sender, EventArgs e) { label_ageChild7.Text = "-"; }
        private void TextBox_DOB_Child8_TextChanged(object sender, EventArgs e) { label_ageChild8.Text = "-"; }
        private void TextBox_DOB_Child9_TextChanged(object sender, EventArgs e) { label_ageChild9.Text = "-"; }
        private void TextBox_DOB_Child10_TextChanged(object sender, EventArgs e) { label_ageChild10.Text = "-"; }


        // BUTTON CALCULATE PARENTAL CONTRIBUTION
        private void Button_calculateParentalContribution_Click(object sender, EventArgs e)
        {
            // Preset
            correctEntry = true;
            SetBirthdatesToZeroTime();
            SetAgesToZero();

            // FIRST: CHECK CHECK BOXES
            CheckCheckBoxes();

            // SECOND: CHECK AND ASSIGN BIRTHDATE(S)
            if (correctEntry == true)
            {
                if (numericUpDown_numOfChildren.Value >= 1) { CheckAndAssignBirthdate(textBox_DOB_Child1.Text); }
                if (numericUpDown_numOfChildren.Value >= 2) { CheckAndAssignBirthdate(textBox_DOB_Child2.Text); }
                if (numericUpDown_numOfChildren.Value >= 3) { CheckAndAssignBirthdate(textBox_DOB_Child3.Text); }
                if (numericUpDown_numOfChildren.Value >= 4) { CheckAndAssignBirthdate(textBox_DOB_Child4.Text); }
                if (numericUpDown_numOfChildren.Value >= 5) { CheckAndAssignBirthdate(textBox_DOB_Child5.Text); }
                if (numericUpDown_numOfChildren.Value >= 6) { CheckAndAssignBirthdate(textBox_DOB_Child6.Text); }
                if (numericUpDown_numOfChildren.Value >= 7) { CheckAndAssignBirthdate(textBox_DOB_Child7.Text); }
                if (numericUpDown_numOfChildren.Value >= 8) { CheckAndAssignBirthdate(textBox_DOB_Child8.Text); }
                if (numericUpDown_numOfChildren.Value >= 9) { CheckAndAssignBirthdate(textBox_DOB_Child9.Text); }
                if (numericUpDown_numOfChildren.Value == 10) { CheckAndAssignBirthdate(textBox_DOB_Child10.Text); }
            }

            // THIRD: CHECK KEYDATE FORMAT
            if (correctEntry == true)
            {
                CheckKeyDateFormat(textBox_keyDate.Text);
            }

            // FOURTH: ASSIGN AND CHECK AGE(S)
            if (correctEntry == true)
            {
                AssignAndCheckAge();
            }

            // FIFTH: CALCULATE PARENTAL CONTRIBUTION AND SHOW CHILDREN's AGE
            if (correctEntry == true)
            {
                CalculateParentalContribution();

                if (numericUpDown_numOfChildren.Value >= 1) { label_ageChild1.Visible = true; PrintAgeToScreen(1); }
                if (numericUpDown_numOfChildren.Value >= 2) { label_ageChild2.Visible = true; PrintAgeToScreen(2); }
                if (numericUpDown_numOfChildren.Value >= 3) { label_ageChild3.Visible = true; PrintAgeToScreen(3); }
                if (numericUpDown_numOfChildren.Value >= 4) { label_ageChild4.Visible = true; PrintAgeToScreen(4); }
                if (numericUpDown_numOfChildren.Value >= 5) { label_ageChild5.Visible = true; PrintAgeToScreen(5); }
                if (numericUpDown_numOfChildren.Value >= 6) { label_ageChild6.Visible = true; PrintAgeToScreen(6); }
                if (numericUpDown_numOfChildren.Value >= 7) { label_ageChild7.Visible = true; PrintAgeToScreen(7); }
                if (numericUpDown_numOfChildren.Value >= 8) { label_ageChild8.Visible = true; PrintAgeToScreen(8); }
                if (numericUpDown_numOfChildren.Value >= 9) { label_ageChild9.Visible = true; PrintAgeToScreen(9); }
                if (numericUpDown_numOfChildren.Value == 10) { label_ageChild10.Visible = true; PrintAgeToScreen(10); }
            }
        }
    }
}