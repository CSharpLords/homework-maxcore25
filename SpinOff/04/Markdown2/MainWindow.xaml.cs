
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
            bool firstStarInText = false;
            int amountOfStars = 0;
            bool italicIsActivated = false;
            StringBuilder resultString = new StringBuilder();
            bool boldIsActivated = false;

            FlowDocument flowDocument = new FlowDocument();
            Paragraph paragraph = new Paragraph();
            flowDocument.Blocks.Add(paragraph);
            PreviewRichTextBox.Document = flowDocument;

            //string text = "a**кот**u";
            string text = MarkdownTextBox.Text;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '*' && firstStarInText == false)
                {
                    firstStarInText = true;
                    italicIsActivated = true;
                }
                else if (text[i] == '*' && text[i - 1] == '*') 
                {
                    if (i < 0)
                    {
                        i++;
                    }
                    if (i >= text.Length)
                    {
                        i--;
                    }
                    boldIsActivated = true;
                    italicIsActivated = false;
                    amountOfStars += 2;
                    
                    if (boldIsActivated == true && amountOfStars == 4) 
                    {
                        Bold bold = new Bold(new Run(resultString.ToString()));
                        paragraph.Inlines.Add(bold);
                        resultString.Clear();
                        amountOfStars = 0;
                        boldIsActivated = false;
                    }
                }
                else
                {
                    if (italicIsActivated == true && text[i] == '*')
                    {
                        Italic italic = new Italic(new Run(resultString.ToString()));
                        paragraph.Inlines.Add(italic);
                        resultString.Clear();
                        amountOfStars = 0;
                        italicIsActivated = false;
                    }
                    else
                    {
                        if (text[i] == '*') 
                        {
                            if (boldIsActivated == true)
                            {
                                italicIsActivated = false;
                            }
                            else
                            {
                                italicIsActivated = true; 
                            }
                        }
                        else // letters 
                        {
                            if (italicIsActivated == true)
                            {
                                resultString.Append(text[i]);
                            }
                            else if (boldIsActivated == true)
                            {
                                resultString.Append(text[i]);
                            }
                            else if(italicIsActivated != true && boldIsActivated != true)
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
