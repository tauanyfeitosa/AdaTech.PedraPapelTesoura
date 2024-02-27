using AdaTech.PedraPapelTesoura.Library.Models.Enums;

namespace AdaTech.PedraPapelTesoura.Library.Extensions
{
    public static class FormaExtensions
    {
        private static readonly Dictionary<Forma, List<Forma>> regras = new Dictionary<Forma, List<Forma>>
        {
            { Forma.Pedra, new List<Forma> { Forma.Tesoura, Forma.Lagarto } },
            { Forma.Papel, new List<Forma> { Forma.Pedra, Forma.Spock } },
            { Forma.Tesoura, new List<Forma> { Forma.Papel, Forma.Lagarto } },
            { Forma.Lagarto, new List<Forma> { Forma.Spock, Forma.Papel } },
            { Forma.Spock, new List<Forma> { Forma.Tesoura, Forma.Pedra } }
        };

        public static bool GanhaDe(this Forma jogada1, Forma jogada2)
        {
            if (regras.TryGetValue(jogada1, out List<Forma> vencedores))
            {
                return vencedores.Contains(jogada2);
            }
            return false;
        }
    }
}
