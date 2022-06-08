#include <stdio.h>
int main() {
    int alunos, i;
    float vector[100], soma = 0.0, media;

    printf("Digite o número de alunos: ");
    scanf("%d", &alunos);
    for (i = 0; i < alunos; ++i) {
        printf("%d. Digite as notas das provas das provas que valiam 10, dos seus alunos: ", i + 1);
        scanf("%f", &vector[i]);
        soma += vector[i];
    }
    media = soma / alunos;
    printf("Média = %.2f", media);
    if(media >= 6){    
    printf("%d \nSua irá ser premiada.");    
    }    
    else{    
    printf("%d \nInfelizmente sua turma não irá ser premiada.");    
    }     
  return 0;
}
