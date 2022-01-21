select *
from produto pd
inner join pedidoItem
on pd.Codigo = pedidoItem.CodigoProduto;

select * from produto;
select * from pedidoItem;

insert produto values (3, 'lapis', 'lapis de madeira', 0.50);
insert produto values (4, 'lapiseira', 'lapiseira de metal', 3.80);

select *
from produto pd
left join pedidoItem
on pd.Codigo = pedidoItem.CodigoProduto;

/* Fica ligado que com right join ela relaciona a tabela da direita (pedidoITEM) com a da esquerda, e se os registros de compatibilidade retorna null */
select *
from produto pd
right join pedidoItem
on pd.Codigo = pedidoItem.CodigoProduto;

/* ======================== LAST CLASS ======================================= */
/* note que isso: */
select *
from produto pd
left join pedidoItem
on pd.Codigo = pedidoItem.CodigoProduto
where pd.Preco > 15;

/* é diferente disso: */
select *
from produto pd
left join pedidoItem
on pd.Codigo = pedidoItem.CodigoProduto
and pd.Preco > 15;

/* No priemiro exemplo retornar apenas um registro, pois o where estará fora da clausula left join, e sim realizando a operaçao where
   no output de left join. Já usando and, estamos adicionando mais operandos na operação booleana que valida o left join. */

/* ========================== PARA ENTENDER MEHLOR O GROUP BY ========================== */

create table vendas(
	id smallint primary key,
	Nome_vendedor varchar(20),
	Quantidade int,
	Produto varchar(50),
	Cidade varchar(50)
);

insert vendas values (10, 'jorge', 1400, 'teclado', 'São Paulo'), (12, 'talita', 1220, 'Mouse', 'São Paulos'), (14, 'Ana', 1700, 'Teclado', 'Rio Janeiro'), (15, 'Rita', 2120, 'Webcam', 'Recife'), (18, 'Marcos0', 980, 'Mouse', 'São Paulo'), (19, 'Carla', 1120, 'ebcam', 'Recife'), (22, 'Roberta', 3145, 'Mouse', 'São Paulo');

select Cidade, sum(Quantidade) as total
from vendas
group by Cidade;


