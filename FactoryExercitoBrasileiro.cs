using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogosDeGuerraModel
{
    class FactoryExercitoBrasileiro : AbstractFactoryExercito
    {
        public override Arqueiro CriarArqueiro()
        {
            return new ArqueiroBrasileiro();
        }

        public override Cavaleiro CriarCavalaria()
        {
            return new CavaleiroBrasileiro();
        }

        public override Guerreiro CriarGuerreiro()
        {
            return new GuerreiroBrasileiro();
        }
    }
}