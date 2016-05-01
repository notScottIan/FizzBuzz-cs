using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz {
    class Program {
        static void Main(string[] args) {

            string fbText = "";

            for (int i = 1; i <= 100; i++ ) {

                fbText = "";

                if (i % 3 == 0) {
                    fbText = "Fizz";
                }
                if (i % 5 == 0) {
                    fbText += "Buzz";
                }

                Console.Write("{0} {1}\t", i, fbText);
                if (i % 5 == 0) {
                    Console.Write("\n");
                }

            }
        }
    }
}
