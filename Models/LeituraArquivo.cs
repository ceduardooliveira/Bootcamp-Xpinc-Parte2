using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class LeituraArquivo
    {
        public (bool Sucesso, string[] Linhas, int QuantidadeLinhas) LerArquivos(string caminho)  
        {

            try{
                string[] linhas = File.ReadAllLines(caminho);
                return(true, linhas, linhas.Count());
            }catch(Exception)    
            {
                return (false, new string[0], 0);
            }
        }
    }
}