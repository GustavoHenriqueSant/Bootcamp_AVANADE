# Arrays :keycap_ten:

Arrays são estrutura de dados de tamanho fixo q armazena dados do mesmo tipo primitivo. Uma vez declarado e habitado, podemos consultar os dados armazenados através de índices, começando em 0 e terminando em N-1, sendo N o tamanho do array. Modos Para instanciar arrays em C#:

- int[] array = new int[4];
- int[] array = new int[]{45, 26, 58, 49};
- String[] nomes = {"gus", "Leo"};
- int[,] arrayBi = new int[4,2];
- int[,] arrayBi = new int[3,2] {
  - ​												{8, 8},
    - ​										 {10 , 20},
      - ​								  {8, 7}
    - ​									};

Note que a última instanciação definimos um array bidimensional, Com a vírgula definimos o número de linhas e o número de colunas. Ao aumentarmos o número de vírgula e especificando valores, aumentamos a dimensão do array. A definição de array é recursiva, isto é, nas multi dimensões, temos arrays do tipo array.

Note o tratamento nos arrays no C# diferente de outras linguagens, ele vem com algumas propriedades e métodos embutidos que podemos usar. Foi dado o exemplo do método getLength(); que retorna o número de elementos dentro de determinada dimensão do array, ele é muito útil para varrer arrays multi dimensionais.



# Manipulando arrays :japanese_ogre:

#### Algoritmo de ordenação bubble sort:

O algoritmo de ordenação bubble sorte baseia-se em um for duplo, ou seja, o algoritmo possui complexidade equivalente e N ao quadrado. Percorremos o vetor N vezes, e em cada uma das quais percorremos mais N vezes verificando se o índice atual de cada iteração é amior que o próximo índice, e se afirmativo, troca o valor de cada índice. Dessa forma após o término do laço for de maior hierarquia, o vetor encontra-se ordenado.

#### Classe Array presente no namespace System:

Como é apresentado, os arrays são aparentemente de baixo nível, para fazer algo com eles escrevemos bastante código. Dessa forma, o .Net nos fornece a classe Array, que possui diversas operações envolvendo array para usarmos no nosso código. Dentre suas operações temos algoritmos de ordenação já implementados, copiar um array para outro, redimensionar arrays, entre muitos outros. **Alguns exemplos práticos foram implementados, estão presentes na classe OperacoesArray.cs** dentro da pasta Helper armazenada dentro da área para prática desse módulo.



# Coleções genéricas :game_die:

No c#, exitem classe de coleções que agrupam valores, onde é apresentado algumas operações comuns, como ordenação, obter valor por índice, obter valor com expressões, trabalhar com tamanhos dinâmicos, etc. 

[Imagem aqui - Genric_collection.png]



#### List

Pelo que foi passado nas aulas a collecntion list é implementado usando arrays por debaixo dos panos. Ao usá-la, porém, não precimos nos preocupar com o tamanho do array, entre demais outras preocupações. Para declararmos uma lista efetuamos o seguinte trecho de código:

- List<T> name_list = new List<T>();
- List<T> name_list = new List<T> {items};

É exatamente da mesma forma que os arrays em relação de sintaxe. Para as listas temos diversos métodos inclusos no C#, caso queria ver exemplos rápidos sem consultar a documentação, há alguns presentes na classe "OperacoesList.cs".



# Coleções específicas :collision:

As coleções específicas implementam regras para a ordem de acesso e manipulação de seus dados. São elas a Queue que são as filas, e a stack q é a pilha. Os exemplos usando-as estão presentes no diretório destinados a prática deste módulo.



# Dicionários :detective:

Um dicionário é um coleção que armazena pares chaves valores, permitindo dessa maneira que conseguimos recuperar de maneira performática um valor por meio de sua chave. Esssa performance é atribuída ao fator de o dicionário armazenar sua chave em hash descobrindo-se em qual índice nosso valor está minimizando ao máximo o número de operações. Para criarmos um dicionário usamos a seguinte sintaxe:

- Dictionary<Tkey, Tvalue> estados = new Dictionary<Tkey, Tvalue>();



# Operações LINQ :straight_ruler:

LINQ significa Language_Integrated Query, é exatamente o que é o Eloquent no Laravel, fornce uma interface para realizar querys em collections.

[imagem aqui - LINQ sintaxes]















