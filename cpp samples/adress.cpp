#include <iostream>

using std::cout;
using std::endl;

int main(void){

  int a = 2;

  int array[3] = {2, 5, 7};

  cout << &a << endl;

  cout << "Resultado array: "<< array << endl;
  cout << "Endereco da primeira posicao: " << &array[0] << endl;
  cout << *(array+1) << endl; 

  return 0;
}