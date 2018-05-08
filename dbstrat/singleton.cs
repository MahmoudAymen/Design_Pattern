using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbstrat
{
    class singleton
    {
          static singleton instance;
          static int counteur;
        private singleton()
        {

        }
        public static singleton getInstance()
        {
            if(instance==null)
         {
             instance = new singleton();
             counteur++;
         }
            return instance;
        }
        public static int getCounteur()
        {
            return counteur;
        }
    }
}
