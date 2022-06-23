
namespace DinamicArrays.entities {
    public class Pessoa {

        // atributos / propriedades (auto-property)
        public string Nome { get; set; }
        public string Phone { get; set; }

        // atributo
        private int _age;

        // construtores
        public Pessoa(string nome, int age) {
            Nome = nome;
            _age = age;
        }

        public Pessoa(string nome, int age, string phone) 
            : this(nome, age) {
            Phone = phone;
        }

        // property associada ao atributo
        public int Age {
            get { return _age; }
            set { 
                if(value > 0) _age = value; ;
            }
        }

        // métodos

    }
}
