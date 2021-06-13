using System;

namespace Fibnocci {

    class Program {

        static int fib1(int num) {
            if (num == 0) {
                return 0;
            }
            else if (num == 1) {
                return 1;
            }
            else {
                return fib1(num - 2) + fib1(num - 1);
            }
        }

        static int fib2(int num) {
            if (num == 0 || num == 1) {
                return num;
            }

            int a = 0;
            int b = 1;
            int c = 1;

            for (int i = 2; i < num; i++) {
                c = a + b;
                a = b;
                b = c;
            }

            return c;
        }
        static void Main(string[] args) {
            int val = fib1(8);
            Console.WriteLine(val);
            
            int val2 = fib1(8);
            Console.WriteLine(val2);
        }
    }
}
