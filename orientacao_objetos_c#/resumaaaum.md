# O que é POO :question:

Programação orientada a objetos é um paradigma de programação, i. e., define-se uma metodologia de programação apara atender um objetivo específico. Esse paradigma em questão foi criado para aproximar o mundo real do mundo da programação, para que abstrações e modelagens sejam feita de maneira mais fácil. POO constitui de 4 pilares:

- Abstração
- Encapsulamento
- Herança
- Polimorfismo

Como já definido anteriormente, a POO tem como base o conceito de classe e objeto. Classe é um molde, e objeto são dados que passa por esse molde. 

[Imagem aqui "Classe_objeto.png"]

As classes são constituídas de estados e ações. Os estados são seus atributos e suas ações são os métodos presentes nela. O exemplo a cima mostra um exemplo da classe Pessoa, seus estados é representados pelos atributos nome e idade, e as ações que ela pode fazer é se apresentar. Ao lado direto pe mostrado um objeto concreto feito a partir dessa classe, fazendo a ação de se apresentar. Uma analogia apresentado que achei legal foi a de uma planta e uma casa construída, Pode-se ver a planta como a classe de um tipo de casa, e a casa construída como o objeto a partir da classe planta. Dentro desse exemplo podemos ver na prática alguns detalhes legais, como, não é possível abrir a porta da planta, mas da casa s. Do mesmo jeito é na POO, não da para manipular uma classe, é sim um objeto de uma classe.



# Abstração :cactus:

A abstração se da do conceito de isolar objetos da realidade, abstraindo as principais características do mesmo dentro do domínio de programação a ser modelado. Na documentação se da a seguinte definição: Modelando os atributos relevantes e as interações de entidades como classes para definir uma representação abstrata de um sistema.



# Encapsulamento :card_index_dividers:

O encapsulamento define uma proteção, um limite de possibilidade de alteração das propriedades de uma classe. Em outra palavra, ele oculta o comportamento de uma classe, e expões somente o necessário para o funcionamento correto do código. 



# Herança :money_mouth_face:

O pilar da herança, nos permite no paradigma orientado a objetos, herdar membros e comportamentos entre classes. Por exemplo, podemos ter a classe Pessoa, Professor e Aluno. Todas são classes diferentes, mas as classes Professor e Aluno herdar a classe Pessoa. Tal característica nos permite ter uma melhor reutilização de código e menos duplicação de código.



# Polimorfismo :heavy_plus_sign:

A palavra polimorfismo significa "várias formas". Tal característica desse paradigma promove a possibilidade de sobrescrever métodos, ou seja, uma classe filha pode refazer um método que herda da classe pai, se esse não a atender. Há dois tipos de polimorfismo: polimorfismo em tempo de execução, e polimorfismo em tempo de compilação. O primeiro remete-se ao exemplo inicial, uma classe filha sobrescrevendo o método herdado da classe pai. Já o segundo refere-se a duplicação de métodos de uma mesma classe, mudando sua assinatura. O exemplo dado foi de uma calculadora, onde temos nessa mesma classe dois métodos "somar", porém os parâmetros utilizados um no outro são diferentes.

**No polimorfismo em tempo de execução** precisamos declarar a intenção de sobrescrita tanto na classe pai tanto no classe filha. Ao declarar o método na classe pai deve-se usar a palavra-chave virtual:

> public virtual void apresentar(){
>
> }

Já na sobrescrita na classe filha, deve-se usar a palavra-chave override:

> public override void aprensetar(){
>
> }

Já **no polimorfismo em tempo de compilação** é preciso apenas diferenciar a assinatura do método que será polimórfico, isto é, os dois métodos de nomes iguais devem receber parâmetros diferentes, seja no tipo dos parâmetros, na quantidade, etc.



# Classes abstratas :japanese_ogre:

Classes abstratas são classes que servem exclusivamente para serem herdadas, isto é, uma classe abstrata é um modelo de classe. Dessa maneira, uma classe abstrata não pode ser instanciada, serve somente para ser herdada. Em seu interior pode-se ter implementações de métodos, que então podem ser abstratos ou n. Métodos abstratos condicionam que a classe filha deve, obrigatoriamente, sobrescrever o método. Uma classe abstrata pode ser implementada com a palavra-chave "abstract":

> public abstract class Pessoa{
>
> }

Do mesmo modo, também a usamos para implementar métodos abstratos:

> public abstract void metodoName(){
>
> }

# Classes seladas :fox_face:

Classes seladas são classes incapacitadas de terem classes filhas. Ao declarar uma classe como selada, significa não ter mais nem um nível hierárquico vindo dela. Isso implica, por exemplo, que uma classes selada pode herdar de outra, mas n pode atribuir herança a outras. Além das classes tabmém há métodos e propriedades seladas. Os métodos selados representam o estado final de um método, isso é, se eu atribuo um método de uma classe pai como selado, todas as possíveis classes filhas deverão usar o método que está na classe pai, sendo impossível sobrescreve-lo. Para implmenetar classes ou metodos selados usamos a palavra-chave "sealed":

> public sealed class Professor{
>
> }

E, segue o mesmo modo para métodos:

> public sealed void apresentar(){
>
> }

Algumas variações podem ocorrer, como:

> public sealed override void apresentar(){
>
> }

Que seguem a mesma sintaxe.

# Classe Object :classical_building:

A classe object é a classe base do C#, todo tipo de dados herda da classe object. Encontra-se nela alguns métodos como equals, toString, etc. Seu principal objetivo é fornecer a suas classes filhas serviços de baixo nível, como operações de referência, alocação de memória, etc.
