using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dbstrat
{
   public interface forme
    {
        double surface();
        void deplace(PictureBox pictureBox1, MouseEventArgs e);
        void afficher(PictureBox pictureBox1);
    }
}
