#include <iostream>

using std::cout; // command out
using std::endl; // end line

int main(void) {

  int vetor[] = {1, 2, 3, 4, 5, 6};

  cout << vetor[3] << endl;
  cout << vetor << endl;
  cout << vetor[0] << endl;

  cout << *vetor << endl;
  cout << *(vetor + 3) << endl;
  cout << *(3 + vetor) << endl;
  cout << 3[vetor] << endl;

}