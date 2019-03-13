using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
// Source used for flags and info: www.flagpedia.net

namespace Vlaggen_van_de_wereld_1._0
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            MyGrid.Background = new SolidColorBrush(Color.FromRgb(250, 241, 218));

            SetStartScreen();
        }

        // SET START SCREEN

        // Margins to be used
        public int marginTop = 50;
        public int marginLeft = 125;

        // Set start screen
        private void SetStartScreen()
        {
            // textBlock_title
            textBlock_title.Text = "Vlaggen van de wereld";
            textBlock_title.FontFamily = new FontFamily("Segoe UI");
            textBlock_title.FontSize = 30;
            textBlock_title.FontWeight = FontWeights.Bold;

            textBlock_title.Margin = new Thickness(
                marginLeft,
                marginTop,
                0,
                0
                );

            // textBlock_selectNations
            textBlock_selectNations.Text = "Kies van welke landen je de nationale vlag wilt zien";
            textBlock_selectNations.Margin = new Thickness(
                marginLeft,
                marginTop + textBlock_title.Height + 20,
                0,
                0
                );

            //comboBox_selectNations
            comboBox_selectNations.Margin = new Thickness(
                marginLeft,
                marginTop + textBlock_title.Height + 20 + textBlock_selectNations.Height + 15,
                0,
                0
                );

            // textBlock_toQuiz
            textBlock_toQuiz.Text = "Of speel de ";
            textBlock_toQuiz.Margin = new Thickness(
                marginLeft + 450,
                marginTop + textBlock_title.Height + 15,
                0,
                0
                );
               
            // textBlock_quiz
            textBlock_quiz.Text = "VLAGGENQUIZ";
            textBlock_quiz.Margin = new Thickness(
               marginLeft + 485,
               marginTop + textBlock_title.Height + 50,
               0,
               0
               );

            // textBlock_selectedNationGroup
            textBlock_selectedNationGroup.Text = "Bekende vlaggen";
            textBlock_selectedNationGroup.Margin = new Thickness(
               marginLeft,
               marginTop + textBlock_title.Height + 50 + textBlock_selectNations.Height + 10 + comboBox_selectNations.ActualHeight + 85,
               0,
               0
               );

            CreateListOfSelectedNations();

            SetNationFlagsAndLabels();
        }


        // CREATE LISTS OF NATION FLAGS TO BE SHOWN
        public string nationGroup;
        public List<string> listOfSelectedNations;

        // Create list of selected nations
        private void CreateListOfSelectedNations()
        {
            if (Africa.IsSelected)
            {
                listOfSelectedNations = new List<string>
                {
                    "Algerije","Angola", "Benin", "Botswana", "Burkina Faso", "Burundi", "Kameroen", "Kaapverdië", "Centraal Afrikaanse Republiek",
                    "Tsjaad", "Comoren", "Ivoorkust", "Democratische Republiek Congo", "Djibouti", "Egypte", "Equatoriaal-Guinea", "Eritrea",
                    "Ethiopië", "Gabon", "Gambia", "Ghana", "Guinea", "Guinea-Bissau", "Kenia", "Lesotho", "Liberia", "Libië", "Madagascar",
                    "Malawi", "Mali", "Mauretanië", "Mauritius", "Marokko", "Mozambique", "Namibië", "Niger", "Nigeria", "Republiek Congo",
                    "Rwanda", "Sao Tomé en Principe", "Senegal", "Seychellen", "Sierra Leone", "Somalië", "Zuid-Afrika", "Zuid-Sudan", "Sudan",
                    "Swaziland", "Tanzania", "Togo", "Tunesië", "Uganda", "Westelijke Sahara", "Zambia", "Zimbabwe"
                };
                nationGroup = "Landen van Afrika";
                listOfSelectedNations.Sort(); // to get an alphabetical order
            }

            else if (Asia.IsSelected)
            {
                listOfSelectedNations = new List<string>
                {
                    "Afghanistan", "Armenië", "Azerbeidzjan", "Bahrein", "Bangladesh", "Bhutan", "Brunei", "Cambodja", "Cyprus", "Oost-Timor", "Egypte",
                    "Georgië", "India", "Indonesië", "Iran", "Irak", "Israel", "Japan", "Jordanië", "Kazachstan", "Koeweit", "Kyrgyzstan", "Laos", "Libanon",
                    "Maleisië", "Malediven", "Mongolië", "Myanmar", "Nepal", "Noord-Korea", "Oman", "Pakistan", "China (Volksrepubliek)", "Filipijnen", "Qatar",
                    "China (Republiek)", "Rusland", "Saudi-Arabië", "Singapore", "Zuid-Korea", "Sri Lanka", "Syrië", "Tadzjikistan", "Thailand", "Turkije",
                    "Turkmenistan", "Verenigde Arabische Emiraten", "Oezbekistan", "Vietnam", "Jemen"
                };
                nationGroup = "Landen van Azië";
                listOfSelectedNations.Sort();
            }

            else if (Europe.IsSelected)
            {
                listOfSelectedNations = new List<string>
                {
                    "Albanië", "Andorra", "Oostenrijk", "Wit-Rusland", "België", "Bosnië en Herzegovina", "Bulgarije", "Kroatië", "Tsjechië", "Denemarken",
                    "Estland", "Finland", "Frankrijk", "Duitsland", "Griekenland", "Hongarije", "IJsland", "Ierland", "Italië", "Kosovo", "Letland", "Liechtenstein",
                    "Litouwen", "Luxemburg", "Macedonië", "Malta", "Moldavië", "Monaco", "Montenegro", "Nederland", "Noorwegen", "Polen", "Portugal", "Roemenië",
                    "Rusland", "San Marino", "Servië", "Slowakije", "Slovenië", "Spanje", "Zweden", "Zwitserland", "Turkije", "Oekraïne", "Verenigd Koninkrijk",
                    "Vaticaanstad"

                };
                nationGroup = "Landen van Europa";
                listOfSelectedNations.Sort();
            }

            else if (NorthAmerica.IsSelected)
            {
                listOfSelectedNations = new List<string>
                {
                    "Antigua en Barbuda", "Bahama's", "Barbados", "Belize", "Canada", "Costa Rica", "Cuba", "Dominica", "Dominicaanse Republiek",
                    "El Salvador", "Grenada", "Guatemala", "Haïti", "Honduras", "Jamaica", "Mexico", "Nicaragua", "Panama", "Saint Kitts en Nevis",
                    "Saint Lucia", "Saint Vincent en de Grenadines", "Trinidad en Tobago", "Verenigde Staten"
                };
                nationGroup = "Landen van Noord-Amerika en de Caraïben";
                listOfSelectedNations.Sort();
            }

            else if (Oceania.IsSelected)
            {
                listOfSelectedNations = new List<string>
                {
                    "Australië", "Cookeilanden", "Oost-Timor", "Fiji", "Indonesië", "Kiribati", "Marshalleilanden", "Micronesië", "Nauru", "Nieuw-Zeeland",
                    "Niue", "Palau", "Papoea-Nieuw-Guinea", "Samoa", "Solomoneilanden", "Tonga", "Tuvalu", "Vanuatu"
                };
                nationGroup = "Landen van Oceanië";
                listOfSelectedNations.Sort();
            }

            else if (SouthAmerica.IsSelected)
            {
                listOfSelectedNations = new List<string>
                {
                    "Argentinië", "Bolivia", "Brazilië", "Chili", "Colombia", "Ecuador", "Guyana", "Paraguay", "Peru", "Suriname", "Trinidad en Tobago",
                    "Uruguay", "Venezuela"
                };
                nationGroup = "Landen van Zuid-Amerika";
                listOfSelectedNations.Sort();
            }

            else if (World.IsSelected)
            {
                listOfSelectedNations = new List<string>
                {
                    "Algerije","Angola", "Benin", "Botswana", "Burkina Faso", "Burundi", "Kameroen", "Kaapverdië", "Centraal Afrikaanse Republiek",
                    "Tsjaad", "Comoren", "Ivoorkust", "Democratische Republiek Congo", "Djibouti", "Egypte", "Equatoriaal-Guinea", "Eritrea",
                    "Ethiopië", "Gabon", "Gambia", "Ghana", "Guinea", "Guinea-Bissau", "Kenia", "Lesotho", "Liberia", "Libië", "Madagascar",
                    "Malawi", "Mali", "Mauretanië", "Mauritius", "Marokko", "Mozambique", "Namibië", "Niger", "Nigeria", "Republiek Congo",
                    "Rwanda", "Sao Tomé en Principe", "Senegal", "Seychellen", "Sierra Leone", "Somalië", "Zuid-Afrika", "Zuid-Sudan", "Sudan",
                    "Swaziland", "Tanzania", "Togo", "Tunesië", "Uganda", "Westelijke Sahara", "Zambia", "Zimbabwe",

                    "Afghanistan", "Armenië", "Azerbeidzjan", "Bahrein", "Bangladesh", "Bhutan", "Brunei", "Cambodja", "Cyprus", "Oost-Timor",
                    "Georgië", "India", "Indonesië", "Iran", "Irak", "Israel", "Japan", "Jordanië", "Kazachstan", "Koeweit", "Kyrgyzstan", "Laos", "Libanon",
                    "Maleisië", "Malediven", "Mongolië", "Myanmar", "Nepal", "Noord-Korea", "Oman", "Pakistan", "China (Volksrepubliek)", "Filipijnen", "Qatar",
                    "China (Republiek)", "Rusland", "Saudi-Arabië", "Singapore", "Zuid-Korea", "Sri Lanka", "Syrië", "Tadzjikistan", "Thailand", "Turkije",
                    "Turkmenistan", "Verenigde Arabische Emiraten", "Oezbekistan", "Vietnam", "Jemen",

                    "Albanië", "Andorra", "Oostenrijk", "Wit-Rusland", "België", "Bosnië en Herzegovina", "Bulgarije", "Kroatië", "Tsjechië", "Denemarken",
                    "Estland", "Finland", "Frankrijk", "Duitsland", "Griekenland", "Hongarije", "IJsland", "Ierland", "Italië", "Kosovo", "Letland", "Liechtenstein",
                    "Litouwen", "Luxemburg", "Macedonië", "Malta", "Moldavië", "Monaco", "Montenegro", "Nederland", "Noorwegen", "Polen", "Portugal", "Roemenië",
                    "San Marino", "Servië", "Slowakije", "Slovenië", "Spanje", "Zweden", "Zwitserland", "Oekraïne", "Verenigd Koninkrijk",
                    "Vaticaanstad",

                    "Antigua en Barbuda", "Bahama's", "Barbados", "Belize", "Canada", "Costa Rica", "Cuba", "Dominica", "Dominicaanse Republiek",
                    "El Salvador", "Grenada", "Guatemala", "Haïti", "Honduras", "Jamaica", "Mexico", "Nicaragua", "Panama", "Saint Kitts en Nevis",
                    "Saint Lucia", "Saint Vincent en de Grenadines", "Trinidad en Tobago", "Verenigde Staten",

                    "Australië", "Cookeilanden", "Fiji", "Kiribati", "Marshalleilanden", "Micronesië", "Nauru", "Nieuw-Zeeland",
                    "Niue", "Palau", "Papoea-Nieuw-Guinea", "Samoa", "Solomoneilanden", "Tonga", "Tuvalu", "Vanuatu",

                    "Argentinië", "Bolivia", "Brazilië", "Chili", "Colombia", "Ecuador", "Guyana", "Paraguay", "Peru", "Suriname",
                    "Uruguay", "Venezuela"
                };
                nationGroup = "Alle landen van de wereld";
                listOfSelectedNations.Sort();
            }

            else
            {
                listOfSelectedNations = new List<string>
                {
                    "Nederland", "België", "Luxemburg", "Duitsland", "Zweden", "Verenigd Koninkrijk", "Frankrijk", "Spanje", "Italië", "Verenigde Staten",
                    "Canada", "Brazilië", "Argentinië", "Rusland", "India", "China (Volksrepubliek)", "Japan", "Zuid-Korea", "Australië", "Nieuw-Zeeland",
                };
                nationGroup = "";
                // This list of well know countries and flags is used for the start screen
            }
        }

        // METHOD TO IMPORT (IMAGE) FILES
        internal static class ResourceAccessor
        {
            public static Uri Get(string resourcePath)
            {
                var uri = string.Format
                    ("pack://application:,,,/{0};component/{1}"
                     , Assembly.GetExecutingAssembly().GetName().Name
                     , resourcePath);

                return new Uri(uri);
            }
        }

        // SET NATION FLAGS AND LABELS AND ADD TO GRID

        // Margins to use for blocks of flags and labels
        public int marginTop_flagsAndLabels = 350;
        public int marginHorizontallyInBetween_flagsAndLabels = 100;
        public int marginVerticallyInBetween_flagsAndLabels = 225;

        // Scalingfactor for the size of the controls
        public double scalingFactor = 1.17;

        // Lists with all flags and labels (for the purpose of removal)
        public List<Image> allFlags;
        public List<TextBlock> allFlagLabels;

        private void SetNationFlagsAndLabels()
        {
            allFlags = new List<Image>();
            allFlagLabels = new List<TextBlock>();

            // 1st flag and label in row
            for (int i = 0; i < listOfSelectedNations.Count; i += 4)
            {
                // Add images with nation flags
                Image image_flagOfNation = new Image();

                image_flagOfNation.Name = $"image_flagOfNation{i + 1}"; // a name is given here, but for the purpose of this program this would not have been necessary
                image_flagOfNation.Source = new BitmapImage(ResourceAccessor.Get($"Flags/{listOfSelectedNations[i]}.png"));
                allFlags.Add(image_flagOfNation);

                image_flagOfNation.Width = 170 * scalingFactor;
                image_flagOfNation.Height = 112 * scalingFactor;
                image_flagOfNation.VerticalAlignment = VerticalAlignment.Top;
                image_flagOfNation.HorizontalAlignment = HorizontalAlignment.Left;
                image_flagOfNation.Stretch = Stretch.Fill; // this is done to create flags of the same size, which looks better in the overview
                image_flagOfNation.StretchDirection = StretchDirection.DownOnly;

                image_flagOfNation.Margin = new Thickness(
                    marginLeft, 
                    marginTop_flagsAndLabels + (i / 4 * marginVerticallyInBetween_flagsAndLabels), 
                    0, 
                    0
                    );

                // Add image to grid
                MyGrid.Children.Add(image_flagOfNation);

                // Add textblocks with nation name
                TextBlock textBlock_nameOfNation = new TextBlock();

                textBlock_nameOfNation.Name = $"textBlock_nameOfNation{i + 1}"; // a name is given here, but for the purpose of this program this would not have been necessary
                textBlock_nameOfNation.Text = $"{listOfSelectedNations[i]}";
                allFlagLabels.Add(textBlock_nameOfNation);

                textBlock_nameOfNation.Width = 170 * scalingFactor;
                textBlock_nameOfNation.Height = 56;
                textBlock_nameOfNation.VerticalAlignment = VerticalAlignment.Top;
                textBlock_nameOfNation.HorizontalAlignment = HorizontalAlignment.Left;
                textBlock_nameOfNation.TextAlignment = TextAlignment.Center;
                textBlock_nameOfNation.FontFamily = new FontFamily("Segoe UI");
                textBlock_nameOfNation.FontSize = 13;
                textBlock_nameOfNation.FontWeight = FontWeights.SemiBold;
                textBlock_nameOfNation.Foreground = new SolidColorBrush(Colors.Black);
                textBlock_nameOfNation.Background = new SolidColorBrush(Color.FromRgb(250, 241, 218));

                textBlock_nameOfNation.Margin = new Thickness(
                    marginLeft, 
                    marginTop_flagsAndLabels + image_flagOfNation.Height + ((i / 4 * marginVerticallyInBetween_flagsAndLabels) + 10), 
                    0, 
                    0
                    );

                // Add textblock to grid
                MyGrid.Children.Add(textBlock_nameOfNation);
            }

            // 2nd flag and label in row
            for (int i = 1; i < listOfSelectedNations.Count; i += 4)
            {
                // Add images with nation flags
                Image image_flagOfNation = new Image();

                image_flagOfNation.Name = $"image_flagOfNation{i + 1}";
                image_flagOfNation.Source = new BitmapImage(ResourceAccessor.Get($"Flags/{listOfSelectedNations[i]}.png"));
                allFlags.Add(image_flagOfNation);

                image_flagOfNation.Width = 170 * scalingFactor;
                image_flagOfNation.Height = 112 * scalingFactor;
                image_flagOfNation.VerticalAlignment = VerticalAlignment.Top;
                image_flagOfNation.HorizontalAlignment = HorizontalAlignment.Left;
                image_flagOfNation.Stretch = Stretch.Fill; 
                image_flagOfNation.StretchDirection = StretchDirection.DownOnly;

                image_flagOfNation.Margin = new Thickness(
                     marginLeft + (image_flagOfNation.Width + marginHorizontallyInBetween_flagsAndLabels), 
                     marginTop_flagsAndLabels + ((i - 1) / 4 * marginVerticallyInBetween_flagsAndLabels), 
                     0, 
                     0
                     );

                // Add image to grid
                MyGrid.Children.Add(image_flagOfNation);

                // Add textblocks with nation name
                TextBlock textBlock_nameOfNation = new TextBlock();

                textBlock_nameOfNation.Name = $"textBlock_nameOfNation{i + 1}";
                textBlock_nameOfNation.Text = $"{listOfSelectedNations[i]}";
                allFlagLabels.Add(textBlock_nameOfNation);

                textBlock_nameOfNation.Width = 170 * scalingFactor;
                textBlock_nameOfNation.Height = 56;
                textBlock_nameOfNation.VerticalAlignment = VerticalAlignment.Top;
                textBlock_nameOfNation.HorizontalAlignment = HorizontalAlignment.Left;
                textBlock_nameOfNation.TextAlignment = TextAlignment.Center;
                textBlock_nameOfNation.FontFamily = new FontFamily("Segoe UI");
                textBlock_nameOfNation.FontSize = 13;
                textBlock_nameOfNation.FontWeight = FontWeights.SemiBold;
                textBlock_nameOfNation.Foreground = new SolidColorBrush(Colors.Black);
                textBlock_nameOfNation.Background = new SolidColorBrush(Color.FromRgb(250, 241, 218));

                textBlock_nameOfNation.Margin = new Thickness(
                     marginLeft + (image_flagOfNation.Width + marginHorizontallyInBetween_flagsAndLabels), 
                     marginTop_flagsAndLabels + image_flagOfNation.Height + (((i - 1) / 4 * marginVerticallyInBetween_flagsAndLabels) + 10), 
                     0, 
                     0
                     );

                // Add textblock to grid
                MyGrid.Children.Add(textBlock_nameOfNation);
            }

            // 3rd flag and label in row
            for (int i = 2; i < listOfSelectedNations.Count; i += 4)
            {
                // Add images with nation flags
                Image image_flagOfNation = new Image();

                image_flagOfNation.Name = $"image_flagOfNation{i + 1}";
                image_flagOfNation.Source = new BitmapImage(ResourceAccessor.Get($"Flags/{listOfSelectedNations[i]}.png"));
                allFlags.Add(image_flagOfNation);

                image_flagOfNation.Width = 170 * scalingFactor;
                image_flagOfNation.Height = 112 * scalingFactor;
                image_flagOfNation.VerticalAlignment = VerticalAlignment.Top;
                image_flagOfNation.HorizontalAlignment = HorizontalAlignment.Left;
                image_flagOfNation.Stretch = Stretch.Fill;
                image_flagOfNation.StretchDirection = StretchDirection.DownOnly;

                image_flagOfNation.Margin = new Thickness(
                       marginLeft + (2 * (image_flagOfNation.Width + marginHorizontallyInBetween_flagsAndLabels)),
                       marginTop_flagsAndLabels + ((i - 2) / 4 * marginVerticallyInBetween_flagsAndLabels), 
                       0, 
                       0
                       );

                // Add image to grid
                MyGrid.Children.Add(image_flagOfNation);

                // Add textblocks with nation name
                TextBlock textBlock_nameOfNation = new TextBlock();

                textBlock_nameOfNation.Name = $"textBlock_nameOfNation{i + 1}";
                textBlock_nameOfNation.Text = $"{listOfSelectedNations[i]}";
                allFlagLabels.Add(textBlock_nameOfNation);

                textBlock_nameOfNation.Width = 170 * scalingFactor;
                textBlock_nameOfNation.Height = 56;
                textBlock_nameOfNation.VerticalAlignment = VerticalAlignment.Top;
                textBlock_nameOfNation.HorizontalAlignment = HorizontalAlignment.Left;
                textBlock_nameOfNation.TextAlignment = TextAlignment.Center;
                textBlock_nameOfNation.FontFamily = new FontFamily("Segoe UI");
                textBlock_nameOfNation.FontSize = 13;
                textBlock_nameOfNation.FontWeight = FontWeights.SemiBold;
                textBlock_nameOfNation.Foreground = new SolidColorBrush(Colors.Black);
                textBlock_nameOfNation.Background = new SolidColorBrush(Color.FromRgb(250, 241, 218));

                textBlock_nameOfNation.Margin = new Thickness(
                     marginLeft + (2 * (image_flagOfNation.Width + marginHorizontallyInBetween_flagsAndLabels)),
                     marginTop_flagsAndLabels + image_flagOfNation.Height + (((i - 2) / 4 * marginVerticallyInBetween_flagsAndLabels) + 10), 
                     0, 
                     0
                     );

                // Add textblock to grid
                MyGrid.Children.Add(textBlock_nameOfNation);
            }

            // 4th flag and label in row
            for (int i = 3; i < listOfSelectedNations.Count; i += 4)
            {
                // Add images with nation flags
                Image image_flagOfNation = new Image();

                image_flagOfNation.Name = $"image_flagOfNation{i + 1}";
                image_flagOfNation.Source = new BitmapImage(ResourceAccessor.Get($"Flags/{listOfSelectedNations[i]}.png"));
                allFlags.Add(image_flagOfNation);

                image_flagOfNation.Width = 170 * scalingFactor;
                image_flagOfNation.Height = 112 * scalingFactor;
                image_flagOfNation.VerticalAlignment = VerticalAlignment.Top;
                image_flagOfNation.HorizontalAlignment = HorizontalAlignment.Left;
                image_flagOfNation.Stretch = Stretch.Fill;
                image_flagOfNation.StretchDirection = StretchDirection.DownOnly;

                image_flagOfNation.Margin = new Thickness(
                    marginLeft + (3 * (image_flagOfNation.Width + marginHorizontallyInBetween_flagsAndLabels)),
                    marginTop_flagsAndLabels + ((i - 3) / 4 * marginVerticallyInBetween_flagsAndLabels), 
                    0, 
                    0);

                // Add image to grid
                MyGrid.Children.Add(image_flagOfNation);

                // Add textblocks with nation name
                TextBlock textBlock_nameOfNation = new TextBlock();

                textBlock_nameOfNation.Name = $"textBlock_nameOfNation{i + 1}";
                textBlock_nameOfNation.Text = $"{listOfSelectedNations[i]}";
                allFlagLabels.Add(textBlock_nameOfNation);

                textBlock_nameOfNation.Width = 170 * scalingFactor;
                textBlock_nameOfNation.Height = 56;
                textBlock_nameOfNation.VerticalAlignment = VerticalAlignment.Top;
                textBlock_nameOfNation.HorizontalAlignment = HorizontalAlignment.Left;
                textBlock_nameOfNation.TextAlignment = TextAlignment.Center;
                textBlock_nameOfNation.FontFamily = new FontFamily("Segoe UI");
                textBlock_nameOfNation.FontSize = 13;
                textBlock_nameOfNation.FontWeight = FontWeights.SemiBold;
                textBlock_nameOfNation.Foreground = new SolidColorBrush(Colors.Black);
                textBlock_nameOfNation.Background = new SolidColorBrush(Color.FromRgb(250, 241, 218));

                textBlock_nameOfNation.Margin = new Thickness(
                      marginLeft + (3 * (image_flagOfNation.Width + marginHorizontallyInBetween_flagsAndLabels)),
                      marginTop_flagsAndLabels + image_flagOfNation.Height + (((i - 3) / 4 * marginVerticallyInBetween_flagsAndLabels) + 10), 
                      0, 
                      0
                      );

                // Add textblock to grid
                MyGrid.Children.Add(textBlock_nameOfNation);
            }
        }

        // BOOLEANS USED FOR QUIZ
        public bool quizIsRunning = false;
        public bool isFirstQuizQuestion;

        // COMBOBOX SELECTION CHANGE
        private void ComboBox_selectNations_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Preset
            RemoveAllFlagsAndLabels();
            listOfSelectedNations.Clear();

            // Set flags and labels (when quiz is not running)
            if (quizIsRunning == false)
            {
                CreateListOfSelectedNations();
                SetNationFlagsAndLabels();
                textBlock_selectedNationGroup.Text = nationGroup;
            }

            // When quiz is running...
            if (quizIsRunning == true)
            {
                // Resets
                listOfNationsReorderedForQuiz.Clear();
                listOfQuizTextBlocks.Clear();
                listOfQuizAnswerBlocks.Clear();
                isFirstQuizQuestion = true;
                numOfQuestionsCorrectlyAnswered = 0;
                textBlock_numOfQuestionsCorrect.Text = $"{numOfQuestionsCorrectlyAnswered}  Goed";
                numOfQuestionsWronglyAnswered = 0;
                textBlock_numOfQuestionsWrong.Text = $"{numOfQuestionsWronglyAnswered}  Fout";
                textBlock_showNextQuestion.IsEnabled = true;

                // New selection, new lists, new flag, new question
                CreateListOfSelectedNations();
                ReorderListOfSelectedNationsForQuiz();
                CreateListOfQuizTextBlocks();
                ShowNewFlagForQuiz();
                ShowNewQuizQuestion();

                // Hide combobox, while playing
                comboBox_selectNations.Visibility = Visibility.Hidden;
                textBlock_selectNations.Text = "";

                // Show text nationgroup
                textBlock_selectedNationGroup.Text = nationGroup;
                textBlock_selectedNationGroup.Visibility = Visibility.Visible;
                textBlock_selectedNationGroup.Margin = new Thickness(
                    marginLeft,
                    marginTop + 60,
                    0,
                    0
                    );
            }
        }

        // TEXTBLOCK QUIZ (to start quiz)
        private void TextBlock_quiz_MouseEnter(object sender, MouseEventArgs e)
        { textBlock_quiz.Foreground = new SolidColorBrush(Colors.Crimson); }

        private void TextBlock_quiz_MouseLeave(object sender, MouseEventArgs e)
        { textBlock_quiz.Foreground = new SolidColorBrush(Colors.Red); }

        private void TextBlock_quiz_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Wil je de vlaggenquiz spelen?", "Vlaggenquiz", MessageBoxButton.YesNo);

            if (result == MessageBoxResult.Yes)
            {
                SetQuizStartScreen();
                quizIsRunning = true;
            }
            else
            {
                // Ignore
            }
        }

        // SET QUIZ START SCREEN
        private void SetQuizStartScreen()
        {
            // Selected index combobox
            comboBox_selectNations.SelectedIndex = -1;
            // COMMENTARY:This operation clears the comboBox selection. 
            // It should remain the first operation in this method, otherwise flags and labels are set again.

            // Resets
            ClearScreenForQuiz();

            // Show
            textBlock_title.Text = "VLAGGENQUIZ";
            textBlock_selectNations.Text = "Kies voor welke landen je de quiz wilt spelen";
            comboBox_selectNations.Visibility = Visibility.Visible;
        }

        // REMOVE ALL FLAGS AND LABELS
        private void RemoveAllFlagsAndLabels()
        {
            foreach (Image flag in allFlags) { flag.Visibility = Visibility.Collapsed; }
            foreach (TextBlock flagLabel in allFlagLabels) { flagLabel.Visibility = Visibility.Collapsed; }
            foreach (TextBlock block in listOfQuizTextBlocks) { block.Visibility = Visibility.Hidden; }
            foreach (TextBlock block in listOfQuizAnswerBlocks) { block.Visibility = Visibility.Hidden; }
        }

        // CLEAR SCREEN FOR QUIZ
        private void ClearScreenForQuiz()
        {
            foreach (Image flag in allFlags) { flag.Visibility = Visibility.Hidden; }
            foreach (TextBlock flagLabel in allFlagLabels) { flagLabel.Visibility = Visibility.Hidden; }
            foreach (TextBlock block in listOfQuizTextBlocks) { block.Visibility = Visibility.Hidden; }
            foreach (TextBlock block in listOfQuizAnswerBlocks) { block.Visibility = Visibility.Hidden; }

            textBlock_toQuiz.Visibility = Visibility.Hidden;
            textBlock_quiz.Visibility = Visibility.Hidden;
            textBlock_selectedNationGroup.Visibility = Visibility.Hidden;
        }

        // REORDER LIST OF SELECTED NATIONS FOR QUIZ
        public List<string> listOfNationsReorderedForQuiz = new List<string>();

        private void ReorderListOfSelectedNationsForQuiz()  
        {
            Random random = new Random();
            List<int> listOfNumbers = new List<int>();
            int number;
            string nation;
           
            for (int i = 0; i < listOfSelectedNations.Count; i ++)
            {
                do
                {
                    number = random.Next(0, listOfSelectedNations.Count);
                }
                while (listOfNumbers.Contains(number));
                listOfNumbers.Add(number);

                nation = listOfSelectedNations[number];

                listOfNationsReorderedForQuiz.Add(nation);
            }
            // COMMENTARY:
            // In the method above at random a new order is created, which is stored in a list, to show the flags of the selected 
            // nations. Random repeat is prevented with the 'do-while'.
            // So the order of the flags/countries is already determined before the quiz starts.
        }


        // SHOW NEW FLAG FOR QUIZ
        public int flagNumberForQuiz;   // to keep track of the number of flags shown (of the selected nations)

        private void ShowNewFlagForQuiz() 
        {
            // Presets
            foreach (Image flag in allFlags) { flag.Visibility = Visibility.Hidden; }
            double scalingFactor = 2.05;

            if (isFirstQuizQuestion == true)
            {
                flagNumberForQuiz = 0;
            }

            // Number of flags
            int numOfFlags = listOfNationsReorderedForQuiz.Count;

            if (flagNumberForQuiz < numOfFlags)
            {
                // Add image of a flag
                Image image_flagOfNation = new Image
                {
                    Source = new BitmapImage(ResourceAccessor.Get($"Flags/{listOfNationsReorderedForQuiz[flagNumberForQuiz]}.png")),

                    Width = 170 * scalingFactor,
                    Height = 112 * scalingFactor,
                    VerticalAlignment = VerticalAlignment.Top,
                    HorizontalAlignment = HorizontalAlignment.Left,
                    //Stretch = Stretch.Fill,  // Not used here to show all flags with the real/correct aspect ratio

                    Margin = new Thickness(
                    marginLeft,
                    marginTop_flagsAndLabels,
                    0,
                    0
                    )
                };

                MyGrid.Children.Add(image_flagOfNation);
                allFlags.Add(image_flagOfNation);

                // FOR TESTING ONLY
                // Add textblock with nation name
                /*
                TextBlock textBlock_nameOfNation = new TextBlock
                {
                    Text = $"{listOfNationsReorderedForQuiz[flagNumberForQuiz]}",

                    Width = 170 * scalingFactor,
                    Height = 56,

                    VerticalAlignment = VerticalAlignment.Top,
                    HorizontalAlignment = HorizontalAlignment.Left,
                    TextAlignment = TextAlignment.Center,
                    FontFamily = new FontFamily("Segoe UI"),
                    FontSize = 13,
                    FontWeight = FontWeights.SemiBold,
                    Foreground = new SolidColorBrush(Colors.Black),
                    Background = new SolidColorBrush(Color.FromRgb(250, 241, 218)),

                    Margin = new Thickness(
                    marginLeft,
                    marginTop_flagsAndLabels + image_flagOfNation.Height + 10,
                    0,
                    0
                    )
                };

                MyGrid.Children.Add(textBlock_nameOfNation);
                */
            }
            else
            {
                // Ignore
            }

            // Set first quiz question to false
            isFirstQuizQuestion = false;
        }


        // SHOW NEW QUIZ QUESTION

        // Lists
        public List<TextBlock> listOfQuizTextBlocks = new List<TextBlock>();
        public List<TextBlock> listOfQuizAnswerBlocks = new List<TextBlock>();

        // Create list of textblocks used for the quiz
        private void CreateListOfQuizTextBlocks()
        {
            // Add quiz textblocks to list
            listOfQuizTextBlocks = new List<TextBlock>()
            {
                textBlock_quizQuestion, textBlock_quizQuestionCounter,
                textBlock_quizAnswerNumber1, textBlock_quizAnswerNumber2, textBlock_quizAnswerNumber3, textBlock_quizAnswerNumber4,
                textBlock_quizAnswer1, textBlock_quizAnswer2, textBlock_quizAnswer3, textBlock_quizAnswer4,
                textBlock_numOfQuestionsCorrect, textBlock_numOfQuestionsWrong
            };

            // Add answer textblocks to specific list
            listOfQuizAnswerBlocks.Add(textBlock_quizAnswer1);
            listOfQuizAnswerBlocks.Add(textBlock_quizAnswer2);
            listOfQuizAnswerBlocks.Add(textBlock_quizAnswer3);
            listOfQuizAnswerBlocks.Add(textBlock_quizAnswer4);
        }

        // Method to show new question at random without repeat
        private void ShowNewQuizQuestion()
        {
            // Resets
            listOfQuizAnswerBlocks[0].Text = "";
            listOfQuizAnswerBlocks[1].Text = "";
            listOfQuizAnswerBlocks[2].Text = "";
            listOfQuizAnswerBlocks[3].Text = "";

            int a = 0;
            int b = 0;
            int c = 0;
            int d = 0;

            // Number of flags
            int numOfFlags = listOfNationsReorderedForQuiz.Count;

            if (flagNumberForQuiz < numOfFlags)
            {
                // Number of flags left
                int flagsLeft = numOfFlags - flagNumberForQuiz;

                // Count question number
                textBlock_quizQuestionCounter.Text = $"Vlag {flagNumberForQuiz + 1} van {numOfFlags}";

                // Add correct answer at random to textblocks
                Random random = new Random();
                int x = random.Next(0, 4);
                listOfQuizAnswerBlocks[x].Text = $"{listOfNationsReorderedForQuiz[flagNumberForQuiz]}";

                // Add the rest of the answers at random, without repeat
                if (x != 0)
                {
                    do
                    {
                        a = random.Next(0, numOfFlags);
                    }
                    while (a == flagNumberForQuiz);
                    listOfQuizAnswerBlocks[0].Text = $"{listOfNationsReorderedForQuiz[a]}";
                }
                if (x != 1)
                {
                    do
                    {
                        b = random.Next(0, numOfFlags);
                    }
                    while (b == flagNumberForQuiz || b == a);
                    listOfQuizAnswerBlocks[1].Text = $"{listOfNationsReorderedForQuiz[b]}";
                }
                if (x != 2)
                {
                    do
                    {
                        c = random.Next(0, numOfFlags);
                    }
                    while (c == flagNumberForQuiz || c == a || c == b);
                    listOfQuizAnswerBlocks[2].Text = $"{listOfNationsReorderedForQuiz[c]}";
                }
                if (x != 3)
                {
                    do
                    {
                        d = random.Next(0, numOfFlags);
                    }
                    while (d == flagNumberForQuiz || d == a || d == b || d == c);
                    listOfQuizAnswerBlocks[3].Text = $"{listOfNationsReorderedForQuiz[d]}";
                }
            }

            // Make textblocks and buttons visible
            foreach (TextBlock block in listOfQuizTextBlocks)
            {
                block.Visibility = Visibility.Visible;
            }
            button_startNewQuiz.Visibility = Visibility.Visible;
            button_startViewingFlags.Visibility = Visibility.Visible;

            // Enable answer textblocks
            foreach (TextBlock block in listOfQuizAnswerBlocks)
            {
                block.IsEnabled = true;
            }

            // The flagnumber needs to be increased by 1, before the program can go to the next question
            flagNumberForQuiz++;
        }


        // SHOW RESULT AFTER CLICKING/SELECTING AN ANSWER
        public int numOfQuestionsCorrectlyAnswered = 0;
        public int numOfQuestionsWronglyAnswered = 0;

        private void ShowResult(string nationClickedOn)
        {
            if (nationClickedOn == $"{listOfNationsReorderedForQuiz[flagNumberForQuiz - 1]}")
            {
                textBlock_quizAnswerResult.Text = "Goed beantwoord!";

                numOfQuestionsCorrectlyAnswered += 1;
                textBlock_numOfQuestionsCorrect.Text = $"{numOfQuestionsCorrectlyAnswered}  Goed";
            }

            if (nationClickedOn != $"{listOfNationsReorderedForQuiz[flagNumberForQuiz - 1]}")
            {
                textBlock_quizAnswerResult.Text = "Fout, dit is de vlag van ";

                textBlock_correctAnswer.Text = $"{listOfNationsReorderedForQuiz[flagNumberForQuiz - 1]}";
                textBlock_correctAnswer.Margin = new Thickness(733, 600, 0, 0);
                textBlock_correctAnswer.Visibility = Visibility.Visible;

                numOfQuestionsWronglyAnswered += 1;
                textBlock_numOfQuestionsWrong.Text = $"{numOfQuestionsWronglyAnswered}  Fout";
            }

            // Make textblocks visible
            textBlock_quizAnswerResult.Visibility = Visibility.Visible;
            textBlock_showNextQuestion.Visibility = Visibility.Visible;

            // Show next question
            textBlock_showNextQuestion.Text = "Toon de volgende vlag";
            textBlock_showNextQuestion.Foreground = new SolidColorBrush(Colors.Red);
            textBlock_showNextQuestion.IsEnabled = true;

            if (flagNumberForQuiz >= listOfNationsReorderedForQuiz.Count)
            {
                textBlock_showNextQuestion.Text = "Je hebt het einde van de quiz bereikt. Wil je opnieuw spelen?";
                textBlock_showNextQuestion.Foreground = new SolidColorBrush(Colors.Black);
                textBlock_showNextQuestion.TextDecorations = null;
                textBlock_showNextQuestion.IsEnabled = false;

                textBlock_playAgainYes.Visibility = Visibility.Visible;
                textBlock_playAgainNo.Visibility = Visibility.Visible;
            }

            // Disable answer textblocks
            foreach (TextBlock block in listOfQuizAnswerBlocks)
            {
                block.IsEnabled = false;
            }
        }


        // QUIZ ANSWER TEXTBLOCK MOUSEDOWN ACTIONS
        private void TextBlock_quizAnswer1_MouseDown(object sender, MouseButtonEventArgs e)
        { ShowResult(listOfQuizAnswerBlocks[0].Text); }

        private void TextBlock_quizAnswer2_MouseDown(object sender, MouseButtonEventArgs e)
        { ShowResult(listOfQuizAnswerBlocks[1].Text); }

        private void TextBlock_quizAnswer3_MouseDown(object sender, MouseButtonEventArgs e)
        { ShowResult(listOfQuizAnswerBlocks[2].Text); }

        private void TextBlock_quizAnswer4_MouseDown(object sender, MouseButtonEventArgs e)
        { ShowResult(listOfQuizAnswerBlocks[3].Text); }


        // SHOW NEXT QUESTION MOUSEDOWN ACTION
        private void TextBlock_showNextQuestion_MouseDown(object sender, MouseButtonEventArgs e)
        {
            ShowNewFlagForQuiz();
            ShowNewQuizQuestion();

            textBlock_quizAnswerResult.Visibility = Visibility.Hidden;
            textBlock_showNextQuestion.Visibility = Visibility.Hidden;
            textBlock_correctAnswer.Visibility = Visibility.Hidden;
            textBlock_playAgainYes.Visibility = Visibility.Hidden;
            textBlock_playAgainNo.Visibility = Visibility.Hidden;
        }


        // CHANGE AND SET BACK TEXT DECORATION AND COLOR QUIZ ANSWERS AT MOUSE ENTER AND MOUSE LEAVE
        private void ChangeTextDecorationAndColor(TextBlock block)
        {
            block.TextDecorations = TextDecorations.Underline;
            block.Foreground = new SolidColorBrush(Colors.Crimson);
        }

        private void SetBackToNormalTextDecorationAndColor(TextBlock block)
        {
            block.TextDecorations = null;
            block.Foreground = new SolidColorBrush(Colors.Red);
        }

        private void TextBlock_quizAnswer1_MouseEnter(object sender, MouseEventArgs e)
        { ChangeTextDecorationAndColor(textBlock_quizAnswer1); }

        private void TextBlock_quizAnswer1_MouseLeave(object sender, MouseEventArgs e)
        { SetBackToNormalTextDecorationAndColor(textBlock_quizAnswer1); }

        private void TextBlock_quizAnswer2_MouseEnter(object sender, MouseEventArgs e)
        { ChangeTextDecorationAndColor(textBlock_quizAnswer2); }

        private void TextBlock_quizAnswer2_MouseLeave(object sender, MouseEventArgs e)
        { SetBackToNormalTextDecorationAndColor(textBlock_quizAnswer2); }

        private void TextBlock_quizAnswer3_MouseEnter(object sender, MouseEventArgs e)
        { ChangeTextDecorationAndColor(textBlock_quizAnswer3); }

        private void TextBlock_quizAnswer3_MouseLeave(object sender, MouseEventArgs e)
        { SetBackToNormalTextDecorationAndColor(textBlock_quizAnswer3); }

        private void TextBlock_quizAnswer4_MouseEnter(object sender, MouseEventArgs e)
        { ChangeTextDecorationAndColor(textBlock_quizAnswer4); }

        private void TextBlock_quizAnswer4_MouseLeave(object sender, MouseEventArgs e)
        { SetBackToNormalTextDecorationAndColor(textBlock_quizAnswer4); }

        private void TextBlock_showNextQuestion_MouseEnter(object sender, MouseEventArgs e)
        { ChangeTextDecorationAndColor(textBlock_showNextQuestion); }

        private void TextBlock_showNextQuestion_MouseLeave(object sender, MouseEventArgs e)
        { SetBackToNormalTextDecorationAndColor(textBlock_showNextQuestion); }


        // TEXTBLOCK-BUTTONS: PLAY AGAIN? YES/NO

        // Mouse enter
        private void TextBlock_playAgainYes_MouseEnter(object sender, MouseEventArgs e)
        { textBlock_playAgainYes.Background = new SolidColorBrush(Colors.RosyBrown); }

        private void TextBlock_playAgainNo_MouseEnter(object sender, MouseEventArgs e)
        { textBlock_playAgainNo.Background = new SolidColorBrush(Colors.RosyBrown); }

        // Mouse leave
        private void TextBlock_playAgainYes_MouseLeave(object sender, MouseEventArgs e)
        { textBlock_playAgainYes.Background = new SolidColorBrush(Colors.Silver); }

        private void TextBlock_playAgainNo_MouseLeave(object sender, MouseEventArgs e)
        { textBlock_playAgainNo.Background = new SolidColorBrush(Colors.Silver); }

        // Mouse down
        private void TextBlock_playAgainYes_MouseDown(object sender, MouseButtonEventArgs e)
        {
            // Hide
            ClearScreenForQuiz();
            textBlock_quizAnswerResult.Visibility = Visibility.Hidden;
            textBlock_showNextQuestion.Visibility = Visibility.Hidden;
            textBlock_correctAnswer.Visibility = Visibility.Hidden;
            textBlock_playAgainYes.Visibility = Visibility.Hidden;
            textBlock_playAgainNo.Visibility = Visibility.Hidden;
            button_startNewQuiz.Visibility = Visibility.Hidden;
            button_startViewingFlags.Visibility = Visibility.Hidden;
            
            // Set quiz start
            SetQuizStartScreen();
        }

        private void TextBlock_playAgainNo_MouseDown(object sender, MouseButtonEventArgs e)
        {
            // Resets
            quizIsRunning = false;
            comboBox_selectNations.SelectedIndex = -1;

            // Hide
            textBlock_quizAnswerResult.Visibility = Visibility.Hidden;
            textBlock_showNextQuestion.Visibility = Visibility.Hidden;
            textBlock_correctAnswer.Visibility = Visibility.Hidden;
            textBlock_playAgainYes.Visibility = Visibility.Hidden;
            textBlock_playAgainNo.Visibility = Visibility.Hidden;
            button_startNewQuiz.Visibility = Visibility.Hidden;
            button_startViewingFlags.Visibility = Visibility.Hidden;
            RemoveAllFlagsAndLabels();

            // Show
            textBlock_toQuiz.Visibility = Visibility.Visible;
            textBlock_quiz.Visibility = Visibility.Visible;
            textBlock_selectedNationGroup.Visibility = Visibility.Visible;
            comboBox_selectNations.Visibility = Visibility.Visible;

            // Set start
            SetStartScreen();
        }

        // BUTTONS START NEW QUIZ & START FLAGVIEWING 
        private void Button_startNewQuiz_Click(object sender, RoutedEventArgs e)
        {
            // Hide
            ClearScreenForQuiz();
            textBlock_quizAnswerResult.Visibility = Visibility.Hidden;
            textBlock_showNextQuestion.Visibility = Visibility.Hidden;
            textBlock_correctAnswer.Visibility = Visibility.Hidden;
            textBlock_playAgainYes.Visibility = Visibility.Hidden;
            textBlock_playAgainNo.Visibility = Visibility.Hidden;
            button_startNewQuiz.Visibility = Visibility.Hidden;
            button_startViewingFlags.Visibility = Visibility.Hidden;

            // Set quiz start
            SetQuizStartScreen();
        }

        private void Button_startViewingFlags_Click(object sender, RoutedEventArgs e)
        {
            // Resets
            quizIsRunning = false;
            comboBox_selectNations.SelectedIndex = -1; 

            // Hide
            textBlock_quizAnswerResult.Visibility = Visibility.Hidden;
            textBlock_showNextQuestion.Visibility = Visibility.Hidden;
            textBlock_correctAnswer.Visibility = Visibility.Hidden;
            textBlock_playAgainYes.Visibility = Visibility.Hidden;
            textBlock_playAgainNo.Visibility = Visibility.Hidden;
            button_startNewQuiz.Visibility = Visibility.Hidden;
            button_startViewingFlags.Visibility = Visibility.Hidden;
            RemoveAllFlagsAndLabels();

            // Show
            textBlock_toQuiz.Visibility = Visibility.Visible;
            textBlock_quiz.Visibility = Visibility.Visible;
            textBlock_selectedNationGroup.Visibility = Visibility.Visible;
            comboBox_selectNations.Visibility = Visibility.Visible;

            // Set start
            SetStartScreen();
        }
    }
}















/*
// Add labels with nation name
Label label_nameOfNation = new Label();

Name = $"label_nameOfNation{i+1}";
label_nameOfNation.Content = $"{listOfSelectedNations[i]}";
label_nameOfNation.Width = 170;
label_nameOfNation.Height = 56;
label_nameOfNation.VerticalAlignment = VerticalAlignment.Top;
label_nameOfNation.HorizontalAlignment = HorizontalAlignment.Left;
label_nameOfNation.HorizontalContentAlignment = HorizontalAlignment.Center;
label_nameOfNation.VerticalContentAlignment = VerticalAlignment.Top;
label_nameOfNation.FontFamily = new FontFamily("Segoe UI");
label_nameOfNation.FontSize = 15;
label_nameOfNation.FontWeight = FontWeights.SemiBold;
label_nameOfNation.Foreground = new SolidColorBrush(Colors.Black);
label_nameOfNation.Background = new SolidColorBrush(Colors.White);
label_nameOfNation.Background = new SolidColorBrush(Color.FromRgb(250, 241, 218));

label_nameOfNation.Margin = new Thickness
    (marginLeft, marginTop_flagsAndLabels + image_flagOfNation.Height + ((i * 218) + 5), 0, 0);

MyGrid.Children.Add(label_nameOfNation);
*/






// RESEARCH

/*
MyModelObject stackPanelDataContext = new MyModelObject()
{

};

MyModelObject imageDataContext = new MyModelObject()
{

};

MyModelObject labelDataContext = new MyModelObject()
{
    Name = $"label_nation{n}"
};

//MyModelObject button1DataContext = new MyModelObject() { Name = "Button 1" };
//Button1.DataContext = button1DataContext;

class Guy
        {
            public Guy(string Name, int Age, decimal Cash)
            {
                Name = "?";
                Age = 0;
                Cash = 0.00M;
            }
        }
        
        private void UseBinding()
        {
            Guy joe = new Guy("Joe", 47, 325.50M);

            Binding cashBinding = new Binding();

            cashBinding.Path = new PropertyPath("Cash");

            cashBinding.Source = joe;

            //walletTextBlock.SetBinding(TextBlock.TextProperty, cashBinding);
        }
        */

/*
 private void ShowNewQuizQuestion()
    {
        /*
        // Add question
        TextBlock textBlock_quizQuestion = new TextBlock()
        {
            Text = "Van welk land is dit de vlag?",
            Margin = new Thickness(
                marginLeft + allFlags[0].ActualWidth + 200, 
                marginTop_flagsAndLabels - 10,
                0,
                0
                ),
            FontFamily = new FontFamily("Segoe UI"),
            FontSize = 24,
            FontWeight = FontWeights.SemiBold
        };
        MyGrid.Children.Add(textBlock_quizQuestion);
        */



//THIS DID NOT WORK!
/*
// Add answers number textblocks
List<string> alphabet = new List<string>() { "A)", "B)", "C)", "D)" };

for (int i = 0; i < 4; i++)
{
    TextBlock textBlock_quizAnswerNumber = new TextBlock
    {
        Name = $"textBlock_quizAnswerNumber{i + 1}",
        Text = alphabet[i],

        Margin = new Thickness(
        marginLeft + allFlags[0].ActualWidth + 200,
        marginTop_flagsAndLabels + 47 + (i * 47),
        0,
        0
        ),
        FontFamily = new FontFamily("Segoe UI"),
        FontSize = 24,
        FontWeight = FontWeights.SemiBold,
    };
    listOfQuizAnswerNumberBlocks.Add(textBlock_quizAnswerNumber);
    MyGrid.Children.Add(textBlock_quizAnswerNumber);
}



*/

/*
listOfQuizAnswerBlocks[0].Margin = new Thickness(
   marginLeft + allFlags[0].ActualWidth + 200 + 40,
   marginTop_flagsAndLabels + 47 + (0 * 47),
   0,
   0
   );

listOfQuizAnswerBlocks[i].Margin = new Thickness(
    marginLeft + allFlags[0].ActualWidth + 200 + 40,
    marginTop_flagsAndLabels + 47 + (i * 47),
    0,
    0
    );
   */


/*
for (int i = 0; i < 4; i++)
{
    listOfQuizAnswerBlocks[i].FontFamily = new FontFamily("Segoe UI");
    listOfQuizAnswerBlocks[i].FontSize = 24;
    listOfQuizAnswerBlocks[i].FontWeight = FontWeights.SemiBold;
    listOfQuizAnswerBlocks[i].Visibility = Visibility.Visible;
    listOfQuizAnswerBlocks[i].Focus();
}
*/




/*
foreach (TextBlock in )

    TextBlock textBlock_quizAnswer = new TextBlock
    {
        Name = $"textBlock_quizAnswer{i + 1}",

        Margin = new Thickness(
        marginLeft + allFlags[0].ActualWidth + 200 + 40,
        marginTop_flagsAndLabels + 47 + (i * 47),
        0,
        0
        ),
        FontFamily = new FontFamily("Segoe UI"),
        FontSize = 24,
        FontWeight = FontWeights.SemiBold,
    };
    listOfQuizAnswerBlocks.Add(textBlock_quizAnswer);
    MyGrid.Children.Add(textBlock_quizAnswer);
}

/*
// Set textBlock_quizAnswer 1, 2, 3 and 4
textBlock_quizAnswer1.Margin = new Thickness(
       marginLeft + allFlags[0].ActualWidth + 200 + 40,
           marginTop_flagsAndLabels + 47 + (0 * 47),
           0,
           0
       );
textBlock_quizAnswer1.FontFamily = new FontFamily("Segoe UI");
textBlock_quizAnswer1.FontSize = 24;
textBlock_quizAnswer1.FontWeight = FontWeights.SemiBold;
/*

// Add answer textblocks to list
listOfQuizAnswerBlocks.Add(textBlock_quizAnswer1);
            listOfQuizAnswerBlocks.Add(textBlock_quizAnswer2);
            listOfQuizAnswerBlocks.Add(textBlock_quizAnswer3);
            listOfQuizAnswerBlocks.Add(textBlock_quizAnswer4);

            // Add correct answer
            Random random = new Random();
int x = random.Next(0, 4);
listOfQuizAnswerBlocks[x].Text = $"{listOfNationsReorderedForQuiz[flagNumberForQuiz]}";

            // Add the rest of the answers
            List<int> listOfNumbersUsed = new List<int>();

            if (listOfQuizAnswerBlocks[0] != listOfQuizAnswerBlocks[x])
            {
                a = random.Next(flagNumberForQuiz + 1, listOfNationsReorderedForQuiz.Count);
                listOfQuizAnswerBlocks[0].Text = $"{listOfNationsReorderedForQuiz[a]}";
                listOfNumbersUsed.Add(a);
                //MessageBox.Show(a.ToString());
            }

            if (listOfQuizAnswerBlocks[1] != listOfQuizAnswerBlocks[x])
            {
                do
                {
                    b = random.Next(flagNumberForQuiz + 1, listOfNationsReorderedForQuiz.Count);
                }
                while (b == a);

                listOfQuizAnswerBlocks[1].Text = $"{listOfNationsReorderedForQuiz[b]}";
                listOfNumbersUsed.Add(b);
                //MessageBox.Show(b.ToString());
            }

            if (listOfQuizAnswerBlocks[2] != listOfQuizAnswerBlocks[x])
            {
                do
                {
                    c = random.Next(flagNumberForQuiz + 1, listOfNationsReorderedForQuiz.Count);
                }
                while (c == a || c == b);

                listOfQuizAnswerBlocks[2].Text = $"{listOfNationsReorderedForQuiz[c]}"; 
                listOfNumbersUsed.Add(c);
                //MessageBox.Show(c.ToString());
            }

            if (listOfQuizAnswerBlocks[3] != listOfQuizAnswerBlocks[x])
            {
                do
                {
                    d = random.Next(flagNumberForQuiz + 1, listOfNationsReorderedForQuiz.Count);
                }
                while (d == a || d == b || d == c);

                listOfQuizAnswerBlocks[3].Text = $"{listOfNationsReorderedForQuiz[d]}";
                listOfNumbersUsed.Add(d);
                //MessageBox.Show(d.ToString());
            }

            // The flagnumber needs to be increased by 1, before the program can go to the next question
            flagNumberForQuiz += 1;
        }

       

        

        private void TextBlock_quizAnswer1_MouseDown(object sender, MouseButtonEventArgs e)
{
    MessageBox.Show("Hello");
}

private void TextBlock_quizAnswer2_MouseDown(object sender, MouseButtonEventArgs e)
{
    MessageBox.Show("Hello");
}

private void TextBlock_quizAnswer3_MouseDown(object sender, MouseButtonEventArgs e)
{
    MessageBox.Show("Hello");
}

private void TextBlock_quizAnswer4_MouseDown(object sender, MouseButtonEventArgs e)
{
    MessageBox.Show("Hello");
}
    }
}
*/

