# Especificações do Projeto

<span style="color:red">Pré-requisitos: <a href="1-Documentação de Contexto.md"> Documentação de Contexto</a></span>


## Personas

<table>
<tbody>
<tr align=center>
<td width="150px"><b>Nome</b></td>
<td width="100px"><b>Idade</b></td>
<td width="150px"><b>Ocupação</b></td>
<td width="150px"><b>Aplicativos</b></td>
<td width="200px"><b>Motivações</b></td>
<td width="200px"><b>Frustrações</b></td>
<td width="200px"><b>Hobbies, História</b></td>
</tr>
<tr>
<td>Ingrid Andrade</td>
<td>21 Anos</td>
<td>Estudante de direito, cliente</td>
<td>Instagram, Pinterest, X </td>
<td>Sonho em me tornar uma advogada influente que advoga por justiça e igualdade</td>
<td>Atraso do meu pedido; perda de tempo, resultando em atraso no meu horário de pausa dos estudos</td>
<td>Caminhadas, Tenis, Livros</td>
</tr>
<tr>
<td>Thiago Souza</td>
<td>35 Anos</td>
<td>Pizzaiolo e Empreendedor, Sócio da Pizzaria Rosas de Saron</td>
<td>Instagram, Flipboard, LinkedIn</td>
<td>Crescimento da minha área profissional; criar um empreendimento que cresça e seja algo grande, com renome e grande importância no cenário nacional</td>
<td>Fluxo intenso e desorganizado de clientes; atraso nos pedidos; má capacitação dos profissionais</td>
<td>Jogos eletrônicos; desenvolvi o sonho de constribuir para o crescimento da minha área profissional e transformar meu empreendimento em algo renomado de grande importância nacional</td>
</tr>
<tr>
<td>Marcelo Augusto</td>
<td>35 Anos</td>
<td>Balconista</td>
<td>Instagram</td>
<td>Crescimento da minha área profissional</td>
<td>Erros nas anotações dos pedidos; atraso no atendimento das mesas</td>
<td>Música; apostas, esportes</td>
</tr>
</tbody>
</table>


## Histórias de Usuários

<table>
<tbody>
<tr align=center>
<td width="150px"><b>Eu como</b></td>
<td width="500px"><b>Quero/Preciso</b></td>
<td width="200px"><b>Para</b></td>
</tr>
<tr>
<td><b>Ingrid Andrade</b></td>
<td>Visualizar de forma clara os produtos que são ofertados</td>
<td>Selecionar os produtos que desejo comprar</td>
</tr>
<tr>
<td><b>Ingrid Andrade</b></td>
<td>Ver o valor dos produtos adicionados</td>
<td>Não extrapolar o orçamento </td>
</tr>
<tr>
<td><b>Thiago Souza</b></td>
<td>Visualizar o andamento de preparo de cada pedido</td>
<td>Conferir se não existem atrasos para evitá-los</td>
</tr>
<tr>
<td><b>Thiago Souza</b></td>
<td>Alterar ou excluir o pedido de um cliente</td>
<td>Caso necessário cancelar ou alterar o pedido do cliente caso seja necessário</td>
</tr>
<tr>
<td><b>Thiago Souza</b></td>
<td>Adicionar novos produtos ao cardápio</td>
<td>Aumentar nossa diversidade de produtos</td>
</tr>
<tr>
<td><b>Marcelo Augusto</b></td>
<td>Visualizar os pedidos realizados em cada mesa</td>
<td>Direcionar os pedidos para a cozinha</td>
</tr>
<tr>
<td><b>Marcelo Augusto</b></td>
<td>Visualizar a numeração da mesa</td>
<td>Garantir a localização e a eficácia do atendimento</td>
</tr>
</tbody>
</table>


## Requisitos

### Requisitos Funcionais

<table>
<tbody>
<tr align=center>
<td width="100px"><b>ID</b></td>
<td width="650px"><b>Descrição</b></td>
<td width="100px"><b>Prioridade</b></td>
</tr>
<tr>
<td><b>RF-001</b></td>
<td>Deve permitir o gerente fazer login</td>
<td>Alta</td>
</tr>
<tr>
<td><b>RF-002</b></td>
<td>Deve permitir ao gerente adicionar produtos</td>
<td>Alta</td>
</tr>
<tr>
<td><b>RF-003</b></td>
<td>Deve permitir o gerente visualizar todos os pedidos realizados</td>
<td>Média</td>
</tr>
<tr>
<td><b>RF-004</b></td>
<td>Deve permitir ao cliente adicionar produtos a sua comanda  </td>
<td>Alta</td>
</tr>
<tr>
<td><b>RF-005</b></td>
<td>Deve permitir ao cliente visualizar todos os pedidos realizados da comanda</td>
<td>Alta</td>
</tr>
<tr>
<td><b>RF-006</b></td>
<td>Deve permitir ao cliente fechar o pedido para pagamento</td>
<td>Alta</td>
</tr>
<tr>
<td><b>RF-007</b></td>
<td>Deve permitir o cliente visualizar os produtos pela sua categoria</td>
<td>Média</td>
</tr>
<tr>
<td><b>RF-008</b></td>
<td>Deve permitir ao gerente dar baixa aos pedidos já pagos</td>
<td>Média</td>
</tr>
<tr>
<td><b>RF-009</b></td>
<td>Deve permitir o cliente navegar entre as páginas da aplicação</td>
<td>Alta</td>
</tr>
<tr>
<td><b>RF-010</b></td>
<td>Deve permitir a escolha de quantidade do produto que vai ser adicionado ao pedido</td>
<td>Alta</td>
</tr>
<tr>
<td><b>RF-011</b></td>
<td>Deve permitir editar um produto</td>
<td>Alta</td>
</tr>
<tr>
<td><b>RF-012</b></td>
<td>Deve permitir deletar um produto</td>
<td>Alta</td>
</tr>
</tbody>
</table>

**Prioridade: Alta / Média / Baixa. 


### Requisitos não Funcionais

<table>
<tbody>
<tr align=center>
<td width="100px"><b>ID</b></td>
<td width="650px"><b>Descrição</b></td>
<td width="100px"><b>Prioridade</b></td>
</tr>
<tr>
<td><b>RNF-001</b></td>
<td>A aplicação deve ser responsiva para adaptar-se às telas de tablets e smartphones</td>
<td>Alta</td>
</tr>
<tr>
<td><b>RNF-003</b></td>
<td>A aplicação deve ser intuitiva para pessoas sem experiência</td>
<td>Alta</td>
</tr>
<tr>
<td><b>RNF-004</b></td>
<td>Deve ser desenvolvido utilizando padrão MVC com SQL Server</td>
<td>Alta</td>
</tr>
</tbody>
</table>

**Prioridade: Alta / Média / Baixa. 


## Restrições

<table>
<tbody>
<tr align=center>
<td width="100px"><b>ID</b></td>
<td width="650px"><b>Descrição</b></td>
</tr>
<tr>
<td><b>RE-001</b></td>
<td>O projeto deverá ser entregue no final do semestre letivo, não podendo extrapolar a data de 23/06/24</td>
</tr>
<tr>
<td><b>RE-002</b></td>
<td>A equipe não pode subcontratar o desenvolvimento do trabalho</td>
</tr>
<tr>
<td><b>RE-003</b></td>
<td>O sistema deve ser desenvolvido em C# .NET -> Entity Framework</td>
</tr>
</tbody>
</table>


## Diagrama de Casos de Uso


<figure> 
  <img src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t7-grupo-gerenciador-de-pedidos/blob/main/docs/img/DiagramaCasoUso.png" alt"Diagrama Caso de Uso">
</figure>
