# Arquitetura da Solução

 <image src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t3-2023-e2-g2/blob/Rafael0608-patch-3/docs/img/Diagrama%20de%20classes.png?raw=true">

    
    
    
    
## Modelo ER (Projeto Conceitual)

O Modelo ER representa através de um diagrama como as entidades (coisas, objetos) se relacionam entre si na aplicação interativa.

Sugestão de ferramentas para geração deste artefato: LucidChart e Draw.io.

A referência abaixo irá auxiliá-lo na geração do artefato “Modelo ER”.

> - [Como fazer um diagrama entidade relacionamento | Lucidchart](https://www.lucidchart.com/pages/pt/como-fazer-um-diagrama-entidade-relacionamento)

## Projeto da Base de Dados

Este projeto de base de dados tem como objetivo criar a estrutura de armazenamento de informações essencial para a aplicação de gestão de locação de produtos. A base de dados será projetada para acomodar informações detalhadas sobre clientes, itens disponíveis para locação e registros de locações, incluindo dados como nome, descrição, valor, status e outros atributos relevantes. A estrutura de banco de dados será desenvolvida para garantir eficiência, escalabilidade e integridade dos dados, permitindo que a aplicação gerencie as operações de locação de forma eficaz e segura

Consideraremos a criação das seguintes tabelas:

1. Tabela "Clientes":
   - `ID` (Chave Primária)
   - `Nome`
   - `Endereço`
   - `Telefone`

2. Tabela "Itens":
   - `ID` (Chave Primária)
   - `Nome`
   - `Descrição`
   - `Valor`
   - `Foto` (Caminho para a imagem do item)

3. Tabela "Locações":
   - `ID` (Chave Primária)
   - `Cliente_ID` (Chave Estrangeira referenciando a tabela "Clientes")
   - `Item_ID` (Chave Estrangeira referenciando a tabela "Itens")
   - `Data`
   - `Descrição`
   - `Quantidade`
   - `Forma_de_Pagamento`
   - `Status` (Valores possíveis: Agendado, Confirmado, Pago, Cancelado)

Relacionamentos:
- Um cliente pode ter várias locações, mas cada locação pertence a um único cliente.
- Um item pode estar presente em várias locações, mas cada locação inclui um único item.


## Tecnologias Utilizadas

Descreva aqui qual(is) tecnologias você vai usar para resolver o seu problema, ou seja, implementar a sua solução. Liste todas as tecnologias envolvidas, linguagens a serem utilizadas, serviços web, frameworks, bibliotecas, IDEs de desenvolvimento, e ferramentas.

Apresente também uma figura explicando como as tecnologias estão relacionadas ou como uma interação do usuário com o sistema vai ser conduzida, por onde ela passa até retornar uma resposta ao usuário.

## Hospedagem

Explique como a hospedagem e o lançamento da plataforma foi feita.

> **Links Úteis**:
>
> - [Website com GitHub Pages](https://pages.github.com/)
> - [Programação colaborativa com Repl.it](https://repl.it/)
> - [Getting Started with Heroku](https://devcenter.heroku.com/start)
> - [Publicando Seu Site No Heroku](http://pythonclub.com.br/publicando-seu-hello-world-no-heroku.html)
