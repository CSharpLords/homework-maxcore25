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

namespace TicTacToe
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private static bool player1 = true;
        bool isClicked1 = false;
        bool isClicked2 = false;
        bool isClicked3 = false;
        bool isClicked4 = false;
        bool isClicked5 = false;
        bool isClicked6 = false;
        bool isClicked7 = false;
        bool isClicked8 = false;
        bool isClicked9 = false;

        private void GameField1_Click(object sender, RoutedEventArgs e)
        {
            if ((string)Label.Content != "    TIC-TAC-TOE")
            {
                isClicked1 = true;
            }
            if (isClicked1 == false)
            {
                if (player1 == true)
                {
                    GameField1.Content = "X";
                    CheckGameField1();
                    player1 = false;
                }
                else
                {
                    GameField1.Content = "O";
                    CheckGameField1();
                    player1 = true;
                }
            }
            isClicked1 = true;
        }

        private void GameField2_Click(object sender, RoutedEventArgs e)
        {
            if ((string)Label.Content != "    TIC-TAC-TOE")
            {
                isClicked2 = true;
            }
            if (isClicked2 == false)
            {
                if (player1 == true)
                {
                    GameField2.Content = "X";
                    CheckGameField2();
                    player1 = false;

                }
                else
                {
                    GameField2.Content = "O";
                    CheckGameField2();
                    player1 = true;
                }
            }
            isClicked2 = true;
        }

        private void GameField3_Click(object sender, RoutedEventArgs e)
        {
            if ((string)Label.Content != "    TIC-TAC-TOE")
            {
                isClicked3 = true;
            }
            if (isClicked3 == false)
            {
                if (player1 == true)
                {
                    GameField3.Content = "X";
                    CheckGameField3();
                    player1 = false;

                }
                else
                {
                    GameField3.Content = "O";
                    CheckGameField3();
                    player1 = true;
                }
            }
            isClicked3 = true;
        }

        private void GameField4_Click(object sender, RoutedEventArgs e)
        {
            if ((string)Label.Content != "    TIC-TAC-TOE")
            {
                isClicked4 = true;
            }
            if (isClicked4 == false)
            {
                if (player1 == true)
                {
                    GameField4.Content = "X";
                    CheckGameField4();
                    player1 = false;

                }
                else
                {
                    GameField4.Content = "O";
                    CheckGameField4();
                    player1 = true;
                }
            }
            isClicked4 = true;
        }

        private void GameField5_Click(object sender, RoutedEventArgs e)
        {
            if ((string)Label.Content != "    TIC-TAC-TOE")
            {
                isClicked5 = true;
            }
            if (isClicked5 == false)
            {
                if (player1 == true)
                {
                    GameField5.Content = "X";
                    CheckGameField5();
                    player1 = false;

                }
                else
                {
                    GameField5.Content = "O";
                    CheckGameField5();
                    player1 = true;
                }
            }
            isClicked5 = true;
        }

        private void GameField6_Click(object sender, RoutedEventArgs e)
        {
            if ((string)Label.Content != "    TIC-TAC-TOE")
            {
                isClicked6 = true;
            }
            if (isClicked6 == false)
            {
                if (player1 == true)
                {
                    GameField6.Content = "X";
                    CheckGameField6();
                    player1 = false;

                }
                else
                {
                    GameField6.Content = "O";
                    CheckGameField6();
                    player1 = true;
                }
            }
            isClicked6 = true;  
        }

        private void GameField7_Click(object sender, RoutedEventArgs e)
        {
            if ((string)Label.Content != "    TIC-TAC-TOE")
            {
                isClicked7 = true;
            }
            if (isClicked7 == false)
            {
                if (player1 == true)
                {
                    GameField7.Content = "X";
                    CheckGameField7();
                    player1 = false;

                }
                else
                {
                    GameField7.Content = "O";
                    CheckGameField7();
                    player1 = true;
                }
            }
            isClicked7 = true;
        }

        private void GameField8_Click(object sender, RoutedEventArgs e)
        {
            if ((string)Label.Content != "    TIC-TAC-TOE")
            {
                isClicked8 = true;
            }
            if (isClicked8 == false)
            {
                if (player1 == true)
                {
                    GameField8.Content = "X";
                    CheckGameField8();
                    player1 = false;

                }
                else
                {
                    GameField8.Content = "O";
                    CheckGameField8();
                    player1 = true;
                }
            }
            isClicked8 = true; 
        }

        private void GameField9_Click(object sender, RoutedEventArgs e)
        {
            if ((string)Label.Content != "    TIC-TAC-TOE")
            {
                isClicked9 = true;
            }
            if (isClicked9 == false)
            {
                if (player1 == true)
                {
                    GameField9.Content = "X";
                    CheckGameField9();
                    player1 = false;
                }
                else
                {
                    GameField9.Content = "O";
                    CheckGameField9();
                    player1 = true;
                }
            }
            isClicked9 = true; 
        }

        private void RestartButton_Click(object sender, RoutedEventArgs e)
        {
            isClicked1 = false;
            isClicked2 = false;
            isClicked3 = false;
            isClicked4 = false;
            isClicked5 = false;
            isClicked6 = false;
            isClicked7 = false;
            isClicked8 = false;
            isClicked9 = false;
            GameField1.Content = "";
            GameField2.Content = "";
            GameField3.Content = "";
            GameField4.Content = "";
            GameField5.Content = "";
            GameField6.Content = "";
            GameField7.Content = "";
            GameField8.Content = "";
            GameField9.Content = "";
            player1 = true;
            Label.Content = "    TIC-TAC-TOE";
        }


        private void CheckGameField1()
        {
            if (player1 == true) 
            {
                if (((string)GameField1.Content == "X" ) && (GameField1.Content == GameField2.Content && GameField1.Content == GameField3.Content) || (GameField1.Content == GameField4.Content && GameField1.Content == GameField7.Content) || (GameField1.Content == GameField5.Content && GameField1.Content == GameField9.Content))
                {
                    Label.Content = "Player 1 won";
                }
            }
            else
            {
                if(((string)GameField1.Content == "O") && (GameField1.Content == GameField2.Content && GameField1.Content == GameField3.Content) || (GameField1.Content == GameField4.Content && GameField1.Content == GameField7.Content) || (GameField1.Content == GameField5.Content && GameField1.Content == GameField9.Content))
                {
                    Label.Content = "Player 2 won";
                }
            }
        }

        private void CheckGameField2()
        {
            if (player1 == true) 
            {
                if (((string)GameField2.Content == "X") && (GameField2.Content == GameField1.Content && GameField2.Content == GameField3.Content) || (GameField2.Content == GameField5.Content && GameField2.Content == GameField8.Content))
                {
                    Label.Content = "Player 1 won";
                }
            }
            else
            {
                if (((string)GameField2.Content == "O") && (GameField2.Content == GameField1.Content && GameField2.Content == GameField3.Content) || (GameField2.Content == GameField5.Content && GameField2.Content == GameField8.Content))
                {
                    Label.Content = "Player 2 won";
                }
            }
        } 

        private void CheckGameField3()
        {
            if (player1 == true)
            {
                if (((string)GameField3.Content == "X") && (GameField3.Content == GameField2.Content && GameField3.Content == GameField1.Content) || (GameField3.Content == GameField6.Content && GameField3.Content == GameField9.Content) || (GameField3.Content == GameField5.Content && GameField3.Content == GameField7.Content))
                {
                    Label.Content = "Player 1 won";
                }
            }
            else
            {
                if (((string)GameField3.Content == "O") && (GameField3.Content == GameField2.Content && GameField3.Content == GameField1.Content) || (GameField3.Content == GameField6.Content && GameField3.Content == GameField9.Content) || (GameField3.Content == GameField5.Content && GameField3.Content == GameField7.Content))
                {
                    Label.Content = "Player 2 won";
                }
            }
        }

        private void CheckGameField4()
        {
            if (player1 == true)
            {
                if (((string)GameField4.Content == "X") && (GameField4.Content == GameField1.Content && GameField4.Content == GameField7.Content) || (GameField4.Content == GameField5.Content && GameField4.Content == GameField6.Content))
                {
                    Label.Content = "Player 1 won";
                }
            }
            else
            {
                if (((string)GameField4.Content == "O") && (GameField4.Content == GameField1.Content && GameField4.Content == GameField7.Content) || (GameField4.Content == GameField5.Content && GameField4.Content == GameField6.Content))
                {
                    Label.Content = "Player 2 won";
                }
            }
        }

        private void CheckGameField5()
        {
            if (player1 == true)
            {
                if (((string)GameField5.Content == "X") && (GameField5.Content == GameField4.Content && GameField5.Content == GameField6.Content) || (GameField5.Content == GameField2.Content && GameField5.Content == GameField8.Content) || (GameField5.Content == GameField1.Content && GameField5.Content == GameField9.Content) || (GameField5.Content == GameField3.Content && GameField5.Content == GameField7.Content))
                {
                    Label.Content = "Player 1 won";
                }
            }
            else
            {
                if (( (string)GameField5.Content == "O") && (GameField5.Content == GameField4.Content && GameField5.Content == GameField6.Content) || (GameField5.Content == GameField2.Content && GameField5.Content == GameField8.Content) || (GameField5.Content == GameField1.Content && GameField5.Content == GameField9.Content) || (GameField5.Content == GameField3.Content && GameField5.Content == GameField7.Content))
                {
                    Label.Content = "Player 2 won";
                }
            }
        }

        private void CheckGameField6()
        {
            if (player1 == true)
            {
                if (((string)GameField6.Content == "X") && (GameField6.Content == GameField3.Content && GameField6.Content == GameField9.Content) || (GameField6.Content == GameField5.Content && GameField6.Content == GameField4.Content))
                {
                    Label.Content = "Player 1 won";
                }
            }
            else
            {
                if (((string)GameField6.Content == "O") && (GameField6.Content == GameField3.Content && GameField6.Content == GameField9.Content) || (GameField6.Content == GameField5.Content && GameField6.Content == GameField4.Content))
                {
                    Label.Content = "Player 2 won";
                }
            }
        }

        private void CheckGameField7()
        {
            if (player1 == true) 
            {
                if (((string)GameField7.Content == "X") && (GameField7.Content == GameField4.Content && GameField7.Content == GameField1.Content) || (GameField7.Content == GameField8.Content && GameField7.Content == GameField9.Content) || (GameField7.Content == GameField5.Content && GameField7.Content == GameField3.Content))
                {
                    Label.Content = "Player 1 won";
                }
            }
            else
            {
                if (((string)GameField7.Content == "O") && (GameField7.Content == GameField4.Content && GameField7.Content == GameField1.Content) || (GameField7.Content == GameField8.Content && GameField7.Content == GameField9.Content) || (GameField7.Content == GameField5.Content && GameField7.Content == GameField3.Content))
                {
                    Label.Content = "Player 2 won";
                }
            }
        }

        private void CheckGameField8()
        {
            if (player1 == true)
            {
                if (((string)GameField8.Content == "X") && (GameField8.Content == GameField7.Content && GameField8.Content == GameField9.Content) || (GameField8.Content == GameField5.Content && GameField8.Content == GameField2.Content))
                {
                    Label.Content = "Player 1 won";
                }
            }
            else
            {
                if (((string)GameField8.Content == "O") && (GameField8.Content == GameField7.Content && GameField8.Content == GameField9.Content) || (GameField8.Content == GameField5.Content && GameField8.Content == GameField2.Content))
                {
                    Label.Content = "Player 2 won";
                }
            }
        }

        private void CheckGameField9()
        {
            if (player1 == true)
            {
                if (((string)GameField9.Content == "X") && (GameField9.Content == GameField8.Content && GameField9.Content == GameField7.Content) || (GameField9.Content == GameField6.Content && GameField9.Content == GameField3.Content) || (GameField9.Content == GameField5.Content && GameField9.Content == GameField1.Content))
                {
                    Label.Content = "Player 1 won";
                }
            }
            else
            {
                if (((string)GameField9.Content == "O") && (GameField9.Content == GameField8.Content && GameField9.Content == GameField7.Content) || (GameField9.Content == GameField6.Content && GameField9.Content == GameField3.Content) || (GameField9.Content == GameField5.Content && GameField9.Content == GameField1.Content))
                {
                    Label.Content = "Player 2 won";
                }
            }
        }
    }
}
