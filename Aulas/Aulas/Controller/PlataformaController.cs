using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aulas.Models;

namespace Aulas.Controller
{
    /// <summary>
    /// 
    /// </summary>
    public class PlataformaController
    {
        private Menu _menuState;
        private int _opcao;
        float pi = 3.14f;
        public PlataformaController()
        {
            _menuState = Menu.Idle;
            _opcao = -1;
        }
        // TODO: 
        // Hack: 
        //
        public void InicializarPlataformaController()
        {
            while (_opcao != 3)
            {
                Console.Clear();
                Console.WriteLine("Escolha uma opca");
                Console.WriteLine("0 Para não fazer nada");
                Console.WriteLine("3 Para saír");
                string opcao = Console.ReadLine();

                if (int.TryParse(opcao, out _opcao))
                {
                    _menuState = (Menu)_opcao;
                    Console.WriteLine("Ok");
                    Console.WriteLine("Prima qualquer tecla para continuar");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Not ok");
                    Console.WriteLine("Prima qualquer tecla para continuar");
                    Console.ReadLine();
                }

                switch (_menuState)
                {
                    case Menu.Idle:
                        // Todo: Não fazer nada...
                        break;
                    case Menu.InserirArtigo:
                        break;
                    case Menu.Sair:
                        break;
                }
            }
            
        }
    }
}
