using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inlämningsuppgift_butik
{
    public class Music : Media
    {
        //För musikalbum: Namn, Artist, Snittbetyg från användare(0 - 10), Releasedatum, Speltid(i minuter och timmar), Antal låtar, Pris.
        //Album innehåller även en lista med låtar som skall innehålla följande information: Låtnamn, Speltid, Ytterligare artister(featuring)

        string[] TrackNames {get; set;}
        string[] FeatureArtist { get; set; }
        int[] Runtime { get; set; }

       public Music(string name, string creator, int rating, string release, double price)
        {
            Name = name;
            Creator = creator;
            Rating = rating;
            Release = release;
            Price = price;
            TrackNames = new string[10];
            FeatureArtist = new string[10];
            Runtime = new int[10];

            Random roll = new Random();

            for (int i = 0; i < 10; i++)
            {
                TrackNames[i] = $"Spår nr {i + 1}";
                FeatureArtist[i] = $"Gästartist nr {i + 1}";
                Runtime[i] = roll.Next(1, 6);
            }
            PlayTime = Convert.ToString(Runtime.Sum());
        }
        public void WriteMusic()
        {
            Console.WriteLine($"Titel: {Name}\nArtist: {Creator} \nSnittbetyg: {Rating} \nReleasedatum: {Release} \nSpeltid: {PlayTime} \nPris: {Price}kr\n");

            for (int i = 0; i<TrackNames.Length; i++)
            {
                Console.WriteLine($"{TrackNames[i]}, med {FeatureArtist[i]}, speltid: {Runtime[i]}min");
            }
            Console.WriteLine();
        }
    }
}
