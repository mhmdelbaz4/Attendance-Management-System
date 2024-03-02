/*using System;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Xsl;
using PdfSharp.Pdf;
using PdfSharp.Drawing;
using PdfSharp.Drawing.Layout;
using PdfSharp.Fonts;
using PdfSharp.Pdf.IO;

namespace Attendance_Management_System.Forms
{
    public partial class tryPdf : Form
    {
        public tryPdf()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialogXml = new OpenFileDialog();
            openFileDialogXml.Filter = "XML Files (*.xml)|*.xml|All Files (*.*)|*.*";
            if (openFileDialogXml.ShowDialog() == DialogResult.OK)
            {
                string xmlFilePath = openFileDialogXml.FileName;

                string xsltFilePath =@"../../../../../xml/Untitled2.xslt"; // Specify the XSLT file name here

                string xmlContent = File.ReadAllText(xmlFilePath);

                string htmlContent = TransformXmlWithXslt(xmlContent, xsltFilePath);

                string pdfOutputPath = Path.ChangeExtension(xmlFilePath, ".pdf");

                ConvertHtmlToPdf(htmlContent, pdfOutputPath);

                MessageBox.Show("PDF generated successfully at:\n" + pdfOutputPath, "Conversion Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private string TransformXmlWithXslt(string xmlContent, string xsltFilePath)
        {
            using (StringReader xsltReader = new StringReader(File.ReadAllText(xsltFilePath)))
            {
                XslCompiledTransform xslt = new XslCompiledTransform();
                xslt.Load(XmlReader.Create(xsltReader));

                using (StringReader xmlReader = new StringReader(xmlContent))
                using (StringWriter outputWriter = new StringWriter())
                {
                    xslt.Transform(XmlReader.Create(xmlReader), null, outputWriter);
                    return outputWriter.ToString();
                }
            }
        }

        private void ConvertHtmlToPdf(string htmlContent, string pdfOutputPath)
        {
            PdfDocument document = new PdfDocument();
            PdfPage page = document.AddPage();

            XGraphics gfx = XGraphics.FromPdfPage(page);
            XFont font = new XFont("Helvetica-Bold", 12);

            // Draw the HTML content on the PDF page
            XTextFormatter tf = new XTextFormatter(gfx);
            tf.DrawString(htmlContent, font, XBrushes.Black, new XRect(10, 10, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);

            // Save the PDF file
            document.Save(pdfOutputPath);
            document.Close();
        }

        private void tryPdf_Load(object sender, EventArgs e)
        {

        }
    }
}*//*
using System;
using System.IO;
using System.Windows.Forms;
using System.Xml.Xsl;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;

namespace Attendance_Management_System.Forms
{
    public partial class tryPdf : Form
    {
        public tryPdf()
        {
            InitializeComponent();
        }
        /*
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialogXml = new OpenFileDialog();
            openFileDialogXml.Filter = "XML Files (*.xml)|*.xml|All Files (*.*)|*.*";
            if (openFileDialogXml.ShowDialog() == DialogResult.OK)
            {
                string xmlFilePath = openFileDialogXml.FileName;

                string xsltFilePath = @"../../../../../xml/XSL Output3.html"; // Specify the XSLT file name here

                string xmlContent = File.ReadAllText(xmlFilePath);

                string htmlContent = TransformXmlWithXslt(xmlContent, xsltFilePath);

                string pdfOutputPath = Path.ChangeExtension(xmlFilePath, ".pdf");

                ConvertHtmlToPdf(htmlContent, pdfOutputPath);

                MessageBox.Show("PDF generated successfully at:\n" + pdfOutputPath, "Conversion Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private string TransformXmlWithXslt(string xmlContent, string xsltFilePath)
        {
            // Implement XSLT transformation if necessary
            return xmlContent;
        }

        private void ConvertHtmlToPdf(string htmlContent, string pdfOutputPath)
        {
            using (FileStream outputStream = new FileStream(pdfOutputPath, FileMode.Create))
            {
                PdfWriter writer = new PdfWriter(outputStream);
                PdfDocument pdf = new PdfDocument(writer);
                Document document = new Document(pdf);

                // Add HTML content to the PDF document
                document.Add(new Paragraph(htmlContent));

                // Close the document
                document.Close();
            }
        }

        private void tryPdf_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialogXml = new OpenFileDialog();
            openFileDialogXml.Filter = "XML Files (*.xml)|*.xml|All Files (*.*)|*.*";
            if (openFileDialogXml.ShowDialog() == DialogResult.OK)
            {
                string xmlFilePath = openFileDialogXml.FileName;
                string xsltFilePath = @"../../../../../xml/Untitled2.xslt"; // Specify the path to your XSLT file here

                // Transform XML using XSLT
                string outputHtmlFilePath = TransformXmlWithXslt(xmlFilePath, xsltFilePath);

                // Print the HTML content
                PrintHtmlFile(@".. /../../../../xml/XSL Output4.html");
            }
        }

        private string TransformXmlWithXslt(string xmlFilePath, string xsltFilePath)
        {
            // Output HTML file path
            string outputHtmlFilePath = @".. /../../../../xml/XSL Output4.html";

            XslCompiledTransform xslt = new XslCompiledTransform();
            xslt.Load(xsltFilePath);

            // Transform XML using XSLT and save the result to output.html
            xslt.Transform(xmlFilePath, outputHtmlFilePath);

            return outputHtmlFilePath;
        }

        private void PrintHtmlFile(string htmlFilePath)
        {
            // Read the content of the HTML file
            string htmlContent = File.ReadAllText(htmlFilePath);

            // Print the HTML content using a WebBrowser control
            WebBrowser browser = new WebBrowser();
            browser.DocumentText = htmlContent;
            browser.DocumentCompleted += (sender, e) =>
            {
                // Print the document once it has finished loading
                browser.Print();
            };
        }


    }
}
*/
/*not interpreted
using System;
using System.IO;
using System.Windows.Forms;
using System.Xml.Xsl;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;

namespace Attendance_Management_System.Forms
{
    public partial class tryPdf : Form
    {
        public tryPdf()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialogXml = new OpenFileDialog();
            openFileDialogXml.Filter = "XML Files (*.xml)|*.xml|All Files (*.*)|*.*";
            if (openFileDialogXml.ShowDialog() == DialogResult.OK)
            {
                string xmlFilePath = openFileDialogXml.FileName;
                string xsltFilePath = @"../../../../../xml/Untitled2.xslt"; // Specify the path to your XSLT file here

                // Transform XML using XSLT
                string outputHtmlFilePath = TransformXmlWithXslt(xmlFilePath, xsltFilePath);

                // Convert HTML to PDF
                string pdfOutputPath = Path.ChangeExtension(xmlFilePath, ".pdf");
                ConvertHtmlToPdf(outputHtmlFilePath, pdfOutputPath);

                MessageBox.Show("PDF generated successfully at:\n" + pdfOutputPath, "Conversion Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private string TransformXmlWithXslt(string xmlFilePath, string xsltFilePath)
        {
            // Output HTML file path
            string outputHtmlFilePath = @"../../../../../xml/XSL Output4.html";

            XslCompiledTransform xslt = new XslCompiledTransform();
            xslt.Load(xsltFilePath);

            // Transform XML using XSLT and save the result to output.html
            xslt.Transform(xmlFilePath, outputHtmlFilePath);

            return outputHtmlFilePath;
        }

        private void ConvertHtmlToPdf(string htmlFilePath, string pdfOutputPath)
        {
            using (FileStream outputStream = new FileStream(pdfOutputPath, FileMode.Create))
            {
                PdfWriter writer = new PdfWriter(outputStream);
                PdfDocument pdf = new PdfDocument(writer);
                Document document = new Document(pdf);

                // Read the content of the HTML file
                string htmlContent = File.ReadAllText(htmlFilePath);

                // Add HTML content to the PDF document
                document.Add(new Paragraph(htmlContent));

                // Close the document
                document.Close();
            }
        }
    }
}
*/
using System;
using System.IO;
using System.Windows.Forms;
using System.Xml.Xsl;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Html2pdf;

namespace Attendance_Management_System.Forms
{
    public partial class tryPdf : Form
    {
        public tryPdf()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialogXml = new OpenFileDialog();
            openFileDialogXml.Filter = "XML Files (*.xml)|*.xml|All Files (*.*)|*.*";
            if (openFileDialogXml.ShowDialog() == DialogResult.OK)
            {
                string xmlFilePath = openFileDialogXml.FileName;
                string xsltFilePath = @"../../../../../xml/Untitled2.xslt"; // Specify the path to your XSLT file here

                // Transform XML using XSLT
                string outputHtmlFilePath = TransformXmlWithXslt(xmlFilePath, xsltFilePath);

                // Convert HTML to PDF
                string pdfOutputPath = Path.ChangeExtension(xmlFilePath, ".pdf");
                ConvertHtmlToPdf(outputHtmlFilePath, pdfOutputPath);

                MessageBox.Show("PDF generated successfully at:\n" + pdfOutputPath, "Conversion Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private string TransformXmlWithXslt(string xmlFilePath, string xsltFilePath)
        {
            // Output HTML file path
            string outputHtmlFilePath = @"../../../../../xml/XSL Output4.html";

            XslCompiledTransform xslt = new XslCompiledTransform();
            xslt.Load(xsltFilePath);

            // Transform XML using XSLT and save the result to output.html
            xslt.Transform(xmlFilePath, outputHtmlFilePath);

            return outputHtmlFilePath;
        }

        private void ConvertHtmlToPdf(string htmlFilePath, string pdfOutputPath)
        {
            // Read the content of the HTML file
            string htmlContent = File.ReadAllText(htmlFilePath);

            using (FileStream outputStream = new FileStream(pdfOutputPath, FileMode.Create))
            {
                ConverterProperties properties = new ConverterProperties();
                HtmlConverter.ConvertToPdf(htmlContent, outputStream, properties);
            }
        }
    }
}

