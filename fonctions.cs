using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPParking
{
    partial class Program
    {
        public static void afficheMenu(int nbPlacesDispo)
        {
            Console.WriteLine("\n\n_______________________________________");
            Console.WriteLine("\nBonjour, il y a {0} places disponibles.\n", nbPlacesDispo);
            Console.WriteLine("\t1. Arrivée d’une voiture"); // \t = tabulation
            Console.WriteLine("\t2. Plan d’occupation du parking");
            Console.WriteLine("\t3. Ou est ma voiture ?");
            Console.WriteLine("\t4. Sortie d’une voiture");
            Console.WriteLine("\t5. Fermeture du parking (fin du programme)");
            Console.WriteLine("\nVotre choix : ");
        }
        static void plan(int[] parking)
        {
            int i; // variable locale
            // titre
            Console.WriteLine("********************");
            Console.WriteLine("Place\tVoiture");
            // affichage du tableau
            for (i = 0; i < parking.Length; i = i + 1)
            {
                if (parking[i] == 0) // place libre
                {
                    // /t est une tabulation
                    //D pour "disponible"
                    Console.WriteLine(i + 1 + "\tD");
                }
                else // la place est occupée
                {
                    Console.WriteLine(i + 1 + "\t" + parking[i]);
                }//finif
            }//finfor
            Console.WriteLine("********************");
        }//fin procedure plan

    }
}
