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

namespace Markdown2
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

        private int amountForItalic = 0;
        private int position1 = 0;
        private int position2 = 0;

        private void MarkdownTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {


            FlowDocument flowDocument = new FlowDocument();
            Paragraph paragraph = new Paragraph();
            Run run = new Run(MarkdownTextBox.Text);
            paragraph.Inlines.Add(run);
            flowDocument.Blocks.Add(paragraph);
            PreviewRichTextBox.Document = flowDocument;

            string convertToString = MarkdownTextBox.Text;

            for (int i = 0; i < MarkdownTextBox.Text.Length; i++)
            {
                if (amountForItalic == 1 && MarkdownTextBox.Text[i] == '*')
                {
                    amountForItalic = 0;

                    //position2 = MarkdownTextBox.Text.IndexOf('*', i);

                    StringBuilder stringBuilder = new StringBuilder();
                    stringBuilder.Append(MarkdownTextBox.Text);
                    stringBuilder.Insert('*', MarkdownTextBox.Text[i]);
                    convertToString = stringBuilder.ToString();

                    Italic italic = new Italic(new Run(convertToString));
                    paragraph.Inlines.Add(italic);
                    break;

                }
                if (MarkdownTextBox.Text[i] == '*')
                {
                    amountForItalic++;
                    break;
                    //position1 = MarkdownTextBox.Text.IndexOf('*', i);
                }
            }
        }
    }
}
