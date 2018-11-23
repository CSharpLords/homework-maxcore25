using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Documents;
using System.Windows.Media;
using Microsoft.Win32;

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
            StringBuilder resultString = new StringBuilder();
            bool italicIsActivated = false;
            bool boldIsActivated = false;
            bool quotingIsActivated = false;

            FlowDocument flowDocument = new FlowDocument();
            Paragraph paragraph = new Paragraph();
            flowDocument.Blocks.Add(paragraph);
            PreviewRichTextBox.Document = flowDocument;

            //string text = "**кот**u";
            string text = MarkdownTextBox.Text;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '-')
                {
                }
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
                                if (quotingIsActivated == true && text[i] == '`')
                                {
                                    Run run = new Run(resultString.ToString());
                                    run.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#f9f2f4"));
                                    run.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#c7254e"));
                                    paragraph.Inlines.Add(run);
                                    resultString.Clear();
                                    quotingIsActivated = false;
                                }
                                else
                                {
                                    if (text[i] == '`')
                                    {
                                        quotingIsActivated = true;
                                    }
                                    else
                                    {
                                        if (italicIsActivated == true)
                                        {
                                            resultString.Append(text[i]);
                                        }
                                        else if (boldIsActivated == true)
                                        {
                                            resultString.Append(text[i]);
                                        }
                                        else if (quotingIsActivated == true)
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

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Markdown file(*.md)|*.md";
            if (saveDialog.ShowDialog() == true)
            {
                File.WriteAllText(saveDialog.FileName, MarkdownTextBox.Text);
            }
        }

        private void OpenButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "Markdown file(*.md)|*.md|All(*.*)|*";
            if (openDialog.ShowDialog() == true)
            {
                string text = File.ReadAllText(openDialog.FileName);
                MarkdownTextBox.Text = text;
            }
        }
    }
}
