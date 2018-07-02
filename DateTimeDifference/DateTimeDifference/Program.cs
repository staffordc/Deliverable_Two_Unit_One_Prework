using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DateTimeDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            //string to inform user

            Console.WriteLine("Howdy, give me two dates, I will find the difference between them; please make sure that you use the more recent day first, I don't like negative answers");
            Console.WriteLine("What is the first date?");
            var DT1 = Console.ReadLine();
            Console.WriteLine("What is the second date?");
            var DT2 = Console.ReadLine();

            DateTime i;
            bool DT1isADateTime = DateTime.TryParse(DT1, out i);
            {
                if (DT1isADateTime == true)
                {

                }
                else if (DT1isADateTime == false)
                {
                    Console.WriteLine("That's not a date, I'm gonna nap now, come back when you're serious!");
                    Console.ReadLine();
                    return;
                }
            }
            DateTime ii;
            bool DT2isADateTime = DateTime.TryParse(DT2, out ii);
            {
                if (DT2isADateTime == true)
                {

                }
                else if (DT2isADateTime == false)
                {
                    Console.WriteLine("One of these is not a date, I'm gonna nap now, come back when you're serious!");
                    Console.ReadLine();
                    return;
                }
            }
            //storage and conversion to equation


            var DTA1 = DateTime.Parse(DT1);
            var DTA2 = DateTime.Parse(DT2);


            //Check if it will return a negative result
            bool CorrectOrder = DTA1 > DTA2;
            {
                if (CorrectOrder == true)
                {

                }
                else if (CorrectOrder == false)
                {
                    Console.WriteLine("I noticed that you didn't put the most recent date first! I don't like negatives!!! Nap time for good programs!");
                    Console.ReadLine();
                    return;
                }
            }

            //calculation
            var DTA3 = DTA1 - DTA2;
            //Console.WriteLine(DTA3);
            //Console.ReadLine();


            //function for years and months simple
            var DTA3months = (DTA1.Year - DTA2.Year) * 12 + DTA1.Month - DTA2.Month;
            DTA3months += DTA1.Day < DTA2.Day ? -1 : 0;
            var years = DTA3months / 12;
            var months = DTA3months % 12;
            var days = DTA1.Subtract(DTA2.AddMonths(DTA3months)).Days;
            //what to print as
            Console.WriteLine($"Years {years}, Months {months}, Days {days}, Hours {DTA3.Hours}, Minutes {DTA3.Minutes}, Seconds {DTA3.Seconds}, Milliseconds {DTA3.Milliseconds}");
            

            //end message
            
            Console.WriteLine("Wowie that was fun!!! Time to nap!");
            Console.ReadLine();

        }
    }
}
