using System;

namespace fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            uitvoerenFibonacci();
        }

            private static void uitvoerenFibonacci() {
            //fibonacci oefening 01
            int count = 0;
            int a = 0;
            int b = 1;

            Console.Write(a + ", ");
            Console.Write(b + ", ");

            while(count <= 50) {

                int c = a + b;
                Console.Write(c + ", ");

                a = b;
                b = c;

                count = count + 1;
        
            }
        }
    }
}
