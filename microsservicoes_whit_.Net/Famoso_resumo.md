# introdução a microsserviços :runner:

**Por que microsserviços ?**

Antes de falarmos sobre microsserviços, adentraremos no problema que os mesmos resolvem: projetos monolitos. Pelo que entendi na definição de um monolito é um projeto feita e acoplado em um único nó, um código, um domínio completo par um projeto gigantesco, de anos de desenvolvimento, isso gera muitas desvantagens como problemas de conflitos de merge, conexões simultâneas TCP limitadas (não entendo o motivo), problema com deadlock, demora para build e deployment, falta de escalabilidade, etc. Dessa forma, como podemos melhorar esse fator  ?

 

**O que é escalabilidade ?**

Pelo que consegui abstrair posso definir o conceito de escalabilidade em aumentar o poder de resposta da minha aplicação. Por exemplo o conceito de um monolito ter conecões simultâneas TCP limitadas é pq a máquina servidor simplesmente não tem poder de conseguir computar tantas chamadas. Dessa forma, ao adentrarmos na necessidade de mais poder computacional podemos escalar verticalmente e horizontalmente. A escalabilidade vertical se da no conceito de aumentar o poder computacional de uma máquina servidor, adicionando mais poder em suas configurações. Já a escalabilidade horizontal se da no conceito de aumentar o número de máquinas, tendo uma máquina auxiliar que gerencia qual porcentagem de solicitações cada máquina vai possuir. Pelo que consegui abstrair tais táticas ainda adicionam desvantagens na presença de um monolito, pois, ao aumentarmos o número de máquina teremos duas máquinas necessitando ter o mesmo código, isto é, duas máquina com um projeto gigantesco, e se aumentarmos o poder computacional de determinadas máquinas além de existir um limite, aumentar uma configuração já boa vai ser tornando cada vez mais cara, dessa forma eu imagino algo como, já tenho 32GB RAM, como colocar mais se a máquina não ter mais slots ? Uma placa mãe mais avançada em nível de servidores ? pode se comprar slots separados? Uma máquina com tanto poder computacional esquentará muito, como vamos controlar a temperatura ? E por aí vai.



**Enfim os microsserviços**

Podemos resolver todos esses problemas através dos microsserviços. O conceito é, cada funcionalidade (Não é cada funcionalidade, pelo que entendi futuramente nas aulas, cada contexto gera um serviço, por exemplo precisamos de funcionalidade para manipular domínio de bigdata, criaríamos um microsserviço para isso) da nossa aplicação será um microsserviços, ele é independente dos outros, imagino que realizar isso 100% concreto seja impossível, mas o mais independente possível seja o mindset que imagino existir em implementações afins. Dessa forma podemos ter máquinas com apenas alguns microsserviços em um contexto de adicionar escalabilidade horizontal junto com microsserviços, dessa forma podemos adicionar máquinas com os microsserviços mais usados de uma aplicação, que consequentemente precisam de mais computação. Note o poder que isso nos da, além da performance o que já e genial, temos o desenvolvimento incrivelmente facilitado. Observa o seguinte exemplo



[Imagem aqui - Example_microservices.PNG]



Este exemplo nos mostra um exemplo em uma aplicação de um e-commerce. A facilidade está de muitas maneiras, por exemplo se eu quero modificar a funcionalidade de User Account preciso apenas fazer o deploy desse domínio. Note que para cada um deles possui um DB, dessa forma desejo mostrar a ideia novamente que ao quisermos escalar um único contexto somos capazes.

