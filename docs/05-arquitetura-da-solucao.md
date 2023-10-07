# Arquitetura da Solução

> Pré-requisitos: [Projeto de Interface](04-projeto-de-interface.md)

## Diagrama de Classes

![Diagrama de Classes](diagrams/04-diagrama-de-classes.png)

## Modelo ER (Projeto Conceitual)

O Diagrama de Entidade-Relacionamento (DER) é uma representação visual crucial que descreve a estrutura da nossa base de dados para a aplicação de gestão de locação de produtos. Este diagrama ilustra as principais entidades e os relacionamentos entre elas, fornecendo uma visão clara e abrangente do sistema de armazenamento de informações.

### Entidades Principais:

1. **Clientes:**
   - A entidade "Clientes" representa informações sobre os clientes que utilizam nosso sistema de locação de produtos. Ela inclui campos como ID, Nome, Endereço e Telefone.

2. **Itens:**
   - A entidade "Itens" representa os produtos disponíveis para locação. Ela contém informações como ID, Nome, Descrição, Valor e um campo para o caminho da Foto do item.

3. **Locações:**
   - A entidade "Locações" armazena registros de todas as transações de locações realizadas no sistema. Ela inclui campos como ID, Cliente_ID, Item_ID, Data, Descrição, Quantidade, Forma_de_Pagamento e Status.

### Relacionamentos Principais:

- **Relacionamento Cliente-Locação:**
  - Um cliente pode ter várias locações, mas cada locação pertence a um único cliente. Isso é representado pelo relacionamento entre a entidade "Clientes" e "Locações", com a chave estrangeira "Cliente_ID" na tabela "Locações" referenciando a chave primária "ID" na tabela "Clientes".

- **Relacionamento Item-Locação:**
  - Um item pode estar presente em várias locações, mas cada locação inclui um único item. Isso é representado pelo relacionamento entre a entidade "Itens" e "Locações", com a chave estrangeira "Item_ID" na tabela "Locações" referenciando a chave primária "ID" na tabela "Itens".

O diagrama de entidade-relacionamento é uma ferramenta essencial para compreender a estrutura da base de dados e os relacionamentos entre as entidades, o que é fundamental para o desenvolvimento da aplicação de gestão de locação de produtos. Ele fornece uma base sólida para a criação de consultas e operações que ajudarão a administrar eficazmente as locações de produtos.


## Projeto da Base de Dados

Este projeto de base de dados tem como objetivo criar a estrutura de armazenamento de informações essencial para a aplicação de gestão de locação de produtos.

A base de dados será projetada para acomodar informações detalhadas sobre clientes, itens disponíveis para locação e registros de locações, incluindo dados como nome, descrição, valor, status e outros atributos relevantes.

A estrutura de banco de dados será desenvolvida para garantir eficiência, escalabilidade e integridade dos dados, permitindo que a aplicação gerencie as operações de locação de forma eficaz e segura

Consideraremos a criação das seguintes tabelas:

1. Clientes:

   - `ID` (Chave Primária)
   - `Nome`
   - `Endereço`
   - `Telefone`

1. Produtos:

   - `ID` (Chave Primária)
   - `Nome`
   - `Descrição`
   - `Valor`
   - `Foto` (Caminho para a imagem do item)

1. Locações:
   - `ID` (Chave Primária)
   - `Cliente_ID` (Chave Estrangeira referenciando a tabela "Clientes")
   - `Item_ID` (Chave Estrangeira referenciando a tabela "Produtos")
   - `Data`
   - `Descrição`
   - `Quantidade`
   - `Forma_de_Pagamento`
   - `Status` (Valores possíveis: Agendado, Confirmado, Pago, Cancelado)

Relacionamentos:

- Um cliente pode ter várias locações, mas cada locação pertence a um único cliente.
- Um item pode estar presente em várias locações, mas cada locação inclui um único item.

## Tecnologias Utilizadas

- Linguagem: C#
- Framework: ASP.NET 7.0 (Web application)
- Gerador de páginas: Razor Pages
- ORM: Entity Framework
- SGBD: A definir
- IDEs: Visual Studio Code

> **Orientações dos professores**: Apresente também uma figura explicando como as tecnologias estão relacionadas ou como uma interação do usuário com o sistema vai ser conduzida, por onde ela passa até retornar uma resposta ao usuário.

## Hospedagem

> **Orientações dos professores**: Explique como a hospedagem e o lançamento da plataforma foi feita.
