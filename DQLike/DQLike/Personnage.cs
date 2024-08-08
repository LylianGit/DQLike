using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DQLike
{
    public class Personnage
    {
        private string nom;
        private int force, agilite, vitalite, adresse, charme, soin, puissance, pv, pvmax, pm, pmmax, attaque, defense, style;
        private List<Sort> sorts;
        private Objet objet;
        private Objet arme;
        private Objet armure;
        public Personnage(string nom, int force, int agilite, int vitalite, int adresse, int charme, int soins, int puissance, int PV, int PM, int attaque, int defense, int style)
        {
            this.nom = nom;
            this.force = force;
            this.agilite = agilite;
            this.vitalite = vitalite;
            this.adresse = adresse;
            this.charme = charme;
            this.soin = soins;
            this.puissance = puissance;
            this.pv = PV;
            this.pvmax = PV;
            this.pm = PM;
            this.pmmax = PM;
            this.attaque = attaque;
            this.defense = defense;
            this.style = style;
            sorts = new List<Sort>();
            Sort attaquer = new Sort("Attaquer",0,1);
            this.ApprendreSort(attaquer);
        }
        public int GetPM()
        {
            return pm;
        }
        public void SetPM(int p)
        {
            pm += p;
        }
        public int GetPV()
        {
            return pv;
        }
        public void SetPV(int p)
        {
            pv += p;
        }
        public string AfficherPV()
        {
            return pv + "/" + pvmax + "PV";
        }

        public string AfficherPM()
        {
            return pm + "/" + pmmax + "PM";
        }

        public string getNom()
        {
            return nom;
        }

        public void ApprendreSort(Sort sort)
        {
            sorts.Add(sort);
        }

        public Sort Attaquer()
        {
            return sorts.First();
        }

        public int GetAgilite()
        {
            return agilite;
        }
    }
}
