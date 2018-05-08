using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbstrat
{
    class Enfant : observateur
    {
        public string s { get; private set; }
        List<string> listEnfant = new List<string>();
        public Enfant(string s)
        {
            this.s = s;
        }
        public void Update(string s1)
        {

           this.s = s1;
        }
    }
}
