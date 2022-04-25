using TopTenPopulation;

string filePath = @"C:\Users\ErangaGayashanBISTEC\source\learning\csharp-collections\Datasources\Pop by Largest Final.csv";

CsvReader reader = new CsvReader(filePath);

Country[] countries = reader.ReadFirstNCountries(10);

foreach (Country country in countries)
{
    Console.WriteLine($"{country.Name} :{country.Population}");
}