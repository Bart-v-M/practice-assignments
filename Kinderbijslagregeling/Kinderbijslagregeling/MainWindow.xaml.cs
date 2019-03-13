using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

// Date: February/March 2019
// Could be a nice type of application for the Tax Authority :-)

namespace Kinderbijslagregeling
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SetStartScreen();
            AutoSetItems_comboBox_selectCalendarYear();
        }


        // SET START SCREEN
        public void SetStartScreen()
        {
            HideAllControls();
            ShowStartControls();
            SetMarginBottomControls(marginBase, marginChangeAtStart, 0, 0, 0, 0);
            label_calculateButton.Background = new SolidColorBrush(Colors.Gainsboro);
            label_calculateButton.Foreground = new SolidColorBrush(Colors.DimGray);
        }


        // CONTROLS

        // Lists with controls
        public List<Control> allControls;
        public List<Control> startControls;
        public List<Control> numOfChildrenControls;
        public List<Control> bottomControls;
        public List<Control> childAllowanceLabels;

        // Hide all controls of the program
        private void HideAllControls()
        {
            allControls = new List<Control>()
            {
                label_header,
                label_calendarYearForCalculation, comboBox_selectCalendarYear,
                label_numOfChildrenForCalculation, comboBox_selectNumOfChildren,
                label_birthdateChild01, textBox_birthdateChild01,
                label_birthdateChild02, textBox_birthdateChild02,
                label_birthdateChild03, textBox_birthdateChild03,
                label_birthdateChild04, textBox_birthdateChild04,
                label_birthdateChild05, textBox_birthdateChild05,
                label_birthdateChild06, textBox_birthdateChild06,
                label_birthdateChild07, textBox_birthdateChild07,
                label_birthdateChild08, textBox_birthdateChild08,
                label_birthdateChild09, textBox_birthdateChild09,
                label_birthdateChild10, textBox_birthdateChild10,
                label_whiteLine, button_calculate, label_explanationCalculateButton,
                label_ChildAllowanceToBeReceivedInYearX,
                label_1stQuarter, label_allowanceInEuros1stQuarter,
                label_2ndQuarter, label_allowanceInEuros2ndQuarter,
                label_3rdQuarter, label_allowanceInEuros3rdQuarter,
                label_4thQuarter, label_allowanceInEuros4thQuarter,
                label_yearTotalChildAllowance, label_allowanceInEurosYearTotal,
                button_newCalculation, label_newCalculationButton
            };

            foreach (Control control in allControls)
            {
                control.Visibility = Visibility.Hidden;
            }
        }

        // Show controls needed at the start of the program
        private void ShowStartControls()
        {
            startControls = new List<Control>()
            {
                label_header,
                label_calendarYearForCalculation, comboBox_selectCalendarYear,
                label_whiteLine, label_calculateButton, label_explanationCalculateButton
            };

            foreach (Control control in startControls)
            {
                control.Visibility = Visibility.Visible;
            }
        }

        // Shows the controls needed to enter the number of children
        private void ShowControls_numOfChildren()
        {
            numOfChildrenControls = new List<Control>()
            {
                label_numOfChildrenForCalculation, comboBox_selectNumOfChildren
            };

            foreach (Control control in numOfChildrenControls)
            {
                control.Visibility = Visibility.Visible;
            }
        }

        // Shows the controls needed to enter the children's birthdates
        private void ShowControls_birthdates(int numOfChildren)
        {
            if (numOfChildren >= 1) { label_birthdateChild01.Visibility = Visibility.Visible; textBox_birthdateChild01.Visibility = Visibility.Visible; }
            if (numOfChildren >= 2) { label_birthdateChild02.Visibility = Visibility.Visible; textBox_birthdateChild02.Visibility = Visibility.Visible; }
            if (numOfChildren >= 3) { label_birthdateChild03.Visibility = Visibility.Visible; textBox_birthdateChild03.Visibility = Visibility.Visible; }
            if (numOfChildren >= 4) { label_birthdateChild04.Visibility = Visibility.Visible; textBox_birthdateChild04.Visibility = Visibility.Visible; }
            if (numOfChildren >= 5) { label_birthdateChild05.Visibility = Visibility.Visible; textBox_birthdateChild05.Visibility = Visibility.Visible; }
            if (numOfChildren >= 6) { label_birthdateChild06.Visibility = Visibility.Visible; textBox_birthdateChild06.Visibility = Visibility.Visible; }
            if (numOfChildren >= 7) { label_birthdateChild07.Visibility = Visibility.Visible; textBox_birthdateChild07.Visibility = Visibility.Visible; }
            if (numOfChildren >= 8) { label_birthdateChild08.Visibility = Visibility.Visible; textBox_birthdateChild08.Visibility = Visibility.Visible; }
            if (numOfChildren >= 9) { label_birthdateChild09.Visibility = Visibility.Visible; textBox_birthdateChild09.Visibility = Visibility.Visible; }
            if (numOfChildren == 10) { label_birthdateChild10.Visibility = Visibility.Visible; textBox_birthdateChild10.Visibility = Visibility.Visible; }
        }

        // Hide the controls needed to enter the children's birthdates
        private void HideControls_birthdates()
        {
            label_birthdateChild01.Visibility = Visibility.Hidden; textBox_birthdateChild01.Visibility = Visibility.Hidden;
            label_birthdateChild02.Visibility = Visibility.Hidden; textBox_birthdateChild02.Visibility = Visibility.Hidden;
            label_birthdateChild03.Visibility = Visibility.Hidden; textBox_birthdateChild03.Visibility = Visibility.Hidden;
            label_birthdateChild04.Visibility = Visibility.Hidden; textBox_birthdateChild04.Visibility = Visibility.Hidden;
            label_birthdateChild05.Visibility = Visibility.Hidden; textBox_birthdateChild05.Visibility = Visibility.Hidden;
            label_birthdateChild06.Visibility = Visibility.Hidden; textBox_birthdateChild06.Visibility = Visibility.Hidden;
            label_birthdateChild07.Visibility = Visibility.Hidden; textBox_birthdateChild07.Visibility = Visibility.Hidden;
            label_birthdateChild08.Visibility = Visibility.Hidden; textBox_birthdateChild08.Visibility = Visibility.Hidden;
            label_birthdateChild09.Visibility = Visibility.Hidden; textBox_birthdateChild09.Visibility = Visibility.Hidden;
            label_birthdateChild10.Visibility = Visibility.Hidden; textBox_birthdateChild10.Visibility = Visibility.Hidden;
        }

        // SET MARGIN OF BOTTOM CONTROLS

        // Margin variables
        public int marginBase;
        public int marginChangeAtStart = -360;
        public int marginChangeAtSelectionNumOfChildren = 67;
        public int marginChangeAfterSelectionNumOfChildren = 50;
        public int marginChangePerExtraChildSelected = 28;

        // Set margin of bottom control
        private void SetMarginBottomControls(int marginBase, int marginChangeAtStart, int marginChangeAtSelectionNumOfChildren,
                                             int marginChangeAfterSelectionNumOfChildren, int numOfChildren, int marginChangePerExtraChildSelected)
        {
            List<Control> bottomControls = new List<Control>()
            {
                label_whiteLine, label_calculateButton, label_explanationCalculateButton
            };

            foreach (Control control in bottomControls)
            {
                if (control == label_whiteLine) { marginBase = 506; }
                else { marginBase = 530; }

                Thickness margin = control.Margin;
                margin.Top = marginBase + marginChangeAtStart + marginChangeAtSelectionNumOfChildren + marginChangeAfterSelectionNumOfChildren
                             + ((numOfChildren - 1) * marginChangePerExtraChildSelected);
                control.Margin = margin;
            }
        }
        // COMMENTARY:
        // The top margin of the bottom control can be set with the method above. For each stage in the user interface a different margin
        // is used. The method above offers the possibility to use a standard margin (by using a public margin variable) or not (by setting 
        // a margin at zero).


        // SELECT CALENDAR YEAR

        // Automatically sets items of 'combobox_selectCalendarYear' to the correct year (at the start of the program)
        private void AutoSetItems_comboBox_selectCalendarYear()
        {
            DateTime today = DateTime.Today;
            int year = today.Year;

            currentYearMinus0.Content = (year - 0).ToString();
            currentYearMinus1.Content = (year - 1).ToString();
            currentYearMinus2.Content = (year - 2).ToString();
            currentYearMinus3.Content = (year - 3).ToString();
            currentYearMinus4.Content = (year - 4).ToString();
        }

        // Reference date for the child allowance calculations
        public DateTime startOfSelectedCalendarYear;

        // Calculate reference date and continue program after selection of calendar year
        private void ComboBox_selectCalendarYear_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (calculateButtonIsClicked == false)
            {
                DateTime today = DateTime.Today;
                DateTime systemStart = new DateTime(2019, 1, 1);

                TimeSpan offset = today - systemStart;
                int numOfOffsetYears = (int)(offset.TotalDays / 365.2524);

                if (currentYearMinus0.IsSelected) { startOfSelectedCalendarYear = systemStart.AddYears(numOfOffsetYears - 0); }
                if (currentYearMinus1.IsSelected) { startOfSelectedCalendarYear = systemStart.AddYears(numOfOffsetYears - 1); }
                if (currentYearMinus2.IsSelected) { startOfSelectedCalendarYear = systemStart.AddYears(numOfOffsetYears - 2); }
                if (currentYearMinus3.IsSelected) { startOfSelectedCalendarYear = systemStart.AddYears(numOfOffsetYears - 3); }
                if (currentYearMinus4.IsSelected) { startOfSelectedCalendarYear = systemStart.AddYears(numOfOffsetYears - 4); }

                ShowControls_numOfChildren();

                SetMarginBottomControls(marginBase, marginChangeAtStart, marginChangeAtSelectionNumOfChildren, 0, 0, 0);

                // The code below is used to keep the margins right, 
                // when the calendar year is changed after the number of children has been set...
                if (numOfChildren == 1) { NumOfChildren02.IsSelected = true; NumOfChildren01.IsSelected = true; }
                if (numOfChildren == 2) { NumOfChildren01.IsSelected = true; NumOfChildren02.IsSelected = true; }
                if (numOfChildren == 3) { NumOfChildren02.IsSelected = true; NumOfChildren03.IsSelected = true; }
                if (numOfChildren == 4) { NumOfChildren03.IsSelected = true; NumOfChildren04.IsSelected = true; }
                if (numOfChildren == 5) { NumOfChildren04.IsSelected = true; NumOfChildren05.IsSelected = true; }
                if (numOfChildren == 6) { NumOfChildren05.IsSelected = true; NumOfChildren06.IsSelected = true; }
                if (numOfChildren == 7) { NumOfChildren06.IsSelected = true; NumOfChildren07.IsSelected = true; }
                if (numOfChildren == 8) { NumOfChildren07.IsSelected = true; NumOfChildren08.IsSelected = true; }
                if (numOfChildren == 9) { NumOfChildren08.IsSelected = true; NumOfChildren09.IsSelected = true; }
                if (numOfChildren == 10) { NumOfChildren09.IsSelected = true; NumOfChildren10.IsSelected = true; }
            }
            if (calculateButtonIsClicked == true)
            {
                // Ignore 
                // The calendar year can't be changed anymore after the calculate button is used
            }
        }


        // SELECT NUMBER OF CHILDREN
        public int numOfChildren;

        private void DetermineNumOfChildren()
        {
            if (NumOfChildren01.IsSelected) { numOfChildren = 1; } if (NumOfChildren02.IsSelected) { numOfChildren = 2; }
            if (NumOfChildren03.IsSelected) { numOfChildren = 3; } if (NumOfChildren04.IsSelected) { numOfChildren = 4; }
            if (NumOfChildren05.IsSelected) { numOfChildren = 5; } if (NumOfChildren06.IsSelected) { numOfChildren = 6; }
            if (NumOfChildren07.IsSelected) { numOfChildren = 7; } if (NumOfChildren08.IsSelected) { numOfChildren = 8; }
            if (NumOfChildren09.IsSelected) { numOfChildren = 9; } if (NumOfChildren10.IsSelected) { numOfChildren = 10; }

            // Change text of label_birthdateChild01...
            if (!NumOfChildren01.IsSelected) { label_birthdateChild01.Content = "Geboortedatum kind 1"; }
            if (NumOfChildren01.IsSelected) { label_birthdateChild01.Content = "Geboortedatum kind"; }
        }

        private void ComboBox_selectNumOfChildren_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (calculateButtonIsClicked == false)
            {
                HideControls_birthdates(); // this works as a reset

                DetermineNumOfChildren();

                // Set margin of bottom controls
                SetMarginBottomControls(marginBase, marginChangeAtStart, marginChangeAtSelectionNumOfChildren, marginChangeAfterSelectionNumOfChildren,
                                            numOfChildren, marginChangePerExtraChildSelected);

                // Show the necessary textboxes to fill in children's birthdates
                ShowControls_birthdates(numOfChildren);
            }
            if (calculateButtonIsClicked == true)
            {
                // Ignore 
                // The number of children can't be changed anymore after the calculate button is used
            }
        }


        // CHECK AND ASSIGN BIRTHDATE METHOD

        // Public variables
        public bool correctEntry = true;
        public static DateTime zeroTime = DateTime.MinValue;

        public DateTime birthdate_child1; public DateTime birthdate_child2; public DateTime birthdate_child3;
        public DateTime birthdate_child4; public DateTime birthdate_child5; public DateTime birthdate_child6;
        public DateTime birthdate_child7; public DateTime birthdate_child8; public DateTime birthdate_child9;
        public DateTime birthdate_child10;

        // Ages of children set at -1 from start, because only for children from zero child benefit is possible
        public int age_child1 = -1; public int age_child2 = -1; public int age_child3 = -1; public int age_child4 = -1; public int age_child5 = -1;
        public int age_child6 = -1; public int age_child7 = -1; public int age_child8 = -1; public int age_child9 = -1; public int age_child10 = -1;

        // If true no age will be calculated for a child and the age remains at -1, so child benefit won't be calculated
        public bool child1NotBornBeforeStart4thQuarter = false; public bool child2NotBornBeforeStart4thQuarter = false;
        public bool child3NotBornBeforeStart4thQuarter = false; public bool child4NotBornBeforeStart4thQuarter = false;
        public bool child5NotBornBeforeStart4thQuarter = false; public bool child6NotBornBeforeStart4thQuarter = false;
        public bool child7NotBornBeforeStart4thQuarter = false; public bool child8NotBornBeforeStart4thQuarter = false;
        public bool child9NotBornBeforeStart4thQuarter = false; public bool child10NotBornBeforeStart4thQuarter = false;

        // Method for checking correctness of user input dates
        public bool birthdayAssigned = false;

        private void CheckAndAssignBirthdate(string input)
        {
            if (correctEntry == true)
            {
                string[] formats = { "d-MM-yyyy", "d-M-yyyy", "dd-MM-yyyy", "dd-MM-yyyy" };

                // Check date format
                var isValidFormat = DateTime.TryParseExact(input, formats, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime birthdate);

                if (isValidFormat)
                {
                    string.Format("{0:dd-MM-yyyy}", birthdate);

                    DateTime zT = zeroTime; // 'zT' is an abbreviation of 'zeroTime', for which 'DateTime.MinValue' is used

                    DateTime start4thQuarter = startOfSelectedCalendarYear.AddMonths(9);

                    birthdayAssigned = false;

                    // This way child allowance benefit is received for the first time, the first quarter after the quarter in which a new child is born.
                    if (birthdate <= start4thQuarter)
                    {
                        if (birthdayAssigned == false && birthdate_child1 == zT) { birthdate_child1 = birthdate; birthdayAssigned = true; }
                        if (birthdayAssigned == false && birthdate_child1 != zT && birthdate_child2 == zT) { birthdate_child2 = birthdate; birthdayAssigned = true; }
                        if (birthdayAssigned == false && birthdate_child2 != zT && birthdate_child3 == zT) { birthdate_child3 = birthdate; birthdayAssigned = true; }
                        if (birthdayAssigned == false && birthdate_child3 != zT && birthdate_child4 == zT) { birthdate_child4 = birthdate; birthdayAssigned = true; }
                        if (birthdayAssigned == false && birthdate_child4 != zT && birthdate_child5 == zT) { birthdate_child5 = birthdate; birthdayAssigned = true; }
                        if (birthdayAssigned == false && birthdate_child5 != zT && birthdate_child6 == zT) { birthdate_child6 = birthdate; birthdayAssigned = true; }
                        if (birthdayAssigned == false && birthdate_child6 != zT && birthdate_child7 == zT) { birthdate_child7 = birthdate; birthdayAssigned = true; }
                        if (birthdayAssigned == false && birthdate_child7 != zT && birthdate_child8 == zT) { birthdate_child8 = birthdate; birthdayAssigned = true; }
                        if (birthdayAssigned == false && birthdate_child8 != zT && birthdate_child9 == zT) { birthdate_child9 = birthdate; birthdayAssigned = true; }
                        if (birthdayAssigned == false && birthdate_child9 != zT && birthdate_child10 == zT) { birthdate_child10 = birthdate; birthdayAssigned = true; }
                    }
                    else if (birthdate > start4thQuarter)
                    {
                        if (birthdate_child1 == zT)
                        {
                            MessageBox.Show("De geboortedatum van kind 1 ligt na de begindatum van het vierde kwartaal. " +
                                "Er kan dit jaar geen kinderbijslag ontvangen worden voor dit kind.");
                            child1NotBornBeforeStart4thQuarter = true;
                        }

                        if (birthdate_child1 != zT && birthdate_child2 == zT)
                        {
                            MessageBox.Show("De geboortedatum van kind 2 ligt na de begindatum van het vierde kwartaal. " +
                                "Er kan dit jaar geen kinderbijslag ontvangen worden voor dit kind.");
                            child2NotBornBeforeStart4thQuarter = true;
                        }

                        if (birthdate_child2 != zT && birthdate_child3 == zT)
                        {
                            MessageBox.Show("De geboortedatum van kind 3 ligt na de begindatum van het vierde kwartaal. " +
                                "Er kan dit jaar geen kinderbijslag ontvangen worden voor dit kind.");
                            child3NotBornBeforeStart4thQuarter = true;
                        }

                        if (birthdate_child3 != zT && birthdate_child4 == zT)
                        {
                            MessageBox.Show("De geboortedatum van kind 4 ligt na de begindatum van het vierde kwartaal. " +
                                "Er kan dit jaar geen kinderbijslag ontvangen worden voor dit kind.");
                            child4NotBornBeforeStart4thQuarter = true;
                        }

                        if (birthdate_child4 != zT && birthdate_child5 == zT)
                        {
                            MessageBox.Show("De geboortedatum van kind 5 ligt na de begindatum van het vierde kwartaal. " +
                                "Er kan dit jaar geen kinderbijslag ontvangen worden voor dit kind.");
                            child5NotBornBeforeStart4thQuarter = true;
                        }

                        if (birthdate_child5 != zT && birthdate_child6 == zT)
                        {
                            MessageBox.Show("De geboortedatum van kind 6 ligt na de begindatum van het vierde kwartaal. " +
                                "Er kan dit jaar geen kinderbijslag ontvangen worden voor dit kind.");
                            child6NotBornBeforeStart4thQuarter = true;
                        }

                        if (birthdate_child6 != zT && birthdate_child7 == zT)
                        {
                            MessageBox.Show("De geboortedatum van kind 7 ligt na de begindatum van het vierde kwartaal. " +
                                "Er kan dit jaar geen kinderbijslag ontvangen worden voor dit kind.");
                            child7NotBornBeforeStart4thQuarter = true;
                        }

                        if (birthdate_child7 != zT && birthdate_child8 == zT)
                        {
                            MessageBox.Show("De geboortedatum van kind 8 ligt na de begindatum van het vierde kwartaal. " +
                                "Er kan dit jaar geen kinderbijslag ontvangen worden voor dit kind.");
                            child8NotBornBeforeStart4thQuarter = true;
                        }

                        if (birthdate_child8 != zT && birthdate_child9 == zT)
                        {
                            MessageBox.Show("De geboortedatum van kind 9 ligt na de begindatum van het vierde kwartaal. " +
                                "Er kan dit jaar geen kinderbijslag ontvangen worden voor dit kind.");
                            child9NotBornBeforeStart4thQuarter = true;
                        }

                        if (birthdate_child9 != zT && birthdate_child10 == zT)
                        {
                            MessageBox.Show("De geboortedatum van kind 10 ligt na de begindatum van het vierde kwartaal. " +
                                "Er kan dit jaar geen kinderbijslag ontvangen worden voor dit kind.");
                            child10NotBornBeforeStart4thQuarter = true;
                        }
                    }
                }
                else     // If (!isValidFormat)
                {
                    if (correctEntry == true && input == textBox_birthdateChild01.Text && input != "")
                    { MessageBox.Show("Ongeldige invoer geboortedatum kind 1. Voer de datum in volgens het format \"dd-MM-jjjj\"."); correctEntry = false; }

                    if (correctEntry == true && input == textBox_birthdateChild02.Text && input != "")
                    { MessageBox.Show("Ongeldige invoer geboortedatum kind 2. Voer de datum in volgens de methode \"dd-MM-jjjj\"."); correctEntry = false; }

                    if (correctEntry == true && input == textBox_birthdateChild03.Text && input != "")
                    { MessageBox.Show("Ongeldige invoer geboortedatum kind 3. Voer de datum in volgens de methode \"dd-MM-jjjj\"."); correctEntry = false; }

                    if (correctEntry == true && input == textBox_birthdateChild04.Text && input != "")
                    { MessageBox.Show("Ongeldige invoer geboortedatum kind 4. Voer de datum in volgens de methode \"dd-MM-jjjj\"."); correctEntry = false; }

                    if (correctEntry == true && input == textBox_birthdateChild05.Text && input != "")
                    { MessageBox.Show("Ongeldige invoer geboortedatum kind 5. Voer de datum in volgens de methode \"dd-MM-jjjj\"."); correctEntry = false; }

                    if (correctEntry == true && input == textBox_birthdateChild06.Text && input != "")
                    { MessageBox.Show("Ongeldige invoer geboortedatum kind 6. Voer de datum in volgens de methode \"dd-MM-jjjj\"."); correctEntry = false; }

                    if (correctEntry == true && input == textBox_birthdateChild07.Text && input != "")
                    { MessageBox.Show("Ongeldige invoer geboortedatum kind 7. Voer de datum in volgens de methode \"dd-MM-jjjj\"."); correctEntry = false; }

                    if (correctEntry == true && input == textBox_birthdateChild08.Text && input != "")
                    { MessageBox.Show("Ongeldige invoer geboortedatum kind 8. Voer de datum in volgens de methode \"dd-MM-jjjj\"."); correctEntry = false; }

                    if (correctEntry == true && input == textBox_birthdateChild09.Text && input != "")
                    { MessageBox.Show("Ongeldige invoer geboortedatum kind 9. Voer de datum in volgens de methode \"dd-MM-jjjj\"."); correctEntry = false; }

                    if (correctEntry == true && input == textBox_birthdateChild10.Text && input != "")
                    { MessageBox.Show("Ongeldige invoer geboortedatum kind 10. Voer de datum in volgens de methode \"dd-MM-jjjj\"."); correctEntry = false; }
                }
            }
        }


        // CHECK AND ASSIGN AGES FOR QUARTER

        // Booleans to check if age of children is above 18 years
        public bool child1_Above18 = false; public bool child2_Above18 = false;
        public bool child3_Above18 = false; public bool child4_Above18 = false;
        public bool child5_Above18 = false; public bool child6_Above18 = false;
        public bool child7_Above18 = false; public bool child8_Above18 = false;
        public bool child9_Above18 = false; public bool child10_Above18 = false;

        private void CheckAndAssignAgesForQuarter(int quarter)
        {
            DateTime startOfQuarter = zeroTime;
            int startMonthQuarter = 0;

            // Determine and assign quarter of the year to be checked
            if (quarter == 1) { startMonthQuarter = 0; }
            if (quarter == 2) { startMonthQuarter = 3; }
            if (quarter == 3) { startMonthQuarter = 6; }
            if (quarter == 4) { startMonthQuarter = 9; }

            startOfQuarter = startOfSelectedCalendarYear.AddMonths(startMonthQuarter);

            // Assign and check ages
            if (correctEntry == true && numOfChildren >= 1 && birthdate_child1 <= startOfQuarter && child1NotBornBeforeStart4thQuarter == false)
            {
                age_child1 = startOfQuarter.Year - birthdate_child1.Year;
                if (startOfQuarter.DayOfYear < birthdate_child1.DayOfYear) { age_child1 -= 1; }
                if (age_child1 >= 18 && age_child1 < 19 && child1_Above18 == false)
                {
                    MessageBox.Show($"De ingevoerde leeftijd van kind 1 ligt vanaf kwartaal {quarter} in {startOfQuarter.Year} boven de 18 jaar. " +
                        $"Vanaf dit kwartaal bestaat geen recht op kinderbijslag voor dit kind.");
                    child1_Above18 = true;
                }
                if (age_child1 >= 19 && child1_Above18 == false)
                { MessageBox.Show("De ingevoerde leeftijd bij kind 1 komt niet in aanmerking voor kinderbijstand."); child1_Above18 = true; }
            }

            if (correctEntry == true && numOfChildren >= 2 && birthdate_child2 <= startOfQuarter && child2NotBornBeforeStart4thQuarter == false)
            {
                age_child2 = startOfQuarter.Year - birthdate_child2.Year;
                if (startOfQuarter.DayOfYear < birthdate_child2.DayOfYear) { age_child2 -= 1; }
                if (age_child2 > 18 && age_child2 < 19 && child2_Above18 == false)
                {
                    MessageBox.Show($"De ingevoerde leeftijd van kind 2 ligt vanaf kwartaal {quarter} in {startOfQuarter.Year} boven de 18 jaar. " +
                        $"Vanaf dit kwartaal bestaat geen recht op kinderbijslag voor dit kind.");
                    child2_Above18 = true;
                }
                if (age_child2 >= 19 && child2_Above18 == false)
                { MessageBox.Show("De ingevoerde leeftijd bij kind 2 komt niet in aanmerking voor kinderbijstand."); child2_Above18 = true; }
            }

            if (correctEntry == true && numOfChildren >= 3 && birthdate_child3 <= startOfQuarter && child3NotBornBeforeStart4thQuarter == false)
            {
                age_child3 = startOfQuarter.Year - birthdate_child3.Year;
                if (startOfQuarter.DayOfYear < birthdate_child3.DayOfYear) { age_child3 -= 1; };
                if (age_child3 > 18 && age_child3 < 19 && child3_Above18 == false)
                {
                    MessageBox.Show($"De ingevoerde leeftijd van kind 3 ligt vanaf kwartaal {quarter} in {startOfQuarter.Year} boven de 18 jaar. " +
                        $"Vanaf dit kwartaal bestaat geen recht op kinderbijslag voor dit kind.");
                    child3_Above18 = true;
                }
                if (age_child3 >= 19 && child3_Above18 == false)
                { MessageBox.Show("De ingevoerde leeftijd bij kind 3 komt niet in aanmerking voor kinderbijstand."); child3_Above18 = true; }
            }

            if (correctEntry == true && numOfChildren >= 4 && birthdate_child4 <= startOfQuarter && child4NotBornBeforeStart4thQuarter == false)
            {
                age_child4 = startOfQuarter.Year - birthdate_child4.Year;
                if (startOfQuarter.DayOfYear < birthdate_child4.DayOfYear) { age_child4 -= 1; };
                if (age_child4 > 18 && age_child4 < 19 && child4_Above18 == false)
                {
                    MessageBox.Show($"De ingevoerde leeftijd van kind 4 ligt vanaf kwartaal {quarter} in {startOfQuarter.Year} boven de 18 jaar. " +
                        $"Vanaf dit kwartaal bestaat geen recht op kinderbijslag voor dit kind.");
                    child4_Above18 = true;
                }
                if (age_child4 >= 19 && child4_Above18 == false)
                { MessageBox.Show("De ingevoerde leeftijd bij kind 4 komt niet in aanmerking voor kinderbijstand."); child4_Above18 = true; }
            }

            if (correctEntry == true && numOfChildren >= 5 && birthdate_child5 <= startOfQuarter && child5NotBornBeforeStart4thQuarter == false)
            {
                age_child5 = startOfQuarter.Year - birthdate_child5.Year;
                if (startOfQuarter.DayOfYear < birthdate_child5.DayOfYear) { age_child5 -= 1; };
                if (age_child5 > 18 && age_child5 < 19 && child5_Above18 == false)
                {
                    MessageBox.Show($"De ingevoerde leeftijd van kind 5 ligt vanaf kwartaal {quarter} in {startOfQuarter.Year} boven de 18 jaar. " +
                        $"Vanaf dit kwartaal bestaat geen recht op kinderbijslag voor dit kind.");
                    child5_Above18 = true;
                }
                if (age_child5 >= 19 && child5_Above18 == false)
                { MessageBox.Show("De ingevoerde leeftijd bij kind 5 komt niet in aanmerking voor kinderbijstand."); child5_Above18 = true; }
            }

            if (correctEntry == true && numOfChildren >= 6 && birthdate_child6 <= startOfQuarter && child6NotBornBeforeStart4thQuarter == false)
            {
                age_child6 = startOfQuarter.Year - birthdate_child6.Year;
                if (startOfQuarter.DayOfYear < birthdate_child6.DayOfYear) { age_child6 -= 1; };
                if (age_child6 > 18 && age_child6 < 19 && child6_Above18 == false)
                {
                    MessageBox.Show($"De ingevoerde leeftijd van kind 6 ligt vanaf kwartaal {quarter} in {startOfQuarter.Year} boven de 18 jaar. " +
                        $"Vanaf dit kwartaal bestaat geen recht op kinderbijslag voor dit kind.");
                    child6_Above18 = true;
                }
                if (age_child6 >= 19 && child6_Above18 == false)
                { MessageBox.Show("De ingevoerde leeftijd bij kind 6 komt niet in aanmerking voor kinderbijstand."); child6_Above18 = true; }
            }

            if (correctEntry == true && numOfChildren >= 7 && birthdate_child7 <= startOfQuarter && child7NotBornBeforeStart4thQuarter == false)
            {
                age_child7 = startOfQuarter.Year - birthdate_child7.Year;
                if (startOfQuarter.DayOfYear < birthdate_child7.DayOfYear) { age_child7 -= 1; };
                if (age_child7 > 18 && age_child7 < 19 && child7_Above18 == false)
                {
                    MessageBox.Show($"De ingevoerde leeftijd van kind 7 ligt vanaf kwartaal {quarter} in {startOfQuarter.Year} boven de 18 jaar. " +
                        $"Vanaf dit kwartaal bestaat geen recht op kinderbijslag voor dit kind.");
                    child7_Above18 = true;
                }
                if (age_child7 >= 19 && child7_Above18 == false)
                { MessageBox.Show("De ingevoerde leeftijd bij kind 7 komt niet in aanmerking voor kinderbijstand."); child7_Above18 = true; }
            }

            if (correctEntry == true && numOfChildren >= 8 && birthdate_child8 <= startOfQuarter && child8NotBornBeforeStart4thQuarter == false)
            {
                age_child8 = startOfQuarter.Year - birthdate_child8.Year;
                if (startOfQuarter.DayOfYear < birthdate_child8.DayOfYear) { age_child8 -= 1; };
                if (age_child8 > 18 && age_child8 < 19 && child8_Above18 == false)
                {
                    MessageBox.Show($"De ingevoerde leeftijd van kind 8 ligt vanaf kwartaal {quarter} in {startOfQuarter.Year} boven de 18 jaar. " +
                        $"Vanaf dit kwartaal bestaat geen recht op kinderbijslag voor dit kind.");
                    child8_Above18 = true;
                }
                if (age_child8 >= 19 && child8_Above18 == false)
                { MessageBox.Show("De ingevoerde leeftijd bij kind 8 komt niet in aanmerking voor kinderbijstand."); child8_Above18 = true; }
            }

            if (correctEntry == true && numOfChildren >= 9 && birthdate_child9 <= startOfQuarter && child9NotBornBeforeStart4thQuarter == false)
            {
                age_child9 = startOfQuarter.Year - birthdate_child9.Year;
                if (startOfQuarter.DayOfYear < birthdate_child9.DayOfYear) { age_child9 -= 1; };
                if (age_child9 > 18 && age_child9 < 19 && child9_Above18 == false)
                {
                    MessageBox.Show($"De ingevoerde leeftijd van kind 9 ligt vanaf kwartaal {quarter} in {startOfQuarter.Year} boven de 18 jaar. " +
                        $"Vanaf dit kwartaal bestaat geen recht op kinderbijslag voor dit kind.");
                    child9_Above18 = true;
                }
                if (age_child9 >= 19 && child9_Above18 == false)
                { MessageBox.Show("De ingevoerde leeftijd bij kind 9 komt niet in aanmerking voor kinderbijstand."); child9_Above18 = true; }
            }

            if (correctEntry == true && numOfChildren == 10 && birthdate_child10 <= startOfQuarter && child10NotBornBeforeStart4thQuarter == false)
            {
                age_child10 = startOfQuarter.Year - birthdate_child10.Year;
                if (startOfQuarter.DayOfYear < birthdate_child10.DayOfYear) { age_child10 -= 1; };
                if (age_child10 > 18 && age_child10 < 19 && child10_Above18 == false)
                {
                    MessageBox.Show($"De ingevoerde leeftijd van kind 10 ligt vanaf kwartaal {quarter} in {startOfQuarter.Year} boven de 18 jaar. " +
                        $"Vanaf dit kwartaal bestaat geen recht op kinderbijslag voor dit kind.");
                    child10_Above18 = true;
                }
                if (age_child10 >= 19 && child10_Above18 == false)
                { MessageBox.Show("De ingevoerde leeftijd bij kind 10 komt niet in aanmerking voor kinderbijstand."); child10_Above18 = true; }
            }
        }


        // SET LABELS TO SHOW CHILD ALLOWANCE BENEFIT

        // Set margin 'childAllowanceLabels'
        private void SetMarginLabelsChildAllowance(int marginBase, int marginChangeAtStart, int marginChangeAtSelectionNumOfChildren,
                                                   int marginChangeAfterSelectionNumOfChildren, int numOfChildren, int marginChangePerExtraChildSelected)
        {
            childAllowanceLabels = new List<Control>()
            {
                label_ChildAllowanceToBeReceivedInYearX,
                label_1stQuarter, label_allowanceInEuros1stQuarter,
                label_2ndQuarter, label_allowanceInEuros2ndQuarter,
                label_3rdQuarter, label_allowanceInEuros3rdQuarter,
                label_4thQuarter, label_allowanceInEuros4thQuarter,
                label_yearTotalChildAllowance, label_allowanceInEurosYearTotal,
            };

            // margin difference used between design view and screenview
            int marginDifference = 30;

            foreach (Control control in childAllowanceLabels)
            {
                if (control == label_ChildAllowanceToBeReceivedInYearX) { marginBase = 562 - marginDifference; }
                if (control == label_1stQuarter || control == label_allowanceInEuros1stQuarter) { marginBase = 592 - marginDifference; }
                if (control == label_2ndQuarter || control == label_allowanceInEuros2ndQuarter) { marginBase = 617 - marginDifference; }
                if (control == label_3rdQuarter || control == label_allowanceInEuros3rdQuarter) { marginBase = 642 - marginDifference; }
                if (control == label_4thQuarter || control == label_allowanceInEuros4thQuarter) { marginBase = 667 - marginDifference; }
                if (control == label_yearTotalChildAllowance || control == label_allowanceInEurosYearTotal) { marginBase = 697 - marginDifference; }

                Thickness margin = control.Margin;
                margin.Top = marginBase + marginChangeAtStart + marginChangeAtSelectionNumOfChildren + marginChangeAfterSelectionNumOfChildren
                             + ((numOfChildren - 1) * marginChangePerExtraChildSelected);
                control.Margin = margin;
            }
        }

        // SHOW LABELS FOR CHILD ALLOWANCE TO BE RECEIVED
        private void ShowLabelsChildAllowanceToBeReceived()
        {
            childAllowanceLabels = new List<Control>()
            {
                label_ChildAllowanceToBeReceivedInYearX,
                label_1stQuarter, label_allowanceInEuros1stQuarter,
                label_2ndQuarter, label_allowanceInEuros2ndQuarter,
                label_3rdQuarter, label_allowanceInEuros3rdQuarter,
                label_4thQuarter, label_allowanceInEuros4thQuarter,
                label_yearTotalChildAllowance, label_allowanceInEurosYearTotal,
                label_newCalculationButton // extra addition, to give users the possibility to start a new calculation
            };

            foreach (Control control in childAllowanceLabels)
            {
                control.Visibility = Visibility.Visible;
            }

            // Adapt content of label 'ChildAllowanceToBeReceivedInYearX' to situation
            label_ChildAllowanceToBeReceivedInYearX.Content =
                $"Te ontvangen kinderbijslag in {startOfSelectedCalendarYear.Year}:";
        }

        // HIDE CALCULATE BUTTON
        private void HideCalculateButton()
        {
            label_calculateButton.Visibility = Visibility.Hidden;
            label_explanationCalculateButton.Visibility = Visibility.Hidden;
        }


        // CALCULATE CHILD ALLOWANCE BENEFIT

        // Child allowance amounts in Euro per quarter
        public double childAllowance1stQuarter = 0;
        public double childAllowance2ndQuarter = 0;
        public double childAllowance3rdQuarter = 0;
        public double childAllowance4thQuarter = 0;
        public double childAllowanceYearTotal = 0;

        // Calculate child allowance per quarter
        private void CalculateChildAllowanceForQuarter(int quarter)
        {
            double childAllowanceUnder12 = 150.00;
            double childAllowanceAbove12 = 235.00;

            double storageRate3Or4Children = 1.02;
            double storageRate5Children = 1.03;
            double storageRate6OrMoreChildren = 1.035;

            // Add children's ages to a list with ages
            List<int> ages = new List<int>();

            if (numOfChildren == 1)
            { ages.Add(age_child1); }

            if (numOfChildren == 2)
            { ages.Add(age_child1); ages.Add(age_child2); }

            if (numOfChildren == 3)
            { ages.Add(age_child1); ages.Add(age_child2); ages.Add(age_child3); }

            if (numOfChildren == 4)
            { ages.Add(age_child1); ages.Add(age_child2); ages.Add(age_child3); ages.Add(age_child4); }

            if (numOfChildren == 5)
            { ages.Add(age_child1); ages.Add(age_child2); ages.Add(age_child3); ages.Add(age_child4); ages.Add(age_child5); }

            if (numOfChildren == 6)
            {
                ages.Add(age_child1); ages.Add(age_child2); ages.Add(age_child3); ages.Add(age_child4); ages.Add(age_child5);
                ages.Add(age_child6);
            }

            if (numOfChildren == 7)
            {
                ages.Add(age_child1); ages.Add(age_child2); ages.Add(age_child3); ages.Add(age_child4); ages.Add(age_child5);
                ages.Add(age_child6); ages.Add(age_child7);
            }

            if (numOfChildren == 8)
            {
                ages.Add(age_child1); ages.Add(age_child2); ages.Add(age_child3); ages.Add(age_child4); ages.Add(age_child5);
                ages.Add(age_child6); ages.Add(age_child7); ages.Add(age_child8);
            }

            if (numOfChildren == 9)
            {
                ages.Add(age_child1); ages.Add(age_child2); ages.Add(age_child3); ages.Add(age_child4); ages.Add(age_child5);
                ages.Add(age_child6); ages.Add(age_child7); ages.Add(age_child8); ages.Add(age_child9);
            }

            if (numOfChildren == 10)
            {
                ages.Add(age_child1); ages.Add(age_child2); ages.Add(age_child3); ages.Add(age_child4); ages.Add(age_child5);
                ages.Add(age_child6); ages.Add(age_child7); ages.Add(age_child8); ages.Add(age_child9); ages.Add(age_child10);
            }

            // Calculate number of children under and above the age of 12
            int numOfChildrenUnder12 = 0;
            int numOfChildrenAbove12 = 0;

            foreach (int age in ages)
            {
                if (age >= 0 && age < 12) { numOfChildrenUnder12 = numOfChildrenUnder12 + 1; }
                if (age >= 12 && age < 18) { numOfChildrenAbove12 = numOfChildrenAbove12 + 1; }
            }

            // Calculate the child allowance for children under and above the age of 12
            double childAllowanceChildrenUnder12 = numOfChildrenUnder12 * childAllowanceUnder12;
            double childAllowanceChildrenAbove12 = numOfChildrenAbove12 * childAllowanceAbove12;

            // Total child allowance (before storage rates)
            double childAllowanceTotal = childAllowanceChildrenUnder12 + childAllowanceChildrenAbove12;

            // Storage rates for parents with more than two children
            if (numOfChildrenUnder12 + numOfChildrenAbove12 == 3 || numOfChildrenUnder12 + numOfChildrenAbove12 == 4) { childAllowanceTotal *= storageRate3Or4Children; }
            if (numOfChildrenUnder12 + numOfChildrenAbove12 == 5) { childAllowanceTotal *= storageRate5Children; }
            if (numOfChildrenUnder12 + numOfChildrenAbove12 >= 6) { childAllowanceTotal *= storageRate6OrMoreChildren; }

            // Child allowance quarter X is...
            if (quarter == 1) { childAllowance1stQuarter = childAllowanceTotal; }
            if (quarter == 2) { childAllowance2ndQuarter = childAllowanceTotal; }
            if (quarter == 3) { childAllowance3rdQuarter = childAllowanceTotal; }
            if (quarter == 4) { childAllowance4thQuarter = childAllowanceTotal; }
        }

        // PRINT TO SCREE CALCULATIONS IN EURO'S
        private void PrintToScreenChildAllowance()
        {
            label_allowanceInEuros1stQuarter.Content = childAllowance1stQuarter.ToString("C", CultureInfo.GetCultureInfo("nl-NL"));
            label_allowanceInEuros2ndQuarter.Content = childAllowance2ndQuarter.ToString("C", CultureInfo.GetCultureInfo("nl-NL"));
            label_allowanceInEuros3rdQuarter.Content = childAllowance3rdQuarter.ToString("C", CultureInfo.GetCultureInfo("nl-NL"));
            label_allowanceInEuros4thQuarter.Content = childAllowance4thQuarter.ToString("C", CultureInfo.GetCultureInfo("nl-NL"));
            label_allowanceInEurosYearTotal.Content = childAllowanceYearTotal.ToString("C", CultureInfo.GetCultureInfo("nl-NL"));
        }

        // CHECK REQUIRED FIELDS
        // Check if there are no required fields left empty
        public bool requiredFieldsAreFilled = false;

        private void CheckRequiredFields()
        {
            if (numOfChildren == 1 && textBox_birthdateChild01.Text != "" && textBox_birthdateChild01.Text.Length >= 7
               || numOfChildren == 2 && textBox_birthdateChild01.Text != "" && textBox_birthdateChild02.Text != "" && textBox_birthdateChild02.Text.Length >= 7
               || numOfChildren == 3 && textBox_birthdateChild01.Text != "" && textBox_birthdateChild02.Text != "" && textBox_birthdateChild03.Text != "" 
               && textBox_birthdateChild03.Text.Length >= 7
               || numOfChildren == 4 && textBox_birthdateChild01.Text != "" && textBox_birthdateChild02.Text != "" && textBox_birthdateChild03.Text != ""
               && textBox_birthdateChild04.Text != "" && textBox_birthdateChild04.Text.Length >= 7
               || numOfChildren == 5 && textBox_birthdateChild01.Text != "" && textBox_birthdateChild02.Text != "" && textBox_birthdateChild03.Text != ""
               && textBox_birthdateChild04.Text != "" && textBox_birthdateChild05.Text != "" && textBox_birthdateChild05.Text.Length >= 7
               || numOfChildren == 6 && textBox_birthdateChild01.Text != "" && textBox_birthdateChild02.Text != "" && textBox_birthdateChild03.Text != ""
               && textBox_birthdateChild04.Text != "" && textBox_birthdateChild05.Text != "" && textBox_birthdateChild06.Text != "" && textBox_birthdateChild06.Text.Length >= 7
               || numOfChildren == 7 && textBox_birthdateChild01.Text != "" && textBox_birthdateChild02.Text != "" && textBox_birthdateChild03.Text != ""
               && textBox_birthdateChild04.Text != "" && textBox_birthdateChild05.Text != "" && textBox_birthdateChild06.Text != "" && textBox_birthdateChild07.Text != "" 
               && textBox_birthdateChild07.Text.Length >= 7
               || numOfChildren == 8 && textBox_birthdateChild01.Text != "" && textBox_birthdateChild02.Text != "" && textBox_birthdateChild03.Text != ""
               && textBox_birthdateChild04.Text != "" && textBox_birthdateChild05.Text != "" && textBox_birthdateChild06.Text != "" && textBox_birthdateChild07.Text != ""
               && textBox_birthdateChild08.Text != "" && textBox_birthdateChild08.Text.Length >= 7
               || numOfChildren == 9 && textBox_birthdateChild01.Text != "" && textBox_birthdateChild02.Text != "" && textBox_birthdateChild03.Text != ""
               && textBox_birthdateChild04.Text != "" && textBox_birthdateChild05.Text != "" && textBox_birthdateChild06.Text != "" && textBox_birthdateChild07.Text != ""
               && textBox_birthdateChild08.Text != "" && textBox_birthdateChild09.Text != "" && textBox_birthdateChild09.Text.Length >= 7
               || numOfChildren == 10 && textBox_birthdateChild01.Text != "" && textBox_birthdateChild02.Text != "" && textBox_birthdateChild03.Text != ""
               && textBox_birthdateChild04.Text != "" && textBox_birthdateChild05.Text != "" && textBox_birthdateChild06.Text != "" && textBox_birthdateChild07.Text != ""
               && textBox_birthdateChild08.Text != "" && textBox_birthdateChild09.Text != "" && textBox_birthdateChild10.Text != "" && textBox_birthdateChild10.Text.Length >= 7)
            {
                requiredFieldsAreFilled = true;
                label_calculateButton.Background = new SolidColorBrush(Colors.Salmon);
                label_calculateButton.Foreground = new SolidColorBrush(Colors.White);
            }
            else
            {
                requiredFieldsAreFilled = false;
                label_calculateButton.Background = new SolidColorBrush(Colors.Gainsboro);
                label_calculateButton.Foreground = new SolidColorBrush(Colors.DimGray);
            }
        }

        // CHECK AND ASSIGN BIRTHDATES
        private void CheckAndAssignBirthdates(int numOfChildren)
        {
            if (numOfChildren >= 1) { CheckAndAssignBirthdate(textBox_birthdateChild01.Text); }
            if (numOfChildren >= 2) { CheckAndAssignBirthdate(textBox_birthdateChild02.Text); }
            if (numOfChildren >= 3) { CheckAndAssignBirthdate(textBox_birthdateChild03.Text); }
            if (numOfChildren >= 4) { CheckAndAssignBirthdate(textBox_birthdateChild04.Text); }
            if (numOfChildren >= 5) { CheckAndAssignBirthdate(textBox_birthdateChild05.Text); }
            if (numOfChildren >= 6) { CheckAndAssignBirthdate(textBox_birthdateChild06.Text); }
            if (numOfChildren >= 7) { CheckAndAssignBirthdate(textBox_birthdateChild07.Text); }
            if (numOfChildren >= 8) { CheckAndAssignBirthdate(textBox_birthdateChild08.Text); }
            if (numOfChildren >= 9) { CheckAndAssignBirthdate(textBox_birthdateChild09.Text); }
            if (numOfChildren == 10) { CheckAndAssignBirthdate(textBox_birthdateChild10.Text); }
        }

        // CALCULATE BUTTON
        public bool calculateButtonIsClicked = false;

        private void Label_calculateButton_MouseDown(object sender, MouseButtonEventArgs e)
        {
            // Check if there are no required fields left empty...
            CheckRequiredFields();

            if (requiredFieldsAreFilled == true)
            {
                // Preset
                correctEntry = true;

                // FIRST: Check and assign birthdates
                CheckAndAssignBirthdates(numOfChildren);

                // SECOND: Assign and check ages for every quarter and calculate child allowance
                // 1st quarter
                if (correctEntry == true)
                {
                    CheckAndAssignAgesForQuarter(1); CalculateChildAllowanceForQuarter(1);

                    // 2nd quarter
                    if (correctEntry == true)
                    {
                        CheckAndAssignAgesForQuarter(2); CalculateChildAllowanceForQuarter(2);

                        // 3rd quarter
                        if (correctEntry == true)
                        {
                            CheckAndAssignAgesForQuarter(3); CalculateChildAllowanceForQuarter(3);

                            // 4th quarter
                            if (correctEntry == true)
                            {
                                CheckAndAssignAgesForQuarter(4); CalculateChildAllowanceForQuarter(4);
                            }
                        }
                    }
                }

                // THIRD: Calculate year total
                if (correctEntry == true)
                { childAllowanceYearTotal = childAllowance1stQuarter + childAllowance2ndQuarter + childAllowance3rdQuarter + childAllowance4thQuarter; }

                // FOURTH: print to screen
                if (correctEntry == true)
                {
                    HideCalculateButton();
                    SetMarginLabelsChildAllowance(marginBase, marginChangeAtStart, marginChangeAtSelectionNumOfChildren,
                                                  marginChangeAfterSelectionNumOfChildren, numOfChildren, marginChangePerExtraChildSelected);
                    ShowLabelsChildAllowanceToBeReceived();
                    PrintToScreenChildAllowance();
                }

                // FIFTH: Set button bool to true
                calculateButtonIsClicked = true;
            }
            else
            {
                // Ignore, because the user is required to fill in all required fields 
                // before the calculate button works.
            }
        }

        // RESTART APPLICAATION WITH NEW CALCULATION BUTTON
        private void RestartApplication()
        {
            System.Diagnostics.Process.Start(Application.ResourceAssembly.Location);
            Application.Current.Shutdown();
        }

        private void Label_newCalculationButton_MouseDown(object sender, MouseButtonEventArgs e)
        {
            RestartApplication();
        }

        // CHECK REQUIRED FIELDS FOR BUTTON ACTIVATION/COLOR CHANGE
        private void TextBox_birthdateChild01_TextChanged(object sender, TextChangedEventArgs e) { CheckRequiredFields(); }
        private void TextBox_birthdateChild02_TextChanged(object sender, TextChangedEventArgs e) { CheckRequiredFields(); }
        private void TextBox_birthdateChild03_TextChanged(object sender, TextChangedEventArgs e) { CheckRequiredFields(); }
        private void TextBox_birthdateChild04_TextChanged(object sender, TextChangedEventArgs e) { CheckRequiredFields(); }
        private void TextBox_birthdateChild05_TextChanged(object sender, TextChangedEventArgs e) { CheckRequiredFields(); }
        private void TextBox_birthdateChild06_TextChanged(object sender, TextChangedEventArgs e) { CheckRequiredFields(); }
        private void TextBox_birthdateChild07_TextChanged(object sender, TextChangedEventArgs e) { CheckRequiredFields(); }
        private void TextBox_birthdateChild08_TextChanged(object sender, TextChangedEventArgs e) { CheckRequiredFields(); }
        private void TextBox_birthdateChild09_TextChanged(object sender, TextChangedEventArgs e) { CheckRequiredFields(); }
        private void TextBox_birthdateChild10_TextChanged(object sender, TextChangedEventArgs e) { CheckRequiredFields(); }

        // CONTROLS NOT USED
        private void Button_calculate_Click(object sender, RoutedEventArgs e) { /* Not used */ }
        private void Button_newCalculation_Click(object sender, RoutedEventArgs e) { /* Not used */ }
    }
}

