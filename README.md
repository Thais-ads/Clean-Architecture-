# Projeto de Arquitetura Limpa e Padrões de Design com Integração
Visão Geral
Este projeto demonstra a aplicação da Arquitetura Limpa combinada com diversos Padrões de Design, com o objetivo de criar uma aplicação escalável, de fácil manutenção e testável. A solução segue os princípios de Separação de Responsabilidades, garantindo que cada camada esteja focada em sua função específica e promovendo o desacoplamento entre os componentes.


## 1. Arquitetura Limpa
A Arquitetura Limpa é uma filosofia de design de software que enfatiza a separação entre as regras de negócio de alto nível e os detalhes técnicos de baixo nível. O foco está em criar uma arquitetura flexível e fácil de manter.

 Neste projeto:

A lógica central do domínio é colocada no centro, isolada das influências externas.
O princípio da Inversão de Dependência é aplicado para que módulos de alto nível não dependam de módulos de baixo nível.
Interfaces são utilizadas para inverter dependências, garantindo que módulos centrais não dependam de detalhes de infraestrutura.
## 2. Padrões de Design
Vários padrões de design foram incorporados ao projeto para aumentar a reutilização e a manutenção do código. Estes incluem:

Padrão Repository: Para lidar com o acesso a dados e abstração, permitindo o desacoplamento entre a fonte de dados e a lógica de negócios.
Padrão Unit of Work: Para gerenciar transações no banco de dados e garantir que as alterações sejam salvas de maneira consistente.
Injeção de Dependência (DI): Para gerenciar a criação e a injeção de dependências, promovendo o baixo acoplamento entre as classes.
## 3. Estrutura em Camadas
O projeto é dividido em múltiplas camadas para garantir uma clara separação de responsabilidades:

Camada de Domínio: Contém a lógica de negócios central e as entidades.
Camada de Aplicação: Responsável por gerenciar as regras de negócio da aplicação e interagir com a camada de domínio.
Camada de Infraestrutura: Lida com a implementação de detalhes técnicos, como acesso a dados e serviços externos.
Camada de Interface: Onde ocorrem as interações do usuário e a comunicação com o backend, como APIs e controladores.
## 4. Integração de Serviços
O projeto também inclui exemplos de integração com serviços externos, onde são realizadas chamadas HTTP a endpoints REST, utilizando o HttpClient para operações como registro de usuários e autenticação.

## Tecnologias Utilizadas
ASP.NET Core: Framework principal da aplicação.
Entity Framework Core: ORM utilizado para o acesso a dados.
Swagger: Documentação automática da API.
Injeção de Dependência (DI): Utilizada para gerenciar as dependências.
Clean Architecture: Princípio central da organização do código.
## Funcionalidades
Cadastro e Login de Usuário: Integração com API para realizar o cadastro e login de usuários, retornando um token de autenticação.
Abstração de Repositórios e Unit of Work: Lógica de acesso a dados desacoplada da camada de negócios.
Swagger: Interface para testar e visualizar endpoints da API.
## Como Executar o Projeto
Clone o repositório:
git clone
Copiar código
git clone https://github.com/seu-usuario/seu-repositorio.git
Configure as variáveis de ambiente e as strings de conexão no arquivo appsettings.json.
Compile e execute o projeto:
Copiar código
dotnet build
dotnet run
Contribuições
Sinta-se à vontade para abrir issues ou enviar pull requests para melhorar o projeto.

Esse README fornece uma explicação clara e detalhada sobre o propósito do projeto, seus conceitos e como usá-lo.
