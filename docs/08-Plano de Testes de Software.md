# Plano de Testes de Software

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Especificação do Projeto</a></span>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>

Apresentação dos cenários de testes utilizados na realização dos testes da sua aplicação. Cenários de testes escolhidos que demonstram os requisitos sendo satisfeitos.

Os casos de teste foram enumerados de forma sequencial e garantem que os requisitos associados a cada um deles estão corretos - de acordo com o que foi definido na seção "2 - Especificação do Projeto". 
 
| **Caso de Teste** 	| **CT-01 – Fazer login com o gerente** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-001 - Deve permitir o gerente fazer login |
| Objetivo do Teste 	| Verificar se o gerente consegue fazer login na aplicação |
| Passos 	| - Abrir o aplicativo - Preencher os campos obrigatórios válidos com os dados de um perfil gerente (e-mail, senha) <br> - Clicar em "Login" |
|Critério de Êxito | - O gerente faz login com sucesso. |
|  	|  	|
| Caso de Teste 	| CT-02 – Adicionar produtos com gerente	|
|Requisito Associado | RF-002	- Deve permitir ao gerente adicionar produtos. |
| Objetivo do Teste 	| Verificar se o gerente consegue adicionar produtos. |
| Passos 	| - Abrir o aplicativo - Preencher os campos obrigatórios válidos com os dados de um perfil gerente (e-mail, senha) <br> - Clicar em "Fazer Login" - Clicar em "Adicionar produtos" - Preencher os campos "Nome", "Descrição" e "Preço" - Adicionar uma imagem para o produto - Clicar em "Adicionar Produto" |
|Critério de Êxito | - O produto é adicionado com sucesso no sistema. |
|  	|  	|
| Caso de Teste 	| CT-03 – Visualizar pedidos realizados	|
|Requisito Associado | RF-003	- Deve permitir o gerente visualizar todos os pedidos realizados. |
| Objetivo do Teste 	| Verificar se o gerente consegue visualizar todos os pedidos. |
| Passos 	| - Abrir o aplicativo - Preencher os campos obrigatórios válidos com os dados de um perfil gerente (e-mail, senha) <br> - Clicar em "Fazer Login" - Conferir se estamos na tela de Pedidos com a aba Pedidos realizados selecionado |
|Critério de Êxito | - Visualizar todos os pedidos realizados e seus detalhes (ID Mesa, Produto, Data/hora, status do pedido). |
|  	|  	|
| Caso de Teste 	| CT-04 – Adicionar produtos a comanda com cliente	|
|Requisito Associado | RF-004	- Deve permitir ao cliente adicionar produtos a sua comanda. |
| Objetivo do Teste 	| Verificar se o cliente consegue adicionar produtos a sua comanda. |
| Passos 	| - Ler o QR identificador da mesa - Clicar em "Cardápio" - Escolher um produto - Escolher quantidade - Clicar em "Enviar para preparo" - Confirmar a escolha |
|Critério de Êxito | - Adiciona todos os produtos e quantidades escolhidos na comanda. |
|  	|  	|
| Caso de Teste 	| CT-05 – Visualizar produtos na comanda	|
|Requisito Associado | RF-005	- Deve permitir ao cliente visualizar todos os pedidos realizados da comanda. |
| Objetivo do Teste 	| Verificar se o cliente consegue visualizar produtos a sua comanda. |
| Passos 	| - Ler o QR identificador da mesa - Clicar em "Cardápio" - Escolher um produto - Escolher quantidade - Clicar em "Enviar para preparo" - Confirmar a escolha - Clicar em "Pedidos" |
|Critério de Êxito | - Visualizar todos os produtos e quantidades escolhidos na comanda. |
|  	|  	|
| Caso de Teste 	| CT-06 – Finalizar a comanda	|
|Requisito Associado | RF-006	- Deve permitir ao cliente fechar o pedido para pagamento. |
| Objetivo do Teste 	| Verificar se o cliente consegue finalizar a sua comanda. |
| Passos 	| - Ler o QR identificador da mesa - Clicar em "Cardápio" - Escolher um produto - Escolher quantidade - Clicar em "Enviar para preparo" - Confirmar a escolha - Clicar em "Pedidos" - Clcar em "Finalizar Comanda" |
|Critério de Êxito | - Comanda é finalizada com sucesso. |
|  	|  	|
| Caso de Teste 	| CT-07 – Visualizar produtos filtrados por categoria	|
|Requisito Associado | RF-007	- Deve permitir o cliente visualizar os produtos pela sua categoria. |
| Objetivo do Teste 	| Verificar se o cliente consegue visualizar os produtos pela sua categoria. |
| Passos 	| - Ler o QR identificador da mesa - Clicar em "Cardápio" - Navegar pelas categorias (Lanches, Bebidas, Sobremesas e Outros) |
|Critério de Êxito | - Visualizar os produtos de acordo com a categoria selecionada. |
|  	|  	|
| Caso de Teste 	| CT-08 – Visualizar status dos pedidos	|
|Requisito Associado | RF-008	- Deve permitir ao gerente dar baixa aos pedidos já pagos. |
| Objetivo do Teste 	| Verificar se o gerente consegue dar baixa aos pedidos já pagos. |
| Passos 	| - Abrir o aplicativo - Preencher os campos obrigatórios válidos com os dados de um perfil gerente (e-mail, senha) <br> - Clicar em "Fazer Login" - Conferir se estamos na tela de Pedidos com a aba Pedidos realizados selecionado - Mudar status do pedido para "Pago"  |
|Critério de Êxito | - Visualizar se o status foi alterado com sucesso. |
|  	|  	|
| Caso de Teste 	| CT-09 – Navegar entre as páginas do cardápio	|
|Requisito Associado | RF-009	- Deve permitir o cliente navegar entre as páginas da aplicação. |
| Objetivo do Teste 	| Verificar se o cliente consegue navegar entre as páginas da aplicação. |
| Passos 	| - Ler o QR identificador da mesa - Clicar em "Cardápio" - Navegar pelas páginas (Início, Cardápio, Pedidos)  |
|Critério de Êxito | - Visualizar as páginas de acordo com a aba selecionada. |
|  	|  	|
| Caso de Teste 	| CT-10 – Mudar a quantidade dos produtos	|
|Requisito Associado | RF-010	- Deve permitir a escolha de quantidade do produto que vai ser adicionado ao pedido. |
| Objetivo do Teste 	| Verificar se o cliente consegue escolher a quantidade do produto que vai ser adicionado ao pedido. |
| Passos 	| - Ler o QR identificador da mesa - Clicar em "Cardápio" - Escolher um produto - Escolher quantidade  |
|Critério de Êxito | - Mudar a quantidade e ao realizar o pedido apresentar a quantidade escolhida corretamente. |
|  	|  	|
| Caso de Teste 	| CT-11 – Editar produtos com gerente	|
|Requisito Associado | RF-011	- Deve permitir ao gerente editar produtos. |
| Objetivo do Teste 	| Verificar se o gerente consegue editar produtos. |
| Passos 	| - Abrir o aplicativo - Preencher os campos obrigatórios válidos com os dados de um perfil gerente (e-mail, senha) <br> - Clicar em "Fazer Login" - Clicar no botão de editar produtos" - Preencher os campos que deseja editar "Nome", "Descrição", "Preço", "Imagem" - Clicar em "Editar Produto" |
|Critério de Êxito | - O produto é editado com sucesso no sistema. |
|  	|  	|
| Caso de Teste 	| CT-12 – Deletar produtos com gerente	|
|Requisito Associado | RF-012	- Deve permitir ao gerente deletar produtos. |
| Objetivo do Teste 	| Verificar se o gerente consegue deletar produtos. |
| Passos 	| - Abrir o aplicativo - Preencher os campos obrigatórios válidos com os dados de um perfil gerente (e-mail, senha) <br> - Clicar em "Fazer Login" - Clicar no botão de deletar produtos" - Verificar os dados do produto que será deletado "Nome", "Descrição", "Preço" - Clicar em "Deletar Produto" |
|Critério de Êxito | - O produto é deletado com sucesso no sistema. |
|  	|  	|

 
> **Links Úteis**:
> - [IBM - Criação e Geração de Planos de Teste](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Práticas e Técnicas de Testes Ágeis](http://assiste.serpro.gov.br/serproagil/Apresenta/slides.pdf)
> -  [Teste de Software: Conceitos e tipos de testes](https://blog.onedaytesting.com.br/teste-de-software/)
> - [Criação e Geração de Planos de Teste de Software](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Ferramentas de Test para Java Script](https://geekflare.com/javascript-unit-testing/)
> - [UX Tools](https://uxdesign.cc/ux-user-research-and-user-testing-tools-2d339d379dc7)
