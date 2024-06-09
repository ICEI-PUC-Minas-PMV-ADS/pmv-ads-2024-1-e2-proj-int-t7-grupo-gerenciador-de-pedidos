# Programação de Funcionalidades

Implementação do sistema descrita por meio dos requisitos funcionais e/ou não funcionais. Deve relacionar os requisitos atendidos com os artefatos criados (código fonte), deverão apresentadas as instruções para acesso e verificação da implementação que deve estar funcional no ambiente de hospedagem.


|ID    | Descrição do Requisito  | Artefato(s) produzido(s) |
|------|-----------------------------------------|-------------|
|RF-001| A aplicação deve permitir que o usuário gerente consiga realizar login | UsuariosController.cs / Usuarios.cs / Login.cshtml | AccessDenied.cshtml | Program.cs |
|RF-002| A aplicação deve permitir adicionar produtos  | ProdutosController.cs / Produto.cs / Create.cshtml | Index.cshtml | assets |
|RF-003| Deve permitir o gerente visualizar todos os pedidos realizados  | PedidosController.cs / Pedidos.cs / ItemPedido.cs / Index.cshtml | 
|RF-004| Deve permitir ao cliente adicionar produtos a sua comanda   | ClienteController.cs / Pedidos.cs / ItemPedido.cs /  ConfirmaPedidos.cshtml | 
|RF-005| Deve permitir ao cliente visualizar todos os pedidos realizados da comanda | ItemPedidosController.cs / Pedido.cs / ItemPedido.cs / Index.cshtml | 
|RF-007| Deve permitir o cliente visualizar os produtos pela sua categoria   | ClienteController.cs / Produto.cs / CardapioBebidas.cshtml | CardapioLanches.cshtml | CardapioSobremesas.cshtml |
|RF-008| Deve permitir ao gerente dar baixa aos pedidos já pagos  | StatusPedidosController.cs / StatusPedido.cs / Edit.cshtml |
|RF-009| Deve permitir o cliente navegar entre as páginas da aplicação  | LayoutCliente.cshtml | 
|RF-010| Deve permitir a escolha de quantidade do produto que vai ser adicionado ao pedido  | PedidosController.cs /  ItemPedidosController.cs /Pedidos.cs / ItemPedido.cs / ConfirmaPedidos.cshtml | 
|RF-011| A aplicação deve permitir editar um produto  | ProdutosController.cs / Produto.cs / Edit.cshtml | Index.cshtml |
|RF-012| A aplicação deve permitir deletar um produto  | ProdutosController.cs / Produto.cs / Delete.cshtml | Index.cshtml |

# Instruções de acesso

A aplicação esta hospedada na URL :https://easyeats.azurewebsites.net/?mesa=10.

 Inicialmente a aplicação possui um tempo limite diário de utilização pelo serviço de hospedagem azure logo pode ocorrer de quando acessar o link acima as páginas não serem carregadas pois a aplicação estará em "stand by" sendo necessário religar a hospedagem.

 A nossa solução é divida em duas áreas(Cliente,Adminstração), ao clicar no link acima você será redirecionado para área do cliente(a ideia principal é o acesso ser feito por meio de QRCODE que ficaria fixado na mesa,assim ao apontar a câmera seria redirecionado para o site passando parâmetro mesaId,accesar o link acima é uma simulação desse processo utilizando a mesa 10), onde somente é possivel visualização mobile,pois não seria lógico o acesso do cliente no estabelecimento ser feito por notebooks ou computadores.
 
Caso esteja acessando o lado do Cliente pelo notebook será necessário inspecionar a página e acionar a visualização mobile.

Já a parte do Administrador é possível acessar pelo notebook ou computador normalmente, visto que a gerência terá acesso a aplicação por esses meios.

Para acessar o lado do Adminstrador basta inserir o caminho /usuarios/login na URl ou clicar no link abaixo e você será redirecionado para a página de login.

Lado Adminstrador:https://easyeats.azurewebsites.net/usuarios/login.

Login: admin, Senha:admin2024
