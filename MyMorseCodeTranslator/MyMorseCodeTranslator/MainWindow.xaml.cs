using System;
using System.Collections.Generic;
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

// Date: February 2019

namespace MyMorseCodeTranslator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // METHOD: CONVERT TEXT TO MORSE
        private void ConvertTextToMorseCode(string text)
        {
            string output = "";

            foreach (char c in text)
            {
                // All capital and small letters of the alphabet
                if      (c == 'A' || c == 'a') { output += ".- "; }
                else if (c == 'B' || c == 'b') { output += "-... "; }
                else if (c == 'C' || c == 'c') { output += "-.-. "; }
                else if (c == 'D' || c == 'd') { output += "-.. "; }
                else if (c == 'E' || c == 'e') { output += ". "; }
                else if (c == 'F' || c == 'f') { output += "..-. "; }
                else if (c == 'G' || c == 'g') { output += "--. "; }
                else if (c == 'H' || c == 'h') { output += ".... "; }
                else if (c == 'I' || c == 'i') { output += ".. "; }
                else if (c == 'J' || c == 'j') { output += ".--- "; }
                else if (c == 'K' || c == 'k') { output += "-.- "; }
                else if (c == 'L' || c == 'l') { output += ".-.. "; }
                else if (c == 'M' || c == 'm') { output += "-- "; }
                else if (c == 'N' || c == 'n') { output += "-. "; }
                else if (c == 'O' || c == 'o') { output += "--- "; }
                else if (c == 'P' || c == 'p') { output += ".--. "; }
                else if (c == 'Q' || c == 'q') { output += "--.- "; }
                else if (c == 'R' || c == 'r') { output += ".-. "; }
                else if (c == 'S' || c == 's') { output += "... "; }
                else if (c == 'T' || c == 't') { output += "- "; }
                else if (c == 'U' || c == 'u') { output += "..- "; }
                else if (c == 'V' || c == 'v') { output += "...- "; }
                else if (c == 'W' || c == 'w') { output += ".-- "; }
                else if (c == 'X' || c == 'x') { output += "-..- "; }
                else if (c == 'Y' || c == 'y') { output += "-.-- "; }
                else if (c == 'Z' || c == 'z') { output += "--.. "; }

                // Numbers from 0 to 9
                else if (c == '0') { output += "----- "; }
                else if (c == '1') { output += ".---- "; }
                else if (c == '2') { output += "..--- "; }
                else if (c == '3') { output += "...-- "; }
                else if (c == '4') { output += "....- "; }
                else if (c == '5') { output += "..... "; }
                else if (c == '6') { output += "-.... "; }
                else if (c == '7') { output += "--... "; }
                else if (c == '8') { output += "---.. "; }
                else if (c == '9') { output += "----. "; }

                // Signs
                else if (c == '.')  { output += ".-.-.- "; }
                else if (c == ',')  { output += "--..-- "; }
                else if (c == '?')  { output += "..--.. "; }
                else if (c == '!')  { output += "-.-.-- "; }
                else if (c == '-')  { output += "-....- "; }
                else if (c == '+')  { output += ".-.-. "; }
                else if (c == '/')  { output += "-..-. "; }
                else if (c == ':')  { output += "---... "; }
                else if (c == ';')  { output += "-.-.- "; }
                else if (c == '\'') { output += ".----. "; }
                else if (c == '"')  { output += ".-..-. "; }
                else if (c == '(')  { output += "-.--. "; }
                else if (c == ')')  { output += "-.--.- "; }
                else if (c == '_')  { output += "..--.- "; }
                else if (c == '=')  { output += "-...- "; }
                else if (c == '@')  { output += ".--.-. "; }
                else if (c == '&')  { output += ".-.... "; }
                else if (c == '$')  { output += "...-..-"; } 

                // Special letters
                else if (c == 'À' || c == 'à' || c == 'Å' || c == 'å') { output += ".--.- "; }
                else if (c == 'Ä' || c == 'ä' || c == 'Æ' || c == 'æ') { output += ".-.- "; }
                else if (c == 'ç') { output += "-.-.. "; }
                else if (c == 'é') { output += "..-.. "; }
                else if (c == 'è') { output += ".-..- "; }
                else if (c == 'ñ') { output += "--.-- "; }
                else if (c == 'Ö' || c == 'ö' || c == 'Ø' || c == 'ø') { output += "---. "; }
                else if (c == 'Ü' || c == 'ü') { output += "..-- "; }

                // Spaces
                else if (c == ' ') { output += "/ "; }

                // All other characters (for which no Morse code exists)
                else { output += "........ "; } // Morse code for error is given
                
                // COMMENTARY:
                // You could also choose not to give any output in return for an input for which no Morse code exists,
                // but personally I thought it would be more correct and clear to return error code in return for this.
            }

            // Output:
            textBox_output.Text = output;
        }

        // METHOD: CONVERT MORSE TO TEXT
        private void ConvertMorseCodeToText(string morse)
        {
            string[] morseSymbols = new string[] { "" };
            morseSymbols = morse.Split(' ');  // a single space as delimiter to get each letter in Morse 

            string output = "";

            foreach (string s in morseSymbols)
            {
                // All capital and small letters in Morse code
                if (s == ".-")        { output += "a"; } 
                else if (s == "-...") { output += "b"; }
                else if (s == "-.-.") { output += "c"; }
                else if (s == "-..")  { output += "d"; }
                else if (s == ".")    { output += "e"; }
                else if (s == "..-.") { output += "f"; }
                else if (s == "--.")  { output += "g"; }
                else if (s == "....") { output += "h"; }
                else if (s == "..")   { output += "i"; }
                else if (s == ".---") { output += "j"; }
                else if (s == "-.-")  { output += "k"; }
                else if (s == ".-..") { output += "l"; }
                else if (s == "--")   { output += "m"; }
                else if (s == "-.")   { output += "n"; }
                else if (s == "---")  { output += "o"; }
                else if (s == ".--.") { output += "p"; }
                else if (s == "--.-") { output += "q"; }
                else if (s == ".-.")  { output += "r"; }
                else if (s == "...")  { output += "s"; }
                else if (s == "-")    { output += "t"; }
                else if (s == "..-")  { output += "u"; }
                else if (s == "...-") { output += "v"; }
                else if (s == ".--")  { output += "w"; }
                else if (s == "-..-") { output += "x"; }
                else if (s == "-.--") { output += "y"; }
                else if (s == "--..") { output += "z"; }

                // Numbers from 0 to 9
                else if (s == "-----") { output += "0"; }
                else if (s == ".----") { output += "1"; }
                else if (s == "..---") { output += "2"; }
                else if (s == "...--") { output += "3"; }
                else if (s == "....-") { output += "4"; }
                else if (s == ".....") { output += "5"; }
                else if (s == "-....") { output += "6"; }
                else if (s == "--...") { output += "7"; }
                else if (s == "---..") { output += "8"; }
                else if (s == "----.") { output += "9"; }

                // Signs
                else if (s == ".-.-.-")  { output += "."; }
                else if (s == "--..--")  { output += ","; }
                else if (s == "..--..")  { output += "?"; }
                else if (s == "-.-.--")  { output += "!"; }
                else if (s == "-....-")  { output += "-"; }
                else if (s == ".-.-.")   { output += "+"; } 
                else if (s == "-..-.")   { output += "/"; }
                else if (s == "---...")  { output += ":"; }
                else if (s == "-.-.-")   { output += ";"; }
                else if (s == ".----.")  { output += "'"; }
                else if (s == ".-..-.")  { output += "\"";}
                else if (s == "-.--.")   { output += "("; }
                else if (s == "-.--.-")  { output += ")"; }
                else if (s == "..--.-")  { output += "_"; } 
                else if (s == "-...-")   { output += "="; }
                else if (s == ".--.-.")  { output += "@"; }
                else if (s == ".-....")  { output += "&"; }
                else if (s == "...-..-") { output += "$"; } 

                // Special letters
                else if (s == ".--.-") { output += "à"; } // choice is made for 'à' in stead of 'å', because 'å' is not used in Dutch language
                else if (s == ".-.-")  { output += "ä"; } // choice is made for 'ä' in stead of 'å', because 'æ' is not used in Dutch language
                else if (s == "-.-..") { output += "ç"; }
                else if (s == "..-..") { output += "é"; }
                else if (s == ".-..-") { output += "è"; }
                else if (s == "--.--") { output += "ñ"; }
                else if (s == "---.")  { output += "ö"; } // choice is made for 'ö' in stead of 'ø', because 'ø' is not used in Dutch language
                else if (s == "..--")  { output += "ü"; }

                // Spaces
                else if (s == "/") { output += " "; }

                // Unknown letter/symbol
                else if (s == "......." || s == "........") { output += " (onbekende letter of symbool) "; }

                // Empty space
                else if (s == " ") { output += " "; }

                // Error
                else
                {
                    if (s != "  ")
                    {
                        output += " (voer Morse code in)";
                        // all else is no Morse code
                    }
                } 
            }

            textBox_output.Text = output;                
        }

        // TEXT CHANGE IN TEXT BOX
        private void TextBox_input_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (translateTextToMorse) { ConvertTextToMorseCode(textBox_input.Text); }
            else { ConvertMorseCodeToText(textBox_input.Text); }
        }

        // COMBOBOX SELECTION
        public bool translateTextToMorse = true;

        private void ComboBox_translateFromTo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Clear textbox
            if (textBox_input != null)
            {
                textBox_input.Clear();
            }

            // Change selection
            if (TranslateTextToMorse.IsSelected) { translateTextToMorse = true; }
            else { translateTextToMorse = false; }
        }
    }
}
