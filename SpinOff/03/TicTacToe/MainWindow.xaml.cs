using System.Windows;
using System.Windows.Controls;

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

        private void GameField_Click(object sender, RoutedEventArgs e)
        {
            if ((string) Label.Content != "    TIC-TAC-TOE")
            {
                return;
            }

            Button gameField = (Button) sender;
            if ((string) gameField.Content == "")
            {
                if (player1 == true)
                {
                    gameField.Content = "X";
                    player1 = false;
                }
                else
                {
                    gameField.Content = "O";
                    player1 = true;
                }
                CheckGameField(gameField);
            }
        }

        private void RestartButton_Click(object sender, RoutedEventArgs e)
        {
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

        private void CheckGameField(Button button)
        {
            if (((string)GameField1.Content != "") && (GameField1.Content == GameField2.Content && GameField1.Content == GameField3.Content) ||
                ((string)GameField1.Content != "") && (GameField1.Content == GameField4.Content && GameField1.Content == GameField7.Content) ||
                ((string)GameField1.Content != "") && (GameField1.Content == GameField5.Content && GameField1.Content == GameField9.Content) ||
                ((string)GameField3.Content != "") && (GameField3.Content == GameField5.Content && GameField3.Content == GameField7.Content) ||
                ((string)GameField2.Content != "") && (GameField2.Content == GameField5.Content && GameField2.Content == GameField8.Content) ||
                ((string)GameField3.Content != "") && (GameField3.Content == GameField6.Content && GameField3.Content == GameField9.Content) ||
                ((string)GameField4.Content != "") && (GameField4.Content == GameField5.Content && GameField4.Content == GameField6.Content) ||
                ((string)GameField7.Content != "") && (GameField7.Content == GameField8.Content && GameField7.Content == GameField9.Content)
            )
            {
                WriteWinner((string) button.Content);
            }
        }

        private void WriteWinner(string content)
        {
            if (content == "X")
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