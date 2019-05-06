using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class Alunos
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string sobrenome { get; set; }
        public string telefone { get; set; }
        public int ra { get; set; }

        public List<Alunos> listaAlunos()
        {

            Alunos aluno = new Alunos();
            aluno.id = 1;
            aluno.nome = "Marta";
            aluno.sobrenome = "Will";
            aluno.telefone = "88952535";
            aluno.ra = 00001;

            Alunos aluno1 = new Alunos();
            aluno1.id = 1;
            aluno1.nome = "Marta";
            aluno1.sobrenome = "Will";
            aluno1.telefone = "88952535";
            aluno1.ra = 00001;

            List<Alunos> listaAlunos = new List<Alunos>();

            listaAlunos.Add(aluno);
            listaAlunos.Add(aluno1);


            return listaAlunos;
        }
    }
}