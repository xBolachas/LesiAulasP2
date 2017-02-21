using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aulas.Models
{
    public class Orcamento
    {
        public List<Artigo> ArtigoList { get; set; }

        public static implicit operator Orcamento(Artigo v)
        {
            throw new NotImplementedException();
        }
    }
}
