# O que é .Net :thinking:

Neste módulo é apresentado a evolução da plataforma do .net. Como o resumo passado o .Net veio para resolver problemas de interoperabilidade de softwares em relação a hardwares. Não se entendi muito bem, mas na linha de pensamento que tenho atual do .Net é que sua evolução trouxe ao .Net 6 atual, que juntou as outras plataformas que tinha na época (.net core, .net framework e Xamarin), porém da mesma forma, a plataforma suporta 3 linguagens, tendo como a principal a C#, cada uma delas possui um compilador que as mapeia para uma linguagem intermediária do .net, que finalmente, é convertido para código de máquina por um runtime. Imagino que, isso aconteceu para padronizar a plataforma, hoje ela encontra-se como open-source, vinculando todas as principais vantagens dessa tecnologia da microsoft.

[foto aqui]



# Iniciando com .Net :eyes:

O gabriel utiliza o VS code, isto é, a "execução" da plataforma é feita manualmente, sem autilização de interface gráfica. Dessa maneira, o que mais me chamou a atenção nessas aulas foi a utilização do cli. A variável de ambiente referente ao .net é **dotnet**. Por exemplo, para saber a versão do framework, existe o seguinte comando:

> **dotnet** --version

A documentação da CLI do .Net está no próprio terminal, podemos fazer o comando help em cada domínio de comando. Por exemplo:

> **dotnet** --help | **dotnet** -h

Exibe todas as opções possíveis de comando **dotnet**. Se usar a opção **new** junto com a flag help, obtemos o que podemos usar com a opção **new**.

> **dotnet** new -h

Adentrando mais no tópico, é abordado pelo Gabriel 3 comando muito importantes, muito usados na confecção de algum projeto, eles são:

> **dotnet** build - Cria um binário referente ao seu projeto. Compila o projeto.
>
> **dotnet** restore - Verifica as atualizações de pacotes que se está usando no projeto. Imagino que a plataforma tem seu próprio esquema para gerenciar dependências, isso deve estar imbutido na CLI, com essa comando verificamos atualizações e dependências.
>
> **dotnet** run - Executa nosso projeto

Algo que me abriu bastante a cebeça também ao ver as aulas, é ficar mais esperto com as variáveis de ambiente do WW. Foi usado um para abrir o explorador de arquivos referenciando o path, e para abrir o vs code, que são respectivamente:

> **explorer** <PATH>
>
> **code** <PATH>

Estiga-me tbm o funcionamento das variáveis de ambiente, sempre as usei, mas nunca me importei em olhar o que realmente são. Promovem códigos específicos da própria aplicação .net que executando seu binário faz-se Syscalls ? Ou algo parecido?

No final do tópico criamos um projeto com template de console. Isso foi executado da seuginte maneira:

> **dotnet** new console -n <NAME>

Lembre-se, qualquer dúvida, a documentação da CLI está no próprio terminal.



# Conhecendo o C# :wave:

C# é uma linguagem de programação que foi inciado junto com o .net, sendo a principal linguagem do framework. Segundo sua documentação C# é uma linguagem elegante, orientada a objetos e fortemente tipada, ou seja, uma vez instânciada uma variável, não pode-se mudar seu tipo sem o uso de operações (cast). Os programas C# são executados na plataforma .NET, esta inclui a CLR (Common Language Runtime),e um conjunto unificado de bibliotecas de classes, como um gframework padrão de determinada linguagem. 

### Como funciona a execução de um programa C# :grey_question:

O código-fonte em C# é compilado e mapeado para um linguagem intermediária (IL). O código nessa linguagem e seus artefatos são armazendos no disco em formato de arquivo executável, portanto extensões como .dll e .exe. Um exemplo prático dessa passagem é o comando **dotnet build** que gera essa mapeação para a IL, gerando os arquivos executáveis. Seguindo essa ideia, quando executamos o programa, o arquivo executável, é carregado o CLR, que é responsável pela execução do programa. Ele converte a IL para código de máquina, ou seja, para um binário representando Syscalls e seus parâmetros. É salientado na video aula que o CLR tem algumas outras tarefas, como genrenciar os lixos de memória, como objetos que n estçao sendo usados no codigo-fonte,  o exception Handler e trata possíveis exceções e o gerenciador de recursos, como qualquer runtime.

[imagem aqui] 

#### Estrutura de um programa C# :straight_ruler:

É citado como as principais elementos organizacionais em C# os seguintes conceitos:

- Programas (o próprio projeto)
- namespaces
- tipos (classes, interfaces)
- membros (atributos e métodos de uma classe)
- assemblyes (executáveis de um projeto (programa))

# Conhecendo variáveis e instruções :wave:

#### :red_circle: Tipos de valor

Há dois tipo de variáveis no C#: **variáveis de tipo de valor e variáveis de referência**.  

Variáveis de tipo de valor são variáveis simples, isto é, variáveis que contêm seus valores diretamente, ao afetar uma variável do tipo valor não altera-se de nenhuma maneira outra variável do tipo valor.

Variáveis de referência são variáveis complexas, é como efetuar em C um typedef em uma struct, e alocar com malloc o novo tipo. O "real" valor da variável é o endereço de onde está os dados do objeto. Dessa maneira, se duas variáveis apontam para o mesmo espaço de memória, ao atualizar uma deles, tbm interfere-se na outra.



#### :red_circle: Instruções em programas

A explicação dada é a mesma nção de statment que vc tem. Um conceito maneiro apresentado, q estou julgando como hierárquico, foi o jeito de apresentar as instruções. Propriamente dizendo há as instruções de escopo que são as instruções de repetição e condição, e instruções que são usadas para auziliar o uso dos domínios das instruções principais.



#### :red_circle: exemplificando conteúdo

Nesse tópico é mostrado na prática as operações presentes no C#. Os exemplos da sintaxe estão neste arquivo, saliento que a sintaxe é praticamente idêntica ao Java.  

**Instrução Using**: Operações de entrada e saída manipula dados a nível de memória, em consequência disso quando precisamos de tais operações precisamos desalocar esses dados da memória manualmente após o uso. Como alternativa podemos manipular esses dados dentro da instrução using, e dessa forma ter o desalocamento feito automaticamente. No exemplo dado, iniciamos um arquivo .txt.

**Arrays multidimensionais:** No C# podemos instanciar arrays multidimensionais da seguinte maneira:

> int [,] a2 = new int[10,5]; -- 10 linhas e 5 colunas;
>
> int[, ,] a3 = new int[10,5,2] -- 10 linhas, 5 colunas e 2 de profundidade;



# Classes e objetos essenciais em C# :open_mouth:

Classes é o principal tipo em C#, dado que a linguagem é orientada a objetos. Sua definição pode ser dado como um molde para formar objetos, que são postos em variáveis de referência. Quando declaramos a implementação de uma nova classe sem especificar se ela herda de alguma classe, criamos uma classe que **herda a Object class**. Dentro desta classe vinculamos **os seus membros**, q podem ser atributos, métodos, constantes, propriedades, etc, da classe. Toda classe possui um método especial, que tem o mesmo nome que a classe, esse é chamado de **construtor**, e serve para iniciar um objeto dessa classe. Para **instanciar um objeto** de uma classe usamos a palavra-chave "new" chamando logo em seguida o construtor:

> Ponto p1 = new Ponto();

Para isso, um espaço na memória é reservado para esse objeto, do mesmo jeito que é feito utilizando o malloc em C, e no final retornando a referência (o endereço de memória) referente ao objeto.  

É salientado que os **membros de uma classe podem ser estáticos ou de instância**, sendo que, quando estático pertence à classe, e quando estático pertence ao objeto. Sem exemplos o que eu entendo disso é que membros de instância só podem ser usados quando um objeto é instanciado.  

Enfatiza-se também que cada **membro de uma classe possui uma acessibilidade**, que controla quais domínios do código podem acessa-los. Os níveis de acessibilidade existentes são:

- Public - Qualquer domínio pode acessar esse membro.
- Protected - Apenas domínios associados podem acessar esse membro, por exemplo um classe filha.
- Internal - Apenas o assembly pode acessar esse membro. Por exemplo, um projeto diferente presente na mesma solução n pode acessar um membro internal de outro projeto.
- Private - Apenas o domínio da própria classe pode acessar o domínio, daí vem, por exemplo, os métodos get e set.

=======================================================================================

É mostrado também como passar endereços de memória como parâmetro usando a palavra-chave ref, ela funciona do mesmo jeito que o * da linguagem C, ou seja, as duas declarações são iguais:

> inverter(int ref x, int ref y){} em C#
>
> inverter(int * x, int * y){} em C

É mostrado também o operando "out", que pelo q eu entendi instancia variáveis através da função. Exemplos para ambas estão no repositório.