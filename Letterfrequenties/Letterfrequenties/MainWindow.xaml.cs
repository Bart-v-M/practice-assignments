using System;
using System.Collections.Generic;
using System.IO;
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
using Microsoft.Win32;

// Date: March 2019

// LETTERFREQUENCIES
namespace Letterfrequenties
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

        // LETTERS AVAILABLE FOR FREQUENCY COUNT
        // In the letterstrings below each time all versions of a letter are given 
        // (uppercase and lowercase with all possible accents, etc.)  

        string letter_a = "AÀÁÂÃĀĂȦÄẢÅǍȀȂĄẠḀẦẤẪẨẰẮẴẲǠǞǺẬẶȺⱯaàáâãāăȧäảåǎȁȃąạḁẚầấẫẩằắẵẳǡǟǻậặⱥɐ";
        string letter_b = "ḂƁḄḆƂɃḃɓḅḇƀƃ";
        string letter_c = "CĆĈĊČƇÇḈȻcćĉċčƈçḉȼ";
        string letter_d = "DḊƊḌḎḐḒĎĐƉƋdḋɗḍḏḑḓďđƌȡ";
        string letter_e = "EÈÉÊẼĒĔĖËẺĚȄȆẸȨĘḘḚỀẾỄỂḔḖỆḜƎɆƐeèéêẽēĕėëẻěȅȇẹȩęḙḛềếễểḕḗệḝɇɛǝⱸⱻ";
        string letter_f = "FḞƑfḟƒ";
        string letter_g = "GǴĜḠĞĠǦƓĢǤgǵĝḡğġǧɠģǥ";
        string letter_h = "HĤḦȞḤḨḪĦⱧhĥḣḧȟḥḩḫẖħⱨ";
        string letter_i = "IÌÍÎĨĪĬİÏỈǏỊĮȈȊḬƗḮiìíîĩīĭıïỉǐịįȉȋḭɨḯ";
        string letter_j = "JĴɈjĵǰȷɉ";
        string letter_k = "KḰǨḴƘḲĶⱩkḱǩḵƙḳķĸⱪ";
        string letter_l = "LĹḺḶĻḼĽĿŁḸȽⱠⱢlĺḻḷļḽľŀłƚḹȴⱡ";
        string letter_m = "MḾṀṂⱮƜmḿṁṃɱɯ";
        string letter_n = "NǸŃÑṄŇƝṆŅṊṈȠnǹńñṅňɲṇņṋṉŉƞȵ";
        string letter_o = "OÒÓÔÕŌŎȮÖỎŐǑȌȎƠǪỌƟØỒỐỖỔȰȪȬṌṐṒỜỚỠỞỢǬỘǾoòóôõōŏȯöỏőǒȍȏơǫọɵøồốỗổȱȫȭṍṏṑṓờớỡởợǭộǿ";
        string letter_p = "PṔṖƤⱣpṕṗƥ";
        string letter_q = "QɊqɋ";
        string letter_r = "RŔṘŘȐȒṚŖṞṜɌⱤrŕṙřȑȓṛŗṟṝɍⱹ";
        string letter_s = "SŚŜṠŠṢȘŞⱾṤṦṨsśŝṡšṣșşȿṥṧṩ";
        string letter_t = "TṪŤƬƮṬȚŢṰṮŦȾtṫẗťƭʈƫṭțţṱṯŧⱦȶ";
        string letter_u = "UÙÚÛŨŪŬÜỦŮŰǓȔȖƯỤṲŲṶṴṸṺǛǗǕǙỪỨỮỬỰɄuùúûũūŭüủůűǔȕȗưụṳųṷṵṹṻǜǘǖǚừứữửựʉ";
        string letter_v = "VṼṾƲɅvṽṿⱱⱴʌ";
        string letter_w = "WẀẂŴẆẄẈⱲwẁẃŵẇẅẘẉⱳ";
        string letter_x = "XẊẌxẋẍ";
        string letter_y = "YỲÝŶỸȲẎŸỶƳỴɎyỳýŷȳẏÿỷẙƴỵɏ";
        string letter_z = "ZŹẐŻŽȤẒẔƵⱿⱫzźẑżžȥẓẕƶɀⱬ";

        /* Possible additions for the choice of letters given in the combobox
        string letter_æ = "ÆǼǢæǽǣ";
        string letter_ß = "ß";
        */

        // ALGORITHM FOR COUNTING LETTER FREQUENCIES
        public int count;
        
        private void CountLetterFrequency(string letterToCount, string text) 
        {
            count = 0;

            foreach (char textChar in text)
            {
                foreach (char letterChar in letterToCount)
                {
                    if (textChar == letterChar)
                    {
                        count++; 
                    }
                }
            }
        }
        // COMMENT: for each text character that appears in the string of characters of the letter to count,
        // the variable 'count' is raised by 1.

        // IMPORT TEXT FILE IN TEXTBOX
        public string startText = "Voer hier uw tekst in of importeer een txt-bestand";
        public string text;

        // Open file method for opening a text file in the program
        private void OpenFileDialog()
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.DefaultExt = ".txt";
            openFileDialog1.Filter = "Text document (.txt)|*.txt";

            if (openFileDialog1.ShowDialog() == true)
            {
                StreamReader reader = new StreamReader(openFileDialog1.FileName);
                text = reader.ReadLine();
                textBox1.Text = text.ToString();

                reader.Close();
            }
        }

        // Button Import txt-file
        private void Button_importTextFile_Click(object sender, RoutedEventArgs e)
        {
            if (text != startText)
            {
                MessageBoxResult result = 
                MessageBox.Show("Als u een tekstbestand importeert dan gaat de tekst die nu in het tekstvak staat verloren. " +
                                "Weet u zeker dat u een bestand wilt importeren?", "Txt-bestand importeren", MessageBoxButton.YesNo);

                if (result == MessageBoxResult.Yes)
                {
                    OpenFileDialog();
                }
                else
                {
                    // Ignore
                }
            }

            if (text == startText || text == "")
            {
                OpenFileDialog();
            }
        }

        // REMOVE TEXT AND CHANGE TEXT COLOR WHEN TEXTBOX IS SELECTED WITH MOUSE
        private void TextBox1_GotMouseCapture(object sender, MouseEventArgs e)
        {
            if (text == startText)
            {
                text = "";
                textBox1.Text = text;
                textBox1.Foreground = new SolidColorBrush(Colors.Black);
            }
        }

        // SET START TEXT AND CHANGE TEXT COLOR OF TEXTBOX (when Lost Focus is true, and when textbox is empty)
        private void TextBox1_LostFocus(object sender, RoutedEventArgs e)
        {
            if (text == "")
            {
                text = startText;
                textBox1.Text = text;
                textBox1.Foreground = new SolidColorBrush(Colors.DimGray);
            }
        }

        // UPDATE TEXT STRING WHEN TEXT IN TEXTBOX CHANGES
        private void TextBox1_TextChanged(object sender, TextChangedEventArgs e)
        {
            text = textBox1.Text;
        }

        // BUTTON COUNT LETTER FREQUENCY
        public string letterToCount;
        public string letter; // used for message in messagebox

        private void Button_countLetterFrequency_Click(object sender, RoutedEventArgs ee)
        {
            if (text != startText && None.IsSelected == false)
            {
                if (a.IsSelected) { letterToCount = letter_a; letter = "a"; }
                if (b.IsSelected) { letterToCount = letter_b; letter = "b"; }
                if (c.IsSelected) { letterToCount = letter_c; letter = "c"; }
                if (d.IsSelected) { letterToCount = letter_d; letter = "d"; }
                if (e.IsSelected) { letterToCount = letter_e; letter = "e"; }
                if (f.IsSelected) { letterToCount = letter_f; letter = "f"; }
                if (g.IsSelected) { letterToCount = letter_g; letter = "g"; }
                if (h.IsSelected) { letterToCount = letter_h; letter = "h"; }
                if (i.IsSelected) { letterToCount = letter_i; letter = "i"; }
                if (j.IsSelected) { letterToCount = letter_j; letter = "j"; }
                if (k.IsSelected) { letterToCount = letter_k; letter = "k"; }
                if (l.IsSelected) { letterToCount = letter_l; letter = "l"; }
                if (m.IsSelected) { letterToCount = letter_m; letter = "m"; }
                if (n.IsSelected) { letterToCount = letter_n; letter = "n"; }
                if (o.IsSelected) { letterToCount = letter_o; letter = "o"; }
                if (p.IsSelected) { letterToCount = letter_p; letter = "p"; }
                if (q.IsSelected) { letterToCount = letter_q; letter = "q"; }
                if (r.IsSelected) { letterToCount = letter_r; letter = "r"; }
                if (s.IsSelected) { letterToCount = letter_s; letter = "s"; }
                if (t.IsSelected) { letterToCount = letter_t; letter = "t"; }
                if (u.IsSelected) { letterToCount = letter_u; letter = "u"; }
                if (v.IsSelected) { letterToCount = letter_v; letter = "v"; }
                if (w.IsSelected) { letterToCount = letter_w; letter = "w"; }
                if (x.IsSelected) { letterToCount = letter_x; letter = "x"; }
                if (y.IsSelected) { letterToCount = letter_y; letter = "y"; }
                if (z.IsSelected) { letterToCount = letter_z; letter = "z"; }

                CountLetterFrequency(letterToCount, text);
                MessageBox.Show($"De letter {letter.ToUpper()} komt {count.ToString()} keer voor in de tekst.");
            }

            if (text == startText)
            {
                MessageBox.Show("Voer eerst uw tekst in of importeer een txt-bestand.");
            }

            if (None.IsSelected && text != "Voer eerst uw tekst in of importeer een txt-bestand.")
            {
                MessageBox.Show("Om de letterfrequentie te kunnen berekenen dient u eerst een letter te kiezen.");
            }
        }
    }
}