using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using System.Drawing.Imaging;

namespace dbstrat
{
    public partial class RibbonForm1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        decorateur d,d1,d2 ;
        List<PictureBox> list = new List<PictureBox>();
        List<PictureBox> list1 = new List<PictureBox>();
        List<PictureBox> list2= new List<PictureBox>();
        int x = 0,y=0,z=0;
        forme f;
        Factory v = new Factory();
        string s = "F:\\Rectangles.png";
        string s1 = "F:\\t.png";
        string s2 = "F:\\trianglee.png";
        Form1 t;
        public RibbonForm1()
        {
            InitializeComponent();
            d = new decorateur(s);
            d1 = new decorateur(s1);
            d2 = new decorateur(s2);
            foreach (Control c in this.groupBox1.Controls  )
            {
                
                    if (c is PictureBox)
                    {
                        list.Add((PictureBox)c);
                    }
               
            }
            foreach (Control c in this.groupBox2.Controls)
            {

                if (c is PictureBox)
                {
                    list1.Add((PictureBox)c);
                }

            }
            foreach (Control c in this.groupBox3.Controls)
            {

                if (c is PictureBox)
                {
                    list2.Add((PictureBox)c);
                }

            }


           

            
        }


        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {


          
            if (e.Item.Equals(barButtonItem3))
            {
                x++;
                panel2.Visible = false;
                panel3.Visible = false;
                for (int i = 0; i < x; i++)
                {
                    f = v.getform("rectangle");
                    f.afficher(list[i]);
                   
                }
              

            }
     
               
            
        }
      

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
           
            
            if (e.Item.Equals(barButtonItem2))
            {
                y++;
                panel2.Visible = false;
                panel3.Visible = false;
                for (int i = 0; i < y; i++)
                {
                    f = v.getform("cercle");
                    f.afficher(list1[i]);

                }


            }
     
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (e.Item.Equals(barButtonItem1))
            {
               z++;
               panel2.Visible = false;
               panel3.Visible = false;
                for (int i = 0; i < z; i++)
                {
                    f = v.getform("triangle");
                    f.afficher(list2[i]);

                }


            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            d.affichage(list);
            d.affichage1(list1);
            d.affichage1(list2);
            
          
            
        }
        void cmd_DoubleClick(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                string a = ((PictureBox)sender).Name;
                if (pictureBox1.Name.Equals(a))
                {
                    d1.setBorder1(colorDialog1.Color, pictureBox1);
                }
                else if (pictureBox2.Name.Equals(a))
                {
                    d1.setBorder1(colorDialog1.Color, pictureBox2);
                }
                else if (pictureBox3.Name.Equals(a))
                {
                    d1.setBorder1(colorDialog1.Color, pictureBox3);
                }
                else if (pictureBox4.Name.Equals(a))
                {
                    d1.setBorder1(colorDialog1.Color, pictureBox4);
                }
                else if (pictureBox5.Name.Equals(a))
                {
                    d.setBorder(colorDialog1.Color, pictureBox5);
                }
                else if (pictureBox6.Name.Equals(a))
                {
                    d.setBorder(colorDialog1.Color, pictureBox6);
                }
                else if (pictureBox7.Name.Equals(a))
                {
                    d.setBorder(colorDialog1.Color, pictureBox7);
                }
                else if (pictureBox8.Name.Equals(a))
                {
                    d.setBorder(colorDialog1.Color, pictureBox8);
                }
                else if (pictureBox9.Name.Equals(a))
                {
                    d.setBorder(colorDialog1.Color, pictureBox9);
                }
                else if (pictureBox10.Name.Equals(a))
                {
                    d.setBorder(colorDialog1.Color, pictureBox10);
                }
                else if (pictureBox11.Name.Equals(a))
                {
                    d1.setBorder1(colorDialog1.Color, pictureBox11);
                }
                else if (pictureBox12.Name.Equals(a))
                {
                    d1.setBorder1(colorDialog1.Color, pictureBox12);
                }
                else if (pictureBox13.Name.Equals(a))
                {
                    d1.setBorder1(colorDialog1.Color, pictureBox13);
                }
                else if (pictureBox14.Name.Equals(a))
                {
                    d.setBorder(colorDialog1.Color, pictureBox14);
                }
                else if (pictureBox15.Name.Equals(a))
                {
                    d.setBorder(colorDialog1.Color, pictureBox15);
                }
                else if (pictureBox22.Name.Equals(a))
                {
                    d.setBorder(colorDialog1.Color, pictureBox22);
                }
                else if (pictureBox17.Name.Equals(a))
                {
                    d2.setBorder1(colorDialog1.Color, pictureBox17);
                }
                else if (pictureBox18.Name.Equals(a))
                {
                    d2.setBorder1(colorDialog1.Color, pictureBox18);
                }
                else if (pictureBox19.Name.Equals(a))
                {
                    d2.setBorder1(colorDialog1.Color, pictureBox19);
                }
                

            }
        }
        
        private void simpleButton3_Click(object sender, EventArgs e)
        {
            if (t.simpleButton3.Name == "simpleButton3")
            {

                panel3.Visible = true;
                observater o = new observater();
                o.TopLevel = false;
                o.FormBorderStyle = FormBorderStyle.None;
                o.Parent = panel3;
                o.Show();
            }
          
        }
        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
           
             if (e.Item.Equals(barButtonItem4))
             {
                 panel2.Visible = true;
                 panel3.Visible = false;
                 t = new Form1();
                 t.TopLevel = false;
                 t.FormBorderStyle = FormBorderStyle.None;
                 t.Parent = panel2;
                 t.Show();
             }

             t.simpleButton3.Click += simpleButton3_Click;
           
        }

        private void pictureBox5_MouseMove(object sender, MouseEventArgs e)
        {
            f = v.getform("rectangle");
            f.deplace(pictureBox5, e);
        }

        private void pictureBox6_MouseMove(object sender, MouseEventArgs e)
        {
            f = v.getform("rectangle");
            f.deplace(pictureBox6, e);
        }

        private void pictureBox7_MouseMove(object sender, MouseEventArgs e)
        {
            f = v.getform("rectangle");
            f.deplace(pictureBox7, e);
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            f = v.getform("cercle");
            f.deplace(pictureBox1, e);
        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            f = v.getform("cercle");
            f.deplace(pictureBox2, e);
        }

        private void pictureBox3_MouseMove(object sender, MouseEventArgs e)
        {
            f = v.getform("cercle");
            f.deplace(pictureBox3, e);
        }

        private void pictureBox19_MouseMove(object sender, MouseEventArgs e)
        {
            f = v.getform("triangle");
            f.deplace(pictureBox19, e);
        }

        private void pictureBox18_MouseMove(object sender, MouseEventArgs e)
        {
            f = v.getform("triangle");
            f.deplace(pictureBox18, e);
        }

        private void pictureBox17_MouseMove(object sender, MouseEventArgs e)
        {
            f = v.getform("triangle");
            f.deplace(pictureBox17, e);
        }

     

      


    }
}