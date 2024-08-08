namespace DQLike
{
    public partial class Form1 : Form
    {
        private List<Personnage> allies = new List<Personnage>();
        private List<Personnage> ennemis = new List<Personnage>();
        private List<Personnage> list = new List<Personnage>();

        private List<UserControl1> list1 = new List<UserControl1>();
        private List<UserControl1> list2 = new List<UserControl1>();
        

        public Form1(List<Personnage> grpEnnemi)
        {
            ennemis = grpEnnemi;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitTeam1();
            //InitTeam2();
            interfacePersonnage();
        }

        private void InitTeam1()
        {
            Personnage Guerrier = new Personnage("Guerrier", 18, 4, 18, 5, 4, 0, 0, 26, 4, 18, 18, 4);
            allies.Add(Guerrier);
            Personnage Pretre = new Personnage("Prêtre", 9, 14, 9, 9, 7, 18, 0, 19, 14, 9, 9, 7);
            Pretre.ApprendreSort(new Sort("Premiers soins",5,1));
            allies.Add(Pretre);
            Personnage Mage = new Personnage("Mage", 4, 18, 7, 14, 7, 0, 18, 18, 16, 4, 7, 7);
            Mage.ApprendreSort(new Sort("Boule de feu",2,1));
            allies.Add(Mage);
            Personnage Artiste = new Personnage("Artiste Martial", 18, 23, 11, 11, 5, 0, 0, 24, 2, 23, 15, 19);
            allies.Add(Artiste);
            Personnage Voleur = new Personnage("Voleur", 13, 18, 11, 18, 3, 4, 0, 23, 6, 17, 15, 18);
            allies.Add(Voleur);
            Personnage Troubadour = new Personnage("Troubadour", 9, 8, 8, 12, 9, 7, 6, 20, 6, 18, 12, 21);
            allies.Add(Troubadour);
        }

        private void InitTeam2()
        {
            Personnage Slime = new Personnage("Slime", 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5);
            ennemis.Add(Slime);

        }

        private void interfacePersonnage()
        {
            userControl121.InitListes(list1, list2);
            userControl122.InitListes(list1, list2);
            userControl123.InitListes(list1, list2);
            userControl124.InitListes(list1, list2);
            userControl125.InitListes(list1, list2);
            userControl126.InitListes(list1, list2);
            userControl127.InitListes(list1, list2);
            userControl128.InitListes(list1, list2);
            userControl129.InitListes(list1, list2);
            userControl130.InitListes(list1, list2);
            userControl131.InitListes(list1, list2);
            userControl132.InitListes(list1, list2);
            userControl133.InitListes(list1, list2);
            userControl134.InitListes(list1, list2);
            userControl135.InitListes(list1, list2);
            userControl136.InitListes(list1, list2);
            userControl137.InitListes(list1, list2);
            userControl138.InitListes(list1, list2);
            userControl139.InitListes(list1, list2);
            userControl138.InitListes(list1, list2);
            list1.Add(userControl121);
            list1.Add(userControl122);
            list1.Add(userControl123);
            list1.Add(userControl124);
            list1.Add(userControl125);
            list1.Add(userControl126);
            list1.Add(userControl127);
            list1.Add(userControl128);
            list1.Add(userControl129);
            list1.Add(userControl130);           
            list2.Add(userControl131);
            list2.Add(userControl132);
            list2.Add(userControl133);
            list2.Add(userControl134);
            list2.Add(userControl135);
            list2.Add(userControl136);
            list2.Add(userControl137);
            list2.Add(userControl138);
            list2.Add(userControl139);
            list2.Add(userControl140);

            list = allies.Concat(ennemis).ToList();
            list.OrderByDescending(x => x.GetAgilite()).ToList();
            foreach (Personnage p in list)
            {
                list1.Where(u => u.GetPersonnage() == p).First().ChangementTour(list1, list2);
            }
            int i = 0;
            foreach(UserControl1 u in list1)
            {
                if (i < allies.Count())
                {
                    u.ChangementTour(list1, list2); 
                    u.AfficherPersonnage(allies[i]);
                    u.SetListeA(allies);
                    u.SetListeE(ennemis);
                    i++;
                }
                else
                {
                    u.Visible = false;
                }
            }
            i = 0;
            foreach (UserControl1 u in list2)
            {
                if (i < ennemis.Count())
                {
                    u.AfficherPersonnage(ennemis[i]);
                    u.SetListeA(ennemis);
                    u.SetListeE(allies);
                    i++;
                }
                else
                {
                    u.Visible = false;
                }
            }

        }

        public void RafraichirEcran()
        {
            int i = 0;
            foreach (UserControl1 u in list1)
            {
                if (i < allies.Count())
                {
                    u.AfficherPersonnage(allies[i]);
                    i++;
                }
            }
            i = 0;
            foreach (UserControl1 u in list2)
            {
                if (i < ennemis.Count())
                {
                    u.AfficherPersonnage(ennemis[i]);
                    i++;
                }
            }
        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }
    }

    
}