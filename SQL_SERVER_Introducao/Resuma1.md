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





