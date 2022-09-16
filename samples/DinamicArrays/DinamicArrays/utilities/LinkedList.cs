
internal class Node<T> {
    public T Value { get; set; }
    public Node<T> ? Next { get; set; }

    public Node(T value) {
        Value = value;
        Next = null;
    }
}

namespace DinamicArrays.utilities {

    public class LinkedList<T> {

        Node<T>? First, Last;

        public LinkedList() {
            First = null;
            Last = null;
        }

        public void Append(T value) {
            if (First == null) {
                First = new Node<T>(value);
                Last = First;
            } else {
                // crio um nó pro novo valor
                Node<T> aux = new Node<T>(value); 

                // o proximo do ultimo será este nó
                Last.Next = aux;

                // o último agora é próximo do antigo último
                Last = Last.Next;

            }
        }

        public void AddFront(T value) {
            if (First == null) {
                First = new Node<T>(value);
                Last = First;
            } else {
                Node<T> refToPreviousFirst = First;
                First = new Node<T>(value);
                First.Next = refToPreviousFirst;
            }
        }

        public void Print() {
            Node<T> current = First;

            while (current != null) {
                Console.WriteLine(current.Value);
                current = current.Next;
            }

        }
    }
}
