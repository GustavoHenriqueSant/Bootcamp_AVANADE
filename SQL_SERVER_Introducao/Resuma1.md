# SQL SERVER :new:

O SQL server é um SGBD para bancos de dados relacionais desenvolvido pelo Microsoft. Pelo pouco que vi dentro da rede é um SGBD mt poderoso, além do gerenciamento comum ele ter diversas outras ferramentas, para gerar relatórios detalhados dos dados, interface para integrar com outras tecnologias, etc.

É dado alguns detalhamentos na aula sobre a força de banco de dados relacionais, mas n entendi muito a relação com o que foi falado. Por exemplo a consistência de dados está fortemente ligado na minha cabeça ao prórpio SGBD ou tecnologias envolvidas na aplicação, não ao paradigma do banco de dados. **Procure mais sobre para sanar suas dúvidas.**



# Criando o primeiro banco de dados :fire:

Nas aulas foi apresentado uma programa que furnece uma interface gráfica ao SQL Server (SQL Server management Studio). Dessa forma é demonstrado nas aulas como fazer algumas operações no SQL Server tanto na interface quanto nos comandos.

Para criar um banco de dados usamos o seguinte sintaxe:

> create database <name>

Uma vez criado, para utilizar um banco de dados, e dessa forma alterá-lo, usamos:

> use <name>

Podemos criar tabelas dentro do banco como a seguir:

> create table <db name> (
>
> ​		<column name> <column type> <propriedades>,
>
> ​		... others columns...
>
> )

É introduzido no vídeo o conceito de modelagem do banco de dados, a configuração das tabelas, seus comportamentos e conexões deve ser adaptadas aos seus negócios. O que é dito mais detalhadamente refere-se a configuração das tabelas, temos propriedades que podemos colocar em cada uma das colunas de uma tabela, dizendo se ela pode ser null ou n, e tantas outras. Além disse determinar o tipo correto é de suma importância, cada um dos tipos detêm um número de bits que ocupará no disco, saber bem a regra de negócio que a aplicação está inserida e escolher bem as configurações da tabela pode preservar bastante espaço em disco sem comprometer  a regra de negócio implementada.

Ademais podemos deletar uma tabela com o seguinte comando:

> drop table <table name>



# Primeiras instruções SQL :beginner:

É demonstrado algumas instruções SQL para amnipulação de tabelas, dentre elas:  Insert, select, delete e update. Para mais informações e exemplos acesse o arquivo de exemplo prático. É apresentado nesse tópico também algumas variações que se pode fazer no comando insert. É apresentado alguns métodos que dinâmica já definidas no SQL Server que podemos usar para nos ajudar, as opções apresentadas são referentes a conversão, e verificação de valor null. **Além da dica de podermos acessar todas os métodos disponíveis na documentação da microsoft, é dito também que há a possibilidade de criarmos nossas próprias rotinas**. Ademais, foi passado alguns conselhos, como a responsabilidade de regra de negócio ser na codificação da aplicação, e n usando o SQL.



# Normalizando dados :minidisc:

**Chave primaria**: Chave primária é uma coluna da tabela que é capaz de ser única para cada um dos valores, e por consequência, com esse atributo conseguir identificar cada um dos registros de uma tabela. Uma chave primária pode ser simples ou composta, sendo simples uma chave primária unitária, ou composta portando mais de um atributo da tabela.

**Chave estrangeira:** Uma chave estrangeira é um atributo de uma tabela que referencia uma chave primária de outra, causando assim, o fato de que toda chave estrangeira é uma cópia de uma chave primária, ela é do mesmo tipo, tem as mesmas constraints e o mesmo tamanho. É com as chaves estrangeiras que se implementa o paradigma entidade relacional, uma tabela tendo uma chave estrangeira ela relaciona a entidade que ela representa com a entidade que possui a chave primária que a chave estrangeira da primeira copia.



**FORMAS DE NORMALIZAÇÃO:**

**Primeira forma normal:** A primeira formal normal prega que n podemos ter uma, ou mais, colunas duplicadas. Isto é, é dado como exemplo na aula o seguinte cenário: há uma coluna na tabela cliente para armazenar o telefone do cliente, porém caso o cliente queira armazenar mais de um telefone, teríamos que fazer uma nova coluna, ou um registro repetido para armazenarmos esse telefone, o que seria totalmente inviável. Em vez disso, podemos criar um nova tabela para a entidade telefone, sendo assim, por meio de uma chave estrangeira na tabela e uma relação com a tabela cliente através de uma chave estrangeira, podemos ter quantos telefones quisermos para um só cliente.

**Segunda forma normal:** Já a segunda forma normal prega que n devemos ter dois atributos iguais para duas entidades que se relacionam. Por exemplo no exemplo implementado em prática nas aulas constrói-se a tabela produto e pedidoItem, o pedidoItem possui uma chave estrangeira de Produto, se nesse caso tivermos um atributo para o nome do produto nas duas tabelas não estaria na segunda forma normal. Ter essa estrutura na nossa modelagem implica no problema de que se tivermos que alterar um nome de um produto teríamos que mudar tbm na outra tabela. Porém no exemplo dado, as duas tabelas tem um atributo de mesmo nome, mas eles n representam a mesma coisa, o nome do atributo é preço. Na tabela pedido ele representa o preço do produto na hora da venda, e na tabela Produto o preço atual do mesmo.

**Terceira forma normal:** Já a terceira forma normal define que todos os atributo normal da tabela devem ser dependentes da chave primária, transformando as atributos que n são dependente exclusivamentes da chave primária em outra tabela, considerando a modelagem específica para a aplicação.

**Ao pesquisar sobre a terceira forma normal vi** muitas pessoas falando que, seguindo o meu resumo, a terceira forma normal equivale a segunda, e que a terceira forma normal serie remover atributos dependentes de outros, ou seja, de maneira formal, todo atributo deve ser atômico. 



# Trabalhando com tabelas relacionadas :construction_worker:

Nessa aula foi apresnetado os comandos join e group by. O join ele serve para cruzar tabelas selecionando registros específicos por meio de uma expressão lógica para validação. Há exemplos no arquivo prático dessa aula, e alguns comentários sobre. Já o group by ele serve para agrupar registros em um através de um conjunto de atributos. Isto é, no exemplo que usei para praticar no arquivo prático foi uma tabela de vendas, onde temos id, nome do vendedor, quantidade, produto, cidade como atributos. O group by como dito ele "reduz" vários registros a um único número, logo o mesmo é associado a uma função de agregação. Supomos que queremos saber qundos produtos foram criados em cada cidade, se usarmos essa query:

> select cidade, sum(quantidade) as total
>
> from vendas;

Teríamos um único resgistro retornado que possui o núemro de vendas total de todas as cidades juntas. É aí que o group by entra, ao fazer essa query usando o group by em cima do atributo cidade, iremos pegar todos os registros que tem o campo cidade iguais, somar todos os atributos quantidades neles e retornar no output da query. Isso é feito para todos os valores no atributo cidade:

> select cidade, sum(quantidade) as total
>
> from vendas
>
> group by cidade;





