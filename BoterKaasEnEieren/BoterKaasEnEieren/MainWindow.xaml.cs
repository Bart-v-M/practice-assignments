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
using System.Windows.Media.Effects;
using System.Diagnostics;
using System.Threading;

// Date: January/February 2019
// Source used for algorithms: "How to win at Tic-Tac-Toe" by Ryan Aycock (2002)

namespace BoterKaasEnEieren
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            HideNoughtsAndCrosses();
            ClearPlayerMoves();
            ClearFieldValues();
            DropShadowEffect(Label_Button_X);
            computer = Player.Noughts;
            playerToMove = Player.Crosses;
            startGame = true;
            gameOver = false;
        }

        private void HideNoughtsAndCrosses()
        {
            // All objects for showing noughts and crosses on the screen
            CrossRectangle1_A1.Visibility = Visibility.Hidden; CrossRectangle2_A1.Visibility = Visibility.Hidden; Circle_A1.Visibility = Visibility.Hidden;
            CrossRectangle1_B1.Visibility = Visibility.Hidden; CrossRectangle2_B1.Visibility = Visibility.Hidden; Circle_B1.Visibility = Visibility.Hidden;
            CrossRectangle1_C1.Visibility = Visibility.Hidden; CrossRectangle2_C1.Visibility = Visibility.Hidden; Circle_C1.Visibility = Visibility.Hidden;
            CrossRectangle1_A2.Visibility = Visibility.Hidden; CrossRectangle2_A2.Visibility = Visibility.Hidden; Circle_A2.Visibility = Visibility.Hidden;
            CrossRectangle1_B2.Visibility = Visibility.Hidden; CrossRectangle2_B2.Visibility = Visibility.Hidden; Circle_B2.Visibility = Visibility.Hidden;
            CrossRectangle1_C2.Visibility = Visibility.Hidden; CrossRectangle2_C2.Visibility = Visibility.Hidden; Circle_C2.Visibility = Visibility.Hidden;
            CrossRectangle1_A3.Visibility = Visibility.Hidden; CrossRectangle2_A3.Visibility = Visibility.Hidden; Circle_A3.Visibility = Visibility.Hidden;
            CrossRectangle1_B3.Visibility = Visibility.Hidden; CrossRectangle2_B3.Visibility = Visibility.Hidden; Circle_B3.Visibility = Visibility.Hidden;
            CrossRectangle1_C3.Visibility = Visibility.Hidden; CrossRectangle2_C3.Visibility = Visibility.Hidden; Circle_C3.Visibility = Visibility.Hidden;
        }


        // DETERMINE GAMETYPE SELECTION
        GameType gameType;

        enum GameType
        {
            Easy,
            Average,
            Hard,
            Invincible,
            PlayAgainstEachOther
        }

        private void DetermineGameTypeSelection()
        {
            if (ComboBoxItem1.IsSelected && gameType != GameType.Easy) { gameType = GameType.Easy; }
            if (ComboBoxItem2.IsSelected && gameType != GameType.Average) { gameType = GameType.Average; }
            if (ComboBoxItem3.IsSelected && gameType != GameType.Hard) { gameType = GameType.Hard; }
            if (ComboBoxItem4.IsSelected && gameType != GameType.Invincible) { gameType = GameType.Invincible; }
            if (ComboBoxItem5.IsSelected && gameType != GameType.PlayAgainstEachOther) { gameType = GameType.PlayAgainstEachOther; }
        }


        // START NEW GAME
        public bool startGame;

        private void StartNewGame()
        {
            HideNoughtsAndCrosses();
            ClearPlayerMoves();
            ClearFieldValues();
            DropShadowEffect(Label_Button_X);
            Label_Button_O.ClearValue(EffectProperty);

            DetermineGameTypeSelection();  

            playerToMove = Player.Crosses;

            if (comboBox_GameTypeText != "Speel tegen elkaar" || gameType != GameType.PlayAgainstEachOther)
            {
                UpdateInstructionLabel("Start spel of selecteer speler");
            }
            if (comboBox_GameTypeText == "Speel tegen elkaar" || gameType == GameType.PlayAgainstEachOther)
            {
                UpdateInstructionLabel("X is aan de beurt");
            }

            lossPrevented = false;
            certainWin = false;

            gameOver = false;
            startGame = true;
        }


        // GAME OVER BOOL
        public bool gameOver;  // If true a game cannot continue


        // CHANGE TURN
        private void ChangeTurn()
        {
            byte a = 0;

            if (playerToMove == Player.Crosses) { a = 0; }
            if (playerToMove == Player.Noughts) { a = 1; }

            if (a == 0)
            {
                UpdateInstructionLabel("О is aan de beurt");
                DropShadowEffect(Label_Button_O);
                Label_Button_X.ClearValue(EffectProperty);
                playerToMove = Player.Noughts;
            }
            if (a == 1)
            {
                UpdateInstructionLabel("X is aan de beurt");
                DropShadowEffect(Label_Button_X);
                Label_Button_O.ClearValue(EffectProperty);
                playerToMove = Player.Crosses;
            }
            // IMPORTANT: Keep the statements above as given, otherwise the program could fail.
        }

        Player playerToMove;
        Player computer;

        enum Player
        {
            Crosses,
            Noughts,
        }


        // COMBOBOX GAMETYPE
        public string comboBox_GameTypeText;
         
        // Change selection
        private void ComboBox_GameType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DetermineGameTypeSelection();

            if (ComboBoxItem1.IsSelected || ComboBoxItem2.IsSelected || ComboBoxItem3.IsSelected || ComboBoxItem4.IsSelected)
            {
                UpdateInstructionLabel("Start spel of selecteer speler");
                StartNewGame();
            }
            if (ComboBoxItem5.IsSelected)
            {
                UpdateInstructionLabel("X is aan de beurt");
                StartNewGame();
            }
            // IMPORTANT: These last if-statements are added to let the program work properly, when selecting another gametype. Do not change these.
        }


        // BUTTONS
        // Below labels are used to create buttons

        // BUTTON X
        private void Label_Button_X_MouseEnter(object sender, MouseEventArgs e)
        {
            if (startGame == true)
            {
                //if (comboBox_GameTypeText != "Speel tegen elkaar")
                if (gameType != GameType.PlayAgainstEachOther)
                {
                    DropShadowEffect(Label_Button_X);
                    Label_Button_O.ClearValue(EffectProperty);
                }
                else
                {
                    // Ignore
                }
            }
        }

        private void Label_Button_X_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (startGame == true)
            {
                if (gameType != GameType.PlayAgainstEachOther)
                {
                    DropShadowEffect(Label_Button_X);
                    Label_Button_O.ClearValue(EffectProperty);
                    UpdateInstructionLabel("Start spel of selecteer speler");

                    computer = Player.Noughts;
                    playerToMove = Player.Crosses;
                }
                else
                {
                    playerToMove = Player.Crosses;
                }
            }
        }

        
        // BUTTON O
        private void Label_Button_O_MouseEnter(object sender, MouseEventArgs e)
        {
            if (startGame == true)
            {
                if (gameType != GameType.PlayAgainstEachOther)
                {
                    DropShadowEffect(Label_Button_O);
                    Label_Button_X.ClearValue(EffectProperty);
                }
                if (gameType == GameType.PlayAgainstEachOther)
                {
                    // Ignore
                }
            }
        }

        private void Label_Button_O_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (startGame == true)
            {
                if (gameType != GameType.PlayAgainstEachOther)
                {
                    DropShadowEffect(Label_Button_O);
                    Label_Button_X.ClearValue(EffectProperty);
                    UpdateInstructionLabel("X is aan de beurt");

                    playerToMove = Player.Crosses;
                    computer = Player.Crosses;

                    ComputerTurn();
                }
                if (gameType == GameType.PlayAgainstEachOther)
                {
                    playerToMove = Player.Crosses;
                }
            }
        }


        // DROP SHADOW EFFECT
        private void DropShadowEffect(Label x)
        {
            // Get a reference to the Button.
            Label myLabel = new Label();

            // Initialize a new DropShadowBitmapEffect that will be applied to the Button.
            DropShadowEffect myDropShadowEffect = new DropShadowEffect();
            // Set the color of the shadow to Black.
            Color myShadowColor = new Color
            {
                ScA = 1,
                ScR = 0,
                ScG = 0,
                ScB = 0,
            };
            myDropShadowEffect.Color = myShadowColor;

            // Set the direction of where the shadow is cast to 320 degrees.
            myDropShadowEffect.Direction = 315;

            // Set the depth of the shadow being cast.
            myDropShadowEffect.ShadowDepth = 10;

            // Set the shadow opacity to half opaque or in other words - half transparent.
            // The range is 0-1.
            myDropShadowEffect.Opacity = 0.75;

            // Apply the bitmap effect to the Button.
            x.Effect = myDropShadowEffect;
        }


        // UPDATE INSTRUCTION LABEL
        private void UpdateInstructionLabel(string instruction)
        {
            InstructionLabel.Content = instruction;
        }

        // LABEL/BUTTON START NEW GAME
        private void Label_StartNewGame_MouseEnter(object sender, MouseEventArgs e)
        {
            Label_StartNewGame.Foreground = Brushes.White;
        }

        private void Label_StartNewGame_MouseLeave(object sender, MouseEventArgs e)
        {
            Label_StartNewGame.Foreground = Brushes.Black;
        }

        private void Label_StartNewGame_MouseDown(object sender, MouseButtonEventArgs e)
        {
            StartNewGame();
        }


        // GAMEBOARD FIELDS

        // The 9 fields of the gameboard are numbered 1 to 9. At the start of a game each field is given a value 0.
        // For reasons of symmetry the fields are numbered as follows:
        // 1 | 6 | 2
        // 5 | 9 | 7
        // 4 | 8 | 3
        //
        // To be able to implement an easy win/lose calculation, after each turn, a field covered by the player 
        // with Crosses (X) will be given the value 1 and a field covered by the player with Noughts (O) will
        // be given the value 4.

        // Corner fields
        public int field1 = 0; public int field2 = 0; public int field3 = 0; public int field4 = 0;

        // Side fields
        public int field5 = 0; public int field6 = 0; public int field7 = 0; public int field8 = 0;

        // Center field
        public int field9 = 0;


        // PLAYER MOVES

        // All moves are given the value 0 at start, because then the gameboard, and thus all fields, are still empty.
        // During the game the player moves will receive a value 1 to 9, according to the gameboard/field layout 
        // given above. The moves are numbered from 1 to 5 for X, and from 1 to 4 for O (because X always starts the 
        // game and has one move more).

        public int X1 = 0; public int X2 = 0; public int X3 = 0; public int X4 = 0; public int X5 = 0;
        public int O1 = 0; public int O2 = 0; public int O3 = 0; public int O4 = 0;


        // ASSIGN PLAYER MOVE
        private void AssignPlayerMove(int fieldNumber)
        {
            int sum = field1 + field2 + field3 + field4 + field5 + field6 + field7 + field8 + field9;

            if (sum == 1) { X1 = fieldNumber; }
            if (sum == 5) { O1 = fieldNumber; }
            if (sum == 6) { X2 = fieldNumber; }
            if (sum == 10) { O2 = fieldNumber; }
            if (sum == 11) { X3 = fieldNumber; }
            if (sum == 15) { O3 = fieldNumber; }
            if (sum == 16) { X4 = fieldNumber; }
            if (sum == 20) { O4 = fieldNumber; }
            if (sum == 21) { X5 = fieldNumber; }
        }


        // CLEAR PLAYER MOVES
        private void ClearPlayerMoves()
        {
            X1 = 0; X2 = 0; X3 = 0; X4 = 0; X5 = 0;
            O1 = 0; O2 = 0; O3 = 0; O4 = 0;
        }


        // CHECK FOR WINNER
        private void CheckForWinner()
        {
            // Gameresult: X wins
            if (gameOver == false 
                     && field1 + field6 + field2 == 3 || field5 + field9 + field7 == 3 || field4 + field8 + field3 == 3
                     || field1 + field5 + field4 == 3 || field6 + field9 + field8 == 3 || field2 + field7 + field3 == 3
                     || field1 + field9 + field3 == 3 || field4 + field9 + field2 == 3)
            {
                UpdateInstructionLabel("X wint!");
                gameOver = true;
            }
            // Gameresult: O wins
            else if (gameOver == false
                     && field1 + field6 + field2 == 12 || field5 + field9 + field7 == 12 || field4 + field8 + field3 == 12
                     || field1 + field5 + field4 == 12 || field6 + field9 + field8 == 12 || field2 + field7 + field3 == 12
                     || field1 + field9 + field3 == 12 || field4 + field9 + field2 == 12)
            {
                UpdateInstructionLabel("O wint!");
                gameOver = true;
            }
            // Gameresult: even 
            else if (gameOver == false
                     && field1 != 0 && field2 != 0 && field3 != 0 && field4 != 0
                     && field5 != 0 && field6 != 0 && field7 != 0 && field8 != 0
                     && field9 != 0)
            {
                UpdateInstructionLabel("Gelijkspel!");
                gameOver = true;
            }
            else
            {
                gameOver = false;
            }
        }


        // CLEAR FIELD VALUES
        private void ClearFieldValues()
        {
            field1 = 0; field2 = 0; field3 = 0; field4 = 0; field5 = 0; field6 = 0; field7 = 0; field8 = 0; field9 = 0;
        }


        // COMPUTER TURN
        private void ComputerTurn()
        {
            int sum = field1 + field2 + field3 + field4 + field5 + field6 + field7 + field8 + field9;

            if (sum == 0) { computer = Player.Crosses; }
            if (sum == 1) { computer = Player.Noughts; }

            if (gameType == GameType.Easy)
            {
                if (computer == Player.Crosses)
                {
                    if (X1 == 0) { ComputerMove_X1(); }
                    if (O1 != 0 && X2 == 0) { ComputerMove_X2_Easy(); }
                    if (O2 != 0 && X3 == 0) { ComputerMove_X3_Easy(); }
                    if (O3 != 0 && X4 == 0) { ComputerMove_X4_Easy(); }
                    if (O4 != 0 && X5 == 0) { ComputerMove_X5(); }
                }
                if (computer == Player.Noughts)
                {
                    if (X1 != 0 && O1 == 0) { ComputerMove_O1_Easy(); }
                    if (X2 != 0 && O2 == 0) { ComputerMove_O2_Easy(); }
                    if (X3 != 0 && O3 == 0) { ComputerMove_O3_Easy(); }
                    if (X4 != 0 && O4 == 0) { ComputerMove_O4_Easy(); }
                }
            }

            if (gameType == GameType.Average)
            {
                if (computer == Player.Crosses)
                {
                    if (X1 == 0) { ComputerMove_X1(); }
                    if (O1 != 0 && X2 == 0) { ComputerMove_X2_Average(); }
                    if (O2 != 0 && X3 == 0) { ComputerMove_X3_Average(); }
                    if (O3 != 0 && X4 == 0) { ComputerMove_X4_Average(); }
                    if (O4 != 0 && X5 == 0) { ComputerMove_X5(); }
                }
                if (computer == Player.Noughts)
                {
                    if (X1 != 0 && O1 == 0) { ComputerMove_O1_Average(); }
                    if (X2 != 0 && O2 == 0) { ComputerMove_O2_Average(); }
                    if (X3 != 0 && O3 == 0) { ComputerMove_O3_Average(); }
                    if (X4 != 0 && O4 == 0) { ComputerMove_O4_Average(); }
                }
            }

            if (gameType == GameType.Hard)
            {
                if (computer == Player.Crosses)
                {
                    if (X1 == 0) { ComputerMove_X1(); }
                    if (O1 != 0 && X2 == 0) { ComputerMove_X2_Hard(); }
                    if (O2 != 0 && X3 == 0) { ComputerMove_X3_Hard(); }
                    if (O3 != 0 && X4 == 0) { ComputerMove_X4_Hard(); }
                    if (O4 != 0 && X5 == 0) { ComputerMove_X5(); }
                }
                if (computer == Player.Noughts)
                {
                    if (X1 != 0 && O1 == 0) { ComputerMove_O1_Hard(); }
                    if (X2 != 0 && O2 == 0) { ComputerMove_O2_Hard(); }
                    if (X3 != 0 && O3 == 0) { ComputerMove_O3_Hard(); }
                    if (X4 != 0 && O4 == 0) { ComputerMove_O4_Hard(); }
                }
            }

            if (gameType == GameType.Invincible)
            {
                if (computer == Player.Crosses)
                {
                    if (X1 == 0) { ComputerMove_X1(); }
                    if (O1 != 0 && X2 == 0) { ComputerMove_X2_Invincible(); }
                    if (O2 != 0 && X3 == 0) { ComputerMove_X3_Invincible(); }
                    if (O3 != 0 && X4 == 0) { ComputerMove_X4_Invincible(); }
                    if (O4 != 0 && X5 == 0) { ComputerMove_X5(); }
                }
                if (computer == Player.Noughts)
                {
                    if (X1 != 0 && O1 == 0) { ComputerMove_O1_Invincible(); }
                    if (X2 != 0 && O2 == 0) { ComputerMove_O2_Invincible(); }
                    if (X3 != 0 && O3 == 0) { ComputerMove_O3_Invincible(); }
                    if (X4 != 0 && O4 == 0) { ComputerMove_O4_Invincible(); }
                }
            }
            if (gameType == GameType.PlayAgainstEachOther)
            {
                // Ignore
            }
        }


        // COMPUTER MOVES

        // COMPUTER MOVE X1
        private void ComputerMove_X1()
        {
            Random random = new Random();
            int fieldNumber = random.Next(1, 10);  // Should be in the range (1, 10), but for testing different numbers can be chosen
            SetInField(fieldNumber);

            // For testing purposes:
            //SetInField(1);
            //SetInField(2);
            //SetInField(3);
            //SetInField(4);
            //SetInField(5);
            //SetInField(6);
            //SetInField(7);
            //SetInField(8);
            //SetInField(9);
        }

        // COMPUTERMOVE X2 - GAMETYPE: INVINCIBLE
        private void ComputerMove_X2_Invincible()
        {
            // Determine and set move X2, after move O1, if move X1 is set in a cornerfield

            // Below gameboard symmetry is used to determine a fieldnumber for move O1, which
            // gives the relative gameboard position of O1 versus the moves X1 and X2.
            // This solution saves a lot of coding.

            // X2 if X1 is in a CORNERFIELD: 
            if (X1 == 1 || X1 == 2 || X1 == 3 || X1 == 4)
            {
                int fieldNumber_O1 = 0;
                int fieldNumber_X2 = 0;
                int a;

                a = X1 - 1;
                fieldNumber_O1 = O1 - a;

                // DETERMINE FIELD NUMBER
                // Cornerfields
                if (O1 == 1 || O1 == 2 || O1 == 3 || O1 == 4)
                {
                    if (fieldNumber_O1 == 0) { fieldNumber_O1 = 4; }
                    if (fieldNumber_O1 == -1) { fieldNumber_O1 = 3; }
                    if (fieldNumber_O1 == -2) { fieldNumber_O1 = 2; }
                }
                // Sidefields
                else if (O1 == 5 || O1 == 6 || O1 == 7 || O1 == 8)
                {
                    if (fieldNumber_O1 == 4) { fieldNumber_O1 = 8; }
                    if (fieldNumber_O1 == 3) { fieldNumber_O1 = 7; }
                    if (fieldNumber_O1 == 2) { fieldNumber_O1 = 6; }
                }
                // Centrefield
                else if (O1 == 9)
                {
                    if (fieldNumber_O1 < 9) { fieldNumber_O1 = 9; }
                }

                // DETERMINE MOVE X2
                if (fieldNumber_O1 == 4 || fieldNumber_O1 == 5 || fieldNumber_O1 == 7 || fieldNumber_O1 == 8)
                {
                    fieldNumber_X2 = 2 + a;
                    if (fieldNumber_X2 == 5) { fieldNumber_X2 = 1; }
                }
                else if (fieldNumber_O1 == 2 || fieldNumber_O1 == 9)
                {
                    fieldNumber_X2 = 3 + a;
                    if (fieldNumber_X2 == 5) { fieldNumber_X2 = 1; }
                    if (fieldNumber_X2 == 6) { fieldNumber_X2 = 2; }
                }
                else if (fieldNumber_O1 == 3 || fieldNumber_O1 == 6)
                {
                    fieldNumber_X2 = 4 + a;
                    if (fieldNumber_X2 == 5) { fieldNumber_X2 = 1; }
                    if (fieldNumber_X2 == 6) { fieldNumber_X2 = 2; }
                    if (fieldNumber_X2 == 7) { fieldNumber_X2 = 3; }
                }
                // SET MOVE X2
                SetInField(fieldNumber_X2);
            }

            // X2 if X1 is in a SIDEFIELD:
            if (X1 == 5 || X1 == 6 || X1 == 7 || X1 == 8)
            {
                int fieldNumber_O1 = 0;
                int fieldNumber_X2 = 0;
                int a;
                int x;

                a = X1 - 5;
                fieldNumber_O1 = O1 - a;

                // DETERMINE FIELD NUMBER
                // Cornerfields
                if (O1 == 1 || O1 == 2 || O1 == 3 || O1 == 4)
                {
                    if (fieldNumber_O1 == 0) { fieldNumber_O1 = 4; }
                    if (fieldNumber_O1 == -1) { fieldNumber_O1 = 3; }
                    if (fieldNumber_O1 == -2) { fieldNumber_O1 = 2; }
                }
                // Sidefields
                else if (O1 == 5 || O1 == 6 || O1 == 7 || O1 == 8)
                {
                    if (fieldNumber_O1 == 4) { fieldNumber_O1 = 8; }
                    if (fieldNumber_O1 == 3) { fieldNumber_O1 = 7; }
                    if (fieldNumber_O1 == 2) { fieldNumber_O1 = 6; }
                }
                // Centrefield
                else if (O1 == 9)
                {
                    if (fieldNumber_O1 < 9) { fieldNumber_O1 = 9; }
                }

                // DETERMINE MOVE X2
                if (fieldNumber_O1 == 1 || fieldNumber_O1 == 3)
                {
                    fieldNumber_X2 = 2 + a;
                    if (fieldNumber_X2 == 5) { fieldNumber_X2 = 1; }
                }
                if (fieldNumber_O1 == 2 || fieldNumber_O1 == 4 || fieldNumber_O1 == 7)
                {
                    fieldNumber_X2 = 3 + a;
                    if (fieldNumber_X2 == 5) { fieldNumber_X2 = 1; }
                    if (fieldNumber_X2 == 6) { fieldNumber_X2 = 2; }
                }
                if (fieldNumber_O1 == 6)
                {
                    Random random = new Random();
                    x = random.Next(0, 2);

                    if (x == 0) { fieldNumber_X2 = 1 + a; }
                    if (x == 1) { fieldNumber_X2 = 9; }
                }
                if (fieldNumber_O1 == 8)
                {
                    Random random = new Random();
                    x = random.Next(0, 2);

                    if (x == 0) { fieldNumber_X2 = 4 + a; }
                    if (x == 1) { fieldNumber_X2 = 9; }
                }
                if (fieldNumber_O1 == 9)
                {
                    Random random = new Random();
                    x = random.Next(0, 2);

                    if (x == 0)
                    {
                        fieldNumber_X2 = 2 + a;
                        if (fieldNumber_X2 == 5) { fieldNumber_X2 = 1; }
                    }
                    if (x == 1)
                    {
                        fieldNumber_X2 = 6 + a;
                        if (fieldNumber_X2 == 9) { fieldNumber_X2 = 5; }
                    }
                }
                // SET MOVE X2
                SetInField(fieldNumber_X2);
            }

            // X2 if X1 is in the CENTRE FIELD:
            if (X1 == 9)
            {
                int fieldNumber_X2 = 0;
                int x;

                // Corner fields
                if (O1 == 1 || O1 == 2 || O1 == 3 || O1 == 4)
                {
                    fieldNumber_X2 = O1 + 2; // opposite corner
                    if (fieldNumber_X2 == 5) { fieldNumber_X2 = 1; }
                    if (fieldNumber_X2 == 6) { fieldNumber_X2 = 2; }
                }
                // Side fields
                if (O1 == 5 || O1 == 6 || O1 == 7 || O1 == 8)
                {
                    Random random = new Random();
                    x = random.Next(0, 4);

                    if (x == 0) { fieldNumber_X2 = 1; }
                    if (x == 1) { fieldNumber_X2 = 2; }
                    if (x == 2) { fieldNumber_X2 = 3; }
                    if (x == 3) { fieldNumber_X2 = 4; }
                }
                // SET MOVE X2
                SetInField(fieldNumber_X2);
            }
        }

        // METHODS FOR LATER MOVES (X3 to X5)

        // Methods to check if a win is possible
        private void CheckRowToWin(int fieldOneInRow, int numValueFieldOne, int fieldTwoInRow, int numValueFieldTwo,
                                   int fieldThreeInRow, int numValueFieldThree, int rowValueToCheck)
        {
            if (gameOver == false && fieldOneInRow + fieldTwoInRow + fieldThreeInRow == rowValueToCheck)
            {
                if (fieldOneInRow == 0)                        { SetInField(numValueFieldOne); CheckForWinner(); }
                if (fieldTwoInRow == 0 && gameOver == false)   { SetInField(numValueFieldTwo); CheckForWinner(); }
                if (fieldThreeInRow == 0 && gameOver == false) { SetInField(numValueFieldThree); CheckForWinner(); }
            }
        }

        // Method to check all rows for a winning move
        private void CheckAllRowsToWin(int rowValueToCheck)
        {
            if (gameOver == false) { CheckRowToWin(field1, 1, field6, 6, field2, 2, rowValueToCheck); }
            if (gameOver == false) { CheckRowToWin(field5, 5, field9, 9, field7, 7, rowValueToCheck); }
            if (gameOver == false) { CheckRowToWin(field4, 4, field8, 8, field3, 3, rowValueToCheck); }
            if (gameOver == false) { CheckRowToWin(field1, 1, field5, 5, field4, 4, rowValueToCheck); }
            if (gameOver == false) { CheckRowToWin(field6, 6, field9, 9, field8, 8, rowValueToCheck); }
            if (gameOver == false) { CheckRowToWin(field2, 2, field7, 7, field3, 3, rowValueToCheck); }
            if (gameOver == false) { CheckRowToWin(field1, 1, field9, 9, field3, 3, rowValueToCheck); }
            if (gameOver == false) { CheckRowToWin(field4, 4, field9, 9, field2, 2, rowValueToCheck); }
        }

        // Methods to check all rows at random for a certain number of points and make a move
        public bool isCheckRowFinished;

        private void CheckRow(int fieldOneInRow, int numValueFieldOne, int fieldTwoInRow, int numValueFieldTwo,
                                  int fieldThreeInRow, int numValueFieldThree, int rowValueToCheck)
        {
            if (fieldOneInRow + fieldTwoInRow + fieldThreeInRow == rowValueToCheck)
            {
                Random random = new Random();
                int x = random.Next(0, 6);

                if (x == 0)
                {
                    if (fieldOneInRow == 0 && isCheckRowFinished == false) { SetInField(numValueFieldOne); isCheckRowFinished = true; }
                    if (fieldTwoInRow == 0 && isCheckRowFinished == false) { SetInField(numValueFieldTwo); isCheckRowFinished = true; }
                    if (fieldThreeInRow == 0 && isCheckRowFinished == false) { SetInField(numValueFieldThree); isCheckRowFinished = true; }
                }
                if (x == 1)
                {
                    if (fieldOneInRow == 0 && isCheckRowFinished == false) { SetInField(numValueFieldOne); isCheckRowFinished = true; }
                    if (fieldThreeInRow == 0 && isCheckRowFinished == false) { SetInField(numValueFieldThree); isCheckRowFinished = true; }
                    if (fieldTwoInRow == 0 && isCheckRowFinished == false) { SetInField(numValueFieldTwo); isCheckRowFinished = true; }
                }
                if (x == 2)
                {
                    if (fieldTwoInRow == 0 && isCheckRowFinished == false) { SetInField(numValueFieldTwo); isCheckRowFinished = true; }
                    if (fieldOneInRow == 0 && isCheckRowFinished == false) { SetInField(numValueFieldOne); isCheckRowFinished = true; }
                    if (fieldThreeInRow == 0 && isCheckRowFinished == false) { SetInField(numValueFieldThree); isCheckRowFinished = true; }
                }
                if (x == 3)
                {
                    if (fieldTwoInRow == 0 && isCheckRowFinished == false) { SetInField(numValueFieldTwo); isCheckRowFinished = true; }
                    if (fieldThreeInRow == 0 && isCheckRowFinished == false) { SetInField(numValueFieldThree); isCheckRowFinished = true; }
                    if (fieldOneInRow == 0 && isCheckRowFinished == false) { SetInField(numValueFieldOne); isCheckRowFinished = true; }
                }
                if (x == 4)
                {
                    if (fieldThreeInRow == 0 && isCheckRowFinished == false) { SetInField(numValueFieldThree); isCheckRowFinished = true; }
                    if (fieldOneInRow == 0 && isCheckRowFinished == false) { SetInField(numValueFieldOne); isCheckRowFinished = true; }
                    if (fieldTwoInRow == 0 && isCheckRowFinished == false) { SetInField(numValueFieldTwo); isCheckRowFinished = true; }
                }
                if (x == 5)
                {
                    if (fieldThreeInRow == 0 && isCheckRowFinished == false) { SetInField(numValueFieldThree); isCheckRowFinished = true; }
                    if (fieldTwoInRow == 0 && isCheckRowFinished == false) { SetInField(numValueFieldTwo); isCheckRowFinished = true; }
                    if (fieldOneInRow == 0 && isCheckRowFinished == false) { SetInField(numValueFieldOne); isCheckRowFinished = true; }
                }
            }
        }

        private void CheckAllRows(int rowValueToCheck)
        {
            isCheckRowFinished = false;

            CheckRow(field1, 1, field6, 6, field2, 2, rowValueToCheck);
            if (isCheckRowFinished == false) { CheckRow(field4, 4, field9, 9, field2, 2, rowValueToCheck); }
            if (isCheckRowFinished == false) { CheckRow(field5, 5, field9, 9, field7, 7, rowValueToCheck); }
            if (isCheckRowFinished == false) { CheckRow(field2, 2, field7, 7, field3, 3, rowValueToCheck); }
            if (isCheckRowFinished == false) { CheckRow(field4, 4, field8, 8, field3, 3, rowValueToCheck); }
            if (isCheckRowFinished == false) { CheckRow(field1, 1, field5, 5, field4, 4, rowValueToCheck); }
            if (isCheckRowFinished == false) { CheckRow(field6, 6, field9, 9, field8, 8, rowValueToCheck); }
            if (isCheckRowFinished == false) { CheckRow(field1, 1, field9, 9, field3, 3, rowValueToCheck); }
        }

        // Method to check if a loss should be prevented
        public bool lossPrevented = false;

        private void CheckRowToPreventLoss(int fieldOneInRow, int numValueFieldOne, int fieldTwoInRow, int numValueFieldTwo,
                                           int fieldThreeInRow, int numValueFieldThree, int rowValueToCheck)
        {
            if (fieldOneInRow + fieldTwoInRow + fieldThreeInRow == rowValueToCheck)
            {
                if (fieldOneInRow == 0 && lossPrevented == false) { SetInField(numValueFieldOne); lossPrevented = true; }
                if (fieldTwoInRow == 0 && lossPrevented == false) { SetInField(numValueFieldTwo); lossPrevented = true; }
                if (fieldThreeInRow == 0 && lossPrevented == false) { SetInField(numValueFieldThree); lossPrevented = true; }
            }
        }

        // Method to check all rows for a loss prevention
        private void CheckAllRowsToPreventLoss(int rowValueToCheck)
        {
            CheckRowToPreventLoss(field1, 1, field6, 6, field2, 2, rowValueToCheck);
            CheckRowToPreventLoss(field5, 5, field9, 9, field7, 7, rowValueToCheck);
            CheckRowToPreventLoss(field4, 4, field8, 8, field3, 3, rowValueToCheck);
            CheckRowToPreventLoss(field1, 1, field5, 5, field4, 4, rowValueToCheck);
            CheckRowToPreventLoss(field6, 6, field9, 9, field8, 8, rowValueToCheck);
            CheckRowToPreventLoss(field2, 2, field7, 7, field3, 3, rowValueToCheck);
            CheckRowToPreventLoss(field1, 1, field9, 9, field3, 3, rowValueToCheck);
            CheckRowToPreventLoss(field4, 4, field9, 9, field2, 2, rowValueToCheck);
        }

        // Method to check if a move into a certain winning position can be made, 
        // or if a certain win of the opponent can be prevented
        private void CheckRowForPossibleMovesIntoWinningPosition(int fieldOneInRow, int valueFieldOne, int fieldTwoInRow, int valueFieldTwo,
                                                                 int fieldThreeInRow, int valueFieldThree, int rowValueToCheck)
        {
            if (fieldOneInRow + fieldTwoInRow + fieldThreeInRow == rowValueToCheck)
            {
                bool selectionMade = false;

                if (selectionMade == false && fieldOneInRow == 0 && possibleField1 == 0) { possibleField1 = valueFieldOne; selectionMade = true; }
                if (selectionMade == false && fieldOneInRow == 0 && possibleField2 == 0) { possibleField2 = valueFieldOne; selectionMade = true; }
                if (selectionMade == false && fieldOneInRow == 0 && possibleField3 == 0) { possibleField3 = valueFieldOne; selectionMade = true; }
                if (selectionMade == false && fieldOneInRow == 0 && possibleField4 == 0) { possibleField4 = valueFieldOne; selectionMade = true; }
                if (selectionMade == false && fieldOneInRow == 0 && possibleField5 == 0) { possibleField5 = valueFieldOne; selectionMade = true; }
                if (selectionMade == false && fieldOneInRow == 0 && possibleField6 == 0) { possibleField6 = valueFieldOne; selectionMade = true; }

                selectionMade = false;
                if (selectionMade == false && fieldTwoInRow == 0 && possibleField1 == 0) { possibleField1 = valueFieldTwo; selectionMade = true; }
                if (selectionMade == false && fieldTwoInRow == 0 && possibleField2 == 0) { possibleField2 = valueFieldTwo; selectionMade = true; }
                if (selectionMade == false && fieldTwoInRow == 0 && possibleField3 == 0) { possibleField3 = valueFieldTwo; selectionMade = true; }
                if (selectionMade == false && fieldTwoInRow == 0 && possibleField4 == 0) { possibleField4 = valueFieldTwo; selectionMade = true; }
                if (selectionMade == false && fieldTwoInRow == 0 && possibleField5 == 0) { possibleField5 = valueFieldTwo; selectionMade = true; }
                if (selectionMade == false && fieldTwoInRow == 0 && possibleField6 == 0) { possibleField6 = valueFieldTwo; selectionMade = true; }

                selectionMade = false;
                if (selectionMade == false && fieldThreeInRow == 0 && possibleField1 == 0) { possibleField1 = valueFieldThree; selectionMade = true; }
                if (selectionMade == false && fieldThreeInRow == 0 && possibleField2 == 0) { possibleField2 = valueFieldThree; selectionMade = true; }
                if (selectionMade == false && fieldThreeInRow == 0 && possibleField3 == 0) { possibleField3 = valueFieldThree; selectionMade = true; }
                if (selectionMade == false && fieldThreeInRow == 0 && possibleField4 == 0) { possibleField4 = valueFieldThree; selectionMade = true; }
                if (selectionMade == false && fieldThreeInRow == 0 && possibleField5 == 0) { possibleField5 = valueFieldThree; selectionMade = true; }
                if (selectionMade == false && fieldThreeInRow == 0 && possibleField6 == 0) { possibleField6 = valueFieldThree; selectionMade = true; }
            }
        }
        // Possibilities:
        public int possibleField1 = 0;
        public int possibleField2 = 0;
        public int possibleField3 = 0;
        public int possibleField4 = 0;
        public int possibleField5 = 0;
        public int possibleField6 = 0;

        // Check all rows for possible moves into a winning position
        private void CheckAllRowsForPossibleMovesIntoWinningPosition(int rowValueToCheck)
        {
            CheckRowForPossibleMovesIntoWinningPosition(field1, 1, field6, 6, field2, 2, rowValueToCheck);
            CheckRowForPossibleMovesIntoWinningPosition(field5, 5, field9, 9, field7, 7, rowValueToCheck);
            CheckRowForPossibleMovesIntoWinningPosition(field4, 4, field8, 8, field3, 3, rowValueToCheck);
            CheckRowForPossibleMovesIntoWinningPosition(field1, 1, field5, 5, field4, 4, rowValueToCheck);
            CheckRowForPossibleMovesIntoWinningPosition(field6, 6, field9, 9, field8, 8, rowValueToCheck);
            CheckRowForPossibleMovesIntoWinningPosition(field2, 2, field7, 7, field3, 3, rowValueToCheck);
            CheckRowForPossibleMovesIntoWinningPosition(field1, 1, field9, 9, field3, 3, rowValueToCheck);
            CheckRowForPossibleMovesIntoWinningPosition(field4, 4, field9, 9, field2, 2, rowValueToCheck);
        }

        // Method that checks if there is a field that leads to a winning position in two different rows. 
        // If true this results in a certain win.
        public bool certainWin = false;

        private void CheckForCertainWinningPosition()
        {
            // Check possible fieldToCover 1
            if (certainWin == false && possibleField1 != 0 && possibleField1 == possibleField2) { SetInField(possibleField1); certainWin = true; }
            if (certainWin == false && possibleField1 != 0 && possibleField1 == possibleField3) { SetInField(possibleField1); certainWin = true; }
            if (certainWin == false && possibleField1 != 0 && possibleField1 == possibleField4) { SetInField(possibleField1); certainWin = true; }
            if (certainWin == false && possibleField1 != 0 && possibleField1 == possibleField5) { SetInField(possibleField1); certainWin = true; }
            if (certainWin == false && possibleField1 != 0 && possibleField1 == possibleField6) { SetInField(possibleField1); certainWin = true; }
            // Check possible fieldToCover 2
            if (certainWin == false && possibleField2 != 0 && possibleField2 == possibleField3) { SetInField(possibleField2); certainWin = true; }
            if (certainWin == false && possibleField2 != 0 && possibleField2 == possibleField4) { SetInField(possibleField2); certainWin = true; }
            if (certainWin == false && possibleField2 != 0 && possibleField2 == possibleField5) { SetInField(possibleField2); certainWin = true; }
            if (certainWin == false && possibleField2 != 0 && possibleField2 == possibleField6) { SetInField(possibleField2); certainWin = true; }
            // Check possible fieldToCover 3
            if (certainWin == false && possibleField3 != 0 && possibleField3 == possibleField4) { SetInField(possibleField3); certainWin = true; }
            if (certainWin == false && possibleField3 != 0 && possibleField3 == possibleField5) { SetInField(possibleField3); certainWin = true; }
            if (certainWin == false && possibleField3 != 0 && possibleField3 == possibleField6) { SetInField(possibleField3); certainWin = true; }
            // Check possible fieldToCover 4
            if (certainWin == false && possibleField4 != 0 && possibleField4 == possibleField5) { SetInField(possibleField4); certainWin = true; }
            if (certainWin == false && possibleField4 != 0 && possibleField4 == possibleField6) { SetInField(possibleField4); certainWin = true; }
            // Check possible fieldToCover 5
            if (certainWin == false && possibleField5 != 0 && possibleField5 == possibleField6) { SetInField(possibleField5); certainWin = true; }
            // Check possible fieldToCover 6 not necessary anymore

            CheckForWinner();
        }

        // Method that checks if a single winning position is possible (should only be used after the method above is used)
        private void CheckForPossibleSingleWinningPosition()
        {
            bool moveMade = false;

            // Check all the selected possible fields in the method 'CheckAllRowsForPossibleMovesIntoWinningPosition' 
            // and make a move if possible
            if (moveMade == false && possibleField1 != 0) { SetInField(possibleField1); moveMade = true; }
            if (moveMade == false && possibleField2 != 0) { SetInField(possibleField2); moveMade = true; }
            if (moveMade == false && possibleField3 != 0) { SetInField(possibleField3); moveMade = true; }
            if (moveMade == false && possibleField4 != 0) { SetInField(possibleField4); moveMade = true; }
            if (moveMade == false && possibleField5 != 0) { SetInField(possibleField5); moveMade = true; }
            if (moveMade == false && possibleField6 != 0) { SetInField(possibleField6); moveMade = true; }

            CheckForWinner();
        }

        // COMPUTER MOVE X3 - GAMETYPE: INVINCIBLE
        private void ComputerMove_X3_Invincible()
        {
            // FIRST: Check if a win is possible 
            CheckAllRowsToWin(2);  // value 2 checks all rows with 2 Crosses

            // SECOND: Check if a loss should be prevented
            if (X3 == 0 && gameOver == false)
            {
                CheckAllRowsToPreventLoss(8);  // value 8 checks all rows with 2 Noughts
            }

            // THIRD: Check if a move into a certain winning position is possible
            if (X3 == 0 && gameOver == false && lossPrevented == false)
            {
                CheckAllRowsForPossibleMovesIntoWinningPosition(1);
                CheckForCertainWinningPosition();
                // Reset:
                possibleField1 = 0; possibleField2 = 0; possibleField3 = 0;
                possibleField4 = 0; possibleField5 = 0; possibleField6 = 0;
            }

            // FOURTH: Check if a move into a certain winning position of the opponent should be prevented
            if (X3 == 0 && gameOver == false && lossPrevented == false && certainWin == false)
            {
                CheckAllRowsForPossibleMovesIntoWinningPosition(4);
                CheckForCertainWinningPosition();
                // Reset:
                possibleField1 = 0; possibleField2 = 0; possibleField3 = 0;
                possibleField4 = 0; possibleField5 = 0; possibleField6 = 0;
            }

            // FIFTH: Check if a (single) winning position is available
            if (X3 == 0 && gameOver == false && lossPrevented == false && certainWin == false)
            {
                CheckAllRowsForPossibleMovesIntoWinningPosition(1);
                CheckForPossibleSingleWinningPosition();
            }

            // Reset:
            lossPrevented = false;
            certainWin = false;
        }

        // COMPUTER MOVE X4 - GAMETYPE: INVINCIBLE
        private void ComputerMove_X4_Invincible()
        {
            // FIRST: Check if a win is possible 
            CheckAllRowsToWin(2);  // value 2 checks all rows with 2 Crosses

            // SECOND: Check if a loss should be prevented
            if (X4 == 0 && gameOver == false)
            {
                CheckAllRowsToPreventLoss(8);  // value 8 checks all rows with 2 Noughts
            }

            // THIRD: Check if a (single) winning position is available
            if (X4 == 0 && gameOver == false && lossPrevented == false)
            {
                CheckAllRowsForPossibleMovesIntoWinningPosition(1);
                CheckForPossibleSingleWinningPosition();
            }
                
            // Reset:
            lossPrevented = false;
        }

        // COMPUTER MOVE X5
        private void ComputerMove_X5()
        {
            // Check all fields and make the last possible move
            if (field1 == 0) { SetInField(1); }
            if (field2 == 0) { SetInField(2); }
            if (field3 == 0) { SetInField(3); }
            if (field4 == 0) { SetInField(4); }
            if (field5 == 0) { SetInField(5); }
            if (field6 == 0) { SetInField(6); }
            if (field7 == 0) { SetInField(7); }
            if (field8 == 0) { SetInField(8); }
            if (field9 == 0) { SetInField(9); }
        }

        // COMPUTER MOVE O1 - GAMETYPE: INVINCIBLE
        private void ComputerMove_O1_Invincible()
        {
            bool moveMade = false;
            
            // FIRST: Check if the centre fieldToCover is available ans set there if possible
            if (field9 == 0) { SetInField(9); moveMade = true; }

            // SECOND: Check corner fieldToCover and set at random in an avaiable corner fieldToCover
            if (moveMade == false)
            {
                bool allCornerFieldsAvailable = true;

                if (moveMade = false && field1 == 0 && field2 == 0 && field3 == 0 && field4 == 0)
                { allCornerFieldsAvailable = true; }

                if (moveMade = false && field1 != 0 || field2 != 0 || field3 != 0 || field4 != 0)
                { allCornerFieldsAvailable = false; }

                if (allCornerFieldsAvailable == true)
                {
                    Random random = new Random();
                    int x = random.Next(0, 4);

                    if (x == 0) { SetInField(1); }
                    if (x == 1) { SetInField(2); }
                    if (x == 2) { SetInField(3); }
                    if (x == 3) { SetInField(4); }
                }
                else
                {
                    Random random = new Random();
                    int x = random.Next(0, 3);

                    if (x == 0) { SetInField(1); }
                    if (x == 1) { SetInField(2); }
                    if (x == 2) { SetInField(3); }
                }
            }
        }

        // COMPUTER MOVE O2  - GAMETYPE: INVINCIBLE
        private void ComputerMove_O2_Invincible()
        {
            // FIRST: Check if a loss should be prevented 
            CheckAllRowsToPreventLoss(2);  // value 2 checks all rows with 2 Crosses

            // SECOND: Check all possible moves on the gameboard left and determine and set a move
            if (lossPrevented == false)
            {
                // If X1 is in the centre field and X2 is in a corner field
                if (field9 == 1 && (field1 == 1 || field2 == 1 || field3 == 1 || field4 == 1))
                {
                    Random random = new Random();
                    int x = random.Next(0, 2);

                    if (x == 0 && field1 != 0 && field2 != 0) { SetInField(3); }
                    if (x == 1 && field1 != 0 && field2 != 0) { SetInField(4); }

                    if (x == 0 && field2 != 0 && field3 != 0) { SetInField(4); }
                    if (x == 1 && field2 != 0 && field3 != 0) { SetInField(1); }

                    if (x == 0 && field3 != 0 && field4 != 0) { SetInField(1); }
                    if (x == 1 && field3 != 0 && field4 != 0) { SetInField(2); }

                    if (x == 0 && field4 != 0 && field1 != 0) { SetInField(2); }
                    if (x == 1 && field4 != 0 && field1 != 0) { SetInField(3); }
                }

                // If X1 and X2 are in a diagonally opposite corner fields and O1 is in the centre field
                bool moveMade = false;

                if (field1 == 1 && field3 == 1 || field2 == 1 && field4 == 1)
                {
                    if (field9 == 0) { SetInField(9); moveMade = true; }  // This code is added to be sure that this move on level 'Invincible'
                                                                          // will also be the most optimal move for Noughts, when the first move
                                                                          // was not the most optimal.
                    if (moveMade == false)
                    {
                        Random random = new Random();
                        int x = random.Next(0, 2);
                        // avoid symmetry trap
                        if (x == 0)
                        {
                            if (field5 == 0) { SetInField(5); }
                            moveMade = true;
                        }

                        if (x == 1)
                        {
                            if (field7 == 0) { SetInField(7); }
                            moveMade = true;
                        }
                    } 
                }

                // If X1 and X2 are both in a adjacent side fields
                if (moveMade == false && field5 == 1 && field6 == 1)
                {
                    if (field9 == 0) { SetInField(9); moveMade = true; }  // This code is added to be sure that this move on level 'Invincible'
                                                                          // will also be the most optimal move for Noughts, when the first move
                                                                          // was not the most optimal.
                    if (moveMade == false && field1 == 0) { SetInField(1); moveMade = true; }
                }

                if (moveMade == false && field6 == 1 && field7 == 1)
                {
                    if (field9 == 0) { SetInField(9); moveMade = true; }  
                    if (moveMade == false && field2 == 0) { SetInField(2); moveMade = true; }
                }

                if (moveMade == false && field7 == 1 && field8 == 1)
                {
                    if (field9 == 0) { SetInField(9); moveMade = true; }
                    if (moveMade == false && field3 == 0) { SetInField(3); moveMade = true; }
                }

                if (moveMade == false && field8 == 1 && field5 == 1)
                {
                    if (field9 == 0) { SetInField(9); moveMade = true; }
                    if (moveMade == false && field4 == 0) { SetInField(4); moveMade = true; }
                }

                // If X1 and X2 are in opposite side fields
                if (moveMade == false 
                    && field5 == 1 && field7 == 1 || field6 == 1 && field8 == 1)
                {
                    Random random = new Random();
                    int x = random.Next(0, 4);
                    // set in one of the four corner fields left
                    if (x == 0) { SetInField(1); moveMade = true; }
                    if (x == 1) { SetInField(2); moveMade = true; }
                    if (x == 2) { SetInField(3); moveMade = true; }
                    if (x == 3) { SetInField(4); moveMade = true; }
                }

                // If X1 in centre field and X2 in a side field opposite to O1
                if (moveMade == false
                    && field9 == 1 && (field1 + field3 == 4))
                {
                    Random random = new Random();
                    int x = random.Next(0, 2);
                    // set in one of the left corner fields
                    if (x == 0) { SetInField(2); moveMade = true; }
                    if (x == 1) { SetInField(4); moveMade = true; }
                }
                if (moveMade == false
                    && field9 == 1 && (field4 + field2 == 5))
                {
                    Random random = new Random();
                    int x = random.Next(0, 2);
                    // set in one of the left corner fields
                    if (x == 0) { SetInField(1); moveMade = true; }
                    if (x == 1) { SetInField(3); moveMade = true; }
                }

                // For all possibilities that are left... search for a (single) winning postion
                if (moveMade == false)
                {
                    CheckAllRowsForPossibleMovesIntoWinningPosition(4);
                    CheckForCertainWinningPosition();
                    CheckForPossibleSingleWinningPosition();
                }
            }

            // Reset:
            lossPrevented = false;
        }

        // COMPUTER MOVE O3  - GAMETYPE: INVINCIBLE
        private void ComputerMove_O3_Invincible()
        {
            // FIRST: Check if a win is possible 
            CheckAllRowsToWin(8);  // value 8 checks all rows with 2 Noughts

            // SECOND: Check if a loss should be prevented
            if (O3 == 0 && gameOver == false)
            {
                CheckAllRowsToPreventLoss(2);  // value 2 checks all rows with 2 Crosses
            }

            // THIRD: Check if a (single) winning position is available (this is always possible for MOVE O3)
            if (O3 == 0 && gameOver == false && lossPrevented == false)
            {
                CheckAllRowsForPossibleMovesIntoWinningPosition(4); // value 4 checks all rows with 1 Nought
                CheckForCertainWinningPosition();
                CheckForPossibleSingleWinningPosition();
            }

            // Reset:
            lossPrevented = false;
        }

        // COMPUTER MOVE O4 - GAMETYPE: INVINCIBLE
        private void ComputerMove_O4_Invincible()
        {
            // FIRST: Check if a win is possible 
            CheckAllRowsToWin(8);  // value 8 checks all rows with 2 Noughts

            // SECOND: Check if a loss should be prevented
            if (O4 == 0 && gameOver == false)
            {
                CheckAllRowsToPreventLoss(2);  // value 2 checks all rows with 2 Crosses
            }   

            // THIRD: Check if a (single) winning position is available
            if (O4 == 0 && gameOver == false && lossPrevented == false)
            {
                CheckAllRowsForPossibleMovesIntoWinningPosition(1);
                CheckForPossibleSingleWinningPosition();
            }

            // FOURTH: If none of the above options is possible, 
            // check all fields and make a random move in one of the two fields left empty
            if (O4 == 0 && gameOver == false && lossPrevented == false)
            {
                int a = 0; 
                int b = 0;

                if (field1 == 0) { a = 1; }
                if (field2 == 0) { if (a == 0) { a = 2; } else { b = 2; } }
                if (field3 == 0) { if (a == 0) { a = 3; } else { b = 3; } }
                if (field4 == 0) { if (a == 0) { a = 4; } else { b = 4; } }
                if (field5 == 0) { if (a == 0) { a = 5; } else { b = 5; } }
                if (field6 == 0) { if (a == 0) { a = 6; } else { b = 6; } }
                if (field7 == 0) { if (a == 0) { a = 7; } else { b = 7; } }
                if (field8 == 0) { if (a == 0) { a = 8; } else { b = 8; } }
                if (field9 == 0) { if (a == 0) { a = 9; } else { b = 8; } }

                Random random = new Random();
                int x = random.Next(0, 2);
                // set in one of the two left fields
                if (x == 0) { SetInField(a); }
                if (x == 1) { SetInField(b); }
            }

            // Reset:
            lossPrevented = false;
        }

        // COMPUTERMOVE X2 - GAMETYPE: EASY
        private void ComputerMove_X2_Easy() 
        {
            // Determine and set move X2, after move O1
            int fieldNumber;

            // X2 if X1 is in a corner field: 
            if ((X1 >= 1 && X1 <= 4) && (O1 >= 1 && O1 <= 9))
            {
                fieldNumber = X1 + 5;
                if (fieldNumber == 9) { fieldNumber = 5; }
                if (fieldNumber == O1) { fieldNumber = O1 + 1; }
                if (fieldNumber == 9) { fieldNumber = 5; }
                SetInField(fieldNumber);
            }

            // X2 if X1 is in a side field: 
            if ((X1 >= 5 && X1 <= 8) && (O1 >= 1 && O1 <= 9))
            {
                fieldNumber = X1 - 4;
                if (fieldNumber == O1)
                {
                    if (X1 == 5 && O1 == 1) { fieldNumber = O1 + 3; }
                    if (X1 == 6 && O1 == 2) { fieldNumber = O1 - 1; }
                    if (X1 == 7 && O1 == 3) { fieldNumber = O1 - 1; }
                    if (X1 == 8 && O1 == 4) { fieldNumber = O1 - 1; }
                }
                SetInField(fieldNumber);
            }

            // X2 if X1 is in the centre field: 
            if (X1 == 9)
            {
                if (O1 >= 1 && O1 <= 4)
                {
                    fieldNumber = O1 - 1;
                    if (fieldNumber == 0) { fieldNumber = 4; }
                    SetInField(fieldNumber);
                }
                if (O1 >= 5 && O1 <= 8)
                {
                    fieldNumber = O1 + 2;
                    if (fieldNumber == 5) { fieldNumber = 1; }
                    if (fieldNumber == 6) { fieldNumber = 2; }
                    SetInField(fieldNumber);
                }
            }
        }

        // COMPUTERMOVE X3 - GAMETYPE: EASY
        private void ComputerMove_X3_Easy()
        {
            CheckAllRows(1);  // Value 1 checks all rows with 1 Cross.

            // If no move is made yet...
            if (X3 == 0)
            {
                FindEmptyFieldAtRandom();
            }
        }

        // COMPUTERMOVE X4 - GAMETYPE: EASY
        private void ComputerMove_X4_Easy() 
        {
            // Check empty field left and make a random move into an empty field
            int a = 0;
            int b = 0;
            int c = 0;

            if (field1 == 0) { a = 1; }
            if (field2 == 0) { if (a == 0) { a = 2; } else { b = 2; } }
            if (field3 == 0) { if (a == 0) { a = 3; } else if (a != 0 && b == 0) { b = 3; } else { c = 3; } }
            if (field4 == 0) { if (a == 0) { a = 4; } else if (a != 0 && b == 0) { b = 4; } else if (b != 0 && c == 0) { c = 4; } }
            if (field5 == 0) { if (a == 0) { a = 5; } else if (a != 0 && b == 0) { b = 5; } else if (b != 0 && c == 0) { c = 5; } }
            if (field6 == 0) { if (a == 0) { a = 6; } else if (a != 0 && b == 0) { b = 6; } else if (b != 0 && c == 0) { c = 6; } }
            if (field7 == 0) { if (a == 0) { a = 7; } else if (a != 0 && b == 0) { b = 7; } else if (b != 0 && c == 0) { c = 7; } }
            if (field8 == 0) { if (a == 0) { a = 8; } else if (a != 0 && b == 0) { b = 8; } else if (b != 0 && c == 0) { c = 8; } }
            if (field9 == 0) { if (a == 0) { a = 9; } else if (a != 0 && b == 0) { b = 9; } else if (b != 0 && c == 0) { c = 9; } }

            Random random = new Random();
            int x = random.Next(0, 3);
            // set in one of the three left fields
            if (x == 0) { SetInField(a); }
            if (x == 1) { SetInField(b); }
            if (x == 2) { SetInField(c); }
        }

        // COMPUTER MOVE O1 - GAMETYPE: EASY
        private void ComputerMove_O1_Easy() 
        {
            // Make a random move, except to the centre field
            Random random = new Random();
            int x = random.Next(0, 8);
           
            if (x == 0 && X1 != 1) { SetInField(1); }
            else if (x == 0 && X1 == 1) { SetInField(2); }

            if (x == 1 && X1 != 2) { SetInField(2); }
            else if (x == 0 && X1 == 2) { SetInField(3); }

            if (x == 2 && X1 != 3) { SetInField(3); }
            else if (x == 0 && X1 == 3) { SetInField(4); }

            if (x == 3 && X1 != 4) { SetInField(4); }
            else if (x == 0 && X1 == 4) { SetInField(1); }

            if (x == 4 && X1 != 5) { SetInField(5); }
            else if (x == 0 && X1 == 5) { SetInField(6); }

            if (x == 5 && X1 != 6) { SetInField(6); }
            else if (x == 0 && X1 == 6) { SetInField(7); }

            if (x == 6 && X1 != 7) { SetInField(7); }
            else if (x == 0 && X1 == 7) { SetInField(8); }

            if (x == 7 && X1 != 8) { SetInField(8); }
            else if (x == 0 && X1 == 8) { SetInField(5); }
        }

        // Method to check empty field at random
        public void FindEmptyFieldAtRandom()
        {
            List<int> list = new List<int>();

            int empty1 = 0; int empty2 = 0; int empty3 = 0; int empty4 = 0; int empty5 = 0;
            int empty6 = 0; int empty7 = 0; int empty8 = 0; int empty9 = 0;

            if (field1 == 0) { empty1 = 1; list.Add(empty1); }
            if (field2 == 0) { empty2 = 2; list.Add(empty2); }
            if (field3 == 0) { empty3 = 3; list.Add(empty3); }
            if (field4 == 0) { empty4 = 4; list.Add(empty4); }
            if (field5 == 0) { empty5 = 5; list.Add(empty5); }
            if (field6 == 0) { empty6 = 6; list.Add(empty6); }
            if (field7 == 0) { empty7 = 7; list.Add(empty7); }
            if (field8 == 0) { empty8 = 8; list.Add(empty8); }
            if (field9 == 0) { empty9 = 9; list.Add(empty9); }

            int count = list.Count;

            Random random = new Random();
            int empty = list[random.Next(list.Count)];

            if (empty == empty1) { SetInField(empty1); }
            if (empty == empty2) { SetInField(empty2); }
            if (empty == empty3) { SetInField(empty3); }
            if (empty == empty4) { SetInField(empty4); }
            if (empty == empty5) { SetInField(empty5); }
            if (empty == empty6) { SetInField(empty6); }
            if (empty == empty7) { SetInField(empty7); }
            if (empty == empty8) { SetInField(empty8); }
            if (empty == empty9) { SetInField(empty9); }
        }

        // COMPUTER MOVE O2 - GAMETYPE: EASY
        private void ComputerMove_O2_Easy() 
        {
            // Make a random move, except to the centre field
            Random random = new Random();
            int x = random.Next(0, 8);

            if (x == 0 && field1 == 0) { SetInField(1); }
            else if (x == 0 && field1 != 0) { FindEmptyFieldAtRandom(); }

            if (x == 1 && field2 == 0) { SetInField(2); }
            else if (x == 1 && field2 != 0) { FindEmptyFieldAtRandom(); }

            if (x == 2 && field3 == 0) { SetInField(3); }
            else if (x == 2 && field3 != 0) { FindEmptyFieldAtRandom(); }

            if (x == 3 && field4 == 0) { SetInField(4); }
            else if (x == 3 && field4 != 0) { FindEmptyFieldAtRandom(); }

            if (x == 4 && field5 == 0) { SetInField(5); }
            else if (x == 4 && field5 != 0) { FindEmptyFieldAtRandom(); }

            if (x == 5 && field6 == 0) { SetInField(6); }
            else if (x == 5 && field6 != 0) { FindEmptyFieldAtRandom(); }

            if (x == 6 && field7 == 0) { SetInField(7); }
            else if (x == 6 && field7 != 0) { FindEmptyFieldAtRandom(); }

            if (x == 7 && field8 == 0) { SetInField(8); }
            else if (x == 7 && field8 != 0) { FindEmptyFieldAtRandom(); }
        }

        // COMPUTERMOVE O3 - GAMETYPE: EASY
        private void ComputerMove_O3_Easy()
        {
            CheckAllRowsToPreventLoss(2);  // Value 2 checks all rows with 2 Crosses.
                                           // To make the game not too easy, a possible loss is prevented here.

            if (lossPrevented == false)
            {
                CheckAllRows(4);  // all rows with 1 Nought
            }

            if (lossPrevented == false && gameOver == false)
            {
                CheckAllRows(0);  // all empty rows
            }

            if (lossPrevented == false && gameOver == false)
            {
                FindEmptyFieldAtRandom(); 
            }

            // Reset:
            lossPrevented = false;
        }

        // COMPUTERMOVE O4 - GAMETYPE: EASY
        private void ComputerMove_O4_Easy()
        {
            FindEmptyFieldAtRandom();
        }

        // COMPUTERMOVE X2 - GAMETYPE: AVERAGE
        private void ComputerMove_X2_Average()
        {
            // First determine if the computer will make a random move or a move an invincible player would make.
            // The chance for a random second move is set at 40%, so 2 out of 5 times the computer could make a mistake.

            Random random = new Random();
            int x = random.Next(0, 5);

            if (x == 0) { ComputerMove_X2_Invincible(); }
            if (x == 1) { ComputerMove_X2_Invincible(); }
            if (x == 2) { ComputerMove_X2_Invincible(); }
            if (x == 3) { FindEmptyFieldAtRandom(); }
            if (x == 4) { FindEmptyFieldAtRandom(); }
        }

        // COMPUTERMOVE X3 - GAMETYPE: AVERAGE
        private void ComputerMove_X3_Average()
        {
            bool moveMade = false;

            // FIRST: Check if a win is possible 
            // OR: Random move (20% chance)
            Random random = new Random();
            int x = random.Next(0, 5);

            if (x == 0) { moveMade = false; } // Ignore
            if (x == 1) { moveMade = false; } // Ignore
            if (x == 2) { moveMade = false; } // Ignore
            if (x == 3) { moveMade = false; } // Ignore
            if (x == 4) { FindEmptyFieldAtRandom(); moveMade = true; }

            // FIRST: Check if a win is possible 
            if (moveMade == false) { CheckAllRowsToWin(2); }  // value 2 checks all rows with 2 Crosses

            // SECOND: Check if a loss should be prevented
            if (moveMade == false && gameOver == false) { CheckAllRowsToPreventLoss(8); }  // value 8 checks all rows with 2 Noughts

            // THIRD: Check if a move into a certain winning position is possible
            // OR: Random move (40% chance)

            if (moveMade == false && gameOver == false && lossPrevented == false)
            {
                Random random2 = new Random();
                int y = random2.Next(0, 5);

                if (y == 0) { moveMade = false; } // Ignore
                if (y == 1) { moveMade = false; } // Ignore
                if (y == 2) { moveMade = false; } // Ignore
                if (y == 3) { FindEmptyFieldAtRandom(); moveMade = true; }
                if (y == 4) { FindEmptyFieldAtRandom(); moveMade = true; }
            }

            // THIRD: Check if a move into a certain winning position is possible
            if (moveMade == false && gameOver == false && lossPrevented == false)
            {
                CheckAllRowsForPossibleMovesIntoWinningPosition(1);
                CheckForCertainWinningPosition();
                // Reset:
                possibleField1 = 0; possibleField2 = 0; possibleField3 = 0; possibleField4 = 0; possibleField5 = 0; possibleField6 = 0;
            }

            // FOURTH: Check if a move into a certain winning position of the opponent should be prevented
            if (moveMade == false && gameOver == false && lossPrevented == false && certainWin == false)
            {
                CheckAllRowsForPossibleMovesIntoWinningPosition(4);
                CheckForCertainWinningPosition();
                // Reset:
                possibleField1 = 0; possibleField2 = 0; possibleField3 = 0; possibleField4 = 0; possibleField5 = 0; possibleField6 = 0;
            }

            // FIFTH: Last option is random move
            if (moveMade == false && gameOver == false && lossPrevented == false && certainWin == false)
            {
                FindEmptyFieldAtRandom();
            }
            
            // Reset:
            lossPrevented = false;
            certainWin = false;
        }

        // COMPUTERMOVE X4 - GAMETYPE: AVERAGE
        private void ComputerMove_X4_Average() 
        {
            // 20% chance for random move, 80% chance for optimal move
            Random random = new Random();
            int x = random.Next(0, 10);
            bool moveMade = false;

            if (x != 8 && x != 9 )
            {
                // Ignore
            }
            else
            {
                FindEmptyFieldAtRandom();
                moveMade = true;
            }

            if (moveMade == false)
            {
                // FIRST: Check if a win is possible 
                CheckAllRowsToWin(2);  // value 2 checks all rows with 2 Crosses
            }

            // SECOND: Check if a loss should be prevented
            if (moveMade == false && gameOver == false)
            {
                CheckAllRowsToPreventLoss(8);  // value 8 checks all rows with 2 Noughts
            }
               
            // THIRD: Last option is random move
            if (moveMade == false && gameOver == false && lossPrevented == false)
            {
                FindEmptyFieldAtRandom();
            }

            // Reset:
            lossPrevented = false;
        }

        // COMPUTER MOVE O1 - GAMETYPE: AVERAGE
        private void ComputerMove_O1_Average()
        {
            // Make a move, 50% of times in the centre (if possible) and 50% of times somewhere else
            Random random = new Random();
            int x = random.Next(0, 10);

            if (x >= 0 && x <= 4)
            {
                if (field9 == 0) { SetInField(9); }
                else if (field9 != 0) { FindEmptyFieldAtRandom(); }
            }

            else if (x >= 5 && x <= 7)
            {
                // Make a random move in an available corner field (30% chance)
                Random random2 = new Random();
                x = random2.Next(0, 4);

                if (x == 0 && field1 == 0)      { SetInField(1); }
                else if (x == 0 && field1 != 0) { SetInField(3); }

                if (x == 1 && field2 == 0)      { SetInField(2); }
                else if (x == 1 && field2 != 0) { SetInField(4); }

                if (x == 2 && field3 == 0)      { SetInField(3); }
                else if (x == 2 && field3 != 0) { SetInField(1); }

                if (x == 3 && field4 == 0)      { SetInField(4); }
                else if (x == 3 && field4 != 0) { SetInField(2); }
            }

            else if (x >= 8 && x <=9)
            {
                // Make a random move in an available side field (20% chance)
                Random random3 = new Random();
                x = random3.Next(0, 4);

                if (x == 0 && field5 == 0)      { SetInField(5); }
                else if (x == 0 && field5 != 0) { SetInField(7); }

                if (x == 1 && field6 == 0)      { SetInField(6); }
                else if (x == 1 && field6 != 0) { SetInField(8); }

                if (x == 2 && field7 == 0)      { SetInField(7); }
                else if (x == 2 && field7 != 0) { SetInField(5); }

                if (x == 3 && field8 == 0)      { SetInField(8); }
                else if (x == 3 && field8 != 0) { SetInField(6); }
            }
        }

        // COMPUTER MOVE O2 - GAMETYPE: AVERAGE
        private void ComputerMove_O2_Average()
        {
            Random random = new Random();
            int x = random.Next(0, 4);

            if (x >= 0 && x <= 2)
            {
                // Check if a loss should be prevented (75% chance)
                CheckAllRowsToPreventLoss(2);  // value 2 checks all rows with 2 Crosses

                if (lossPrevented == false)
                {
                    CheckAllRowsForPossibleMovesIntoWinningPosition(4); // value 4 checks all rows with 1 Nought
                    CheckForPossibleSingleWinningPosition();
                }

                if (O2 == 0)
                {
                    FindEmptyFieldAtRandom();
                }
            }
            else
            {
                // (25% chance)
                FindEmptyFieldAtRandom();
            }

            // Reset:
            lossPrevented = false;
        }

        // COMPUTER MOVE O3  - GAMETYPE: AVERAGE
        private void ComputerMove_O3_Average()
        {
            Random random = new Random();
            int x = random.Next(0, 10);

            if (x != 0)
            {
                // FIRST: Check if a win is possible (90% of times)
                CheckAllRowsToWin(8);  // value 8 checks all rows with 2 Noughts
            }
            else
            {
                // Ignore
            }

            if (O3 == 0 && gameOver == false)
            {
                Random random2 = new Random();
                int y = random2.Next(0, 10);

                if (y != 0)
                {
                    // SECOND: Check if a loss should be prevented (90% of times)
                    CheckAllRowsToPreventLoss(2);  // value 2 checks all rows with 2 Crosses
                }
                else
                {
                    // Ignore
                }
            }

            // THIRD: Check if a (single) winning position is available (this is always possible for MOVE O3)
            if (O3 == 0 && gameOver == false && lossPrevented == false)
            {
                Random random3 = new Random();
                int z = random3.Next(0, 10);

                if (z != 0 && z != 1)
                {
                    CheckAllRowsForPossibleMovesIntoWinningPosition(4); // value 4 checks all rows with 1 Nought
                    CheckForPossibleSingleWinningPosition();
                }  
                else
                {
                    // Ignore
                }
            }

            if (O3 == 0 && gameOver == false && lossPrevented == false && certainWin == false)
            {
                // FOURTH: If not a move is made yet, make a random move now
                FindEmptyFieldAtRandom();
            }

            // Reset:
            lossPrevented = false;
            certainWin = false;
        }

        // COMPUTER MOVE O4  - GAMETYPE: AVERAGE
        private void ComputerMove_O4_Average()
        {
            Random random = new Random();
            int x = random.Next(0, 10);

            if (x != 0)
            {
                // FIRST: Check if a win is possible (90% of times)
                CheckAllRowsToWin(8);  // value 8 checks all rows with 2 Noughts
            }
            else
            {
                // Ignore
            }

            if (O4 == 0 && gameOver == false)
            {
                Random random2 = new Random();
                int y = random2.Next(0, 10);

                if (y != 0)
                {
                    // SECOND: Check if a loss should be prevented (90% of times)
                    CheckAllRowsToPreventLoss(2);  // value 2 checks all rows with 2 Crosses
                }
                else
                {
                    // Ignore
                }
            }

            // THIRD: Check if a (single) winning position is available (this is always possible for MOVE O3)
            if (O4 == 0 && gameOver == false && lossPrevented == false)
            {
                Random random3 = new Random();
                int z = random3.Next(0, 10);

                if (z != 0 && z != 1)
                {
                    CheckAllRowsForPossibleMovesIntoWinningPosition(4); // value 4 checks all rows with 1 Nought
                    CheckForPossibleSingleWinningPosition();
                }
                else
                {
                    // Ignore
                }
            }

            if (O4 == 0 && gameOver == false && lossPrevented == false && certainWin == false)
            {
                // FOURTH: If not a move is made yet, make a random move now
                FindEmptyFieldAtRandom();
            }

            // Reset:
            lossPrevented = false;
            certainWin = false;
        }

        // COMPUTERMOVE X2 - GAMETYPE: Hard
        private void ComputerMove_X2_Hard()
        {
            // First determine if the computer will make a random move or a move an invincible player would make.
            // The chance for a random second move is set at 20%, so 1 out of 5 times the computer could make a mistake.

            Random random = new Random();
            int x = random.Next(0, 5);

            if (x == 0) { ComputerMove_X2_Invincible(); }
            if (x == 1) { ComputerMove_X2_Invincible(); }
            if (x == 2) { ComputerMove_X2_Invincible(); }
            if (x == 3) { ComputerMove_X2_Invincible(); }
            if (x == 4) { FindEmptyFieldAtRandom(); }
        }

        // COMPUTERMOVE X3 - GAMETYPE: HARD
        private void ComputerMove_X3_Hard()
        { 
            bool moveMade = false;

            // FIRST: Check if a win is possible 
            { CheckAllRowsToWin(2); }  // value 2 checks all rows with 2 Crosses

            // SECOND: Check if a loss should be prevented
            if (moveMade == false && gameOver == false) { CheckAllRowsToPreventLoss(8); }  // value 8 checks all rows with 2 Noughts

            // THIRD: Check if a move into a certain winning position is possible
            // OR: Random move (20% chance)
            if (moveMade = false && gameOver == false && lossPrevented == false)
            {
                Random random = new Random();
                int x = random.Next(0, 5);

                if (x == 0) { moveMade = false; } // Ignore
                if (x == 1) { moveMade = false; } // Ignore
                if (x == 2) { moveMade = false; } // Ignore
                if (x == 3) { moveMade = false; } // Ignore
                if (x == 4) { FindEmptyFieldAtRandom(); moveMade = true; }
            }

            // THIRD: Check if a move into a certain winning position is possible
            if (moveMade == false && gameOver == false && lossPrevented == false)
            {
                CheckAllRowsForPossibleMovesIntoWinningPosition(1);
                CheckForCertainWinningPosition();
                // Reset:
                possibleField1 = 0; possibleField2 = 0; possibleField3 = 0; possibleField4 = 0; possibleField5 = 0; possibleField6 = 0;
            }

            // FOURTH: Check if a move into a certain winning position of the opponent should be prevented
            if (moveMade = false && gameOver == false && lossPrevented == false && certainWin == false)
            {
                CheckAllRowsForPossibleMovesIntoWinningPosition(4);
                CheckForCertainWinningPosition();
                // Reset:
                possibleField1 = 0; possibleField2 = 0; possibleField3 = 0; possibleField4 = 0; possibleField5 = 0; possibleField6 = 0;
            }

            // FIFTH: Last option is random move
            if (moveMade = false && gameOver == false && lossPrevented == false && certainWin == false)
            {
                FindEmptyFieldAtRandom();
            }

            // Reset:
            lossPrevented = false;
            certainWin = false;
        }

        // COMPUTERMOVE X4 - GAMETYPE: HARD
        private void ComputerMove_X4_Hard()
        {
            // 5% chance for random move, 95% chance for optimal move
            Random random = new Random();
            int x = random.Next(0, 20);
            bool moveMade = false;

            if (x != 0)
            {
                // Ignore
            }
            else
            {
                FindEmptyFieldAtRandom();
                moveMade = true;
            }

            if (moveMade == false)
            {
                // FIRST: Check if a win is possible 
                CheckAllRowsToWin(2);  // value 2 checks all rows with 2 Crosses
            }

            // SECOND: Check if a loss should be prevented
            if (moveMade == false && gameOver == false)
            {
                CheckAllRowsToPreventLoss(8);  // value 8 checks all rows with 2 Noughts
            }

            // THIRD: Check if a (single) winning position is available
            if (moveMade == false && gameOver == false && lossPrevented == false)
            {
                CheckAllRowsForPossibleMovesIntoWinningPosition(1);
                CheckForPossibleSingleWinningPosition();

                // Reset:
                possibleField1 = 0; possibleField2 = 0; possibleField3 = 0;
                possibleField4 = 0; possibleField5 = 0; possibleField6 = 0;
            }

            // FOURTH: Last option left is a random move (probably not necessary, but to be certain a move is made)
            if (X4 == 0 && moveMade == false && gameOver == false && lossPrevented == false && certainWin == false)
            {
                FindEmptyFieldAtRandom();
            }            

            // Reset:
            lossPrevented = false;
            certainWin = false;
        }

        // COMPUTER MOVE O1 - GAMETYPE: HARD
        private void ComputerMove_O1_Hard()
        {
            // Determine if 'ComputerMove_O1' will be of level 'Average' (30% chance) or 'Invincible' (70% chance)
            Random random = new Random();
            int x = random.Next(0, 10);

            if (x == 0 || x == 1 || x == 2) { ComputerMove_O1_Average(); }
            else {
                    ComputerMove_O1_Invincible();
                    // If no move can be made...
                    if (O1 == 0) { FindEmptyFieldAtRandom(); }
                 }
        }

        // COMPUTER MOVE O2 - GAMETYPE: HARD
        private void ComputerMove_O2_Hard()
        {
            // Determine if 'ComputerMove_O2' will be of level 'Average' (30% chance) or 'Invincible' (70% chance)
            Random random = new Random();
            int x = random.Next(0, 10);

            if (x == 0 || x == 1 || x == 2) { ComputerMove_O2_Average(); }
            else
            {
                ComputerMove_O2_Invincible();
                // If no move can be made...
                if (O2 == 0) { FindEmptyFieldAtRandom(); }
            }
        }

        // COMPUTER MOVE O3 - GAMETYPE: HARD
        private void ComputerMove_O3_Hard()
        {
            // Determine if 'ComputerMove_O2' will be of level 'Average' (30% chance) or 'Invincible' (70% chance)
            Random random = new Random();
            int x = random.Next(0, 10);

            if (x == 0 || x == 1 || x == 2) { ComputerMove_O3_Average(); }
            else
            {
                ComputerMove_O3_Invincible();
                // If no move can be made...
                if (O3 == 0) { FindEmptyFieldAtRandom(); }
            }
        }

        // COMPUTER MOVE O4 - GAMETYPE: HARD
        private void ComputerMove_O4_Hard()
        {
            // Determine if 'ComputerMove_O2' will be of level 'Average' (30% chance) or 'Invincible' (70% chance)
            Random random = new Random();
            int x = random.Next(0, 10);

            if (x == 0 || x == 1 || x == 2) { ComputerMove_O4_Average(); }
            else
            {
                ComputerMove_O4_Invincible();
                // If no move can be made...
                if (O4 == 0) { FindEmptyFieldAtRandom(); }
            }
        }


        // SET NOUGHTS AND CROSSES
        public int fieldValue;

        private void SetInField(int fieldNumber)
        {
            if (fieldNumber == 1) { fieldValue = field1; }
            if (fieldNumber == 2) { fieldValue = field2; }
            if (fieldNumber == 3) { fieldValue = field3; }
            if (fieldNumber == 4) { fieldValue = field4; }
            if (fieldNumber == 5) { fieldValue = field5; }
            if (fieldNumber == 6) { fieldValue = field6; }
            if (fieldNumber == 7) { fieldValue = field7; }
            if (fieldNumber == 8) { fieldValue = field8; }
            if (fieldNumber == 9) { fieldValue = field9; }

            if (gameOver == true)
            {
                // Ignore
            }
            else
            { 
                if (fieldValue == 0)
                {
                    if (playerToMove == Player.Crosses)
                    {
                        if (fieldNumber == 1) { CrossRectangle1_A3.Visibility = Visibility.Visible; CrossRectangle2_A3.Visibility = Visibility.Visible; field1 = 1; }
                        if (fieldNumber == 2) { CrossRectangle1_C3.Visibility = Visibility.Visible; CrossRectangle2_C3.Visibility = Visibility.Visible; field2 = 1; }
                        if (fieldNumber == 3) { CrossRectangle1_C1.Visibility = Visibility.Visible; CrossRectangle2_C1.Visibility = Visibility.Visible; field3 = 1; }
                        if (fieldNumber == 4) { CrossRectangle1_A1.Visibility = Visibility.Visible; CrossRectangle2_A1.Visibility = Visibility.Visible; field4 = 1; }
                        if (fieldNumber == 5) { CrossRectangle1_A2.Visibility = Visibility.Visible; CrossRectangle2_A2.Visibility = Visibility.Visible; field5 = 1; }
                        if (fieldNumber == 6) { CrossRectangle1_B3.Visibility = Visibility.Visible; CrossRectangle2_B3.Visibility = Visibility.Visible; field6 = 1; }    
                        if (fieldNumber == 7) { CrossRectangle1_C2.Visibility = Visibility.Visible; CrossRectangle2_C2.Visibility = Visibility.Visible; field7 = 1; }
                        if (fieldNumber == 8) { CrossRectangle1_B1.Visibility = Visibility.Visible; CrossRectangle2_B1.Visibility = Visibility.Visible; field8 = 1; }
                        if (fieldNumber == 9) { CrossRectangle1_B2.Visibility = Visibility.Visible; CrossRectangle2_B2.Visibility = Visibility.Visible; field9 = 1; }
                    }
                    if (playerToMove == Player.Noughts)
                    {
                        if (fieldNumber == 1) { Circle_A3.Visibility = Visibility.Visible; field1 = 4; }
                        if (fieldNumber == 2) { Circle_C3.Visibility = Visibility.Visible; field2 = 4; }
                        if (fieldNumber == 3) { Circle_C1.Visibility = Visibility.Visible; field3 = 4; }
                        if (fieldNumber == 4) { Circle_A1.Visibility = Visibility.Visible; field4 = 4; }
                        if (fieldNumber == 5) { Circle_A2.Visibility = Visibility.Visible; field5 = 4; }
                        if (fieldNumber == 6) { Circle_B3.Visibility = Visibility.Visible; field6 = 4; }
                        if (fieldNumber == 7) { Circle_C2.Visibility = Visibility.Visible; field7 = 4; }
                        if (fieldNumber == 8) { Circle_B1.Visibility = Visibility.Visible; field8 = 4; }
                        if (fieldNumber == 9) { Circle_B2.Visibility = Visibility.Visible; field9 = 4; }
                    }

                    startGame = false;
                    gameOver = false;

                    AssignPlayerMove(fieldNumber);
                    CheckForWinner();

                    if (gameOver == false)
                    {
                        ChangeTurn();

                        if (gameType != GameType.PlayAgainstEachOther && playerToMove == computer)
                        {
                            WaitNSeconds(1);
                        }
                        // COMMENT: The delay is used to let the computer look MORE HUMAN :-)
                    }
                }
                else
                {
                    // Ignore
                }
            }
        }


        // TIME DELAY: WAIT N SECONDS
        private void WaitNSeconds(int seconds)
        {
            if (seconds < 1) return;
            DateTime _desired = DateTime.Now.AddSeconds(seconds);
            while (DateTime.Now < _desired)
            {
                Thread.Sleep(1);
                System.Windows.Forms.Application.DoEvents();
                DisableAllLabels();
            }
            EnableAllLabels();

            // COMMENT: During the wait, the labels are disabled to make it impossible that a player, after he made
            // his move, can make a next move before the computer has made its move.
            // After the wait time all labels are enabled again.
        }


        // DISABLE AND ENABLE ALL LABELS
        public List<Label> allGameBoardLabels;

        private void DisableAllLabels()
        {
            allGameBoardLabels = new List<Label>
            {
                Label_A1, Label_A2, Label_A3, Label_B1, Label_B2, Label_B3, Label_C1, Label_C2, Label_C3
            };

            foreach (Label label in allGameBoardLabels)
            {
                label.IsEnabled = false;
            }
        }

        private void EnableAllLabels()
        {
            allGameBoardLabels = new List<Label> 
            {
                Label_A1, Label_A2, Label_A3, Label_B1, Label_B2, Label_B3, Label_C1, Label_C2, Label_C3
            };

            foreach (Label label in allGameBoardLabels)
            {
                label.IsEnabled = true;
            }
        }


        // MOUSEDOWN ACTIONS TO SET NOUGHTS AND CROSSES
        private void Label_A1_MouseDown(object sender, MouseButtonEventArgs e) { SetInField(4); ComputerTurn(); }
        private void Label_A2_MouseDown(object sender, MouseButtonEventArgs e) { SetInField(5); ComputerTurn(); }
        private void Label_A3_MouseDown(object sender, MouseButtonEventArgs e) { SetInField(1); ComputerTurn(); }
        private void Label_B1_MouseDown(object sender, MouseButtonEventArgs e) { SetInField(8); ComputerTurn(); }
        private void Label_B2_MouseDown(object sender, MouseButtonEventArgs e) { SetInField(9); ComputerTurn(); }
        private void Label_B3_MouseDown(object sender, MouseButtonEventArgs e) { SetInField(6); ComputerTurn(); }
        private void Label_C1_MouseDown(object sender, MouseButtonEventArgs e) { SetInField(3); ComputerTurn(); }
        private void Label_C2_MouseDown(object sender, MouseButtonEventArgs e) { SetInField(7); ComputerTurn(); }
        private void Label_C3_MouseDown(object sender, MouseButtonEventArgs e) { SetInField(2); ComputerTurn(); }
    }
}
