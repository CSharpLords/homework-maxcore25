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

namespace Markdown2018
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

        private void MarkdownTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void PreviewRichTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            StackPanel stackPanel = new StackPanel();
            FlowDocument flowDocument = new FlowDocument();
            Run run = new Run("hello");
            Bold bold = new Bold(new Run(" world"));
            Paragraph paragraph = new Paragraph();
            paragraph.Inlines.Add(run);
            paragraph.Inlines.Add(bold);
            flowDocument.Blocks.Add(paragraph);
            RichTextBox richTextBox = new RichTextBox();
            richTextBox.Document = flowDocument;
            stackPanel.Children.Add(richTextBox);
            this.Content = stackPanel;
        }
    }
}
