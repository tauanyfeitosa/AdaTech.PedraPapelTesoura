# Jogo de Pedra, Papel, Tesoura, Lagarto e Spock

Este é um projeto de exemplo que implementa o famoso jogo de Pedra, Papel, Tesoura, Lagarto e Spock, inspirado na série de TV The Big Bang Theory, utilizando ASP.NET Core.

## Descrição

O jogo de Pedra, Papel, Tesoura, Lagarto e Spock é uma variação do clássico jogo Pedra, Papel e Tesoura, com a adição de dois elementos adicionais: Lagarto e Spock. As regras do jogo são as seguintes:

- Pedra esmaga Tesoura.
- Tesoura corta Papel.
- Papel cobre Pedra.
- Pedra esmaga Lagarto.
- Lagarto envenena Spock.
- Spock quebra Tesoura.
- Tesoura decapita Lagarto.
- Lagarto come Papel.
- Papel refuta Spock.
- Spock vaporiza Pedra.

## Tecnologias Utilizadas

- ASP.NET Core 8.0
- Entity Framework Core 8.0
- Microsoft.EntityFrameworkCore.Tools
- Microsoft.EntityFrameworkCore.Design
- Microsoft.EntityFrameworkCore.SQLite
- Microsoft.EntityFrameworkCore.InMemory (Para testes em memória)

## Como Executar

1. Clone o repositório para sua máquina local.
2. Abra o projeto em sua IDE preferida (Visual Studio, Visual Studio Code, etc.).
3. Execute o projeto.

## Funcionalidades

- O jogo permite aos usuários jogarem contra o computador, selecionando sua jogada (Pedra, Papel, Tesoura, Lagarto ou Spock).
- O computador escolhe sua jogada aleatoriamente.
- O resultado do jogo é exibido ao usuário, indicando se ele ganhou, perdeu ou empatou.

## Testes

Este projeto inclui testes de unidade para as principais funcionalidades do serviço. Os testes são escritos usando xUnit, Moq e FluentAssertions. Eles podem ser encontrados no diretório `Jogo.ServicesTests` no projeto.

## Autor

Maria Tauany Santos Feitosa

[![linkedin badge](https://img.shields.io/badge/linkedin-%230077B5.svg?&style=for-the-badge&logo=linkedin&logoColor=white)](https://www.linkedin.com/in/tauanyfeitosa/)
<a href="mailto:tauanysanttos13@gmail.com"><img src="https://img.shields.io/badge/-Gmail-%23333?style=for-the-badge&logo=gmail&logoColor=red" target="_blank"></a>
[<img src="https://img.shields.io/badge/instagram-%23E4405F.svg?&style=for-the-badge&logo=instagram&logoColor=white" />](https://instagram.com/tauanyfeitosa)
