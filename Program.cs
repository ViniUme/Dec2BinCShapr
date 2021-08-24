using System;

namespace Dec2Bin
{
    class Program
    {
        static void Main(string[] args)
        {

            //Feito por Vinicius Henrique dos Santos
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Decimal para Binario de 16bit");
            Console.WriteLine("---Maximo Decimal = 65.535---");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("");

            int[] numDecimal = new int[1];
            int[] numBinario = new int[16];
            int i = 0;

            Console.Write("digite o numero decimal: ");
            numDecimal[0] =  Convert.ToInt32(Console.ReadLine());
            int constDecimal = numDecimal[0];

            if(numDecimal[0] == 0){
                Console.WriteLine("");
                Console.WriteLine(numDecimal[0] + " = " + "null");
            }

            while(numDecimal[0] > 1){
                numBinario[i] = numDecimal[0] % 2;
                numDecimal[0] = numDecimal[0] / 2;
                i++;

                if(numDecimal[0] <= 1){
                    numBinario[i] = numDecimal[0];
                }
            }
            
            Console.Clear();
            Console.Write(constDecimal + " = ");

            i = 15;
            int zeroEsquerda = 1;
            while(i != -1){

                while(zeroEsquerda == 1){
                    if(numBinario[i] == 0){
                        i--;
                    }
                    else{
                        zeroEsquerda--;
                    }
                }

                Console.Write(numBinario[i]);
                i--;

                if(i == 11 || i == 7 || i == 3){
                    Console.Write(" ");
                }
            }
            Console.ReadKey();
        }
    }
}