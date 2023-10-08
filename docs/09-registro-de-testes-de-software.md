# Registro de Testes de Software

requisito funcional:

#### RF-01: Sistema de Login
**Passos:**
1. Abra a aplicação.
2. Tente acessar uma área restrita sem fazer login.
3. Insira credenciais válidas.
4. Verifique se o sistema redireciona o usuário para a área restrita após o login.

**Critério de Sucesso:**
- O sistema deve permitir o acesso apenas a usuários autenticados, redirecionando-os para a área restrita após o login bem-sucedido.

#### RF-02: Portalibilidade Assíncrona entre Usuários Cadastrados
**Passos:**
1. Faça login em duas contas de usuário diferentes em duas sessões diferentes.
2. Realize ações em uma sessão (por exemplo, adicionar um produto ao carrinho ou fazer uma reserva).
3. Verifique se as ações realizadas em uma sessão são refletidas automaticamente na outra sessão sem a necessidade de atualização da página.

**Critério de Sucesso:**
- As ações realizadas por um usuário em uma sessão devem ser atualizadas automaticamente para os outros usuários sem a necessidade de recarregar a página.

#### RF-03: Gerenciamento de Produtos e Adição de Novos
**Passos:**
1. Faça login como administrador.
2. Acesse a área de gerenciamento de produtos.
3. Tente adicionar um novo produto preenchendo todos os campos obrigatórios.
4. Verifique se o produto é adicionado com sucesso e exibido na lista de produtos.

**Critério de Sucesso:**
- O administrador deve ser capaz de adicionar novos produtos com sucesso e vê-los listados na área de gerenciamento de produtos.

#### RF-04: Usuários Devem Apenas Adquirir Produtos Logados
**Passos:**
1. Tente adquirir um produto sem estar logado.
2. Verifique se o sistema impede a aquisição e redireciona o usuário para a página de login.

**Critério de Sucesso:**
- Os usuários devem ser impedidos de adquirir produtos sem fazer login e redirecionados para a página de login.

#### RF-05: Usuários Devem Ser Capazes de Realizar Reservas Antecipadas
**Passos:**
1. Faça login como usuário.
2. Navegue até a página de produtos.
3. Selecione um produto e faça uma reserva antecipada.
4. Verifique se a reserva é registrada com sucesso.

**Critério de Sucesso:**
- Os usuários devem ser capazes de fazer reservas antecipadas de produtos e verificá-las no sistema.

#### RF-06: Usuários Devem Ser Capazes de Buscar e Filtrar Produtos
**Passos:**
1. Faça login como usuário.
2. Navegue até a página de produtos.
3. Utilize a funcionalidade de busca e filtro para encontrar produtos com base em critérios específicos.
4. Verifique se os produtos correspondentes são exibidos corretamente.

**Critério de Sucesso:**
- Os usuários devem ser capazes de buscar e filtrar produtos com sucesso de acordo com os critérios especificados.

#### RF-07: Usuários Devem Ser Capazes de Realizar Aluguel Temporário de Produtos
**Passos:**
1. Faça login como usuário.
2. Navegue até a página de produtos.
3. Selecione um produto e inicie o processo de aluguel temporário.
4. Complete o processo de pagamento.
5. Verifique se o produto está disponível para aluguel temporário após a conclusão do processo.

**Critério de Sucesso:**
- Os usuários devem ser capazes de alugar temporariamente produtos, e os produtos devem ficar disponíveis para aluguel após o processo de pagamento.




