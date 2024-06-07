# Arquitetura da Solução

<span style="color:red">Pré-requisitos: <a href="3-Projeto de Interface.md"> Projeto de Interface</a></span>



Definição de como o software é estruturado em termos dos componentes que fazem parte da solução e do ambiente de hospedagem da aplicação.

## Diagrama de Classes

O diagrama de classes ilustra graficamente como será a estrutura do software, e como cada uma das classes da sua estrutura estarão interligadas. Essas classes servem de modelo para materializar os objetos que executarão na memória.

<figure> 
  <img src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t7-grupo-gerenciador-de-pedidos/blob/main/docs/img/DiagramadeClasse2.png" alt"Diagrama de Classe">
</figure>

## Modelo ER (Projeto Conceitual)

O Modelo ER representa através de um diagrama como as entidades (coisas, objetos) se relacionam entre si na aplicação interativa.A seguir é possível visualizar o Modelo ER do nosso projeto.

<figure> 
  <img src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t7-grupo-gerenciador-de-pedidos/blob/main/docs/img/MER.png" alt"Modelo de entidade e relacionamento">
</figure>


## Projeto da Base de Dados

O projeto da base de dados corresponde à representação das entidades e relacionamentos identificadas no Modelo ER, no formato de tabelas, com colunas e chaves primárias/estrangeiras necessárias para representar corretamente as restrições de integridade,na imagem a seguir é possível visualizar o projeto da base de dados do sistema a ser desenvolvido.
 

<figure> 
  <img src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t7-grupo-gerenciador-de-pedidos/blob/main/docs/img/projetoBD.png" alt"Projeto da base de dados">

## Tecnologias Utilizadas

Para implementar a solução a equipe de desenvolvimento utilizou a linguagem C# ASP.NET com o Entity Framework e a biblioteca Session para nos ajudar no armazenamento local de dados,também foi utilizado os serviços da Azure de hospedagem de banco de dados SQL Server,Blob para armazenamento de imagens na nuvem e o serviço de hospedagem na web para que o sistema possa ser colocada em produção.


Também foram utilizadas ferramentas como o Visual Studio para desenvolvimento do código,Azure Data Studio para manipulação e verificação do banco de dados,Discord para comunicação da equipe
(Dailys,Reuniões de alinhamento e Pair Programming), GitHub e GitHub Projects para versionamento de código e organização de tarefas por meio da metodologia ágil SCRUM.

## Hospedagem

A aplicação esta hospedada na URL :<a href="https://easyeats.azurewebsites.net/?mesa=10">https://easyeats.azurewebsites.net/?mesa=10</a>.

Para hospedagem da nossa solução utilizamos os serviços de hospedagem web da Azure,porém,optamos pelo plano mais simples,para inicialmente evitar gastos, nesse plano a aplicação tem um tempo limite diário de utilização logo pode ocorrer de quando acessar o link acima as páginas não serem carregadas pois a aplicação estará em "stand by" sendo necessário religar a hospedagem.

Obs:  A nossa solução é divida em duas áreas(Cliente,Adminstração),ao clicar no link acima você será redirecionado para área do cliente,onde somente é possivel visualização mobile,pois não seria lógico o 
acesso do cliente no estabelecimento ser feito por notebooks ou computadores,caso esteja acessando o lado do Cliente pelo notebook será necessário inspecionar a página e acionar a visualização mobile.

Obs:  Já a parte do Administrador é possível acessar pelo notebook ou computador normalmente,visto que a gerência terá acesso a aplicação por esses meios.Para acessar o lado do Adminstrador basta inserir
o caminho /usuarios/login na URl ou clicar no link abaixo e você será redirecionado para a página de login. 


Lado Adminstrador:<a href="https://easyeats.azurewebsites.net/usuarios/login">https://easyeats.azurewebsites.net/usuarios/login</a>.

Login: admin,  Senha:admin2024
