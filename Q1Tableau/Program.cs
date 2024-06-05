using System;

class MainClass
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Entre la taille des tableaux : ");

        // Choix de la taille des tableaux
        int taille = Convert.ToInt32(Console.ReadLine());

        // Initialisation des tableaux
        int[] tab1 = new int[taille];
        int[] tab2 = new int[taille];
        int[] doubleTab = new int[taille*2];

        // Boucle de remplissage du premier tableau par l'utilisateur
        for (int i = 0; i < tab1.Length; i++)
        {
            Console.WriteLine($"Tableau 1 : Entre la valeur numéro {i + 1} : ");
            tab1[i] = Convert.ToInt32(Console.ReadLine());
        }

        // Boucle de remplissage du second tableau par l'utilisateur
        for (int i = 0; i < tab2.Length; i++)
        {
            Console.WriteLine($"Tableau 2 : Entre la valeur numéro {i + 1} : ");
            tab2[i] = Convert.ToInt32(Console.ReadLine());
        }


        // Boucle de remplissage du double tableau
        for (int i = 0; i < tab1.Length; i++)
        {
            doubleTab[i] = tab1[i];
        }
        for (int i = 0; i < tab2.Length; i++)
        {
            // Décale le remplissage du second tableau par la taille du premier tableau
            doubleTab[tab1.Length + i] = tab2[i]; 
        }

        // Affichage console
        Console.WriteLine("Affichage du troisième tableau :");
        for (int i = 0; i < doubleTab.Length; i++)
        {
          
            Console.Write($"{doubleTab[i]} ");

        }
    }
}