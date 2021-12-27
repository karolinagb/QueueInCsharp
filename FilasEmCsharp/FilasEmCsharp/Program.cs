using System;
using System.Collections.Generic;
using System.Linq;

namespace FilasEmCsharp
{
    class Program
    {
        static Queue<string> pedagio = new Queue<string>();
        static void Main(string[] args)
        {
            //entrou Van
            Enfileirar("Van");

            //entrou Kombi
            Enfileirar("Kombi");

            //entrou Guincho
            Enfileirar("Guincho");

            //entrou Pickup
            Enfileirar("Pickup");

            Desenfileirar();

            Desenfileirar();

            Desenfileirar();

            Desenfileirar();

            Desenfileirar();

        }

        private static void Desenfileirar()
        {
            if (pedagio.Any())
            {
                //Saber quem ta esperando na fila com metodo Peek
                if (pedagio.Peek() == "Guincho")
                {
                    Console.WriteLine("Guinho está fazendo o pagamento.");
                }


                var veiculo = pedagio.Dequeue();
                Console.WriteLine($"Saiu da fila: {veiculo}");
                Console.WriteLine("FILA:");
                ImprimirFila();
            }
        }

        private static void ImprimirFila()
        {
            foreach (var v in pedagio)
            {
                Console.WriteLine(v);
            }
            Console.WriteLine();
        }

        private static void Enfileirar(string veiculo)
        {
            Console.WriteLine($"Entrou na fila: {veiculo}");
            pedagio.Enqueue(veiculo);
            ImprimirFila();
        }
    }
}
