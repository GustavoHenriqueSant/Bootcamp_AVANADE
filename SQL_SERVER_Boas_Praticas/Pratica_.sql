create database SuperMarket;
use SuperMarket;

/* NO PLURAL CARAAAAAAAAAAAAAA */
create table Produto(
	Codigo			int				primary key identity(1,1),
	Descricao		varchar(100)	not null,
	Data_Validade	datetime,
	EAN				varchar(150),
	Ind_Inativo		int not null
);

create index idx_Produtos_EAN on Produto(EAN);
/* Setando o valor padrao para o atributo ind_inativo como 0 */
alter table Produto add constraint df_Produto_IndInativo default 0 for Ind_Inativo;

insert Produto values ('teste', getdate(), '456161616565', 0);
insert Produto (Descricao, EAN) values ('blablabla', '16516151615');
insert Produto (Descricao, EAN) values ('blablabla','+654654');

select * from Produto;

/* o uso do like procuro algo parecido com o que é especificado, no nosso exemplo ele procura qualquer registro que no campo descricao
   tenha qualquer coisa no começo e acabe com bla. Note que esse tipo de consulta não é indexado, dependendo do tamanho da tabela 
   demora para se obter um resultado. Dessa forma, é recomendado sempre utilizar junto com outra clausula where para limitar os registros
   analisados para gformar o output*/
select * from Produto where Descricao like '%bla';

/* No SQL temos em mãos diversas funções de agregação, como a count*/
select count(*) as total
	from Produto;

create table Lojas(
	Codigo int not null,
	Nome varchar(50) not null,
	Ind_Inativo bit default 0,
	constraint pk_Lojas primary key(Codigo)
);

insert Lojas (Codigo, Nome) values (1, 'Lojas de SJC'), (2, 'Loja de SP');

create table Estoque(
	Codigo_Produto  int		not null,
	Codigo_Loja		int		not null,
	quantidade		decimal not null,
	constraint pk_Estoque primary key(Codigo_Produto, Codigo_Loja)
);

alter table Estoque add constraint fk_Estoque_Produto foreign key (Codigo_Produto) references Produto(Codigo);
alter table Estoque add constraint fk_Estoque_Lojas foreign key (Codigo_Loja) references Lojas(Codigo);

insert Estoque (Codigo_Produto, Codigo_Loja, quantidade) values (1, 1, 1), (1, 2, 220), (2, 1, 22);

select * from Estoque;

select P.EAN, E.quantidade
	from Estoque as E right join Produto as P
	on E.Codigo_Produto = P.Codigo
	order by P.Codigo;

create table instrutores(
	nome varchar(30)
);

INSERT INTO Instrutores values('Camila Cavalcante');

INSERT INTO Instrutores values('Venilton FalvoJr');

select * from instrutores;

create table pessoa;