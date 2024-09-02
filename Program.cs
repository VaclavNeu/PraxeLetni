namespace W3School_Linq_u28_u29
{
    internal class Program
    {
        static void citiesUkazka(string mesta)
        {
            Console.WriteLine(mesta);
        }
        static void Main(string[] args)
        {

        // Ukol 28

            string[] cities =
         {
            "ROME","LONDON","NAIROBI","CALIFORNIA","ZURICH","NEW DELHI","AMSTERDAM","ABU DHABI", "PARIS"
         };


            var ms = cities.OrderBy(x => x).ToArray();          // method syntaxe


            foreach(var x in ms)
            {
                Console.WriteLine(x);
            } 


            Console.WriteLine("\n");
        ////////////////////////////////////////////////////////////
        
            // Ukol 29

            var splitovani = from x in Enumerable.Range(0, cities.Length)       // Query syntaxe
                             group cities[x] by x / 3;

            foreach(var x in splitovani)
            {
                citiesUkazka(string.Join("; ", x.ToArray()));
            }


            // Vymyslet jak to udělat přes method syntax

            Console.ReadLine();
    

        }
    }
}