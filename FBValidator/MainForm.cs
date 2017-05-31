using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Schema;

namespace FBValidator
{
    public partial class MainForm : Form
    {
        readonly XmlSchema FB2Schema;
        static readonly List<string> statusLines = new List<string>();

        public MainForm()
        {
            InitializeComponent();

            using (var FB2SchemaReader = XmlReader.Create(@"Schemas\FB2\2.2\FictionBook.xsd"))
            {
                FB2Schema = XmlSchema.Read(FB2SchemaReader, null);
            }

        }

        static void FB2ValidationEventHandler(object sender, ValidationEventArgs e)
        {
            statusLines.Add(e.Message);
        }

        private void buttonValidate_Click(object sender, EventArgs e)
        {

            var FB2Document = new XmlDocument();
            FB2Document.Schemas.Add(@"http://www.gribuser.ru/xml/fictionbook/2.0", @"Schemas\FB2\2.1\FictionBook.xsd");
            FB2Document.Load(textBoxInput.Text);
            FB2Document.Validate(FB2ValidationEventHandler);

            textBoxInformation.Lines = statusLines.ToArray();
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
                textBoxInput.Text = openFileDialog.FileName;
        }
    }
}
