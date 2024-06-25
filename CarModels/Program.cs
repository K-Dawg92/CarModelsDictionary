namespace CarModels
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> brandOfTheYear = new();
            brandOfTheYear.Add(2015, "BMW");
            brandOfTheYear.Add(2016, "Mercedes");
            brandOfTheYear.Add(2017, "Audi");
            brandOfTheYear.Add(2018, "Tesla");

            Console.WriteLine(brandOfTheYear[2016]);
            if (brandOfTheYear.ContainsKey(2017))
            {
                Console.WriteLine(brandOfTheYear[2017]);
            }
            else
            {
                Console.WriteLine("There is not brand of the year");
            }

            Dictionary<String, List<String>> modelesOfBrands = new();
            modelesOfBrands.Add("BMW", new List<string> { "BMW X2, BMW X4, BMW X6 " });
            modelesOfBrands.Add("Mercedes", new List<string> { "Mercedes A Class, Mercedes C Class, Mercedes E Class" });
            modelesOfBrands.Add("Audi", new List<string> { "Audi A1, Audi A3, Audi A4" });

            foreach (var (key, value) in modelesOfBrands) 
            {
                Console.WriteLine($"{key}'s list of models");
                foreach (var item  in value)

                {

                Console.WriteLine(item); 
                
                }
            }
            foreach(var (key, value) in brandOfTheYear )
                { 
                    Console.WriteLine(value);
                }
            brandOfTheYear.Remove(1);
;        }
        
        
        
    }
}
