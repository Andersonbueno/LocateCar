using DinamicArrays.entities;

namespace DinamicArrays {

    public class Program {

        public static void Swap1(int a, int b) {
            int temp = a;
            a = b;
            b = temp;
        }

        public static void Swap2(ref int a, ref int b) {
            int temp = a;
            a = b;
            b = temp;
        }

        public static void Main(String[] args) {

            utilities.LinkedList<int> list = new();

            list.Append(2);
            list.Append(3);
            list.Append(4);

            list.Print();

        }

    }
   
}