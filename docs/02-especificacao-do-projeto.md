# Especificações do Projeto

> Pré-requisitos: [Documentação de Contexto](01-documentacao-de-contexto.md)

## Personas

| Nome   | Idade | Ocupação   | Aplicativos | Hobbies  | Motivações                           | Frustrações                                          |
| ------ | ----- | ---------- | ----------- | -------- | ------------------------------------ | ---------------------------------------------------- |
| João   | 25    | Estudante  | Instagram   | Esportes | Facilidade de uso, Praticidade       | Lentidão em processos, Interfaces complexas          |
| Maria  | 30    | Professora | WhatsApp    | Leitura  | Comunicação eficaz, Organização      | Falta de tempo, Dificuldades tecnológicas            |
| Carlos | 35    | Empresário | LinkedIn    | Esportes | Networking, Crescimento profissional | Falta de atualização das conexões, Interface confusa |

## Histórias de Usuários

| Eu como ... `Persona` | Quero/Preciso ... `Funcionalidade`          | Para ... `Motivo/Valor`                                   |
| --------------------- | ------------------------------------------- | --------------------------------------------------------- |
| João                  | Pesquisar produtos disponíveis para locação | Encontrar rapidamente o que desejo alugar                 |
| Maria                 | Visualizar histórico de locações            | Ter um controle sobre os produtos que já aluguei          |
| Carlos                | Cadastrar novos produtos para locação       | Adicionar facilmente novos itens disponíveis para aluguel |

## Requisitos

### Requisitos Funcionais

| ID   | Descrição do Requisito                                                        | Prioridade |
| ---- | ----------------------------------------------------------------------------- | ---------- |
| RF01 | Sistema deve permitir a pesquisa de produtos disponíveis para locação         | Alta       |
| RF02 | Sistema deve exibir detalhes dos produtos, incluindo preço e disponibilidade  | Média      |
| RF03 | Usuário administrador deve poder cadastrar novos produtos para locação        | Alta       |
| RF04 | Usuário administrador deve poder registrar a retirada e devolução de produtos | Alta       |
| RF05 | Sistema deve manter histórico de locações para cada cliente                   | Média      |
| RF06 | Cliente deve poder visualizar seu histórico de locações                       | Alta       |
| RF07 | Sistema deve permitir autenticação via e-mail/senha                           | Média      |

## Requisitos Não Funcionais

| ID    | Descrição do Requisito                                                    | Prioridade |
| ----- | ------------------------------------------------------------------------- | ---------- |
| RNF01 | A aplicação deve ser desenvolvida utilizando C#                           | Alta       |
| RNF02 | A interface do usuário deve ser intuitiva e de fácil utilização           | Média      |
| RNF03 | A aplicação deve ser responsiva para diferentes dispositivos              | Baixa      |
| RNF04 | A aplicação deve ter um tempo de resposta aceitável em todas as operações | Alta       |

## Restrições

| ID  | Restrição                                             |
| --- | ----------------------------------------------------- |
| R01 | O projeto deverá ser entregue até o final do semestre |
| R02 | Pagamentos serão realizados fora da aplicação         |

## Diagrama de Casos de Uso

![Diagrama de casos de uso](diagrams/01-diagrama-casos-de-uso.png)
