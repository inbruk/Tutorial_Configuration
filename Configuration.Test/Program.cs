using Configuration.Auxiliary.Helpers;

namespace Configuration.Auxiliary.Helpers
{
    public class Program
    {
        static void Main()
        {
            string sectionName = "Alpha";
            string itemName = "Betta";
            string Gamma = Configuration.GetItem(sectionName, itemName);
            Console.WriteLine("Alpha:Betta => {0}", Gamma);

            sectionName = "Delta";
            itemName = "Epsilon";
            string Dzeta = Configuration.GetItem(sectionName, itemName);
            Console.WriteLine("Delta:Epsilon => {0}", Dzeta);

            Console.ReadKey();
        }
    }
}
