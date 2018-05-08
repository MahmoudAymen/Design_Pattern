using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace dbstrat
{
    public class FichierXml
    {

        public void effacer()
        {
            throw new NotImplementedException();
        }

        public string lire(string s)
        {
            string lines = "";
            XmlTextReader reader = new XmlTextReader(s);
            while (reader.Read())
            {


                //Display the text in each element.
                lines += reader.Value;



            }


            return lines;
        }
    }
}