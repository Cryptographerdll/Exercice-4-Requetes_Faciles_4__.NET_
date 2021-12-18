using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Requêtes_Faciles_4__.NET_
{
    class Program
    {
        static void Main(string[] args)
        {
            // Récupérer tous les fruits dont la taille du nom est supérieure à 5 lettres

            List<string> Fruits = new List<string>
            {
                "Banana", "Peer", "watermelon", "Apple", "Orange"
            };

            var length = from fr 
                         in Fruits 
                         where fr.Length > 5 
                         orderby fr ascending
                         select fr;

            foreach (var fr in length)
            {
                Console.WriteLine(fr);
            }
        }
    }
}
