using System;
using System.Diagnostics;

namespace Session04Example06
{
    class Program
    {
        static void Main(string[] args)
        {
            // Vad klockan är
            DateTime currentDateTime = DateTime.Now;

            //Tiden utan olika zoner
            DateTime currentTimeZoneNeutraDateTime = DateTime.UtcNow;

            // kontrollera skottår
            DateTime.IsLeapYear(currentDateTime.Date.Year);

            // maximala ocn minimala tiden
            DateTime minValue = DateTime.MinValue;
            DateTime maxValue = DateTime.MaxValue;

            // Hämta ut ett datum från en sträng
            var parsedDate = DateTime.Parse();

            // out-parameter sätter alltid cärdet, parsedDate är ändrat
            // DateTime.TryParse fungerar på samma sätt som intr.TryParse...
            bool dateWasParsed = DateTime.TryParse("asdf", out parsedDate);

            //Tiden
            TimeSpan currentTime = currentDateTime.TimeOfDay;
            //Baserar på ticks
            //currentTime.Ticks;

            //Hur många ticks som får på en sekund
            //TimeSpan.TicksPerSecond; 

            TimeSpan createdTimeSpan = new TimeSpan();

            Stopwatch timer = new Stopwatch();
            timer.Start();

            // Pausa programmet manuellt
            Thread.Sleep(1000);
            
            timer.Stop();

            
            
            




            currentDateTime.Date;


        }
    }
}
