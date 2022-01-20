select * from Cliente;


insert produto values (1, 'Caneta', 'De cor de azul', 1.5);
insert produto values (2, 'caderno', 'de 10 matérias', 20.0);

select * from produto;
select * from Pedido;

insert Pedido values (1,  getdate(), 0, 3, 6);

insert pedidoItem values (1, 1, 1.5, 1);
insert pedidoItem values (1, 2, 40, 2);

select * from pedidoItem;

/* ================================= select variations: */
select isnull(DataCriacao, getdate()), *
from Cliente;


/* Todas as operações abaixo nos apresentam um retorno formatado, mas n altera o dado na célula */
select *,
	case 
		when TipoPessoa = 'J' then 'Jurídica'
		when TipoPessoa = 'F' then 'Fisica'
		else 'Oloko bixo'
	end
from Cliente;
select * from Cliente;


select *, convert(varchar(50), DataSolicitacao, 103) from Pedido;
select * from Pedido;