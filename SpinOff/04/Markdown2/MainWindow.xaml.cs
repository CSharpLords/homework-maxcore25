
using System;
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
            bool italicIsActivated = false;
            StringBuilder resultString = new StringBuilder();
            bool boldIsActivated = false;

            FlowDocument flowDocument = new FlowDocument();
            Paragraph paragraph = new Paragraph();
            flowDocument.Blocks.Add(paragraph);
            PreviewRichTextBox.Document = flowDocument;

            //string text = "**кот**u";
            string text = MarkdownTextBox.Text;

            for (int i = 0; i < text.Length; i++)
            {
                if (boldIsActivated == true && text[i] == '*' && i != 0 && text[i - 1] == '*')
                {
                    Bold bold = new Bold(new Run(resultString.ToString()));
                    paragraph.Inlines.Add(bold);
                    resultString.Clear();
                    boldIsActivated = false;
                    italicIsActivated = false;
                }
                else
                {
                    if (text[i] == '*' && i != 0 && text[i - 1] == '*')
                    {
                        boldIsActivated = true;
                        italicIsActivated = false;
                    }
                    else
                    {
                        if (italicIsActivated == true && text[i] == '*')
                        {
                            Italic italic = new Italic(new Run(resultString.ToString()));
                            paragraph.Inlines.Add(italic);
                            resultString.Clear();
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
                                    resultString.Append(text[i]);
                                }
                                else if (boldIsActivated == true)
                                {
                                    resultString.Append(text[i]);
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
}
