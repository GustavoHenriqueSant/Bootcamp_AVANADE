# Modelando um banco de dados na prática com sql server :man_factory_worker::

**Apresentação do tma, da API e a orgnização das tabelas:**

Na modelagem do BD passamos na fase do desenvolvimento do MER (Modelo entidade relacionamento), uma dessas etapas é definir a cardinalidade das entidades. No exemplo dado entre as entidades pessoa e planeta seria:

> <planeta> 1 -- n <pessoa>
>
> <pessoa> 1 -- 1 <planeta>

Dada essa relação podemos modela-la implementando uma chave estrangeira na tabela que tem relação de cardinalidade 1, no caso então teríamos uma chave estrangeira de planeta na tabela pessoa. Já em outras cardinalidades como no exemplo de pessoa e nave teríamos:

> <pessoa> 1 -- n <naves>
>
> <nave> 1 -- n <pessoas>

Pois uma pessoa pode pilotar n naves diferentes durante sua vida, e uma nave pode ser pilotada por n pessoas durante a sua vida. Nesses casos precisamos criar uma nova tabela para armazenar esse relacionamento, que teria uma chave estrangeira tanto para pessoa tanto para nave. Note que tabelas que representam relacionamentos não possuem uma chave primária própria.



