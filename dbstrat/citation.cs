using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbstrat
{
    class citation : observable
    {
        private List<observateur> enfants = new List<observateur>();
        private string proverbe;
        public void Abonnee(observateur obs)
        {
            enfants.Add(obs);
        }
        public void Desabonnee(observateur obs)
        {
            enfants.Remove(obs);
        }
        public void Notifier()
        {
            foreach (observateur o in enfants)
            {
                o.Update(proverbe);
            }

        }
        public string SetProverbeState
        {
            get { return proverbe; }
            set { proverbe = value; }

        }
    }
}
