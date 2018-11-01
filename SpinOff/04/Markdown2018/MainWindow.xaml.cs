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
        private List<Element> elements;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MarkdownTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            Paragraph paragraph = new Paragraph();
            elements = new List<Element>();

            BoldType();
            ItalicType();
            UsualType();
            elements = elements.OrderBy(el => el.position).ToList();
            foreach (var element in elements)
            {
                paragraph.Inlines.Add(element.element);
            }

            FlowDocument flowDocument = new FlowDocument();
            flowDocument.Blocks.Add(paragraph);

            PreviewRichTextBox.Document = flowDocument;
        }

        private void BoldType()
        {
            string[] parts = MarkdownTextBox.Text.Split(new[] { "**" }, StringSplitOptions.None);
            int start = 0;
            for (int i = 0; i < parts.Length; i++)
            {
                if (i % 2 != 0)
                {
                    Bold bold = new Bold(new Run(parts[i]));
                    Element boldType = new Element();
                    boldType.element = bold;
                    boldType.position = MarkdownTextBox.Text.IndexOf("**", start);
                    start = boldType.position + 2 + parts[i].Length + 2;
                    elements.Add(boldType);
                }
            }
        }

        private void ItalicType()
        {
            string[] parts = MarkdownTextBox.Text.Split( new[] {"*"} , StringSplitOptions.None);
            int start = 0;
            for (int i = 0; i < parts.Length; i++)
            {
                if (i % 2 != 0)
                {
                    Italic italic = new Italic(new Run(parts[i]));
                    Element italicType = new Element();
                    italicType.element = italic;
                    italicType.position = MarkdownTextBox.Text.IndexOf("*", start);
                    start = italicType.position + 2 + parts[i].Length;
                    elements.Add(italicType);
                }
            }
        }

        private void UsualType()
        {
            string[] parts = MarkdownTextBox.Text.Split(new[] { "*"}, StringSplitOptions.None);
            int start = 0;
            for (int i = 0; i < parts.Length; i++)
            {
                if (i % 2 == 0)
                {
                    Run run = new Run(parts[i]);
                    Element usualType = new Element();
                    usualType.element = run;
                    usualType.position = MarkdownTextBox.Text.IndexOf("*", start);
                    start = usualType.position + parts[i].Length;
                    elements.Add(usualType);
                }
            }
        }
    }

    class Element
    {
        public Inline element;
        public int position;
    }
}
