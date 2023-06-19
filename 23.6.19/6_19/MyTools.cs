using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace _6_19
{
    public static class MyTools // extended method 
    {
        public static void DogPrint(this Dog myDog) 
        {
            myDog.PrintInfos();
        
        }

        public static int Plus(this int firstValue, int secondValue) 
        {
            Console.WriteLine("{0} + {1} = {2}", firstValue, secondValue, firstValue + secondValue);     
            
            
            return firstValue + secondValue;
       
        
        }


    }
}
