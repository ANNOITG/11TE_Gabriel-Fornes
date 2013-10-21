using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Öva_list
{
    
    class Program
    {
        static List<Lärare> lärareLista = new List<Lärare>();
        static List<Elev> elevLista = new List<Elev>();
        static void Main(string[] args)
        {
            
            //hejsan.Add(Console.ReadLine());
            //hejsan.Add(Console.ReadLine());

            //for (int i = 0; i < hejsan.Count; i++)
            //{
            //    Console.WriteLine(hejsan[i]);
            //    if (hejsan[i] == "Hejsan")
            //        hejsan[i] = "hejdå";
            //}
            //Console.WriteLine(hejsan[1]);
            //Console.ReadKey();
            //Console.Clear();

            
            Menu();       
            
            
            
            Console.ReadKey();

        }
        private static void Menu()
        {
            Elev elev = new Elev("gabbe", "13371337", "1238913812", "Adress", "bajs");
            elev.setKurser(new elevKurs("Matte", "A+"));
            Console.WriteLine(elev.ToString());
            elevLista.Add(elev);
            


            //Console.Clear();
            Console.WriteLine("Välj vad du vill lägga till\n");

            Console.WriteLine("A:Lägg till lärare\n");
            Console.WriteLine("B:Lägg till kurs\n");
            Console.WriteLine("C:Lägg till elev\n");
            Console.WriteLine("D:Se alla lärare\n");
            Console.WriteLine("E:Se alla kurser\n");
            Console.WriteLine("F:Se alla elever\n");

            string alternativ = Console.ReadLine().ToLower();
            /*
            if (alternativ == "a")
            {
                addLärare();
            }

            else if (alternativ == "b")
            {
                addKurs();
            }
            else if (alternativ == "c")
            {
                addElev();
            }
            else if (alternativ == "d")
            {
                seLärare();
            }
            else if (alternativ == "e")
            {
                seKurs();
            }
            else if (alternativ == "f")
            {
                seElev();
            }
             * */
        }
        /*
        private static void addLärare()
        {
                Console.Clear();
                while (true)
                {
                    Console.WriteLine("Skriv lärarens namn och klicka sedan på enter.\nOm du vill gå till menyn så skriver du exit.");
                    string b = Console.ReadLine();
                    if (b == "exit")
                    {
                        break;
                    }
                    else if (b == "clear")
                    {
                        Console.WriteLine("Du kommer nu ta bort alla namn i listan.\nÄr du säker på att du vill göra det? j/n");
                        string c = Console.ReadLine();
                        if (c == "j")
                        {
                            lärare.Clear();
                            break;
                        }
                        else if (c == "n")
                        {
                            
                        }

                    }
                    lärare.Add(b);
                    Console.Clear();
                }
                Console.Clear();
                Menu();
        }

        private static void addKurs()
        {
            Console.Clear();
            while (true)
            {
                Console.WriteLine("Skriv kursens namn och klicka sedan på enter.\nOm du vill gå till menyn så skriver du exit.");

                string b = Console.ReadLine();
                if (b == "exit")
                {
                    break;
                }
                kurs.Add(b);
                Console.Clear();
            }
            Console.Clear();
            Menu();

        }

        private static void addElev()
        {
            while (true)
            {
                Console.WriteLine("Skriv elevens namn och klicka sedan på enter.\nOm du vill gå till menyn så skriver du exit.");

                string b = Console.ReadLine();
                if (b == "exit")
                {
                    break;
                }
                elev.Add(b);
                Console.Clear();
    
            }
            Menu();
        }

        private static void seLärare()
        {
            Console.Clear();
            Console.WriteLine("Här ser du alla lärare. Skriv tryck på enter för att gå till menyn.");
            for (int i = 0; i < lärare.Count; i++)
            {               
                Console.WriteLine((i+1) + ". " + lärare[i]);                
            }
            Console.ReadKey();
            Menu();
        }

        private static void seKurs()
        {
            Console.Clear();
            Console.WriteLine("Här ser du alla kurser. Skriv tryck på enter för att gå till menyn.");
            for (int i = 0; i < lärare.Count; i++)
            {               
                Console.WriteLine(kurs[i]);                
            }
            Console.ReadKey();
            Menu();

        }

        private static void seElev()
        {
            Console.Clear();
            Console.WriteLine("Här ser du alla elever. Skriv tryck på enter för att gå till menyn.");
            for (int i = 0; i < elev.Count; i++)
            {
                Console.WriteLine(elev[i]);
            }
            Console.ReadKey();
            Menu();
        }
        */
    }



    public class Person
    {
        private string namn;
        private string pnr;
        private string telenr;
        private string adress;



        public string getNamn() { return namn; }
        public void setNamn(string namn) { this.namn = namn; }

        public string getPnr() { return pnr; }
        public void setPnr(string personnummer) { this.pnr = personnummer; }

        public string getTeleNr() { return telenr; }
        public void setTeleNr(string telenr) { this.telenr = telenr; }

        public string getAdress() { return adress; }
        public void setAdress(string adress) { this.adress = adress; }
    }

    public class Lärare : Person
    {
        private string lön;
        private string kurser;

        public string getLön() { return lön; }
        public void setLön(string lön) { this.lön = lön; }

        public string getKurser() { return kurser; }
        public void setKurser(string kurser) { this.kurser = kurser; }


        public Lärare(string namn, string personnummer, string teleNr, string Adress)
        {
            setNamn(namn);
            setPnr(personnummer);
            setTeleNr(teleNr);
            setAdress(Adress);


        }
        public void höjLön(int höjningAvLön)
        {
            lön += höjningAvLön;
            
        }
    


    }

    public class Elev : Person
    {
        private string klass;
        private List<elevKurs> kurser = new List<elevKurs>();

        public string getKlass() { return klass; }
        public void setKlass(string klass) { this.klass = klass; }

        public List<elevKurs> getKurser() { return kurser; }
        public void setKurser(elevKurs kurs) { this.kurser.Add(kurs);
                
        }


         public Elev(string namn, string personnummer, string teleNr, string Adress, string klass)
        {
            setNamn(namn);
            setPnr(personnummer);
            setTeleNr(teleNr);
            setAdress(Adress);
            setKlass(klass);

        }
         public override string ToString()
         {


             string text = "Namn: " + getNamn() + "\n" + getKlass() + "\n" + getTeleNr() + "\n" + getPnr() + "\n" + getAdress();

             for(int i = 0;i<kurser.Count;i++){
                 text += "\n" + kurser[i].kursNamn + " " + kurser[i].betyg + "\n--------------------------------------------";
             }
             return text;
         }
    }

    public class elevKurs
    {
        public string kursNamn { get; set; }
        public string betyg { get; set; }

        public elevKurs(string kNamn, string kBetyg)
        {
            this.kursNamn = kNamn;
            this.betyg = kBetyg;
        }

    }
}
