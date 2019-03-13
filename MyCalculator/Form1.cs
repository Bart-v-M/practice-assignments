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

namespace MyCalculator_v3_
{
    public partial class MyCalculator : Form
    {
        public string displayValue;
        public string displayMemory;

        public decimal value1;
        public byte value1Used;                // 1 if used, 0 if not
        public decimal value2;
        public byte value2Used;                // 1 if used, 0 if not
        public decimal result;

        public string operationType;
        public byte lastButtonWasOperator;     // 1 if true, 0 if not 
        public byte lastButtonWasC;            // 1 if true, 0 if not 

        public byte euroSignOnOff;             // 0 if off, 1 if on 
        public byte euroSignOffTemporarily;    // 1 if off temporarily, 0 if not

        public byte lastButtonWasOperator;     // 1 if true, 0 if not 
        public byte lastButtonWasC;            // 1 if true, 0 if not 

        public string resetDisplay = "";
        public string resetDisplayToZero = "0";
        public byte reset = 0;
        public string resetOperationType = "";


        // METHODS FOR UPDATING DISPLAY(LABEL)

        // UPDATE DISPLAY & FORMAT NUMBER
        public void UpdateDisplay(string displayValue)
        {
            displayValue = displayValue.Replace(",", ".");
            //decimal value = Convert.ToDecimal(displayValue);
            //Try string.Split for adding dots.

            display.Font = new Font("Segoe UI", 20);

            int displayLength = displayValue.Length;
            if (displayLength > 16)  // Makes font smaller for larger displayvalues
            {
                display.Font = new Font("Segoe UI", 14);
            }

            display.Text = displayValue;
            //displayValue = displayMemory;
        }

        // METHOD FOR UPDATING EURO DISPLAY(LABEL)
        public void UpdateEuroDisplay(int euroSignOnOff)
        {
            if (euroSignOnOff == 1)
            {
                displayEuro.Font = new Font("Segoe UI", 20);

                int displayLength = displayValue.Length;
                if (displayLength > 16)   // Makes font smaller for larger displayvalues
                {
                    display.Font = new Font("Segoe UI", 14);
                }
          
                displayEuro.Text = "€ ";
            }
            else
            {
                displayEuro.Text = "";
            }
            //lastButtonWasOperator = 0;    // Best option to comment this one out.
        }

        // OPTIONAL METHOD FOR ROUNDING OFF AMOUNTS IN EURO'S TO TWO DECIMALS (NOT USED)
        public void RoundOffEuros(bool containsEuroSign)
        {
            containsEuroSign = displayEuro.Text.Contains("€ ");

            if (containsEuroSign)
            {
                displayValue = displayValue.Replace(",", ".");
                value1 = Convert.ToDecimal(displayValue);

                decimal value = Math.Round(value1, 2);
                displayValue = value.ToString();
                displayValue = displayValue.Replace(".", ",");
                UpdateDisplay(displayValue);
            }
    }


    // INITIALIZATION

    public MyCalculator()
        {
            InitializeComponent();

            displayValue = resetDisplayToZero;
            value1 = reset;
            value2 = reset;
            operationType = resetOperationType;
            euroSignOnOff = 0;
            euroSignOffTemporarily = 0;
            lastButtonWasOperator = 0;
            lastButtonWasC = 0;
        }

        private void MyCalculator_Load(object sender, EventArgs e)
        {
            // Load program.
        }


        // ALL CLEAR (AC) BUTTON
        private void allClear_Click(object sender, EventArgs e)
        {
            displayValue = resetDisplayToZero;
            value1 = reset;
            value2 = reset;
            operationType = resetOperationType;
            euroSignOnOff = 0;
            euroSignOffTemporarily = 0;
            lastButtonWasOperator = 0;
            lastButtonWasC = 0;
           
            UpdateDisplay(displayValue);
            UpdateEuroDisplay(euroSignOnOff);
        }

        // CLEAR (C) BUTTON
        private void clear_Click(object sender, EventArgs e)
        {
            // Clears only the last input
            if (lastButtonWasOperator == 0)
            {
                displayValue = displayMemory;
                displayValue = resetDisplayToZero;
                euroSignOnOff = 0;
                UpdateDisplay(displayValue);
                UpdateEuroDisplay(euroSignOnOff);
                lastButtonWasC = 1;
            }
            if (lastButtonWasOperator == 1)
            {
                // If last button was operator button
                operationType = resetOperationType;
                lastButtonWasC = 1;
            }
        }


        // NUMBER BUTTONS

        // NUMBER 0
        private void number0_Click(object sender, EventArgs e)
        {
            if (displayValue == "0")
            {
                displayValue = resetDisplay;
            }
            else
            {
                displayValue += "0";
                UpdateDisplay(displayValue);
            }
            lastButtonWasOperator = 0;
        }

        // NUMBER 1
        private void number1_Click(object sender, EventArgs e)
        {
            if (displayValue == "0")
            {
                displayValue = resetDisplay;
            }
            displayValue += "1";
            UpdateDisplay(displayValue);
            lastButtonWasOperator = 0;
        }

        // NUMBER 2
        private void number2_Click(object sender, EventArgs e)
        {
            if (displayValue == "0")
            {
                displayValue = resetDisplay;
            }
            displayValue += "2";
            UpdateDisplay(displayValue);
            lastButtonWasOperator = 0;
        }

        // NUMBER 3
        private void number3_Click(object sender, EventArgs e)
        {
            if (displayValue == "0")
            {
                displayValue = resetDisplay;
            }
            displayValue += "3";
            UpdateDisplay(displayValue);
            lastButtonWasOperator = 0;
        }

        // NUMBER 4
        private void number4_Click(object sender, EventArgs e)
        {
            if (displayValue == "0")
            {
                displayValue = resetDisplay;
            }
            displayValue += "4";
            UpdateDisplay(displayValue);
            lastButtonWasOperator = 0;
        }

        // NUMBER 5
        private void number5_Click(object sender, EventArgs e)
        {
            if (displayValue == "0")
            {
                displayValue = resetDisplay;
            }
            displayValue += "5";
            UpdateDisplay(displayValue);
            lastButtonWasOperator = 0;
        }

        // NUMBER 6
        private void number6_Click(object sender, EventArgs e)
        {
            if (displayValue == "0")
            {
                displayValue = resetDisplay;
            }
            displayValue += "6";
            UpdateDisplay(displayValue);
            lastButtonWasOperator = 0;
        }

        // NUMBER 7
        private void number7_Click(object sender, EventArgs e)
        {
            if (displayValue == "0")
            {
                displayValue = resetDisplay;
            }
            displayValue += "7";
            UpdateDisplay(displayValue);
            lastButtonWasOperator = 0;
        }

        // NUMBER 8
        private void number8_Click(object sender, EventArgs e)
        {
            if (displayValue == "0")
            {
                displayValue = resetDisplay;
            }
            displayValue += "8";
            UpdateDisplay(displayValue);
            lastButtonWasOperator = 0;
        }

        // NUMBER 9
        private void number9_Click(object sender, EventArgs e)
        {
            if (displayValue == "0")
            {
                displayValue = resetDisplay;
            }
            displayValue += "9";
            UpdateDisplay(displayValue);
            lastButtonWasOperator = 0;
        }

        // COMMA BUTTON
        private void comma_Click(object sender, EventArgs e)
        {
            bool contains = displayValue.Contains(",");

            if (!contains)
            {
                displayValue += ",";
                formulaDisplayValue += ",";

                if (displayValue == "," || displayValue == "0,")
                {
                    displayValue = "0,";
                    UpdateDisplay(displayValue);
                }
            }
            else
            {
                // ignore, because we don't want more than one comma in our numbers
            }
            lastButtonWasOperator = 0;
        }


        // OPERATOR BUTTONS

        // PLUS BUTTON
        private void plus_Click(object sender, EventArgs e)
        {
            if (euroSignOffTemporarily == 1)
            {
                euroSignOnOff = 1;
                UpdateEuroDisplay(euroSignOnOff);
            }

            ConvertAndKeepOnCalculating(displayValue);
            //displayValue = displayMemory;
            displayValue = resetDisplay;
            operationType = "+";
            lastButtonWasOperator = 1;
        }

        // MINUS BUTTON
        private void minus_Click(object sender, EventArgs e)
        {
            // Switches on the eurosign again, after being off temporarily.
            if (euroSignOffTemporarily == 1)
            {
                euroSignOnOff = 1;
                UpdateEuroDisplay(euroSignOnOff);
            }

            ConvertAndKeepOnCalculating(displayValue);
            //displayValue = displayMemory;
            displayValue = resetDisplay;
            operationType = "-";
            lastButtonWasOperator = 1;
        }

        // MULTIPLY BUTTON
        private void multiply_Click(object sender, EventArgs e)
        {
            if (euroSignOnOff == 1)  
            {
                // Switches of the eurosign temporarily, because a money amount 
                // cannot be multiplied by a money amount. The sign comes back
                // automatically when the calculation is continued.
                // If the user wants, switching back is als possible immediately,
                // by hitting the €-button. However, in practice this doesn't 
                // change the output.
                euroSignOnOff = 0;
                UpdateEuroDisplay(euroSignOnOff);
                euroSignOffTemporarily = 1;
            }

            ConvertAndKeepOnCalculating(displayValue);
            //displayValue = displayMemory;
            displayValue = resetDisplay;
            operationType = "×";
            lastButtonWasOperator = 1;
        }

        // DIVIDE BUTTON
        private void divide_Click(object sender, EventArgs e)
        {
            if (euroSignOnOff == 1)
            {
                // Switches of the eurosign temporarily, because a money amount 
                // is usually not divided by another money amount. The sign comes back
                // automatically when the calculation is continued.
                // If the user wants, switching back is als possible immediately,
                // by hitting the €-button. However, in practice this doesn't 
                // change the output.
                euroSignOnOff = 0;
                UpdateEuroDisplay(euroSignOnOff);
                euroSignOffTemporarily = 1;
            }

            ConvertAndKeepOnCalculating(displayValue);
            //displayValue = displayMemory;
            displayValue = resetDisplay;
            operationType = "÷";
            lastButtonWasOperator = 1;
        }

        // IS RESULT BUTTON (=)
        private void isResult_Click(object sender, EventArgs e)
        {
            if (euroSignOffTemporarily == 1)
            {
                // Switches eurosign on again automatically
                euroSignOnOff = 1;
                UpdateEuroDisplay(euroSignOnOff);
                euroSignOffTemporarily = 0;
            }

            displayValue = displayValue.Replace(",", ".");

            value2 = Convert.ToDecimal(displayValue);

            if (operationType == "+")
            {
                result = value1 + value2;
            }
            else if (operationType == "-")
            {
                result = value1 - value2;
            }
            else if (operationType == "×")
            {
                result = value1 * value2;
            }
            else if (operationType == "÷")
            {
                if (value2 != 0)
                {
                    result = value1 / value2;
                }
            }

            displayValue = result.ToString();
            displayValue = displayValue.Replace(".", ",");
            UpdateDisplay(displayValue);

            value1 = result;

            if (operationType == "÷")
            {
                if (value2 == 0)
                {
                    // Dividing by zero is mathematically impossible
                    displayValue = "Cannot divide by zero";
                    UpdateDisplay(displayValue);
                    operationType = resetOperationType;
                    value1 = reset;
                }
            }

            value2 = reset;
            operationType = resetOperationType;
            lastButtonWasOperator = 0;
        }

        // SQUARE ROOT BUTTON
        private void squareRoot_Click(object sender, EventArgs e)
        {
            bool containsMinusSign = displayValue.Contains("-");
            if (containsMinusSign)
            {
                // Square root cannot be calculated from a negative number.
                displayValue = "Invalid input";
                UpdateDisplay(displayValue);
                displayValue = resetDisplayToZero;
                operationType = resetOperationType;
                value1 = reset;
                value2 = reset;
            }

            if (!containsMinusSign && euroSignOnOff == 0)
            {
                displayValue = displayValue.Replace(",", ".");
                value1 = Convert.ToDecimal(displayValue); 

                double value;
                value = Convert.ToDouble(value1);

                double result;
                result = Math.Sqrt(value);

                value1 = Convert.ToDecimal(result);

                displayValue = result.ToString();
                displayValue = displayValue.Replace(".", ",");
                UpdateDisplay(displayValue);
                value1 = result;
            }

            if (euroSignOnOff == 1)
            {
                // Square root cannot be calculated from a money amount.
                displayValue = "Switch off euro(€) for √";
                UpdateDisplay(displayValue);
            }
            lastButtonWasOperator = 0;
        }

        // SQUARE BUTTON
        private void square_Click(object sender, EventArgs e)
        {
            if (euroSignOnOff == 0)
            {
                if (lastButtonWasOperator == 1)
                {
                    displayValue = displayMemory;
                }

                displayValue = displayValue.Replace(",", ".");

                double value;
                value = Convert.ToDouble(displayValue);

                double result;
                result = Math.Pow(value, 2);

                // Prevents overflow problem, makes that output continues until infinity.
                double max = (double.MaxValue + double.MaxValue / 1e16);
                if (result > max || result < double.MinValue)
                {
                    result = 0;
                    if (result == 0)
                    {
                        displayValue = result.ToString();
                        displayValue = displayValue.Replace(".", ",");
                        UpdateDisplay(displayValue);
                        value1 = result;
                    }
                }

                displayValue = result.ToString();
                displayValue = displayValue.Replace(".", ",");
                UpdateDisplay(displayValue);
                value1 = result;
            }

            if (euroSignOnOff == 1)
            {
                // Square cannot be calculated from a money amount.
                displayValue = "Switch off euro(€) for 𝑥²";
                UpdateDisplay(displayValue);
            }
            lastButtonWasOperator = 0;
        }


        // OTHER BUTTONS 

        // PERCENTAGE BUTTON
        private void percentage_Click(object sender, EventArgs e)
        {
            if (euroSignOnOff == 0)
            {
                displayValue = displayValue.Replace(",", ".");

                value1 = Convert.ToDecimal(displayValue);

                result = value1 / 100;
                displayValue = result.ToString();
                displayValue = displayValue.Replace(".", ",");
                UpdateDisplay(displayValue);
                value1 = result;
            }

            if (euroSignOnOff == 1)
            {
                // Percentage button is not for money amounts.
                displayValue = "Switch off euro(€) for %";
                UpdateDisplay(displayValue);
            }
            lastButtonWasOperator = 0;
        }

        // PLUS OR MINUS SWITCH BUTTON
        private void plusMinusSwitch_Click(object sender, EventArgs e)
        {
            bool contains = displayValue.Contains("-");

            if (!contains)
            {
                // Switch on
                displayValue = "-" + displayValue;
                UpdateDisplay(displayValue);
            }
            else
            {
                // Switch off
                displayValue = displayValue.Replace("-", "");
                UpdateDisplay(displayValue);
            }
            lastButtonWasOperator = 0;
        }

        // EUROSIGN (SWITCH) BUTTON
        private void euro_Click(object sender, EventArgs e)
        {
            bool containsEuroSign = displayEuro.Text.Contains(" € ");

            if (!containsEuroSign)
            {
                // Switch on
                euroSignOnOff = 1;
                UpdateEuroDisplay(euroSignOnOff);
                containsEuroSign = true;
            }
            else
            {
                // Switch off
                euroSignOnOff = 0;
                UpdateEuroDisplay(euroSignOnOff);
            }
            lastButtonWasOperator = 0;
        }


        // CALCULATION METHOD FOR THE OPERATOR BUTTONS PLUS, MINUS, MULTIPLY AND DIVIDE
        public void ConvertAndKeepOnCalculating(string displayValue)
        {
            displayValue = displayValue.Replace(",", ".");

            if (lastButtonWasC == 0)
            {
                if (operationType == "")
                {
                    // If operation type is not used, collect the first value
                    value1 = Convert.ToDecimal(displayValue);
                }
                else
                {
                    // If operation type is used and value 1 is collected, collect the second value
                    value2 = Convert.ToDecimal(displayValue);

                    if (operationType == "+")
                    {
                        result = value1 + value2;
                    }
                    else if (operationType == "-")
                    {
                        result = value1 - value2;
                    }
                    else if (operationType == "×")
                    {
                        result = value1 * value2;
                    }
                    else if (operationType == "÷")
                    {
                        if (value2 != 0)
                        {
                            result = value1 / value2;
                        }
                    }

                    displayValue = result.ToString();
                    displayValue = displayValue.Replace(".", ",");
                    UpdateDisplay(displayValue);
                    value1 = result;

                    if (operationType == "÷")
                    {
                        if (value2 == 0)
                        {
                            // Dividing by zero is mathematically impossible
                            displayValue = "Cannot divide by zero";
                            UpdateDisplay(displayValue);
                            operationType = resetOperationType;
                            value1 = reset;
                        }
                    }
                    // Reset second value, because result of calculation is new first value.
                    value2 = reset;
                }
            }
            if (lastButtonWasC == 1)
            {
                // First value is displayvalue in memory
                value1 = Convert.ToDecimal(displayMemory);

                if (operationType == "+")
                {
                    result = value1 + value2;
                }
                else if (operationType == "-")
                {
                    result = value1 - value2;
                }
                else if (operationType == "×")
                {
                    result = value1 * value2;
                }
                else if (operationType == "÷")
                {
                    if (value2 != 0)
                    {
                        result = value1 / value2;
                    }
                }

                displayValue = result.ToString();
                displayValue = displayValue.Replace(".", ",");
                UpdateDisplay(displayValue);
                value1 = result;

                if (operationType == "÷")
                {
                    if (value2 == 0)
                    {
                        // Dividing by zero is mathematically impossible
                        displayValue = "Cannot divide by zero";
                        UpdateDisplay(displayValue);
                        operationType = resetOperationType;
                        value1 = reset;
                    }
                }
                // Reset second value, because result of calculation is new first value.    
                value2 = reset;
                lastButtonWasC = 0;
            }
        }
    }
}

