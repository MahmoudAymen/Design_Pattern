using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbstrat
{
    interface observable
    {
        void Abonnee(observateur obs);
        void Desabonnee(observateur obs);
        void Notifier();
    }
}
