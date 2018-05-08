using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dbstrat
{
    public abstract class shapedecorator : forme
    {
        protected forme decoratedShape;
        public shapedecorator(){}
        public shapedecorator(forme decoratedShape)
        {
          this.decoratedShape = decoratedShape;
         }
        public void deplace(PictureBox pictureBox1,MouseEventArgs e)
        {
            decoratedShape.deplace(pictureBox1,e );
        }
        public void afficher(PictureBox pictureBox1)
        {
            decoratedShape.afficher(pictureBox1);
        }
        public double surface()
        {
            return decoratedShape.surface();
        }
        public abstract void setBorder(Color c, PictureBox pictureBox1);
        public abstract  void setBorder1(Color c, PictureBox pictureBox1);


    }

}
