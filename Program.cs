﻿using ExemploExplorando.Models;

Pessoa p1 = new Pessoa(nome: "Carlos Eduardo", sobrenome: "Pereira de Oliveira");
Pessoa p2 = new Pessoa(nome: "Leonardo", sobrenome: "Buta");


Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Inglês";
cursoDeIngles.Alunos = new List<Pessoa>();


cursoDeIngles.adicionarAluno(p1);
cursoDeIngles.adicionarAluno(p2);
cursoDeIngles.ListarAlunos();















// Pessoa p1 = new Pessoa();

// p1.Nome = "Carlos Eduardo";
// p1.Sobrenome = "Pereira de Oliveira";
// p1.Idade = 30;
// p1.Apresentar();