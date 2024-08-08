using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DQLike
{
    public class Sort
    {
        private string nom;
        private int coutMana;
        private int nbCible;
        public Sort(string nom, int coutMana, int nbCible)
        {
            this.nom = nom;
            this.coutMana = coutMana;
            this.nbCible = nbCible;
        }
        public Sort(int nbCible)
        {
            this.nom = "";
            this.coutMana = 0;
            this.nbCible = nbCible;
        }

        public void UtiliserSort(Personnage utilisateur, List<Personnage> cibles, int dgt)
        {
            if (coutMana > utilisateur.GetPM())
                return;
            utilisateur.SetPM(-coutMana);
            foreach (Personnage cible in cibles)
            {
                cible.SetPV(dgt);
            }
        }

        public int GetNbCibles()
        {
            return nbCible;
        }
    }
}
