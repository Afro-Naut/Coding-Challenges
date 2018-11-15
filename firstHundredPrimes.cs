using System;

namespace PrimeAPP {
    class PrimeGenerator {
        static void Main(string[] args) {

        int testValue = 2;
        int counter = 0;
        int[] output = new int[100];

        bool IsPrime(int n) {
            if (n < 2)
            {
                return false;
            }
            else if (n == 2)
            {
                return false;
            }
            else if (n % 2 == 0)
            {
                return false;
            }


            double limit = Math.Round(Math.Sqrt(n));
            for (int j = 3; j <= limit; j++)
            {
                if (j % 2 == 0)
                {
                    ;
                }
                else if (n % j == 0)
                {
                    return false;
                }
            }

            return true;
        }

        while (counter < 100) {
            if (IsPrime(testValue) == true) {
                output[counter] = testValue;
                testValue = testValue + 1;
                counter = counter + 1;
            }
            else {
                testValue = testValue + 1;
            }
        }

        for (int i = 0; i < 100; i++) {
            Console.WriteLine(output[i]);
        }

        }
    }
}