# Design Patterns :chart_with_upwards_trend:

A tradução livre de Design Patterns é "Padrões de projetos" que são implementações para resolver problemas recorrentes na implementação de softwares. Há diversos padrões de projetos existentes, cada um seguindo um "genero", que são 3: padrões de instanciação, padrões de estrutura e padrões de comportamento. Esse tópico do bootcamp foca em mostrar algumas implementações de design patterns famosos. Como não entendi bem a estrutura mostrada nas aulas vi os vídeos para entender cada padrão de projeto apresentado, e tentei implmenta-los em aplicações .net Console.



#### :point_right: Singleton

O padrão de projeto Singleton é usada quando precisamos que apenas um objeto seja instanciado de uma determinada classe durante todo o ciclo de vida de um programa. Ele é um padrão de projeto de instanciação.



#### :point_right: Repository

O padrão de projeto Repository é usada de forma a separar a camada de negócio da camada de dados. Dessa forma conseguimos encapsular a camada de dados, e aproximar mais a implementação no paradigma orientado a objetos. A implementação é feita orientada a interfaces, uma interface é implementada para o repositório de uma tabela, dessa forma podemos ter diversas classes que implementam essa interface, que fazem a lógica para os dados persistir. Dessa forma nosso código entende que pedimos para gravar um dado, ou retornar, ou deletar, sem se importar se isso significa ter que fazer querys SQL ou ler um arquivo .txt, pois a lógica está centralizada nas classes que implementam a interface repository.



#### :point_right: Facade

Não entendi bem o objetivo do facade, parece-se muito com a definição de encapsulamento. O objetivo desse projeto é desenvolver uma classe que serve como uma interface simples para se manipular um subsistema mais complexo. Por exemplo, se tivermos uma classe carro é após a declararmos para usá-la tivermos que usar vários métodos, por exemplo introduzir chave da própria classe carro, inicar combustão de uma classe motor, e por aí vai, poderíamos ter uma classe que tem como método ligar carro, que chama todos esses métodos. Dessa maneira, na chama principal teríamos a chamada de apenas um método, que seria o ligar da classe que implementa o facade.



[Image here - Facade.PNG]