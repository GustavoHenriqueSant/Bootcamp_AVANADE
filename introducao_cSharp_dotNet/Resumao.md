# O que é dotNet :question:

DotNet, também conhecido como .Net, é um framework inicialmente desenvolvido pela Microsoft, e atualmente residindo como open source. Pelo q entendi o .Net serve como uma plataforma, desenvolvemos códigos que interagem com ele, e ele com o SO. Dessa forma, além da disponibilizar recursos como um framework comum: funcionalidades para solução de problemas comuns na implementação de aplicações, também serve como uma interface entre o programador e o SO, de maneira a promover vantagens para o mesmo. Uma das coisas que vi que exemplifica bem é que ao escrever e compilar o código em qualquer linguagem suportada pelo .Net, ele converterá o código para um linguagem intermediária chamada Microsoft Intermediate Language (MSIL), com a qual se faz as chamadas as funções do sistema operacional. Tal característica promove alto poder de flexibilidade a projetos. Por exemplo, é sempre dito que uma linguagem de programação é melhor para um coisa específica do que outras, dessa maneira podemos usar mais de uma linguagem para um mesmo projeto, focando-as naquilo que são boas para fazer. 



# Um pouco sobre C# :thinking:

C# é uma linguagem de programação desenvolvida pela Microsoft como parte da plataforma .Net. Os objetivos pré-concebidos no desenvolvimento do C# é que a própria designa-se a ser simples, de propósito geral e orientada a objetos; A linguagem possui suporte a princípiios da engenharia de software , como n deixar que instancia uma variável sem usa-la; o que me deixou curioso é que a linguagem destinou-se a ser utilizada no desenvolvimento de componentes de software adequados para implanatação em ambientes distribuídos, vejo, das poucas característica que vi da linguagem até então, bastante tentativa de independência de código, como atribuição de namespace, podendo repetir nomes de classes para domínios diferentes (table como mesa, serve também para tabela). 

>A linguagem C# faz parte do conjunto de ferramentas oferecidas na plataforma .NET e surge como uma linguagem simples, robusta, orientada a objetos, fortemente tipada e altamente escalável a fim de permitir que uma mesma aplicação possa ser executada em diversos dispositivos de *hardware*, independentemente destes serem PCs, *handhelds* ou qualquer outro dispositivo móvel.
>
>O avanço das ferramentas de programação e dos dispositivos eletrônicos inteligentes, criou problemas e novas exigências. As novas versões de componentes compartilhados eram incompatíveis com o *software* antigo. Os desenvolvedores reconheceram a necessidade de *software* que fosse acessível para qualquer um e disponível por meio de praticamente qualquer tipo de dispositivo. Para tratar dessas necessidades, a *Microsoft* anunciou sua iniciativa .NET e a linguagem de programação C#.[[6\]](https://pt.wikipedia.org/wiki/C_Sharp#cite_note-6)
>
>Durante o desenvolvimento da plataforma .NET, as [bibliotecas](https://pt.wikipedia.org/wiki/Biblioteca_(computação)) foram escritas originalmente numa linguagem chamada *Simple Managed C* (SMC), que tinha um compilador próprio. Mas, em Janeiro de 1999, uma equipe de desenvolvimento foi formada por [Anders Hejlsberg](https://pt.wikipedia.org/wiki/Anders_Hejlsberg), que fora escolhido pela *Microsoft* para desenvolver a linguagem. Dá-se início à criação da linguagem chamada *Cool*. Um pouco mais tarde, em 2000, o projeto .NET era apresentado ao público na *Professional Developers Conference* (PDC), e a linguagem Cool fora renomeada e apresentada como C#.
>
>​																											~wikipedia.

Como é evidenciado, o grande objetivo do .net era atribuir interoperabilidade de softaware em relação a hardwares. Isso é ainda mais visto na história da linguagem C#.



# Estruturas presentes na sintaxe do C#

### Namespace

Os namespace's são usadas para organizar as classes, ao declarar um namespace formulamos um bloco de código que armazenas classes. Para usar classes de um namespace deve-se usando a palavra-chave "using", como um import no python. As vantagens atreladas a isso, imagino ser a elucidação de ambiguidades.



### Classes

A sintaxe refente a classes é idêntico a java, tirando o fator do namespace.



### Interface

A interface também segue o mesmo padrão do Java. Porém para especificar que um classe implementa uma interface usa-se ":", por exemplo:

> **class** Gato : **IAnimal**{
>
> }



### Enum





