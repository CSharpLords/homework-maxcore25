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
            if (isClicked1 == false)
            {
                if (player1 == true)
                {
                    GameField1.Content = "X";
                    player1 = false;
                }
                else
                {
                    GameField1.Content = "O";
                    player1 = true;
                }
            }
            isClicked1 = true;
            CheckGameField1();
        }

        private void GameField2_Click(object sender, RoutedEventArgs e)
        {
            if (isClicked2 == false)
            {
                if (player1 == true)
                {
                    GameField2.Content = "X";
                    player1 = false;

                }
                else
                {
                    GameField2.Content = "O";
                    player1 = true;
                }
            }
            isClicked2 = true;
            CheckGameField2();
        }

        private void GameField3_Click(object sender, RoutedEventArgs e)
        {
            if (isClicked3 == false)
            {
                if (player1 == true)
                {
                    GameField3.Content = "X";
                    player1 = false;

                }
                else
                {
                    GameField3.Content = "O";
                    player1 = true;
                }
            }
            isClicked3 = true;
            CheckGameField3();
        }

        private void GameField4_Click(object sender, RoutedEventArgs e)
        {
            if (isClicked4 == false)
            {
                if (player1 == true)
                {
                    GameField4.Content = "X";
                    player1 = false;

                }
                else
                {
                    GameField4.Content = "O";
                    player1 = true;
                }
            }
            isClicked4 = true;
            CheckGameField4();
        }

        private void GameField5_Click(object sender, RoutedEventArgs e)
        {
            if (isClicked5 == false)
            {
                if (player1 == true)
                {
                    GameField5.Content = "X";
                    player1 = false;

                }
                else
                {
                    GameField5.Content = "O";
                    player1 = true;
                }
            }
            isClicked5 = true;
            CheckGameField5();
        }

        private void GameField6_Click(object sender, RoutedEventArgs e)
        {
            if (isClicked6 == false)
            {
                if (player1 == true)
                {
                    GameField6.Content = "X";
                    player1 = false;

                }
                else
                {
                    GameField6.Content = "O";
                    player1 = true;
                }
            }
            isClicked6 = true;
            CheckGameField6();
        }

        private void GameField7_Click(object sender, RoutedEventArgs e)
        {
            if (isClicked7 == false)
            {
                if (player1 == true)
                {
                    GameField7.Content = "X";
                    player1 = false;

                }
                else
                {
                    GameField7.Content = "O";
                    player1 = true;
                }
            }
            isClicked7 = true;
            CheckGameField7();
        }

        private void GameField8_Click(object sender, RoutedEventArgs e)
        {
            if (isClicked8 == false)
            {
                if (player1 == true)
                {
                    GameField8.Content = "X";
                    player1 = false;

                }
                else
                {
                    GameField8.Content = "O";
                    player1 = true;
                }
            }
            isClicked8 = true;
            CheckGameField8();
        }

        private void GameField9_Click(object sender, RoutedEventArgs e)
        {
            if (isClicked9 == false)
            {
                if (player1 == true)
                {
                    GameField9.Content = "X";
                    player1 = false;

                }
                else
                {
                    GameField9.Content = "O";
                    player1 = true;
                }
            }
            isClicked9 = true;
            CheckGameField9();
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
            if ((GameField1.Content == GameField2.Content && GameField1.Content == GameField3.Content) || (GameField1.Content == GameField4.Content && GameField1.Content == GameField7.Content) || (GameField1.Content == GameField5.Content && GameField1.Content == GameField9.Content))
            {
                WriteWinner();
            }
        }
        private void CheckGameField2()
        {
            if ((GameField2.Content == GameField1.Content && GameField2.Content == GameField3.Content) || (GameField2.Content == GameField5.Content && GameField2.Content == GameField8.Content))
            {
                WriteWinner();
            }
        } // some strange mistakes (always player 2 wins)
        private void CheckGameField3()
        {
            if ((GameField3.Content == GameField2.Content && GameField3.Content == GameField1.Content) || (GameField3.Content == GameField6.Content && GameField3.Content == GameField9.Content) || (GameField3.Content == GameField5.Content && GameField3.Content == GameField7.Content))
            {
                WriteWinner();
            }
        }
        private void CheckGameField4()
        {
            WriteWinner();
        }
        private void CheckGameField5()
        {
            if ((GameField5.Content == GameField4.Content && GameField5.Content == GameField6.Content) || (GameField5.Content == GameField2.Content && GameField5.Content == GameField8.Content) || (GameField5.Content == GameField1.Content && GameField5.Content == GameField9.Content) || (GameField5.Content == GameField3.Content && GameField5.Content == GameField7.Content))
            {
                WriteWinner();
            }
        }
        private void CheckGameField6()
        {
            if ((GameField6.Content == GameField3.Content && GameField6.Content == GameField9.Content) || (GameField6.Content == GameField5.Content && GameField6.Content == GameField4.Content))
            {
                WriteWinner();
            }
        }
        private void CheckGameField7()
        {
            if ((GameField7.Content == GameField4.Content && GameField7.Content == GameField1.Content) || (GameField7.Content == GameField8.Content && GameField7.Content == GameField9.Content) || (GameField7.Content == GameField5.Content && GameField7.Content == GameField3.Content))
            {
                WriteWinner();
            }
        }
        private void CheckGameField8()
        {
            if ((GameField8.Content == GameField7.Content && GameField8.Content == GameField9.Content) || (GameField8.Content == GameField5.Content && GameField8.Content == GameField2.Content))
            {
                WriteWinner();
            }
        }
        private void CheckGameField9()
        {
            if ((GameField9.Content == GameField8.Content && GameField9.Content == GameField7.Content) || (GameField9.Content == GameField6.Content && GameField9.Content == GameField3.Content) || (GameField9.Content == GameField5.Content && GameField9.Content == GameField1.Content))
            {
                WriteWinner();
            }
        }

        private void WriteWinner()
        {
            if (Content == "X")
            {
                Label.Content = "Player 1 won";
            }
            else
            {
                Label.Content = "Player 2 won";
            }
        }
    }
}
