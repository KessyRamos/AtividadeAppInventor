using System;

namespace ListaForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ListaArray = new string[5];

            ListaArray[0] = "Arroz";
            ListaArray[1] = "Feijão";
            ListaArray[2] = "Leite";
            ListaArray[3] = "Açucar";
            ListaArray[4] = "Macarrão";

            Console.WriteLine("");

            foreach(string Lista in ListaArray)
            {
                Console.WriteLine(Lista);
            }
            
        }
    }
}
