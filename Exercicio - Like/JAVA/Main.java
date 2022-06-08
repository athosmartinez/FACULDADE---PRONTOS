import java.util.Scanner;
public class Main {

    public static void main(String[] args) {
        System.out.println("Digite o número de alunos: ");
        Scanner scanner = new Scanner(System.in);
        int alunos = scanner.nextInt();
        /* Declaring array of alunos elements, the value
         * of alunos is provided by the user
         */
        double[] array = new double[alunos];
        double soma = 0;

        for(int i=0; i<array.length; i++){
        	System.out.print((i+1) + ". Digite as notas das provas das provas que valiam 10, dos seus alunos: ");
        	array[i] = scanner.nextDouble();
        }
        scanner.close();
        for(int i=0; i<array.length; i++){
        	soma = soma + array[i];
        }
        
        double media = soma / array.length;

      
        System.out.format("A media da sala é %.2f", media);

      if (media > 6) {
  System.out.println("\nSua turma irá ser premiada.");
} else {
  System.out.println("\nInfelizmente sua turma não irá ser premiada.");
}   
}
}