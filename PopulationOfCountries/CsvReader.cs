using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopulationOfCountries
{
    public class CsvReader
    {
        private readonly string _filePath;

        public CsvReader(string filePath)
        {
            this._filePath = filePath;
        }

        public List<Country> ReadAllCountries()
        {
            List<Country> countries = new List<Country>();

            using(StreamReader reader = new StreamReader(this._filePath))
            {
                reader.ReadLine();

                string csvLine;
                while ((csvLine = reader.ReadLine()) != null)
                {
                    countries.Add(ReadCountryFromCsvLine(csvLine));
                }
            }
            return countries;
        }

        private Country ReadCountryFromCsvLine(string? csvLine)
        {
            string[] parts = csvLine.Split(new char[] { ',' });

            string name, code, region;
            int population;
          
            if(parts.Length == 4)
            {
                name = parts[0];
                code = parts[1];
                region = parts[2];
                try
                {
                    population = int.Parse(parts[3]);
                }
                catch (FormatException)
                {
                    population = 0;
                }
                
            }
            else
            {
                name = parts[0] + parts[1];
                code = parts[2];
                region = parts[3];
                try
                {
                    population = int.Parse(parts[4]);
                }
                catch (FormatException)
                {
                    population = 0;
                }
            }

            return new Country(name, code, region, population);
        }
    }
}
