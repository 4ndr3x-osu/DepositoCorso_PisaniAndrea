using System;

class Program
{
    static void Main(string[] args)
    {
        //-----ESERCIZIO 1
        bool negativo = false;
        int n;
        int somma = 0;

        while (!negativo)
        {
            Console.WriteLine("Inserisci un numero positivo: ");
            n = int.Parse(Console.ReadLine());
            if(n >= 0)
            {
                somma += n;
            }
            else
            {
                negativo = true;
                Console.WriteLine($"Fine ciclo. Risultato: {somma}");
            }
        }



        //-----ESERCIZIO 2
        bool trovato = false;
        const int SEGRETO = 727;
        int num;

        while (!trovato)
        {
            Console.WriteLine("Inserisci un numero: ");
            num = int.Parse(Console.ReadLine());
            if(num != SEGRETO)
            {
                if(num > SEGRETO)
                {
                    Console.WriteLine("Il numero inserito è maggiore del numero segreto. Ritenta");
                }
                else
                {
                    Console.WriteLine("Il numero inserito è minore del numero segreto. Ritenta");
                }
            }
            else
            {
                Console.WriteLine("Hai indovinato il numero segreto");
                trovato = true;
            }
        }
    }
}