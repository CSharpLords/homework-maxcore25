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
        private bool isClicked = false;

        private void GameField1_Click(object sender, RoutedEventArgs e)
        {
            bool isClicked1 = false;
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
        }

        private void GameField2_Click(object sender, RoutedEventArgs e)
        {
            bool isClicked2 = false;
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
        }

        private void GameField3_Click(object sender, RoutedEventArgs e)
        {
            bool isClicked3 = false;
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
        }

        private void GameField4_Click(object sender, RoutedEventArgs e)
        {
            bool isClicked4 = false;
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
        }

        private void GameField5_Click(object sender, RoutedEventArgs e)
        {
            bool isClicked5 = false;
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
        }

        private void GameField6_Click(object sender, RoutedEventArgs e)
        {
            bool isClicked6 = false;
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
        }

        private void GameField7_Click(object sender, RoutedEventArgs e)
        {
            bool isClicked7 = false;
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
        }

        private void GameField8_Click(object sender, RoutedEventArgs e)
        {
            bool isClicked8 = false;
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
        }

        private void GameField9_Click(object sender, RoutedEventArgs e)
        {
            bool isClicked9 = false;
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
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }
    }
}
