alunos = int(input('Digite o número de alunos: '))
soma = 0
for n in range(alunos):
    numbers = float(input('Digite as notas das provas das provas que valiam 10, dos seus alunos:'))
    soma += numbers
media = soma/alunos
print('Sua sala com  ', alunos, 'teve a uma media de:', media)

if media >= 6:
    print("Sua turma irá ser premiada.")
else:
    print("Infelizmente sua turma não irá ser premiada.")
 