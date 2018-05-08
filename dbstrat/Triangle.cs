using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dbstrat
{
    class Triangle : forme
    {
        private Point MouseDownLocation;

        public void deplace(PictureBox pictureBox1, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                pictureBox1.Left = e.X + pictureBox1.Left - MouseDownLocation.X;
                pictureBox1.Top = e.Y + pictureBox1.Top - MouseDownLocation.Y;
               
            }
        }

        public double surface()
        {
            return 3.14 * Math.Pow(5, 2);

        }
        public void afficher(PictureBox pictureBox2)
        {
            pictureBox2.Visible = true;
        }
    }
}
