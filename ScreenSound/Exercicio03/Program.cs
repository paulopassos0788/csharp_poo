using Exercicio03;

Aluno aluno1 = new Aluno();
aluno1.Nome = "João";
aluno1.Idade = 20;
aluno1.Nota = 8.5;

Aluno aluno2 = new Aluno();
aluno2.Nome = "Maria";
aluno2.Idade = 22;
aluno2.Nota = 9.0;

Aluno aluno3 = new Aluno();
aluno3.Nome = "Pedro";
aluno3.Idade = 21;
aluno3.Nota = 7.5;

Disciplina disciplina = new Disciplina();
disciplina.Nome = "Matemática";
disciplina.Alunos.Add(aluno1);
disciplina.Alunos.Add(aluno2);
disciplina.Alunos.Add(aluno3);

Professor professor1 = new Professor();
professor1.Nome = "Carlos";
professor1.Disciplina = disciplina;
professor1.ExibirDadosProfessor();
