
using System.Security.AccessControl;
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
            bool italicIsActivated = false;
            StringBuilder italicString = new StringBuilder();
            bool boldIsActivated = false;
            StringBuilder boldString = new StringBuilder();

            FlowDocument flowDocument = new FlowDocument();
            Paragraph paragraph = new Paragraph();
            flowDocument.Blocks.Add(paragraph);
            PreviewRichTextBox.Document = flowDocument;

            //string text = "a**кот**u";
            string text = MarkdownTextBox.Text;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '*' && text[i + 1] == '*') //must correct this condition
                {
                    boldIsActivated = true;
                    amountOfStars += 2;
                    if (i >= text.Length)
                    {
                        i--;
                    }
                    if (boldIsActivated == true && amountOfStars == 4) 
                    {
                        Bold bold = new Bold(new Run(boldString.ToString()));
                        paragraph.Inlines.Add(bold);
                        boldString.Clear();
                        amountOfStars = 0;
                        boldIsActivated = false;
                    }
                }
                else
                {
                    if (amountOfStars == 1 && text[i] == '*')
                    {
                        Italic italic = new Italic(new Run(italicString.ToString()));
                        paragraph.Inlines.Add(italic);
                        italicString.Clear();
                        amountOfStars = 0;
                        italicIsActivated = false;
                    }
                    else
                    {
                        if (text[i] == '*')
                        {
                            italicIsActivated = true;
                        }
                        else // letters 
                        {
                            if (italicIsActivated == true)
                            {
                                italicString.Append(text[i]);
                            }
                            if (boldIsActivated == true)
                            {
                                boldString.Append(text[i]);
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
}
