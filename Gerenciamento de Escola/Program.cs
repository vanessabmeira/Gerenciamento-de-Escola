using Gerenciamento_de_Escola;
using System;
//Imagine que você está desenvolvendo um sistema de gerenciamento de escola.

//Crie o cadastro do Aluno com caracteristicas como nome, idade, número de identificação do
//aluno (matrícula) e uma lista de cursos em que o aluno está matriculado. Abra a possibilidade
//que um aluno se matricule em um curso. Crie também uma forma de exibir a lista de cursos em
//que o aluno está matriculado.

//Crie o cadastro de Curso com caracteristicas como nome, código do curso, os alunos
//matriculados no curso e as disciplinas deste curso. Deve-se permitir que um aluno
//seja adicionado à lista de alunos do curso, assim como as disciplinas. Disponibilize
//a lista de alunos matriculados no curso. Disponibilize também a lista de disciplinas.

//Crie o cadastro de Disciplinas com caracteristicas como titulo, carga horária e ementa. 

//Crie o cadastro de Professor com o nome, idade e um conjunto de disciplinas que
//o professor está lecionando. Permita que uma disciplina seja atribuída a um professor.
//Disponibilize a lista de cursos + disciplinas que o professor está lecionando.

//Gerenciar a atribuição de um aluno a um curso e vice-versa onde ambos
//serão atribuidos um ao outro portanto não deve ser possível adicionar
//um curso a um aluno sem adicionar o aluno ao curso e vice-versa.

namespace GerenciamentoEscolar
{
    class program
    {
        static void Main(string[] args)
        {
            Curso cursoCsharp = new Curso("C#", 101);
            Curso cursoJava = new Curso("Java", 102);

            Aluno alunoVanessa = new Aluno(1, "Vanessa", 20);
            Aluno alunoEwerson = new Aluno(2, "Ewerson", 21);

            cursoCsharp.MatricularAluno(alunoVanessa);
            cursoJava.MatricularAluno(alunoEwerson);

            Console.WriteLine($"Aluno(a) {alunoVanessa.nome} está matriculado(a) nos cursos:");
            foreach (var curso in alunoVanessa.ExibirCursosMatriculados())
            {
                Console.WriteLine(curso.nomeCurso);
            }

            Console.WriteLine($"Aluno(a) {alunoEwerson.nome} está matriculado(a) nos cursos:");
            foreach (var curso in alunoEwerson.ExibirCursosMatriculados())
            {
                Console.WriteLine(curso.nomeCurso);
            }
        }
    }
}