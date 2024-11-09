using System;

// initialize variables - graded assignments 
string[] alunos = {"Sophia", "Andrew", "Emma", "Logan", "Becky", "Chris", "Eric", "Gregor"};

decimal currentAssignments = 5;

int[] notas_sophia = {90, 86, 87, 98, 100, 94, 90};
int[] notas_andrew = {92, 89, 81, 96, 90, 89};
int[] notas_emma = {90, 85, 87, 98, 68, 89, 89, 89};
int[] notas_logan = {90, 95, 87, 88, 96, 96};
int[] beckyScores = {92, 91, 90, 91, 92, 92, 92};
int[] chrisScores = {84, 86, 88, 90, 92, 94, 96, 98};
int[] ericScores = {80, 90, 100, 80, 90, 100, 80, 90};
int[] gregorScores = {91, 91, 91, 91, 91, 91, 91};

int[][] notas = {notas_sophia, notas_andrew, notas_emma, notas_logan, beckyScores, chrisScores, ericScores, gregorScores};

Console.WriteLine("Student\t\tExam Score\t\tOverall Grade\t\tExtra Credit\n");
foreach (string aluno in alunos) {
    int[] notas_aluno = notas[Array.IndexOf(alunos, aluno)];

    decimal media_provas = 0;
    decimal media_extras = 0;
    decimal media_ponderada_extras = 0;
    for (int nota = 0; nota < notas_aluno.Length; nota++) {
        if (nota < 5) {
            media_provas += notas_aluno[nota] / currentAssignments;
        } else {
            media_extras += notas_aluno[nota] / (notas_aluno.Length - currentAssignments);
            media_ponderada_extras += notas_aluno[nota] / currentAssignments / 10;
        }
    }

    decimal media_final = media_provas + media_ponderada_extras;
    string nota_letra = "F";
    string[] notas_letras = {"A", "B", "C", "D"};
    for (int i = 0; i < notas_letras.Length; i++) {
        int nota_corte = (90 - 10 * i);
        if (media_final >= nota_corte) {
            nota_letra = notas_letras[i];

            if ((media_final - nota_corte) >= 7) {
                nota_letra += "+";
            } else if ((media_final - nota_corte) < 3) {
                nota_letra += "-";
            }

            break;
        }
    }


    Console.WriteLine($"{aluno}\t\t{media_provas}\t\t\t{media_final}\t{nota_letra}\t\t{(int)media_extras} ({media_ponderada_extras} pts)");
}

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();