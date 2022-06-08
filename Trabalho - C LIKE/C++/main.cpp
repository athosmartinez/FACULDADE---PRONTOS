#include <iostream>
using namespace std;

int main()
{
    int notas, i;
    float vector[100], soma=0.0, media;

    cout << "Digite o número de alunos: ";
    cin >> notas;

    for(i = 0; i < notas; ++i)
    {
        cout << i + 1 << ". Digite as notas das provas das provas que valiam 10, dos seus alunos: ";
        cin >> vector[i];
        soma += vector[i];
    }
    media = soma / notas;
    cout << "A média desse turma é de = " << media;
      if (media >= 6){
  cout << "\nSua turma irá ser premiada.";
        }
  else {
  cout << "\nInfelizmente sua turma não irá ser premiada.";
}
    return 0;
}
