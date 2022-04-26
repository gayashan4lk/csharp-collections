using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopulationOfCountries
{
    public class Country
    {
        public Country(string name, string code, string region, int population)
        {
            Name = name;
            Code = code;
            Region = region;
            Population = population;
        }

        public string Name { get; private set; }
        public string Code { get; private set; }
        public string Region { get; private set; }
        public int Population { get; private set; }
    }
}
