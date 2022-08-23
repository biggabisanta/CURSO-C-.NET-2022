using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variaveis
{
    internal class Program
    {
        /*enum Notas 
        { 
            Minimo = 10, 
            Media = 20, 
            Maxima = 30
              
        } */ 

        struct Pessoa //Uma estrutura que vai armazenar os dados de pessoas
        {
            public string nome;//puclic é um dos modificadores de acesso, esse deixa a variavél publica/visível
            public int idade;
            public double altura;
        } 
       
        static void Main(string[] args)
        {
            #region Numericas Integrais
            /*Variável integral assinado - suporta numeros negativos e postivos 
            sbyte num1 = 10; //8 bits, de -128 a 127   
            short num2 = 10; //16 bits
            int num3 = 30;//32 bits
            long num4 = 40L;//64 bits
           // a diferença entre todas elas são o espaço de memória que elas ocupam.

            //Variável integral sem sinal - não suporta numéros negativos 

            /*para declarar uma variável temos que declarar
            antes o TIPO e atribuir um valor essa variavel com = (igual) 
            e finaliza a declaração com ; (ponto e vírgula).
            Os valores tem que estar compátível com as váriaveis 
            sbyte, short, int, long. Cada um desses suporta determinados valores 


            sbyte numero = 100;
            numero = 120;

            Console.WriteLine(numero); // quando for referenciar uma váriavel
                                 // que contem algum valor númério não pode
                                 // colocar a váriavel entre aspas duplas (" ")
                                 // apenas a palavra. Senão será lida como
                                 // strigs(conjunto de caracteres)
            Console.ReadKey();*/
            #endregion

            #region Numeros Reais 
            /* float real1 = 100.75f; //32 bits
            /* variaveis do tipo float que contem numero com casas decimais se separa
            com .(ponto) e o sufixo f. Ex: 455.78f. Não se usa vírgulas
            double real2 = 12500.45; //64 bits
            variaveis do tipo double não precisa de sufixo, e double ser para criar variaveis de tipo inteiro
            decimal real3 = 752538.457m; //128 bits
            /* variavel do tipo décimo preciso de sufixo*/

            /* Variaveis desse tipo (float, double etc) pode
             ser inicializado sem um valor numérico. 
            valor = 26656.74;
            double valor;


            Console.WriteLine(real1);
            Console.ReadKey(); */
            #endregion

            #region Tipo Caractere

            /*Variável do tipo char aceita apenas 1 caractere. Deve ser atribuído
         dentro de ' ' (aspas simples) e ; (ponto e vírgula). 
            char letra = 'G';
            char letra1 = '\u0061'; //é um código de 1 caractere, portanto o char está lendo uma letra só. 
            //\u0041 é a código da letra a minusculo então ela imprimi o a; 
            char letra2 = '\u0041';//vai imprimir o A maiúsculo.
            char escape = '\n'; 
            //caractere tipo escape são carectere tipo nulo ou caractere de quebra de linha: '\n'

            Console.WriteLine(escape);
            Console.ReadKey();*/
            #endregion

            #region Tipo Boolean

            /*
            
            bool verificar = false;
            verificar = true; 
            /*Expressões booleanas são utilizadas em estruturas condicionais 
            para alterar o fluxo do código mediante a uma verificação.

            Console.WriteLine(verificar);
            Console.ReadKey(); */

            #endregion

            #region Cadeia de Caractere String
            /* é uma coleção senquencial de zero ou mais caracteres dentro de ASPAS DUPLAS " " 

            string texto = "Gabrielle \n @@@???"; // \n pula a linha 
            string ativi = @"O @ ignora todos os caracteres \n especiais ou de escape e vai imprimir tudo em texto";
            /* Colocar o @ antes numa string- @"texto" - anula todo os carecteres 
             de escape naquele texto.

            string mensagem = null; //string nulas com valor vazio
            mensagem = texto;
            /*string é tipo de referência(não premitivo) ele contém vários conjuntos
              de métodos e atributos que ajuda na maninupulação dos caracteres. 
            para acessar esses métodos coloca-se . no final da strings 
            
            
            Console.WriteLine(ativi);
            Console.ReadKey(); */

            #endregion

            #region Tipo Var
            /*Tipo var não tem um tipo definido na sua criação. É usado quando a entrada
             de dados e tipo de dados não foi definido. 
            No caso da variável var tem que ser atribuido um tipo
            */

            /*var valor =140;
            valor = 20;

            /*valor = "gabrielle"; depoir que "valor" foi atribuido ao tipo de dado numérico inteiro
            ele não muda o tipo de dado. Ele não aceita strings por exemplo. 
            

            //usando var não da mais para alterar o TIPO  DE DADO


            //var valor = "Gabrielle";
            //var valor = false;

            Console.WriteLine(valor);
            Console.ReadKey();*/


            #endregion

            #region Tipo object
            //Pode ser atribuido qualquer TIPO de valores. Valor padrão null

            /* O tipo Object é uma variável que o C# criou para herdar todos 
            outros tipos de variáveis. 
            O object é a base para todos os outros tipos, portanto ela consegue
            comportar qualquer TIPO DE DADO. Ela não assume o tipo de dado até
            o final, e sim o object é base para todos os valores.  */

            /*object obj = false;
            obj = 200;
            obj = "Gabrielle";
            // todos os valores que estiverem armazenados em object vão ser tratados como object e não como aquele tipo específico. 
            Console.WriteLine(obj);
            Console.ReadKey(); */
            #endregion

            #region Constantes
            //Para situaçãoes que o valor não pode ser alterado ao longo da aplicação.
            /* Antes de colocar o Tipo de dado tem que colocar a palavra 
               reservada const */
            //o valor precisa ser definido já na sua criação
            /*const double pi = 3.1415;
          

            Console.WriteLine(pi);  
            Console.ReadKey(); */
            #endregion

            #region Enumerações

            /* Se declara uma enumeração na raiz da classe com a palavra 
             reservada enum Nomedaenumeração { } abre e fecha chaves. As variaveis
            dentro da chaves são separadas por apenas vírgula
            Só pode ser declarado numeros inteiros constantes */

           /* Notas notasAlunos = Notas.Media;

            Console.WriteLine();
            Console.ReadKey(); */
            #endregion 

            #region Estruturas 
            /* Estrutura é um Tipo. Que permite o armazenamento de diferentes tipos de dados.
             * Estrutura não é uma  classe, */
           
            Pessoa p1 = new Pessoa(); //desse jeito que se inicia uam estrutura.
            p1.altura = 1.65;
            p1.idade = 23;
            p1.nome = "Gabrielle";

            Pessoa p2 = new Pessoa
            {
                nome = "Miguel",
                idade = 5,
                altura = 1.30

            };
            p1.nome = "Silver";

            Console.WriteLine(p1.nome);
            Console.WriteLine(p1.idade);
            Console.WriteLine(p1.altura);

            Console.WriteLine();

            Console.WriteLine(p2.nome);
            Console.WriteLine(p2.idade);
            Console.WriteLine(p2.altura);

            Console.ReadKey();


            #endregion

        }

    }
    }

