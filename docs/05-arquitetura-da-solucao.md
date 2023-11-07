# Arquitetura da Solução

## Diagrama de Classes

O "Diagrama de Classes" é uma representação visual que descreve a estrutura das classes em um sistema e os relacionamentos entre elas. Para a nossa aplicação de gestão de locações de produtos, o diagrama de classes desempenha um papel crucial na modelagem das entidades e dos componentes do sistema. Ele incluirá classes que representam itens, clientes, locações e outras entidades relevantes. Além disso, ele definirá as associações entre essas classes, ajudando a visualizar como os dados serão organizados e como as informações serão compartilhadas dentro do sistema. O diagrama de classes é uma ferramenta essencial para o desenvolvimento orientado a objetos, garantindo que a estrutura do sistema seja sólida e bem organizada.

![Diagrama de Classes](diagrams/04-diagrama-de-classes.png)

## Modelo ER (Projeto Conceitual)

O "Modelo ER" é uma representação visual que descreve as entidades e seus relacionamentos em um sistema. Para a nossa aplicação, o modelo ER define as entidades-chave, como "Produto", "Cliente", "Locação" e suas propriedades. Além disso, ele identifica os relacionamentos entre essas entidades, como a relação entre um cliente e uma locação. O modelo ER é essencial para a definição da estrutura da base de dados, permitindo que a equipe de desenvolvimento projete a estrutura de armazenamento de dados de forma eficiente e normalize. Ele serve como um guia sólido para a implementação da base de dados, garantindo a integridade e a consistência dos dados em todo o sistema.

![Modelo ER - Projeto Conceitual](diagrams/05-modelo-er.png)

## Projeto da Base de Dados

O "Projeto da Base de Dados" é a implementação prática do modelo ER, descrevendo como os dados serão armazenados, acessados e gerenciados. Para a nossa aplicação, o projeto da base de dados envolverá a criação de tabelas, definição de chaves primárias e estrangeiras, além de índices para otimização de consultas. Ele também abrangerá a definição de procedimentos de armazenamento e gatilhos, que garantem a integridade dos dados e a aplicação de regras de negócios. O projeto da base de dados é fundamental para garantir que nossa aplicação tenha um sistema de gerenciamento de dados sólido e eficiente.

![Projeto do Banco de Dados](diagrams/06-projeto-do-banco-de-dados.png)

## Tecnologias Utilizadas

- Linguagem: C#
- Framework: ASP.NET 7.0 (Web application)
- Gerador de páginas: Razor Pages
- ORM: Entity Framework
- SGBD: A definir
- IDEs: Visual Studio Code

> **Orientações dos professores**: Apresente também uma figura explicando como as tecnologias estão relacionadas ou como uma interação do usuário com o sistema vai ser conduzida, por onde ela passa até retornar uma resposta ao usuário.

## Hospedagem

A "Hospedagem" escolhida para a nossa aplicação de gestão de locações de produtos é o GitHub Pages. O GitHub Pages é um serviço de hospedagem de sites oferecido pelo GitHub, que permite hospedar sites estáticos diretamente dos repositórios do GitHub. Essa escolha oferece uma maneira conveniente e acessível de disponibilizar nossa aplicação ao público, além de fornecer integração direta com o controle de versão e colaboração facilitada entre membros da equipe. Além disso, o GitHub Pages oferece recursos de segurança para proteger nossa aplicação e garantir seu funcionamento confiável. É uma opção eficaz para hospedar nossa aplicação de forma prática e acessível.
