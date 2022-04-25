string[] daysOfWeek = new string[] { "Monday", "Tuesday", "Wedssdfsdsfsfsdfsday", "Thursday", "Friday", "Satureday", "Sunday" };
int count = 0;

Console.WriteLine("First Array");
foreach (string day in daysOfWeek)
    Console.WriteLine($"{++count} - {day}");

daysOfWeek[2] = "Wednsday";
count = 0;
Console.WriteLine("Second Array");
foreach (string day in daysOfWeek)
    Console.WriteLine($"{++count} - {day}");


/*
Console.WriteLine("Enter you input :");
int iDay = int.Parse(Console.ReadLine());

Console.WriteLine($"You have choosen : {daysOfWeek[--iDay]}");*/

