using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;

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
            Paragraph paragraph = new Paragraph();

            BoldType(paragraph);

            FlowDocument flowDocument = new FlowDocument();
            flowDocument.Blocks.Add(paragraph);

            PreviewRichTextBox.Document = flowDocument;
        }

        private void BoldType(Paragraph paragraph)
        {
            string[] parts = MarkdownTextBox.Text.Split(new[] { "**" }, StringSplitOptions.None);
            for (int i = 0; i < parts.Length; i++)
            {
                if (i % 2 != 0)
                {
                    Bold bold = new Bold(new Run(parts[i]));
                    paragraph.Inlines.Add(bold);
                }
                else
                {
                    string[] splittedParts = parts[i].Split(new[] { "*" }, StringSplitOptions.None);
                    ItalicType(paragraph, splittedParts);
                }
            }
        }

        private void ItalicType(Paragraph paragraph, string[] parts)
        {

            for (int i = 0; i < parts.Length; i++)
            {
                if (i % 2 != 0)
                {
                    Italic italic = new Italic(new Run(parts[i]));
                    paragraph.Inlines.Add(italic);
                }
                else
                {
                    Run run = new Run(parts[i]);
                    paragraph.Inlines.Add(run);
                }
            }
        }
    }
}
