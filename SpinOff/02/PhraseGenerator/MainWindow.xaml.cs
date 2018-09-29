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
        Random random = new Random();
        int indexNoun;
        int indexAdverb;
        int indexVerb;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void NounsList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            indexNoun = random.Next(0, NounsList.Items.Count);
        }

        private void AdverbsList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            indexAdverb = random.Next(0, AdverbsList.Items.Count);
        }

        private void VerbsList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            indexVerb = random.Next(0,AdverbsList.Items.Count);
        }

        private void GenerateButton_Click(object sender, RoutedEventArgs e)
        {
            Text.Content = ((ListBoxItem)NounsList.Items[indexNoun]).Content.ToString() + " " + ((ListBoxItem)AdverbsList.Items[indexAdverb]).Content.ToString() + " " + ((ListBoxItem)VerbsList.Items[indexVerb]).Content.ToString();
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
