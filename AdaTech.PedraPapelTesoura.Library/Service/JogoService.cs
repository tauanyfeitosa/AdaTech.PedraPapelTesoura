
using AdaTech.PedraPapelTesoura.Library.Extensions;
using AdaTech.PedraPapelTesoura.Library.Models.Enums;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("AdaTech.PedraPapelTesoura.Test")]
namespace AdaTech.PedraPapelTesoura.Library.Service
{
    internal class JogoService
    {
        public static Forma? Jogar(Forma jogada1, Forma jogada2)
        {
            if (jogada1 == jogada2)
                return null;

            bool ganhador = jogada1.GanhaDe(jogada2);

            if (ganhador)
                return jogada1;
            else
                return jogada2;
        }
    }
}
