namespace Lab02_Recursividad;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        int n,k;
        var stopwatch = new Stopwatch();


        do{
            Console.WriteLine("Introduzca el numero de terminos:");
            n=Convert.ToInt16(Console.ReadLine());
        }while(n<=1);
            Console.WriteLine("Serie de numeros fibonacci recursivo");
            stopwatch.Start();

            for(k=0;k<n;k++){
                Console.Write(FibonacciRecursivo(k) + ",");
            }
            stopwatch.Stop();

            Console.WriteLine($"Tiempo de ejecución: {stopwatch.ElapsedMilliseconds} ms");
            Console.WriteLine("");

            stopwatch.Reset();

            Console.WriteLine("Serie de numeros fibonacci iterativo");
            stopwatch.Start();
            FibonacciIterativo(n);
            stopwatch.Stop();
            Console.WriteLine($"Tiempo de ejecución: {stopwatch.ElapsedMilliseconds} ms");

        }

        static int FibonacciRecursivo(int n){
        if(n<2){
            return n;
        }else{
            return (FibonacciRecursivo(n-2) + FibonacciRecursivo(n-1));
        }
    }

    static void FibonacciIterativo(long n){
        int i;
        int ant1,ant2;
        ant1=ant2=1;
        Console.WriteLine("0 1 1");
        for(i=1 ; i<n-2 ; i++){
            int actual = ant1+ant2;
            Console.Write(actual + ",");
            ant2=ant1;
            ant1=actual;
        }

    }

    }

    
    








