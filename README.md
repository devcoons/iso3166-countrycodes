# ISO3166 - Country Codes

C# Library of the ISO3166 

> The purpose of ISO 3166 is to define internationally recognized codes of letters and/or numbers that we can use when we refer to countries and their subdivisions. However, it does not define the names of countries – this information comes from United Nations sources (Terminology Bulletin Country Names and the Country and Region Codes for Statistical Use maintained by the United Nations Statistics Divisions).

## Install package

Search for ```Devcoons.ISO3166``` Package 

## How to use this nuget package?

```
   static void Main(string[] args)
        {

            ISO3166.ISO3166 obj = new ISO3166.ISO3166();

            // Get available list of continents
            var listOfContinents = obj.Continents;

            // Set as selected continent (a random continent from the list)
            obj.Continent = listOfContinents.ElementAt((new Random()).Next(1, listOfContinents.Count - 1)).Key;

            // Get available list of countries (based on selected continent)
            var listOfCountries = obj.Countries;

            // Set as selected country (a random country from the list)
            obj.Country = listOfCountries.ElementAt((new Random()).Next(1, listOfCountries.Count - 1)).Key;

            // Get available list of Subdivisions (based on selected country)
            var listOfSubdivisions = obj.Subdivisions;

            // Set as selected subdivision (a random subdivision from the list)
            obj.Subdivision = listOfSubdivisions.ElementAt((new Random()).Next(1, listOfSubdivisions.Count - 1)).Key;
        }
```
