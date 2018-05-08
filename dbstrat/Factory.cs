using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbstrat
{
    class Factory
    {
        public forme getform(String form)
        {
            if (form == null)
            {
                return null;
            }
            if (form.Equals("cercle"))
            {
                return new Cercle();

            }
            else if (form.Equals("rectangle"))
            {
                return new rectangle();

            }
            else if (form.Equals("triangle"))
            {
                return new Triangle();

            }


            return null;
        }
    }
}
