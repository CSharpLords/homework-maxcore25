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

namespace PhraseGenerator
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
        
        private void GenerateButton_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            int indexNoun = random.Next(0, NounsList.Items.Count);
            int indexAdverb = random.Next(0, AdverbsList.Items.Count);
            int indexVerb = random.Next(0, AdverbsList.Items.Count);
            Text.Content = ((ListBoxItem)NounsList.Items[indexNoun]).Content.ToString() + " " + ((ListBoxItem)AdverbsList.Items[indexAdverb]).Content.ToString() + " " + ((ListBoxItem)VerbsList.Items[indexVerb]).Content.ToString();
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void AddNounButton_Click(object sender, RoutedEventArgs e)
        {
            NounsList.Items.Add(NounTextBox.Text);
        }

        private void AddAdverbButton_Click(object sender, RoutedEventArgs e)
        {
            AdverbsList.Items.Add(AdverbTextBox.Text);
        }

        private void AddVerbButton_Click(object sender, RoutedEventArgs e)
        {
            VerbsList.Items.Add(VerbTextBox.Text);
        }
    }
}
