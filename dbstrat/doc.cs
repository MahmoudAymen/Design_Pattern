using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft;
using NetOffice.WordApi;


namespace dbstrat
{
   public class doc :action
    {
       public string lire(string s)
       {
           string lines = "";
           Application application = new Application();
           Document document = application.Documents.Open(@s);

           // Loop through all words in the document.
           int count = document.Words.Count;
           for (int i = 1; i <= count; i++)
           {
               // Write the word.
               lines += document.Words[i].Text;

           }
           // Close word.
           application.Quit();
           return lines;
       }
       public void effacer()
        {
            throw new NotImplementedException();
        }
      
    }
    
}
