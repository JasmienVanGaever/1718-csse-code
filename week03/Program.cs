using System;
using System.Collections;

namespace week03
{
      class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Choose a number");
            int table = Convert.ToInt32(Console.ReadLine());

          
            Hashtable hash = new Hashtable(); 

         
            for (int i = 0; i < 11; i++){
                int result = table * i;
                string resultString = i + "x" + table + "=" + result;
                Console.WriteLine(resultString);
                
            }

             arr[i] = resultString;
             hash[i] = resultString;
            }
        
            Console.WriteLine("Result in Array:");
            foreach(string j in arr) {
                Console.WriteLine(j);
            }
            
            Console.WriteLine("Result in Hashtable:");
            foreach(DictionaryEntry e in hash) {
                Console.WriteLine(e.Value);
            }
            
        }
    }
}