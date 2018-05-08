using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dbstrat
{
    public class decorateur : shapedecorator
    {
        string fileToDisplay;
        public decorateur(String fileToDisplay)
        {
            this.fileToDisplay = fileToDisplay;
        }
        public decorateur(forme shapedecorator) : base(shapedecorator) { }
        public override void setBorder(Color c, PictureBox pictureBox1)
        {
            Bitmap bmp = new Bitmap(fileToDisplay);
            for (int x = 0; x < bmp.Width ; x++)
            {
                for (int y = 0; y < bmp.Height; y++)
                {

                    bmp.SetPixel(x, y, c);
                }
            }
            pictureBox1.Image = bmp;

        }
        public void affichage(List<PictureBox>lisBox)
        {
            for(int i=1;i<lisBox.Count;i++) 
            {
                lisBox[i].Visible = false;
            }
        }
        public void affichage1(List<PictureBox> lisBox)
        {
            for (int i = 0; i < lisBox.Count; i++)
            {
                lisBox[i].Visible = false;
            }
        }
        public override void setBorder1(Color c, PictureBox PictureBox1)
        {
           
             
                Bitmap image1 = new Bitmap(fileToDisplay, true);

                int x, y;

              
                for (x = 0; x < image1.Width; x++)
                {
                    for (y = 0; y < image1.Height; y++)
                    {
                        
                       c = image1.GetPixel(x, y);
                       
                            if (c.A<0)
                            {
                                Color newColor = Color.FromArgb(c.R, c.G, c.B);
                                image1.SetPixel(x, y, newColor);
                            
                        }
                    }
                }
                PictureBox1.Image = image1;

         
        }
    }
}
