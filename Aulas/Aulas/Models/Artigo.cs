/*
 * 
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[assembly: CLSCompliant(true)]
namespace Aulas.Models
{
    /// <summary>
    ///
    /// </summary>
    public class Artigo
    {
        public Artigo(string nome, float preco)
        {
            Nome = nome;
            Preco = preco;
        }
        public string Nome { get; set; }
        public float Preco { get; set; }
    }
}
