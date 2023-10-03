# Especificações do Projeto

> Pré-requisitos: [Documentação de Contexto](documentacao-de-contexto.md)

A definição do problema foi formada a partir de análises dos usuários que mais utilizam este meio e entrevistas com os mesmos, assim possibilitando a criação das personas e histórias de usuários.

## Personas

|                                                      | Nome             | Idade | Ocupação                                              | Aplicativos                               | Hobbies                                                             | Motivações                                                                                                                  | Frustrações                                                                                                                       |
| ---------------------------------------------------- | ---------------- | ----- | ----------------------------------------------------- | ----------------------------------------- | ------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------- |
| ![Amanda Ribeiro](img/persona-2.jpg)                 | Amanda Ribeiro   | 33    | Proprietária de uma empresa de utensílios para festas | Linkedin, Instagram, WhatsApp             | Viajar pelo mundo, Ler livros                                       | Crescimento do Negócio, Satisfação do cliente, Melhor organização Operacional                                               | Conflitos em datas de agendamento, Problemas relacionados ao Pagamento, Dificil Organização de Estoque                            |
| ![Fernando Alencar](img/persona-1.jpg)               | Fernando Alencar | 47    | Ler, Ouvir Musicas                                    | Diretor Executivo de Empresa De Marketing | Manter Competitividade, Eficiência Operacional, Adesão a Tecnologia | Linkedin, Twitter, ClubHouse                                                                                                | Dificuldade de adaptação a novas tecnologias do mercado, Concorrência Acirrada, Mal Gestão de Tempo                               |
| ![Clara Maria](img/persona-enfermeira.jpg)           | Clara Maria      | 26    | Estudar, Dançar                                       | Enfermeira                                | Organizar festas para a família e sua filha                         | Linkedin, Twitter: Encontrar os itens certos para cada festa, evitar gastos excessivos com itens que serão pouco utilizados |
| ![Joaquim Ferreira](img/persona-educador-fisico.jpg) | Joaquim Ferreira | 30    | Jogar bola, jogar Games                               | Professor de Educação Física              | Organizar eventos esportivos e recreativos, artigos esportivos      | WhatsApp, Instagram                                                                                                         | Garantir que todos os participantes tenham acesso aos equipamentos necessários, evitar a compra de itens caros e pouco utilizados |

## Histórias de Usuários

Com base na análise das personas forma identificadas as seguintes histórias de usuários:

| Eu como ... `Persona` | Quero/Preciso ... `Funcionalidade`                                   | Para ... `Motivo/Valor`                                             |
| --------------------- | -------------------------------------------------------------------- | ------------------------------------------------------------------- |
| Amanda Ribeiro        | Alocar Produtos do Estoque e Gerencia-los                            | Melhor Gerenciamento do Estoque                                     |
| Amanda Ribeiro        | Possibilidade de agendamentos de produtos previamente pelos clientes | Evitar conflitos que ocorrem com clientes quando se alugam produtos |
| Amanda Ribeiro        | Ter a disponibilidade de fazer alterações nos produtos               | Mais praticidade e melhor usuabilidade para o usuário               |
| Fernando Alencar      | Deixar o sistema rápido e responsivo                                 | Visando na competitividade do mercado                               |
| Fernando Alencar      | Busca precisas a produtos catalogados                                | Melhorar a Eficiência e rapidez do usuário                          |
| Fernando Alencar      | Adaptação a tecnologia e suas funcionalidades                        | Visando estar em constante mudança no mercado e facilitar as vendas |
| Amanda Ribeiro        | Ferramenta que cadastre usuários                                     | Para melhor segurança e Conforto do usuario e da Empresa            |
| Clara Maria           | Conseguir escolher produtos para Festas                              | Facilitar a escolha de certos produtos e comm um bom orçamento      |
| Joaquim Ferreira      | Diversidade e fácil utilização da ferramenta de aluguel              | Facilitar o processo de aluguel de produtos especificos             |
| Joaquim Ferreira      | Definição de data para retirada e entrega dos produtos               | Melhor planejamento de tempo                                        |
| Clara Maria           | Pesquisa especifica pelo produto                                     | Rapidez e eficiência na compra                                      |

## Requisitos

As tabelas abaixo apresentam os requisitos funcionais e não funcionais que detalham o escopo do projeto.

### Requisitos Funcionais

| ID     | Descrição do Requisito                  | Prioridade |
| ------ | --------------------------------------- | ---------- |
| RF-001 | Permitir que o usuário cadastre tarefas | ALTA       |
| RF-002 | Emitir um relatório de tarefas no mês   | MÉDIA      |

### Requisitos não Funcionais

| ID      | Descrição do Requisito                                            | Prioridade |
| ------- | ----------------------------------------------------------------- | ---------- |
| RNF-001 | O sistema deve ser responsivo para rodar em um dispositivos móvel | MÉDIA      |
| RNF-002 | Deve processar requisições do usuário em no máximo 3s             | BAIXA      |

## Restrições

O projeto está restrito pelos itens apresentados na tabela a seguir.

| ID  | Restrição                                             |
| --- | ----------------------------------------------------- |
| 01  | O projeto deverá ser entregue até o final do semestre |
| 02  | Não pode ser desenvolvido um módulo de backend        |

> **Orientações dos professores**: Enumere as restrições à sua solução. Lembre-se de que as restrições geralmente limitam a solução candidata.

## Diagrama de Casos de Uso

![Diagrama de casos de uso](img/diagrama-casos-de-uso.png)
