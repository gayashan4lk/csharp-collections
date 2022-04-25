string[] daysOfWeek = new string[] { "Monday", "Tuesday", "Wednsday", "Thursday", "Friday", "Satureday", "Sunday" };

Console.WriteLine("Which day you want to display ?");

int count = 0;

foreach (string day in daysOfWeek)
{
    Console.WriteLine($"{day} = {++count}");
}

Console.WriteLine("Enter you input :");
int iDay = int.Parse(Console.ReadLine());

Console.WriteLine($"You have choosen : {daysOfWeek[--iDay]}");

