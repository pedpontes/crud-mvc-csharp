# User Management Web Application
### Este projeto é uma aplicação web para gerenciamento de usuários. A aplicação permite adicionar, editar, listar e excluir usuários. A interface é implementada com uma tabela que lista todos os usuários e oferece a funcionalidade de edição e exclusão via modais.

## Funcionalidades
- Listagem de Usuários: Visualize todos os usuários em uma tabela.
- Edição de Usuários: Edite as informações de um usuário através de um modal.
- Exclusão de Usuários: Exclua um usuário da lista.
- Adição de Usuários: Adicione novos usuários.
## Ferramentas Utilizadas
- ASP.NET Core: Framework utilizado para criar a API que gerencia os usuários.
- Entity Framework: ORM para a interação com o banco de dados.
- MySQL/MariaDB: Banco de dados relacional utilizado para armazenar as informações dos usuários.
- HTML/CSS: Utilizado para estruturar e estilizar a página web.
- JavaScript: Utilizado para adicionar interatividade à página web, como exibir modais e lidar com a edição e exclusão de usuários.
## Rotas da API
#### Listagem de Usuários

Método: GET
Rota: /users
Descrição: Retorna uma lista de todos os usuários.
Adição de Usuário

Método: POST
Rota: /add
Descrição: Adiciona um novo usuário. O corpo da requisição deve incluir os dados do usuário (nome, idade, senha).
Edição de Usuário

Método: PUT
Rota: /users
Descrição: Atualiza as informações de um usuário existente. O corpo da requisição deve incluir o ID do usuário e os dados a serem atualizados (nome, idade, senha).
Exclusão de Usuário

Método: DELETE
Rota: /users?id={id}
Descrição: Exclui um usuário com o ID especificado.
