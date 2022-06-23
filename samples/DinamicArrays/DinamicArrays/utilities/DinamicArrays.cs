
namespace DinamicArrays.utilities {
    public class DinamicArraysClass<T> {

        public T[] Content { get; private set; }

        public DinamicArraysClass() {
            Content = new T[0];
        }

        public void Add(T newElement) {
            int size;
            T[] Copy;
            ExpandArray(out size, out Copy);

            for (int i = 0; i < size; i++) {
                Content[i] = Copy[i];
            }

            Content[size] = newElement;

        }

        public void AddFront(T newElement) {
            int size;
            T[] Copy;
            ExpandArray(out size, out Copy);

            Content[0] = newElement;

            for(int i = 1; i <= size; i++) {
                Content[i] = Copy[i - 1];
            }

        }

        private void ExpandArray(out int size, out T[] Copy) {
            size = Content.Length;
            Copy = Content;
            Content = new T[size + 1]; // crio vazio com tamanho aumentado
        }

    }
}
