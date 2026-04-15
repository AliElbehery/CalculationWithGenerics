using System.Numerics;

namespace Calculation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DemonstrateCalculeter();
            void DemonstrateCalculeter()
            { 
                Calculater<int> intCalc = new Calculater<int>();
                Console.WriteLine("int type calculations:");
                Console.WriteLine(intCalc.Add (5, 3));
                Console.WriteLine(intCalc.Subtract (6, 4));
                Console.WriteLine(intCalc.Multiply(2, 3)); 
                Console.WriteLine(intCalc.Divide (4, 2)); 
                Console.WriteLine(intCalc.Modulo(4, 2)); 

                Calculater<double> doubleCalc = new Calculater<double>();
                Console.WriteLine("double type calculations:");
                Console.WriteLine(doubleCalc.Add(5.4, 3.6));
                Console.WriteLine(doubleCalc.Subtract(6.2, 4.1));
                Console.WriteLine(doubleCalc.Multiply(2.5, 3.1));
                Console.WriteLine(doubleCalc.Divide(4.8, 2.4));
                Console.WriteLine(doubleCalc.Modulo(4.5, 2.2));
            }
           
        }
        
    }
    public class Calculater<T> where T : INumber<T> 
    {
        public T Add(T a, T b) 
        {
            return a + b;
            
        }
        public T Subtract(T a, T b) 
        {
            return a - b;
        }
        public T Multiply(T a, T b) 
        {
            return a * b;
        }
        public T Divide(T a, T b) 
        {
            return a / b;
        }
        public T Modulo(T a, T b) 
        {
            return a % b;
        }
    }
}
