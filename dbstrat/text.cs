using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbstrat
{
    public class text : action
    {
        public string lire(string s)
        {


            string lines = "";
            string line;
            // Read the file and display it line by line.  
            System.IO.StreamReader file =
                new System.IO.StreamReader(@s);
            while ((line = file.ReadLine()) != null)
            {
                lines += line;
            }

            file.Close();

            return lines;
        }

       public void  effacer()
        {
            throw new NotImplementedException();
        }

        
    }
}
