create table produto(
	Codigo int,
	Nome varchar(100),
	Descricao varchar(200),
	Preco float
)

create table Cliente(
	Codigo int,
	Nome varchar(200),
	TipoPessoa char(1)
)

create table Pedido(
	Codigo int not null,
	DataSolicitacao datetime not null,
	FlagPago bit not null,
	TotalPedido float not null,
	CodigoCliente int not null
)

create table pedidoItem(
	CodigoPedido int not null,
	CodigoProduto int not null,
	Preco int not null,
	Quantidade int not null
)

/* PRIMEIRAS INSTRUÇÕES SQL */
insert into Cliente (Codigo, Nome, TipoPessoa) values (1, 'Gustavo', 'F');
insert Cliente (Codigo, Nome, TipoPessoa) values (2, 'Henrique', 'F');
insert Cliente (TipoPessoa, Nome, Codigo) values ('F', 'Fábio', 3);
insert Cliente values (4, 'Gabriel', 'F'); /* Considera que os valores são apresentados na ordem da tabela */
insert Cliente values (5, 'Gabriela', 'F'), (6, 'Lenadro', 'F'); /* Mias de uma inserção em uma mesma linha */

select * from Cliente;


select * from Cliente Where codigo in (2,3,4,5);

Delete from Cliente where codigo = 3;

Delete from Cliente where codigo = 3 or codigo = 5;
select * from Cliente Where codigo in (2,3,4,5);

insert Cliente values (5, 'Gabriela', 'F'), (3, 'Lenadro', 'F');
Delete from Cliente where codigo = 3 or codigo = 5;
select * from Cliente Where codigo in (2,3,4,5);

update Cliente set nome = 'nome atualizado menó' where codigo = 2;
select * from Cliente;