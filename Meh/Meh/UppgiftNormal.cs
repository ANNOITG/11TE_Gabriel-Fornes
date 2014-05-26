using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Meh
{
    class WriteTextFile
    {
        static List<string> lines = new List<string>();        
          
        static void Main()
        {            
            Menu();          
        }

        private static void Menu()
        {
            while (true)
            {
                Console.Clear();
              
                Console.WriteLine("A: Write a new file.");
                Console.WriteLine("B: Read from an existing file");
                Console.WriteLine("C: Edit an already existing file");
                Console.WriteLine("D: Add more songs and artists to a file");
                Console.WriteLine("E: Delete a specified file");
                Console.WriteLine("\nWrite exit to go back to the menu.");
                string alternativ = Console.ReadLine().ToLower();

                if (alternativ == "a")
                {
                    Console.Clear();
                     addFile(); 
                    break;
                                      
                }
                else if (alternativ == "b")
                {
                    Console.Clear();
                    readFile(); 
                    break;
                                       
                }
                else if (alternativ == "c")
                {
                    Console.Clear();
                    editFile();
                    break;

                }
                else if (alternativ == "d")
                {
                    Console.Clear();
                    addMoreFile();
                    break;
                }
                else if (alternativ == "e")
                {
                    Console.Clear();
                    deleteFile();
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("You can only choose between A, B, C, D, or E. Press any key to continue...");
                    Console.ReadKey();
                    
                }
            }

        }

        private static void addFile()
        {

            lines.Add("Artist name: ");
            lines.Add("AlbumName: ");
            
            string filename = "";
            Console.Clear();

            Console.WriteLine("Write the Artists name: ");
            string c = Console.ReadLine();
            lines[0] += c;
            Console.Clear();

            Console.WriteLine("Write the album name: ");
            string a = Console.ReadLine();
            lines[1] += a;
            Console.Clear();

            Console.WriteLine("Write the song names. If you are finished press escape to move on.;");
            string sångNamn = "";


            for (; ; )
            {
                ConsoleKeyInfo cki = Console.ReadKey();

                if (cki.Key == ConsoleKey.Escape)
                {
                    break;
                }
                else
                {
                    if(cki.Key.ToString().Length == 1)
                        sångNamn += cki.Key.ToString();
                    
                    Console.Clear();
                    Console.Write(sångNamn);
                    sångNamn += Console.ReadLine();
                    lines.Add("Song Name: " + sångNamn);
                    sångNamn = "";
                    Console.Clear();
                }
            }
            Console.ReadKey();

            Console.Clear();
            Console.WriteLine(@"All the files in the folder \test");

            DirectoryInfo q = new DirectoryInfo(@"C:\Users\Public\Documents\test\");
            FileInfo[] Files = q.GetFiles("*.txt");
            foreach (FileInfo file in Files)
            {
                Console.WriteLine(file);
            }
            Console.WriteLine("___________________________________________________________________________");

          
            Console.WriteLine("Write what the file name will be:");
            while (true)
            {
                filename = Console.ReadLine();
                if (filename == "exit")
                {
                    Console.WriteLine("You can't name the file exit...");
                }

                else if (File.Exists(@"C:\Users\Public\Documents\test\" + filename + ".txt"))
                {
                    Console.Clear();
                    Console.WriteLine("Filename already exists. Write a new Filename.");
                }
                else
                {
                    File.WriteAllLines(@"C:\Users\Public\Documents\test\" + filename + ".txt", lines);
                    break;
                }
            }
            Console.Clear();
            lines.Clear();
            Menu();
        }

        private static void readFile()
        {
            Console.Clear();
            Console.WriteLine(@"All the files in the folder \test");
           
            DirectoryInfo c = new DirectoryInfo(@"C:\Users\Public\Documents\test\");
            FileInfo[] Files = c.GetFiles("*.txt"); 
            foreach (FileInfo file in Files)
            {
                Console.WriteLine(file);                
            }
            Console.WriteLine("___________________________________________________________________________");

            Console.WriteLine("Write the name of the file that you want.");

            string filnamn = "";
            
            while (true)
            {
                filnamn = Console.ReadLine();
                Console.Clear();

                if (filnamn == "exit")
                {
                    break;
                }

                if (!File.Exists(@"C:\Users\Public\Documents\test\" + filnamn + ".txt"))
                {
                    Console.Clear();
                    Console.WriteLine("Filename does not exist. Write a new Filename.");
                   

                }
                if(File.Exists(@"C:\Users\Public\Documents\test\" + filnamn + ".txt"))
                {                    
                    string[] readthefile = File.ReadAllLines(@"C:\Users\Public\Documents\test\" + filnamn + ".txt");
                    foreach (string s in readthefile)
                    {
                        Console.WriteLine(s);
                        
                        
                    }
                    Console.WriteLine("\nPress Enter to go back to the menu");
                    Console.ReadKey();
                    break;
                }
            }
            Menu();
        }

        private static void editFile()
        {
            Console.Clear();
            Console.WriteLine(@"All the files in the folder \test");

            DirectoryInfo a = new DirectoryInfo(@"C:\Users\Public\Documents\test\");
            FileInfo[] Files = a.GetFiles("*.txt");
            foreach (FileInfo file in Files)
            {
                Console.WriteLine(file);
            }
            Console.WriteLine("___________________________________________________________________________");

            Console.WriteLine("Write the name of an already existing file that you want to edit.");
            string filnamn = "";
             while (true)
            {


                filnamn = Console.ReadLine();
                Console.Clear();

                if (filnamn == "exit")
                {
                    Menu();
                    break;
                }

                if (!File.Exists(@"C:\Users\Public\Documents\test\" + filnamn + ".txt"))
                {
                    Console.Clear();
                    Console.WriteLine("Filename does not exist. Write a new Filename.");
                   

                }
                if(File.Exists(@"C:\Users\Public\Documents\test\" + filnamn + ".txt"))
                {                                                           
                    break;
                }

            }
            
             string[] filnamn2 = File.ReadAllLines(@"C:\Users\Public\Documents\test\" + filnamn + ".txt");
             foreach (string s in filnamn2)
             {
                 Console.WriteLine("Old text: " + s);
             }
             Console.WriteLine("________________________________________________________________________________");
             lines.Add("Songname: ");
             lines.Add("Artist name: ");
             
             
             Console.WriteLine("Write the new song name:");
             string b = Console.ReadLine();
             lines[0] += b;
             
             Console.WriteLine("Write the new artists name: ");
             string c = Console.ReadLine();
             lines[1] += c;
            
             
             Console.Clear();
             File.WriteAllLines(@"C:\Users\Public\Documents\test\" + filnamn + ".txt", lines);
             lines.Clear();
             





             Console.ReadKey();
             Menu();










        }

        private static void addMoreFile()
        {
            Console.Clear();
            Console.WriteLine(@"All the files in the folder \test");

            DirectoryInfo a = new DirectoryInfo(@"C:\Users\Public\Documents\test\");
            FileInfo[] Files = a.GetFiles("*.txt");
            foreach (FileInfo file in Files)
            {
                Console.WriteLine(file);
            }
            Console.WriteLine("___________________________________________________________________________");
            Console.WriteLine("Write the name of an already existing file that you want to edit.");
            string filnamn = "";
            while (true)
            {
                filnamn = Console.ReadLine();
                Console.Clear();

                if (filnamn == "exit")
                {
                    Menu();
                    break;
                    
                }

                if (!File.Exists(@"C:\Users\Public\Documents\test\" + filnamn + ".txt"))
                {
                    Console.Clear();
                    Console.WriteLine("Filename does not exist. Write a new Filename.");
                }
                if (File.Exists(@"C:\Users\Public\Documents\test\" + filnamn + ".txt"))
                {
                    break;
                }
            }
            string[] filnamn2 = File.ReadAllLines(@"C:\Users\Public\Documents\test\" + filnamn + ".txt");
            foreach (string s in filnamn2)
            {
                Console.WriteLine("Old text: " + s);
            }
            Console.WriteLine("________________________________________________________________________________");
            lines.Add("Songname: ");
            lines.Add("Artist name: ");

            Console.WriteLine("Write the new song name:");
            string b = Console.ReadLine();
            lines[0] += b;

            Console.WriteLine("Write the new artists name: ");
            string c = Console.ReadLine();
            lines[1] += c;
            using (StreamWriter writer = new StreamWriter(@"C:\Users\Public\Documents\test\" + filnamn + ".txt", true))
            {
                for (int i = 0; i < lines.Count(); i++)
                {
                    writer.WriteLine(lines[i]);
                }
            }
            lines.Clear();
            Console.Clear();
            //5 File.WriteAllLines(@"C:\Users\Public\Documents\test\" + filnamn + ".txt", lines);
            Console.ReadKey();
            Menu();
        }

        private static void deleteFile()
        {
            Console.Clear();
            Console.WriteLine(@"All the files in the folder \test");

            DirectoryInfo a = new DirectoryInfo(@"C:\Users\Public\Documents\test\");
            FileInfo[] Files = a.GetFiles("*.txt");
            foreach (FileInfo file in Files)
            {
                Console.WriteLine(file);
            }
            Console.WriteLine("___________________________________________________________________________");
            Console.WriteLine("Write the name of the file that you want.");

            string filnamn = "";

            while (true)
            {


                filnamn = Console.ReadLine();
                Console.Clear();

                if (filnamn == "exit")
                {
                    break;
                }


                if (!File.Exists(@"C:\Users\Public\Documents\test\" + filnamn + ".txt"))
                {
                    Console.Clear();
                    Console.WriteLine("Filename does not exist. Write a new Filename.");


                }
               
                if (File.Exists(@"C:\Users\Public\Documents\test\" + filnamn + ".txt"))
                {
                   
                    Console.WriteLine("Are you sure you want to delete the file? y/n");
                    string deletefiles = Console.ReadLine().ToLower();
                    if (deletefiles == "y")
                    {
                        Console.Clear();
                        File.Delete(@"C:\Users\Public\Documents\test\" + filnamn + ".txt");
                        Console.WriteLine(filnamn + " has been deleted.");
                        Console.WriteLine("\nPress Enter to go back to the menu");
                        Console.ReadKey();
                        break;
                    }
                    if (deletefiles == "n")
                    {
                        Console.WriteLine("Press Enter to go back to Delete File");
                        Console.ReadKey();
                        deleteFile();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("You have to press y or n.\nPress Enter to return to delete menu.");
                        Console.ReadKey();
                        deleteFile();
                    }
                }
            }
            Menu();




        }


        
        
        
    }
    
}
