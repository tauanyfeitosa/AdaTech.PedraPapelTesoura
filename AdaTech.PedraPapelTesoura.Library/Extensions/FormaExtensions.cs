using AdaTech.PedraPapelTesoura.Library.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaTech.PedraPapelTesoura.Library.Extensions
{
    public static class FormaExtensions
    {
        private static readonly Dictionary<Forma, Forma> regras = new Dictionary<Forma, Forma>
        {
            { Forma.Pedra, Forma.Tesoura  }, // Pedra ganha de Tesoura
            { Forma.Papel, Forma.Pedra  },   // Papel ganha de Pedra
            { Forma.Tesoura,Forma.Papel  }  // Tesoura ganha de Papel
        };

        public static bool GanhaDe(this Forma jogada1, Forma jogada2)
        {
            if (regras.TryGetValue(jogada1, out Forma vencedor))
            {
                return vencedor == jogada2; // Retorna true se jogada1 ganha de jogada2
            }
            return false; // Retorna false se jogada1 não ganha de jogada2 ou se a jogada não está mapeada
        }
    }
}
