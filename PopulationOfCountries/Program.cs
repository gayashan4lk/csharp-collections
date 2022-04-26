using PopulationOfCountries;

string filePath = @"C:\Users\ErangaGayashanBISTEC\source\learning\csharp-collections\Datasources\Pop by Largest Final.csv";

CsvReader reader = new CsvReader(filePath);

List<Country> countries = reader.ReadAllCountries();

foreach (var country in countries)
{
    Console.WriteLine($"{PopulationFormatter.FormatPopulation(country.Population).PadLeft(15)} : {country.Name}");
}