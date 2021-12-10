# Git e GitHub :octopus:

> "Sempre que vou estudar uma tecnologia nova me pergunto a sua finalidade, e o que isso me adicionará na carreira."  
>
> > ---- Otávio Reis  



### Como o git funciona ? :gear:

A base do git é um algoritmo de criptografia chamado de SHA1, que, através de um input do tipo string retorna uma chave hash de 40 caracteres. O que há de especial no SHA1 em relação ao git, é que ao gerar uma criptografia para um texto qualquer, se modifica-lo em apenas um ponto, como substituir um ponto por vírgula, a chave hash para a nova versão será totalemnte diferente. Dessa maneira, através desse algoritmo, sabe-se sempre quando um arquivo do repositório foi modificado.  

Após saber da tal fato, analisemos a estrutura da tecnologia git. Ela é composta por três objetos internos: blob, tree e commits. Blop é o objeto base do git, ele representa a string inicial, uma unidade de arquivo a ser versionada. Em seu interior armazena-se alguns dados, como o tamanho da string (a quantidade de caracteres que o cód possui por exemplo), o conteúdo existente no arquivo (os caracteres do cód por exemplo) e o cód SHA1 do blob em questão. Já as Trees são objetos recursivos, i. e., podemos apontar para outras tree, ou para blobs. Em seu interior armazena-se se está apontando para uma treee ou blob, seu SHA1 e o nome do arquivo referente ao blob , ou o caminho da tree. Note que as tree seguem o mesmo esquema da estrutura de diretórios de sistemas operacionais, onde um diretório aponta para outros diretórios, e as folhas são arquivos finais. Tal estrutura adiciona rastreabilidade. E, por fim, os commits são objetos que apontam para uma tree, para um parente (o commit passado, adiciona rastreabilidade, uma linha de tempo de versionamento), aponta para um autor, e armazena uma mensagem e o tempo no qual o commit foi feito. Observe que o commit é uma estrutura muito importante à dinâmica do git, ele causa a rastreabilidade de versões anteriores, ele causa a anatomicidade de modificações a determinado autor, de forma segura. Note a importância dessa segurança,a  estrutura do git é feita no conceito de que, um commit aponta para uma Tree, uma Tree pode apontar para outra Tree ou para um blob, que por sua vez é a folha da árvore. Se modificarmos a folha (blob) modificamos a estrutura de árvore, eo commit, logo, uma vez que um commit foi feito, não há como modificar suas alterações, bem como sua identificação. Isso evita todo tipo de tentativa de sabotagem.



### Ciclo de vida dos arquivos no git :heart:

![ciclo de vida dos arquivos no git](C:\Users\Gustavo\workSpace\Bootcamp_AVANADE\Git_and_GitHub\dinamica_git.PNG) 



### Como resolver conflitos no github :facepunch:

Note que anteriormente vc n tinha ciência sobre conflitos no git, o comando "git pull origin <branch_name>". Ao ter um arquivo para modificação em seu repositório local, e algum parceiro de equipe ter o mesmo em sua máquina, ocorrerá a situação onde, o último a tentar realizar o push no github estará mexendo no arquivo não sincronizado com o servidor. Dentre essas situações pode ocorrer que vc tente modificar a mesma linha que seu parceiro, e assim ocorrendo os conflitos. Para resolve-los, usamos o comando git pull, que pega o estado atual do servidor e mescla com as suas modificações, e te mostra aonde ocorre os conflitos. Dessa maneira vc e seu parceiro são capazes de resolver o conflito manualmente.