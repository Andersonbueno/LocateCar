using DinamicArrays.entities;
using DinamicArrays.utilities;

namespace DinamicArrays {

    public class Program {

        public static void Main(String[] args) {

            var vetor = new DinamicArraysClass<int>();

            foreach (var inteiro in vetor.Content) Console.Write($"{ inteiro} ");
            Console.WriteLine();
            vetor.Add(2);

            foreach (var inteiro in vetor.Content) Console.Write($"{ inteiro} ");
            vetor.Add(3);
            Console.WriteLine();

            foreach (var inteiro in vetor.Content) Console.Write($"{ inteiro} ");
            vetor.Add(5);
            Console.WriteLine();

            foreach (var inteiro in vetor.Content) Console.Write($"{ inteiro} ");
            vetor.AddFront(9);
            Console.WriteLine();

            foreach (var inteiro in vetor.Content) Console.Write($"{ inteiro} ");
            Console.WriteLine();


        }

    }
   
}