using Inlämningsuppgift_butik;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;

namespace Assignment01StoreInterface
{
    public class Program
    {
        static void Main(string[] args)
        {

            Store myStore = new Store();

            myStore.VisitingAdress = "Nygatan 41";
            myStore.ZipCodeVisit = 80324;
            myStore.BillingAdress = "Kungsgatan 4";
            myStore.ZipCodeBill = 80435;
            myStore.NumberStore = "026 - 157098";
            myStore.NumberOffice = "026 - 158096";

            Movies myMovies = new Movies();

            //Hans-Johnny har precis startat en butik på nätet där han säljer film och musik till en smalare publik.
            //Butiken har två adresser, en för fakturering och en besöksadress.

            List<Movies> products = new List<Movies>();
            using (FileStream stream = File.Open("Movies.csv", FileMode.Open))
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    string line; // = reader.ReadLine();
                    while ((line = reader.ReadLine()) != null)
                    {
                        // Logik för raden
                        string[] columns = line.Split(';');

                        try
                        {
                            Movies movies = new Movies();

                            movies.Name = columns[0];
                            movies.Creator = columns[1];
                            movies.Rating = Convert.ToInt32(columns[2]);
                            movies.Release = columns[3];
                            movies.PlayTime = columns[4];
                            movies.Price = Convert.ToInt32(columns[5]);

                            // Placera behandling av produkten efter inläsningen, i samma try-sats
                            // För att undvika behandling av ogiltig data
                            products.Add(movies);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                }
            }

            Random roll = new Random();
            List<Music> albums = new List<Music>();

            for (int i = 0; i < 25; i++)
            {
                Music newAlbum = new Music($"Titel nr{i+1}",$"Artist nr{i+1}",roll.Next(1,11),$"199{roll.Next(0,10)}-0{roll.Next(1,10)}-{roll.Next(0, 3)}{roll.Next(1, 9)}", roll.Next(99,149));
                albums.Add(newAlbum);
            }


            Console.WriteLine("Välkommen till Hans-Johnnys butik - Sveriges film- och musikaffär på nätet för den smala bubliken.");
            Console.WriteLine("Vi har ett unikt utbud av 25 filmer och musikalbum - dessa får du inte missa!");
            Console.WriteLine();

            bool retry = true;
            while (retry != false)
            { 
            Console.WriteLine("Välj ett val i menyn: \n[1]Filmer\n[2]Musikalbum\n[3]Butiksinformation\n[4]Avsluta programmet");

            int userChoice = int.Parse(Console.ReadLine());
            switch (userChoice)
                {
                    case 1:
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.White;

                        Console.WriteLine("Filmutbud:\n");
                        foreach (Movies movie in products)
                        {
                            movie.WriteMovie();
                        }
                        break;
                    case 2:
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Musikutbud:\n");
                        foreach (Music album in albums)
                        {
                            album.WriteMusic();
                        }
                        break;
                    case 3:
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        myStore.PrintBothAdresses();
                        break;
                        
                    case 4:
                        Console.WriteLine("Hej då!");
                        retry = false;

                        break;
                    default:
                        Console.WriteLine("Du valde ett ogiltigt alternativ, välj igen");
                        break;
                }
            }

            
            


            Console.SetWindowPosition(0, 0);
            Console.ReadKey();
            
        }


        //Butikens utbud består av 25 unika filmer och unika 25 musikalbum.

        //Resultatet skall presentera följande information.

        //För filmer: Namn, Regissör, Snittbetyg från användare(0 - 10), Releasedatum, Speltid(i minuter och timmar), Pris.

        //För musikalbum: Namn, Artist, Snittbetyg från användare(0 - 10), Releasedatum, Speltid(i minuter och timmar), Antal låtar, Pris.

        //Album innehåller även en lista med låtar som skall innehålla följande information: Låtnamn, Speltid, Ytterligare artister(featuring)

        //Följande skall skrivas ut:

        //Butikens information(inklusive adresser).
        //Filmutbud, sorterat efter releasedatum, fallande(nyast överst).
        //Albumutbud, sorterat efter snittbetyg från användare, fallande(högst överst).

        //Datamodellen skall i största möjliga mån dela information där det är möjligt.

        //(Fiktiv data accepteras självklart)
    }
}
