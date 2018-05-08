using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.IO;

namespace dbstrat
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
      
        public Form1()
        {
            InitializeComponent();
        }

       

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (Path.GetExtension(openFileDialog1.FileName) == ".txt")
                {
                    action t = new text();

                    label1.MaximumSize = new Size(400, 0);
                    label1.AutoSize = true;
                    string s = openFileDialog1.FileName;

                    label1.Text = t.lire(s);

                }
                else if ((Path.GetExtension(openFileDialog1.FileName) == ".docx") || (Path.GetExtension(openFileDialog1.FileName) == ".doc"))
                {
                    action t = new doc();

                    label1.MaximumSize = new Size(400, 0);
                    label1.AutoSize = true;
                    string s = openFileDialog1.FileName;
                    label1.Text = t.lire(s);

                }
                else
                {
                    string ext = Path.GetExtension(openFileDialog1.FileName);
                    FichierXml xml = new FichierXml();
                    action d = new adapter(xml);
                    label1.MaximumSize = new Size(400, 0);
                    label1.AutoSize = true;
                    string s = openFileDialog1.FileName;
                    label1.Text = d.lire(s);
                }

            }
            singleton singleton = singleton.getInstance();
            int count = singleton.getCounteur();
            DevExpress.XtraEditors.XtraMessageBox.Show("nb de objet de singleton=" + count.ToString());
           

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            label1.Text = "";
        }

       
    }
}
