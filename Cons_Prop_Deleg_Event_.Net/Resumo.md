# Construtores :building_construction:

Construtores representam um método especial no paradigma orientado a objetos. Esse método tem como objetivo instanciar objetos de sua classe, dando uma forma padrão para objetos serem instanciados. Há a possibilidade também de sobrecarga de construtores, adicionando polimorfismo a esse método, podendo assim, ter mais de um padrão para se instanciar um objeto. Caso o construtor de uma classe não for implementado, é considerado um construtor padrão automaticamente, que não recebe parâmetros e inicia os atributos da classe com o valor padrão de seus tipos primitivos. Note que quando definimos um construtor a uma classe, o C# não atribui mais, o construtor padrão, logo, uma vez definido, temos que usar os construtores disponíveis a nível de implementação. Para implementar um construtor deve-se declarar um método com o mesmo nome da classe, por exemplo para a classe Pessoa:

> public Pessoa(string bame, string lastName){
>
> }

**Construtores privados**: Há a possibilidade de termos construtores privados, dessa forma não há maneira de instanciarmos nossa classe. Note que, podemos cair na dúvida do "porque não usar uma classe abstrata ?", a resposta se encontra no fato de tal implementação existe para objetivos diferentes. Usamos um construtor privado para implementar um design patter chamado **singleton**, que consiste em ter um único objeto de uma classe em todo o ciclo de vida do programa. Para implementa-lo declaramos o construtor de uma classe como privado e temos como seu atributo um variável do tipo da própria classe, após,  implementamos um método estático com o objetivo de instanciar o objeto da classe usando o construtor privado e retornando-o, caso o mesmo seja diferente de nulo, o retornamos sem fazer nada. Dessa maneira sempre retornamos o mesmo objeto.

**Construtores na herança**: Quando herdamos de uma classe pai devemos especificar na classe filha o construtor da classe pai com o método base(). Ele é feito da mesma maneira que se especifica qual é a classe pai quando implementamos a filha:

> public Aluno(string name,  string lastName, string disciplina) : base(name, lastName){
>
> ​		this,disciplina = disciplina;
>
> }



# Getters e Setters :ok_hand:

Getters e seter são metodos que podemos colocar em nossas classes com o objetivo de adicionar validação para mudar atributos, formatação para retornar atributos, e pode colocar os atributos com encapsulamento privado, usando esses métodos como o processo requerido para manipular os atributos do objeto.

Seguindo como uma melhora dos métodos getter e setter temos em C# as propriedades. Nas propriedades podemos definir a validação de uma variável, ela compões já metodologia de getter e setter em seu interior:

>private int _mes;
>
>​		public int mes {
>
>​				get{
>
>​						return this._mes;
>
>​				}
>
>​				
>
>​				set{
>
>​						//value representa o valor passado para setar a variavel
>
>​						if(value > 0 && value <= 12)
>
>​								this._mes = value;
>
>​				}
>
>​		}



# Modificadores :m:

Podemos ter 3 tipos de modificadores: readonly, constante e static. O modificador **readonly** uma vez dado a uma variável, esse não poderá mais ser modificada a não ser na sua inicialização ou no construtor da classe. Servindo apenas para leitura após tais operações. Para declararmos uma variável como readonly a botamos depois do modificador de acesso:

>  private readonly string name;

Já o **constante** serve para declararmos "variáveis" locais constantes ou campos constantes, isso é, uma vez atribuído um valor a eles, representarão o mesmo valor até o ciclo de vida do programa. Podemos declarar constantes de tal maneira:

> const double pi = 3,14;

Note a diferença entre os dois modificadores, uma constante é sempre um constante, devemos atribuir seu valor em sua declaração (inicialização), já readonly torna-se readonly quando atribuímos um valor a variável, ou seja, podemos calcular, processar, seu valor após a mesma ter sido definida. De maneira mais formal a constante é constante em nível de compilação, já o readonly, é readonly em nível de execução.



# Delegates :hand:

Delegates é uma forma de passar um método a uma variável, dessa maneira podemos invoca-lo dessa variável a hora que quisermos. Com isso, podemos, por exemplo, mandar um método por parâmetro. Para declararmos um delegate usamos uma sintaxe parecida com a declaração da assinatura de um método:

> public delegate void Operacao(int x, int y);

Dessa maneira, qualquer método que passarmos para esse delegate, deve respeitar essa assinatura. Ao declararmos o delegate podemos instancia-lo da seguinte forma:

> Opracao op = new Operacao(<metodo aqui>);

Dessa forma temos o delegate op, que armazena o método passado. Com ele instanciado podemos invocar o método armazenado com .invoke():

> op.Invoke(<parametros do metodo>);

Além dessa sintaxe, também podemos optar por:

> Operacao op = <metodo aqui>;
>
> op(<paratetros do metodo>);

Há a possibilidade também de usarmos o **multi cast delegate** que nada mais é que adicionar mais de uma referência ao delegate, ou seja, mais de um método apontado. Deve-se ainda respeitar a assinatura do método especificado na declaração do delegate. Para adicionar mais um método fazemos da seguinte forma:

> op += <metodo aqui>;

Dessa forma quando invocarmos o delegate ele executa todos os método q ele armazena com metodologia de prioridade FIFO, i. e. o primeiro q entra é o primeiro que sai.



# Eventos :ticket:

