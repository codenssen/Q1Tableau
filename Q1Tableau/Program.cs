using System;

class MainClass
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Entre la taille des tableaux : ");
        int taille = Convert.ToInt32(Console.ReadLine());
        int[] tab1 = new int[taille];
        int[] tab2 = new int[taille];
        int[] doubleTab = new int[taille*2];

        for (int i = 0; i < tab1.Length; i++)
        {
            Console.WriteLine($"Tableau 1 : Entre la valeur numéro {i + 1} : ");
            tab1[i] = Convert.ToInt32(Console.ReadLine());
        }

        for (int i = 0; i < tab2.Length; i++)
        {
            Console.WriteLine($"Tableau 2 : Entre la valeur numéro {i + 1} : ");
            tab2[i] = Convert.ToInt32(Console.ReadLine());
        }



        for (int i = 0; i < tab1.Length; i++)
        {
            doubleTab[i] = tab1[i];
        }
        for (int i = 0; i < tab2.Length; i++)
        {
            doubleTab[tab1.Length + i] = tab2[i]; 
        }

        Console.WriteLine("Affichage du troisième tableau :");
        for (int i = 0; i < doubleTab.Length; i++)
        {
          
            Console.Write($"{doubleTab[i]} ");

        }
    }
}