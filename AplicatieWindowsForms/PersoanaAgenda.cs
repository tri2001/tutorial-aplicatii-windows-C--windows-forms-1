using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicatieWindowsForms
{
    public class PersoanaAgenda
    {
        public enum Gen
        {
            Masculin, Feminin
        }

        public string Nume;
        public string Telefon;
        public Gen GenulPersoanei;
    }
}
