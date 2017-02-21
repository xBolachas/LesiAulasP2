using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aulas.Controller;
using Aulas.Models;

namespace Aulas
{
    class Program
    {
        
        static void Main(string[] args)
        {
            PlataformaController plataformaController = new PlataformaController();
            plataformaController.InicializarPlataformaController();
            Debug.WriteLine("teste 12");
            
        }
    }
}
