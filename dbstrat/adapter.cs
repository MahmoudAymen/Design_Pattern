using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbstrat
{
   public class adapter:action
    {
       FichierXml fichier;
       public adapter(FichierXml fichier)
       {
           this.fichier = fichier;
       }
       public string lire(string s)
       {

           return fichier.lire(s);
       }
       public void effacer()
      {
          throw new NotImplementedException();
      }
    }
}
