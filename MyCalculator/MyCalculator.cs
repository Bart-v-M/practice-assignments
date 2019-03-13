using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

// Date: November/December 2018

namespace MyCalculator
{
    public partial class MyCalculator : Form
    {
        // DISPLAY VARIABLES
        public string onDisplay ;
        public char numberHit;
        public int displayLength;

        // CALCULATION VALUES
        public double value1;
        public string operation;
        public double value2;
        public double result;

        // RESET VALUES 
        public string displayReset = "";
        public string displayResetToZero = "0";
        public byte valueReset;
        public byte valueResetToZero = 0;
        public string operationReset = "";

        // LAST INPUT STATUS (keeps track of last input for the Clear function)
        public bool lastInputValue1;
        public bool lastInputOperation;
        public bool lastInputValue2;

        // PREVIOUS BUTTON STATUS (keeps track of button hit previously)
        // PB is abbreviation of 'PreviousButton'.
        public bool PB_Clear;
        public bool PB_Number;
        public bool PB_Operation;
        public bool P2B_Operation; // Operation Button hit (at least) two times consecutively.
        public bool PB_SquareOrRoot;
        public bool PB_Equals;
        public bool PB_plusMinusSwitch;

        // UPDATE DISPLAY METHOD
        public void UpdateDisplay(string onDisplay)
        {
            // Font size, dependent on number of display characters.
            displayLength = onDisplay.Length;
            if (displayLength < 17) { displayscreen.Font = new Font("Segoe UI", 20); }

            // Makes font smaller for larger display values.
            if (displayLength > 17) { displayscreen.Font = new Font("Segoe UI", 18); }
            if (displayLength > 20) { displayscreen.Font = new Font("Segoe UI", 16); }
            if (displayLength > 23) { displayscreen.Font = new Font("Segoe UI", 15); }
            if (displayLength > 26) { displayscreen.Font = new Font("Segoe UI", 14); }
            if (displayLength > 29) { displayscreen.Font = new Font("Segoe UI", 13); }
            if (displayLength > 32) { displayscreen.Font = new Font("Segoe UI", 12); }

            // Prints string onDisplay to displayscreen.
            displayscreen.Text = onDisplay;
        }

        // UPDATE EURO CURRENCY DISPLAY
        public void UpdateEuroDisplay(bool euroSign)
        {
            if (euroSign == true)
            {
                // Font size dependent on number of display characters.
                displayLength = onDisplay.Length;
                if (displayLength < 17) { displayEuro.Font = new Font("Segoe UI", 20); }

                // Makes font smaller for larger display values.
                if (displayLength > 17) { displayEuro.Font = new Font("Segoe UI", 18); }
                if (displayLength > 20) { displayEuro.Font = new Font("Segoe UI", 16); }
                if (displayLength > 23) { displayEuro.Font = new Font("Segoe UI", 15); }
                if (displayLength > 26) { displayEuro.Font = new Font("Segoe UI", 14); }
                if (displayLength > 29) { displayEuro.Font = new Font("Segoe UI", 13); }
                if (displayLength > 32) { displayEuro.Font = new Font("Segoe UI", 12); }

                // Prints Euro currency sign to eurodisplayscreen.
                displayEuro.Text = "€ ";
            }
            if (euroSign == false)
            {
                displayEuro.Text = "";
            }
        }

        // UPDATE DISPLAY AFTER NUMBER BUTTON IS HIT (adds a new number to the display)
        public void UpdateDisplayNumber(char numberHit)
        {
            // If button is hit when a result is shown on the display, all is cleared and 
            // a new calculation and a new number are started.
            if (displayShowsResult)
            {
                AllClear();
            }

            if (onDisplay == "0")
            {
                onDisplay = displayReset;
            }
            onDisplay += numberHit;
            UpdateDisplay(onDisplay);
        }

        // UPDATE BUTTON STATUS AFTER NUMBER BUTTON IS HIT
        public void UpdateButtonStatusAfterNumber()
        {
            PB_Clear = false; PB_Number = true; PB_Operation = false; P2B_Operation = false;
            PB_SquareOrRoot = false; PB_plusMinusSwitch = false; PB_Equals = false;
            divisionByZero = false;
            displayShowsResult = false;
        }

        // CLEAR MESSAGES METHOD
        public void ClearMessages()
        {
            if (onDisplay == "Cannot divide by zero"
                || divisionByZero == true
                || onDisplay == "Invalid input"
                || onDisplay == "∞"
                || onDisplay == "Cannot calculate √ from value in €"
                || onDisplay == "Cannot calculate 𝑥² from value in €")
            {
                AllClear();
            }
        }

        // DIVISION BY ZERO BOOL
        public bool divisionByZero = false;

        // OPERATIONS METHOD (plus, minus, multiply, divide)
        public void Operation(string onDisplay)
        {
            ClearMessages();

            // Replaces a possible comma in string for a dot, so conversion to a double with decimals becomes possible.  
            onDisplay = onDisplay.Replace(",", ".");

            // If no operation is determined yet, before hitting the operation button.
            if (operation == "" && PB_Clear == false)
            {
                value1 = Convert.ToDouble(onDisplay);
                DetermineLastInput();
            }

            // Calculates 'result' from 'operation' with 'value1' and 'value2'.
            // Guarantees calculation keeps going every time the operation button is hit.
            else if (operation != "" && P2B_Operation == false && equalsRepeatMethodNotRunBefore == true)
            {
                value2 = Convert.ToDouble(onDisplay);

                if (operation == "+") { result = value1 + value2; }
                if (operation == "-") { result = value1 - value2; }
                if (operation == "×") { result = value1 * value2; }
                if (operation == "÷" && value2 != 0) { result = value1 / value2; }

                onDisplay = result.ToString();             // For display value, conversion of double to string again.
                onDisplay = onDisplay.Replace(".", ",");   // Replaces a possible dot for a comma, after conversion to string.
                value1 = result;                           // Sets value1 to result.  
                UpdateDisplay(onDisplay);

                // Exception 1: divison by zero.
                if (operation == "÷" && value2 == 0)
                {
                    // Division by zero mathematically not possible.
                    onDisplay = "Cannot divide by zero";
                    UpdateDisplay(onDisplay);

                    // Resets values:
                    value1 = valueResetToZero;
                    operation = operationReset;
                    value2 = valueResetToZero;

                    divisionByZero = true;
                }

                DetermineLastInput();
            }

            else if (operation != "" && P2B_Operation == false && equalsRepeatMethodNotRunBefore == false)
            {
                value1 = Convert.ToDouble(onDisplay);
                DetermineLastInput();
                equalsRepeatMethodNotRunBefore = true;

                // Important commentary!
                // The condition with the 'EqualsRepeatMethodNotRunBefore' is used for error handling here.
                // Without it the calculator would not be able to switch back from EqualsRepeatMethod, which would result in
                // wrong calculations.
            }

            // Status update:
            PB_Clear = false; PB_Number = false; PB_Operation = true; P2B_Operation = false;
            PB_SquareOrRoot = false; PB_plusMinusSwitch = false; PB_Equals = false;
            displayShowsResult = false;
            
            // Exception 2: previous two buttons Operation Button (prevents null problem of display value).
            if (PB_Operation)
            {
                DetermineLastInput();

                // Status update:
                P2B_Operation = true;
                PB_Operation = false;
            }

            // Exception 3: previous button Clear (prevents value problem)
            if (PB_Clear == true)
            {
                // Ignore. See also addition in the first statement of this method: 
                // if (PB_Clear == false);
            }
        }

        // EQUALS METHOD
        private void Equals()
        {
            if (operation == "+") { result = value1 + value2; }
            if (operation == "-") { result = value1 - value2; }
            if (operation == "×") { result = value1 * value2; }
            if (operation == "÷" && value2 != 0) { result = value1 / value2; }

            onDisplay = result.ToString();             // For display value, conversion of double to string again.
            onDisplay = onDisplay.Replace(".", ",");   // Replaces a possible dot for a comma, after conversion to string.
            value1 = result;                           // Sets value1 to result.  
            UpdateDisplay(onDisplay);

            // Exception: divison by zero.
            if (operation == "÷" && value2 == 0 && equalsRepeatMethodNotRunBefore == true)
            {
                // Division by zero mathematically not possible.
                onDisplay = "Cannot divide by zero";
                UpdateDisplay(onDisplay);

                // Resets values:
                value1 = valueResetToZero;
                operation = operationReset;
                value2 = valueResetToZero;

                divisionByZero = true;
            }
        }

        // ALL CLEAR METHOD
        private void AllClear()
        {
            // Resets values.
            value1 = valueResetToZero;
            operation = operationReset;
            value2 = valueResetToZero;
            result = valueResetToZero;

            // Resets last input values and previous button status.
            lastInputValue1 = false; lastInputOperation = false; lastInputValue2 = false;
            PB_Clear = false; PB_Number = false; PB_Operation = false; P2B_Operation = false;
            PB_SquareOrRoot = false; PB_plusMinusSwitch = false; PB_Equals = false;
            displayShowsResult = false;
            divisionByZero = false;
            equalsRepeatMethodNotRunBefore = true;
            euroSign = false;
            euroSignSwitchedOffTemporarily = false;

            // Resets displays
            onDisplay = displayResetToZero;
            UpdateDisplay(onDisplay);
            UpdateEuroDisplay(euroSign);
        }

        // METHOD TO DETERMINE LAST INPUT FOR CLEAR FUNCTION (value1, operator or value2)
        public void DetermineLastInput()
        {
            if (PB_Number && operation == "" || PB_Equals || PB_SquareOrRoot && operation == "") // Code before: if (PB_Number && operation == "" || PB_Equals ) 
            {
                lastInputValue1 = true; lastInputOperation = false; lastInputValue2 = false;
            }
            else if (PB_Operation || P2B_Operation)
            {
                lastInputValue1 = false; lastInputOperation = true; lastInputValue2 = false;
            }
            else if (PB_Number && operation != "" || PB_SquareOrRoot && operation != "")     // Code before: else if (PB_Number && operation != "")
            {
                lastInputValue1 = false; lastInputOperation = false; lastInputValue2 = true;
            }
            else
            {
                lastInputValue1 = false; lastInputOperation = false; lastInputValue2 = false;
            }
        }

        // INITIALIZATION
        public MyCalculator()
        {
            InitializeComponent();
            AllClear();
        }

        // ALL CLEAR (AC) BUTTON
        private void AllClear_Click(object sender, EventArgs e)
        {
            AllClear();
        }

        // CLEAR (C) BUTTON (clears only last user input)
        private void Clear_Click(object sender, EventArgs e)
        {
            // Clear/reset of last input value of value or operation:
            if (lastInputValue1)
            {
                value1 = valueResetToZero;
                value2 = valueResetToZero;
                onDisplay = displayResetToZero;
                UpdateDisplay(onDisplay);
            }
            else if (lastInputOperation)
            {
                operation = operationReset;
            }
            else if (lastInputValue2)
            {
                value2 = valueResetToZero;
                onDisplay = displayResetToZero;
                UpdateDisplay(onDisplay);
            }

            // Status update:
            PB_Clear = true; PB_Number = false; PB_Operation = false; P2B_Operation = false;
            PB_SquareOrRoot = false; PB_plusMinusSwitch = false; PB_Equals = false;
            displayShowsResult = false;
            divisionByZero = false;
            equalsRepeatMethodNotRunBefore = true;
        }

        // NUMBER BUTTONS:

        // NUMBER 0
        private void Number0_Click(object sender, EventArgs e)
        { ClearMessages(); UpdateDisplayNumber('0'); UpdateButtonStatusAfterNumber(); DetermineLastInput(); }

        // NUMBER 1
        private void Number1_Click(object sender, EventArgs e)
        { ClearMessages(); UpdateDisplayNumber('1'); UpdateButtonStatusAfterNumber(); DetermineLastInput(); }

        // NUMBER 2
        private void Number2_Click(object sender, EventArgs e)
        { ClearMessages(); UpdateDisplayNumber('2'); UpdateButtonStatusAfterNumber(); DetermineLastInput(); }

        // NUMBER 3
        private void Number3_Click(object sender, EventArgs e)
        { ClearMessages(); UpdateDisplayNumber('3'); UpdateButtonStatusAfterNumber(); DetermineLastInput(); }

        // NUMBER 4
        private void Number4_Click(object sender, EventArgs e)
        { ClearMessages(); UpdateDisplayNumber('4'); UpdateButtonStatusAfterNumber(); DetermineLastInput(); }

        // NUMBER 5
        private void Number5_Click(object sender, EventArgs e)
        { ClearMessages(); UpdateDisplayNumber('5'); UpdateButtonStatusAfterNumber(); DetermineLastInput(); }

        // NUMBER 6
        private void Number6_Click(object sender, EventArgs e)
        { ClearMessages(); UpdateDisplayNumber('6'); UpdateButtonStatusAfterNumber(); DetermineLastInput(); }

        // NUMBER 7
        private void Number7_Click(object sender, EventArgs e)
        { ClearMessages(); UpdateDisplayNumber('7'); UpdateButtonStatusAfterNumber(); DetermineLastInput(); }

        // NUMBER 8
        private void Number8_Click(object sender, EventArgs e)
        { ClearMessages(); UpdateDisplayNumber('8'); UpdateButtonStatusAfterNumber(); DetermineLastInput(); }

        // NUMBER 9
        private void Number9_Click(object sender, EventArgs e)
        { ClearMessages(); UpdateDisplayNumber('9'); UpdateButtonStatusAfterNumber(); DetermineLastInput(); }

        // COMMA BUTTON
        private void Comma_Click(object sender, EventArgs e)
        {
            ClearMessages();

            // Solves null problem, if first button used is comma button.
            if (onDisplay is null)
            {
                onDisplay = "0,";
                UpdateDisplay(onDisplay);
            }

            // Checks if display value contains a comma.
            bool contains = onDisplay.Contains(",");

            if (!contains)
            {
                onDisplay += ",";
                UpdateDisplay(onDisplay);

                if (onDisplay == ",")
                {
                    onDisplay = "0,";
                    UpdateDisplay(onDisplay);
                }
            }

            if (contains)
            {
                // Ignore, because not more than one comma can be accepted in a number value.
            }

            // Button status update after comma, same as after number.
            UpdateButtonStatusAfterNumber();
            DetermineLastInput();
        }

        // OPERATION BUTTONS (plus, minus, multiply, divide):

        // PLUS BUTTON
        private void Plus_Click(object sender, EventArgs e)
        {
            ClearMessages();
            if (euroSignSwitchedOffTemporarily == true) { SwitchOnEuroSignAgain(euroSign); }  // Switches on the eurosign again after a multiply or divide operation.
            if (PB_Operation) { P2B_Operation = true; }                                       // Operation Button hit for two or more consecutive times.
            Operation(onDisplay);
            onDisplay = displayReset;
            operation = "+";
        }

        // MINUS BUTTON
        private void Minus_Click(object sender, EventArgs e)
        {
            ClearMessages();
            if (euroSignSwitchedOffTemporarily == true) { SwitchOnEuroSignAgain(euroSign); }  // Switches on the eurosign again after a multiply or divide operation.
            if (PB_Operation) { P2B_Operation = true; }                                       // Operation Button hit for two or more consecutive times.
            Operation(onDisplay);
            onDisplay = displayReset;
            operation = "-";
        }

        // MULTIPLY BUTTON
        private void Multiply_Click(object sender, EventArgs e)
        {
            ClearMessages();
            if (euroSign == true) { TemporaryEuroSwitchOff(euroSign); }  // Because a money amount cannot be multiplied by a money amount.
            if (PB_Operation) { P2B_Operation = true; }                  // Operation Button hit for two or more consecutive times.
            Operation(onDisplay);
            onDisplay = displayReset;
            operation = "×";                                               
        }

        // DIVIDE BUTTON
        private void Divide_Click(object sender, EventArgs e)
        {
            ClearMessages();
            if (euroSign == true) { TemporaryEuroSwitchOff(euroSign); }  // Because a money amount is usually not divided by a money amount.
            if (PB_Operation) { P2B_Operation = true; }                  // Operation Button hit for two or more consecutive times.
            Operation(onDisplay);
            onDisplay = displayReset;
            operation = "÷";
        }

        // EQUALS OPERATION:

        // This bool is set to true after the equals button is hit.
        // It is used to prevent that numbers, that are given as a result of a calculation, can be extended
        // by hitting the number button again. A completely new calculation with a new number is started then.
        public bool displayShowsResult;

        // This bool is used (only) for the so-called EqualsRepeatMethod below.
        public bool equalsRepeatMethodNotRunBefore;

        // EQUALS BUTTON
        private void Equals_Click(object sender, EventArgs e)
        {
            ClearMessages();

            // Switches on the eurosign again after a multiply or divide operation.
            if (euroSignSwitchedOffTemporarily == true) { SwitchOnEuroSignAgain(euroSign); }

            // Replaces a possible comma in string for a dot, so conversion to a double with decimals becomes possible.  
            onDisplay = onDisplay.Replace(",", ".");

            // If no operation is determined yet, before hitting the operation button.
            if (operation == "")
            {
                // Ignore, because the equals operation always requires one of the 
                // standard operations plus, minus, multiply or divide.
            }

            // Equals repeat method, version1: 
            // Used to calculate and keep on calculating with the equals, after hitting a number button and an operation button.
            else if (operation != "" && (lastInputOperation || lastInputValue1) && !PB_plusMinusSwitch)
            {
                if (equalsRepeatMethodNotRunBefore == true)
                {
                    value2 = value1;
                }
                Equals();
                DetermineLastInput();
                equalsRepeatMethodNotRunBefore = false;
            }

            // Equals repeat method, version2:
            // Used to calculate and keep on calculating with the equals button, after hitting an operation button and a number button.
            else if (operation != "" && (PB_Number || PB_Equals || PB_SquareOrRoot))
            {
                if (equalsRepeatMethodNotRunBefore == true)
                {
                    value2 = Convert.ToDouble(onDisplay);   // value1 is kept at zero, the display value is converted to value2.  
                }
                Equals();                                   // In this case the answer of multiply and divide operations is always zero, but for plus and minus not.
                DetermineLastInput();
                equalsRepeatMethodNotRunBefore = false;
            }

            // Usual situation when hitting the equals button:
            // value1, operator and value2 are all given.
            else if ((PB_Number || PB_SquareOrRoot) && lastInputValue2)
            {
                value2 = Convert.ToDouble(onDisplay);
                Equals();   
                DetermineLastInput();
            }

            // Status update:
            PB_Clear = false; PB_Number = false; PB_Operation = false; P2B_Operation = false;
            PB_SquareOrRoot = false; PB_plusMinusSwitch = false; PB_Equals = true;
            displayShowsResult = true;
        }

        // SQUARE ROOT BUTTON
        private void SquareRoot_Click(object sender, EventArgs e)
        {
            ClearMessages();  // Not necessary, but just added to be extra secure.
             
            // To check if the display value contains a minus sign.
            bool contains = onDisplay.Contains("-");

            if (!contains && euroSign == false)
            {
                onDisplay = onDisplay.Replace(",", ".");

                if (lastInputValue1)
                {
                    value1 = Convert.ToDouble(onDisplay);
                    value1 = Math.Sqrt(value1);
                    onDisplay = value1.ToString();
                }
                else if (lastInputValue2)
                {
                    value2 = Convert.ToDouble(onDisplay);
                    value2 = Math.Sqrt(value2);
                    onDisplay = value2.ToString();
                }
                onDisplay = onDisplay.Replace(".", ",");
                UpdateDisplay(onDisplay);
                DetermineLastInput();

                // Status update:
                PB_Clear = false; PB_Number = false; PB_Operation = false; P2B_Operation = false;
                PB_SquareOrRoot = true; PB_plusMinusSwitch = false; PB_Equals = false;
            }

            else if (contains && euroSign == false)
            {
                // Square root cannot be calculated from a negative number.
                onDisplay = "Invalid input";
                UpdateDisplay(onDisplay);
                onDisplay = displayResetToZero;
                value1 = valueResetToZero;
                operation = operationReset;
                value2 = valueResetToZero;
            }

            // Check for eurosign.
            if (euroSign == true)
            {
                euroSign = false;
                UpdateEuroDisplay(euroSign);
                onDisplay = "Cannot calculate √ from value in €";
                UpdateDisplay(onDisplay);
            }
        }

        // SQUARE BUTTON
        private void Square_Click(object sender, EventArgs e)
        {
            ClearMessages();

            onDisplay = onDisplay.Replace(",", ".");

            if (lastInputValue1 && euroSign == false)
            {
                value1 = Convert.ToDouble(onDisplay);
                value1 = Math.Pow(value1, 2);
                onDisplay = value1.ToString();
            }

            if (lastInputValue2 && euroSign == false)
            {
                value2 = Convert.ToDouble(onDisplay);
                value2 = Math.Pow(value2, 2);
                onDisplay = value2.ToString();
            }

            onDisplay = onDisplay.Replace(".", ",");
            UpdateDisplay(onDisplay);
            DetermineLastInput();

            // Status update:
            PB_Clear = false; PB_Number = false; PB_Operation = false; P2B_Operation = false;
            PB_SquareOrRoot = true; PB_plusMinusSwitch = false; PB_Equals = false;

            // Check for eurosign.
            if (euroSign == true)
            {
                euroSign = false;
                UpdateEuroDisplay(euroSign);
                onDisplay = "Cannot calculate 𝑥² from value in €";
                UpdateDisplay(onDisplay);
            }
        }

        // PERCENTAGE BUTTON
        private void Percentage_Click(object sender, EventArgs e)
        {
            if (euroSign == false)
            {
                ClearMessages();

                onDisplay = onDisplay.Replace(",", ".");

                if (lastInputValue1)
                {
                    value1 = Convert.ToDouble(onDisplay);
                    value1 = value1 / 100;
                    onDisplay = value1.ToString();
                }

                if (lastInputValue2)
                {
                    value2 = Convert.ToDouble(onDisplay);
                    value2 = value2 / 100;
                    onDisplay = value2.ToString();
                }

                onDisplay = onDisplay.Replace(".", ",");
                UpdateDisplay(onDisplay);
                DetermineLastInput();
            }
            else
            {
                // Ignore, because this makes no sense
            }
        }

        // SWITCH BUTTONS 

        // PLUS OR MINUS SWITCH BUTTON
        private void PlusMinusSwitch_Click(object sender, EventArgs e)
        {
            ClearMessages();

            // To check if the display containd a minus sign or not.
            bool contains = onDisplay.Contains("-");

            // Switch on (only if there's not zero on the display)
            if (!contains)
            {
                if (onDisplay != "0")
                {
                    onDisplay = "-" + onDisplay;
                    UpdateDisplay(onDisplay);

                    // If PlusMinusSwitch is hit after operation button.
                    if (onDisplay == "-" && value1 != 0)
                    {
                        onDisplay = "-" + value1.ToString();
                        UpdateDisplay(onDisplay);
                    }
                    // If PlusMinusSwitch is hit after operation button and display is zero.
                    else if (onDisplay == "-" && value1 == 0)
                    {
                        onDisplay = "0";
                        UpdateDisplay(onDisplay);
                    }
                }
                if (onDisplay == "0")
                {
                    // Ignore, because zero is never written with a minus sign before it.
                }
            }

            if (contains)
            {
                // Switch off
                onDisplay = onDisplay.Replace("-", "");
                UpdateDisplay(onDisplay);
            }

            // Status update:
            PB_Clear = false; PB_Number = false; PB_Operation = false; P2B_Operation = false;
            PB_SquareOrRoot = false; PB_plusMinusSwitch = true; PB_Equals = true;
        }

        // EUROSIGN BUTTON (SWITCH TO EURO CURRENCY)

        // EUROSIGN BOOL
        public bool euroSign;

        private void Euro_Click(object sender, EventArgs e)
        {
            bool containsEuroSign = displayEuro.Text.Contains("€ ");

            if (containsEuroSign)
            {
                // Switch off
                euroSign = false;
                UpdateEuroDisplay(euroSign);
            }
            else if (!containsEuroSign)
            {
                // Switch on
                euroSign = true;
                UpdateEuroDisplay(euroSign);
            }
        }

        // ROUND OFF AMOUNTS IN EURO'S TO TWO DECIMALS (method not used in calculator)
        public void RoundOffEuros(string onDisplay)
        {
            onDisplay = onDisplay.Replace(",", ".");
            double roundOff = Convert.ToDouble(onDisplay);

            roundOff = Math.Round(roundOff, 2);
            onDisplay = roundOff.ToString();
            onDisplay = onDisplay.Replace(".", ",");
            UpdateDisplay(onDisplay);
        }

        // EURO TEMPORARY SWITCH-OFF BOOL
        // For switching off the eurosign temporarily for a calculation (with multiply or divide)
        public bool euroSignSwitchedOffTemporarily;

        // SWITCH OFF EUROSIGN TEMPORARILY FOR MULTIPLY OR DIVIDE OPERATION
        public void TemporaryEuroSwitchOff(bool eurosign)
        {
            euroSign = false;
            UpdateEuroDisplay(euroSign);
            euroSignSwitchedOffTemporarily = true;
        }

        // SWITCH ON EUROSIGN AGAIN AFTER TEMPORARY SWITCH-OFF
        public void SwitchOnEuroSignAgain(bool eurosign)
        {
            euroSign = true;
            UpdateEuroDisplay(euroSign);
            euroSignSwitchedOffTemporarily = false;
        }
    }
}