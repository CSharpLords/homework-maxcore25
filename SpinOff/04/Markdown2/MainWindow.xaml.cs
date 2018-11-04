
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;

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



        private void MarkdownTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            int amountOfStars = 0;
            StringBuilder italicString = new StringBuilder();

            FlowDocument flowDocument = new FlowDocument();
            Paragraph paragraph = new Paragraph();
            flowDocument.Blocks.Add(paragraph);
            PreviewRichTextBox.Document = flowDocument;

            string text = "a*s*кот*s*u";
            //string text = MarkdownTextBox.Text;

            for (int i = 0; i < text.Length; i++)
            {
                if (amountOfStars == 1 && text[i] == '*')
                {
                    Italic italic = new Italic(new Run(italicString.ToString()));
                    paragraph.Inlines.Add(italic);
                    italicString.Clear();
                    amountOfStars = 0;
                }
                else
                {
                    if (text[i] == '*')
                    {
                        amountOfStars++;
                    }
                    else
                    {
                        if (amountOfStars == 1)
                        {
                            italicString.Append(text[i]);
                        }
                        else
                        {
                            Run run = new Run(text[i].ToString());
                            paragraph.Inlines.Add(run);
                        }
                    }
                }
            }
        }
    }
}
