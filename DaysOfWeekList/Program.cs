namespace DaysOfWeekList
{
    class Program
    {
        static void Main(string[] args)
        {
            /*List<string> daysOfWeek = new List<string>();
            daysOfWeek.Add("Monday");
            daysOfWeek.Add("Tuesday");*/

            // Collection Intializer -> still Add() is called!
            List<string> daysOfWeek = new List<string>
            {
                "Monday",
                "Tuesday",
                "Wednsday",
                "Thursday",
                "Friday",
                "Satureday",
                "sunday"
            };

            foreach (var day in daysOfWeek)
            {
                Console.WriteLine(day);
            }

        }
    }
}