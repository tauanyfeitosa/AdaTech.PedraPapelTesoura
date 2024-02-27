using AdaTech.PedraPapelTesoura.Library.Models.Enums;
using AdaTech.PedraPapelTesoura.Library.Service;

namespace AdaTech.PedraPapelTesoura.Test
{
    public class JogoJonKenPon
    {
        [Fact]
        public void Jogo_deve_empatar_caso_ambos_os_jogadores_usem_a_mesma_forma()
        {
            var jogada1 = Forma.Pedra;
            var jogada2 = Forma.Pedra;

            var resultado = JogoService.Jogar(jogada1, jogada2);

            Assert.Equal(null, resultado);
        }

        [Fact]
        public void Jogador_1_deve_vencer_caso_jogue_pedra_e_jogador_2_jogue_tesoura()
        {
            var jogada1 = Forma.Pedra;
            var jogada2 = Forma.Tesoura;

            var resultado = JogoService.Jogar(jogada1, jogada2);

            Assert.Equal(Forma.Pedra, resultado);
        }

        [Fact]
        public void Jogador_1_deve_vencer_caso_jogue_papel_e_jogador_2_jogue_pedra()
        {
            var jogada1 = Forma.Papel;
            var jogada2 = Forma.Pedra;

            var resultado = JogoService.Jogar(jogada1, jogada2);

            Assert.Equal(Forma.Papel, resultado);
        }

        [Fact]
        public void Jogador_1_deve_vencer_caso_jogue_tesoura_e_jogador_2_jogue_papel()
        {
            var jogada1 = Forma.Tesoura;
            var jogada2 = Forma.Papel;

            var resultado = JogoService.Jogar(jogada1, jogada2);

            Assert.Equal(Forma.Tesoura, resultado);
        }

        [Fact]
        public void Jogador_2_deve_vencer_caso_jogue_pedra_e_jogador_1_jogue_tesoura()
        {
            var jogada1 = Forma.Tesoura;
            var jogada2 = Forma.Pedra;

            var resultado = JogoService.Jogar(jogada1, jogada2);

            Assert.Equal(Forma.Pedra, resultado);
        }

        [Fact]
        public void Jogador_2_deve_vencer_caso_jogue_papel_e_jogador_1_jogue_pedra()
        {
            var jogada1 = Forma.Pedra;
            var jogada2 = Forma.Papel;

            var resultado = JogoService.Jogar(jogada1, jogada2);

            Assert.Equal(Forma.Papel, resultado);
        }

        [Fact]
        public void Jogador_2_deve_vencer_caso_jogue_tesoura_e_jogador_1_jogue_papel()
        {
            var jogada1 = Forma.Papel;
            var jogada2 = Forma.Tesoura;

            var resultado = JogoService.Jogar(jogada1, jogada2);

            Assert.Equal(Forma.Tesoura, resultado);
        }

        [Fact]
        public void Deve_lancar_excecao_quando_forma_invalida_e_usada()
        {
            var jogada1 = (Forma)6;
            var jogada2 = Forma.Papel;

            var exception = Record.Exception(() => JogoService.Jogar(jogada1, jogada2));

            Assert.NotNull(exception);
            Assert.IsType<ArgumentException>(exception);
        }

        [Theory]
        [InlineData(Forma.Pedra, Forma.Tesoura)]
        [InlineData(Forma.Papel, Forma.Pedra)]
        [InlineData(Forma.Tesoura, Forma.Papel)]
        [InlineData(Forma.Tesoura, Forma.Pedra)]
        [InlineData(Forma.Pedra, Forma.Papel)]
        [InlineData(Forma.Papel, Forma.Tesoura)]

        public void Nao_deve_dar_empate(Forma jogada1, Forma jogada2)
        {
            var resultado = JogoService.Jogar(jogada1, jogada2);

            Assert.NotEqual(null, resultado);
        }

        [Theory]
        [InlineData(Forma.Pedra, Forma.Lagarto)]
        [InlineData(Forma.Lagarto, Forma.Spock)]
        [InlineData(Forma.Spock, Forma.Tesoura)]
        [InlineData(Forma.Tesoura, Forma.Lagarto)]
        [InlineData(Forma.Lagarto, Forma.Papel)]
        [InlineData(Forma.Papel, Forma.Spock)]
        [InlineData(Forma.Spock, Forma.Pedra)]
        public void Jogador_1_deve_vencer_com_novas_regras(Forma jogada1, Forma jogada2)
        {
            var resultado = JogoService.Jogar(jogada1, jogada2);

            Assert.Equal(jogada1, resultado);
        }

        [Theory]
        [InlineData(Forma.Lagarto, Forma.Pedra)]
        [InlineData(Forma.Spock, Forma.Lagarto)]
        [InlineData(Forma.Tesoura, Forma.Spock)]
        [InlineData(Forma.Lagarto, Forma.Tesoura)]
        [InlineData(Forma.Papel, Forma.Lagarto)]
        [InlineData(Forma.Spock, Forma.Papel)]
        [InlineData(Forma.Pedra, Forma.Spock)]
        public void Jogador_2_deve_vencer_com_novas_regras(Forma jogada1, Forma jogada2)
        {
            var resultado = JogoService.Jogar(jogada1, jogada2);

            Assert.Equal(jogada2, resultado);
        }

        [Theory]
        [InlineData(Forma.Pedra, Forma.Papel)]
        [InlineData(Forma.Papel, Forma.Tesoura)]
        [InlineData(Forma.Tesoura, Forma.Pedra)]
        [InlineData(Forma.Pedra, Forma.Spock)]
        [InlineData(Forma.Papel, Forma.Lagarto)]
        [InlineData(Forma.Tesoura, Forma.Spock)]
        [InlineData(Forma.Lagarto, Forma.Pedra)]
        [InlineData(Forma.Spock, Forma.Papel)]
        public void Nao_deve_dar_empate_com_novas_regras(Forma jogada1, Forma jogada2)
        {
            var resultado = JogoService.Jogar(jogada1, jogada2);

            Assert.NotEqual(null, resultado);
        }
    }
}