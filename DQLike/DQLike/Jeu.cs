using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DQLike
{
    public class Jeu
    {
        public List<Personnage> Classe()
        {
            List<Personnage> list = new List<Personnage>();
            list.Add(new Personnage("Guerrier", 18, 4, 18, 5, 4, 0, 0, 26, 4, 18, 18, 4));
            list.Add(new Personnage("Prêtre", 9, 14, 9, 9, 7, 18, 0, 19, 14, 9, 9, 7));
            list.Add(new Personnage("Mage", 4, 18, 7, 14, 7, 0, 18, 18, 16, 4, 7, 7));
            list.Add(new Personnage("Artiste Martial", 18, 23, 11, 11, 5, 0, 0, 24, 2, 23, 15, 19));
            list.Add(new Personnage("Voleur", 13, 18, 11, 18, 3, 4, 0, 23, 6, 17, 15, 18));
            list.Add(new Personnage("Troubadour", 9, 8, 8, 12, 9, 7, 6, 20, 6, 18, 12, 21));
            return list;
        }
    }


}
