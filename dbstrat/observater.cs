using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.IO;

namespace dbstrat
{
    public partial class observater : DevExpress.XtraEditors.XtraForm
    {

        static  string s="F:\\citations.txt";
        int i=1;
        static string s1 = System.IO.File.ReadAllText(s);
        static char split = '.';
        static  string[] Data=Data = s1.Split(split);
        public observater()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
                
                citation c = new citation();
                observateur o = new Enfant(s);
                c.Abonnee(o);
                c.Notifier();
               if (simpleButton1.Text == "S'abonner")
               {
                   if (i < Data.Length)
                   {
                       label1.Text = Data[i];
                       i++;
                   }
               }
                 
              
               
              
          

            
              
            }

        private void observater_Load(object sender, EventArgs e)
        {
          
              
            System.IO.StreamReader file =  new System.IO.StreamReader(@s);
            label1.Text = file.ReadLine();
            file.Close();

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            citation c = new citation();
            observateur o = new Enfant(s);
            c.Desabonnee(o);
            Random aleatoire = new Random();
            i = aleatoire.Next(1, Data.Length);
            label1.Text = Data[i];
            
        }

        }
    }
