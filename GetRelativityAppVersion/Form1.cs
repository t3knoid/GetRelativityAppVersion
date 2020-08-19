using Ionic.Zip;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace GetRelativityAppVersion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btGetVersion_Click(object sender, EventArgs e)
        {
            // Set up temp file
            string tempfolder = String.Empty;
            try
            {
                tempfolder = Path.GetTempPath();                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Application.Exit();
            }

            // Extract application.xml from rap file
            try
            {
                using (ZipFile zip = ZipFile.Read(this.tbRAPFile.Text))
                {
                    ZipEntry rapfile = zip["application.xml"];
                    rapfile.Extract(tempfolder, ExtractExistingFileAction.OverwriteSilently);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            // Read file
            try
            {
                string tempfile = Path.Combine(tempfolder, "application.xml");
                using (XmlReader reader = XmlReader.Create(tempfile))
                {
                    while (reader.Read())
                    {
                        if (reader.IsStartElement())
                        {
                            if (reader.Name.ToString() == "Version" )
                            {
                                MessageBox.Show(reader.ReadString(),"Version info");
                            }
                        }
                    }
                }
                // Delete the file
                try
                {
                    File.Delete(tempfile);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    this.tbRAPFile.Text = openFileDialog1.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
