using System;

namespace MyCalculator {
    public class MyCalculator {
        public static double Add (double x, double y) {
            return x + y;
        }

        public static double Subtract (double x, double y) {
            return x - y;
        }

        public static double Multiply (double x, double y) {
            return x * y;
        }

        public static double Division (double x, double y) {
            return x / y;
        }

        public static double Power (double x, double y) {
            double result = 1;
            for (double i = 1; i <= y; i++) {
                result *= x;
            }
            return result;
        }

        public static double Square (double x) {
            return x * x;
        }

        public static double Modulus (double x, double y) {
            return x % y;
        }

    }
}