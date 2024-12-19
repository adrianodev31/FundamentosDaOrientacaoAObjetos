using System;

namespace ArquivoPOOEstudos // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DEFINIÇÃO DE OBJETO {Um objeto possui propriedades, metodos, e eventos}===================
            /*
                - propriedades: tamanho, largura, altura, cor, etc...
                - metodos: reproduz som, capta som, escreve algo, etc...
                - evento: ao reproduzir som, faça..., ao ligar, faça...
            */
            //
            //CLASSE E OBJETO============================================================================
            /*
                STRUCT!! >> FICAM NA MEMORIA STEAK
                    ex:CRIANDO > 
                    struct Customer {
                        public string Name;
                    }

                    USANDO:
                    var customer = new Customer(){
                        customer.Name = "Teste"; 
                        Console.WriteLine("Olá");
                    }


                CLASS!!!    > observe que crio igual a struct   >> a diferença é que classes são tipos de referência!! armazena só o endereço
                Ficam na memoria HEAP
                    ex:CRIANDO > 
                    class Customer {
                        public string Name;
                    }  

                    USANDO:
                    var customer = new Customer(){
                        customer.Name = "Teste"; 
                        Console.WriteLine("Olá");
                    }


                OBS: Classes acabam sendo um molde para o objeto 
                    ex: class Cliente
                        {
                            string name;    
                        }

            */

            //ENCAPSULAMENTO========================================================================================
            /*
                - É trazer o que faz sentir pra junto, numa classe 
                - conferir - UmPayments
                - uso o primeiro conceito de POO - encapsulamento!

                      class Pagamento
                        {
                            //propriedades      (variaveis viram propriedades)
                            DateTime Vencimento;

                            // Métodos  (funções viram métodos)
                            void Pagar(){

                            }

                        }
            
            */

            // ABSTRAÇÃO=============================================================================================
            /*
                - Esconder tudo que não é preciso (tipo ligar um carro, acender uma luz, a gente só quer que funcione, e as vezes n entende como funciona por debaixo dos panos)
                - Tipo o método ConsultarSaldoDoCartão abaixo, só é util dentro do pagamento, pra outras classes, nem tanto

                    class Pagamento
                        {
                            //propriedades      (variaveis viram propriedades)
                            DateTime Vencimento;

                            // Métodos  (funções viram métodos)
                            void Pagar(){
                                ConsultarSaldoDoCartão("415151515");   >> aqui antes do pagamento, eu consulto o saldo rs
                            }

                            //método
                            private void ConsultarSaldoDoCartão(string numero){  >> O private, serve para que classes de fora, não acessem esse método!! o public é ao contrário rs
                            
                            }

                        }
            
            */

            //HERANÇA=====================================================================================================
            /*
                - herda todos os atributos de OUTRO objeto
                ex:

                class Pagamento
                        {    
                            public DateTime Vencimento;

                            public void Pagar(){
                               
                            }
                        }

                class PagamentoBoleto : Pagamento {    // Aqui to Herdando de Pagamento  /Repare que PagamentoBoleto, se caracteristicas semelhantes a Pagamento, logico que lidarão com coisas diferentes, mas fazem a mesma coisa
                    //Mesmo eu não tendo nada aqui, eu herdei a propriedade e o método!!

                    public string NumeroBoleto; // alem dos herdados, posso ter propriedades e tudo mais, próprios
                }


                AI COMO EU USO ? TENHO QUE INSTANCIAR, PORQUE É NO ATO DE INSTANCIAR, QUE TRANSFORMO A CLASSE EM UM OBJETO EM SI!!
                - var pagamentoBoleto = new PagamentoBoleto();    
                - pagamentoBoleto.Pagar();  >> por exemplo
                - pagamentoBoleto.Vencimento = DateTime.Now;
                - pagamentoBoleto.NumeroBoleto = "123";

                !!!HERDANDO OUTRA EX:
                    class PagamentoCartaoCredito : Pagamento
                    {
                        public string Numero;
                    }


            */

            //POLIMORFISMO========================================================================================================
            /*
                - quando eu herdo uma classe, e pego por exemplo o método pagar(), se eu herdo ela em pagar no credito por exemplo, ela tem que ser modificada, então eu altero ela 
                - uso o "virtual" no metodo para permitir que ele seja socrescrito, editado, obs: uso ele na classe pai
                - uso o "override" na classe filho, a classe que herdou, uso override diretamente no método, exemplo abaixo:

                        public class Pagamento
                        {    
                            public DateTime Vencimento;

                            public virtual void Pagar(){
                               
                            }
                        }

                        class PagamentoBoleto : Pagamento
                        {
                            public override void Pagar (){
                                //Regra nova aqui!!!
                            }
                        }  
            
            */

            //MODIFICADORES DE ACESSO==================================================================================================
            /*  
                - são os publics, privates...
                - posso usa-los em classes, metodos, propriedades
                - eles são: private / protected / internal e public

                    **private: só é visto de dentro da própria classe!
                    **protected: o pretected só é visivel para os filhos da classe!
                    **O internal fica visivel sempre no mesmo namespace
                    **public é pra geral
            
            
                    usando o base!! quando estou dentro de uma classe que foi herdada,e quero usar algo diretamente do pai
                    repare que o Vencimento esta como protected, no caso só com o uso do base eu consigo usa-lo
                    

                        public class Pagamento
                        {    
                            portected DateTime Vencimento;      <<<

                            public virtual void Pagar(){
                               
                            }
                        }

                        class PagamentoCredito : Pagamento
                        {    
                            void Test(){
                                base.Vencimento;        <<
                            }
                        }  
            
            */

            //TIPOS COMPLEXOS ========================================================================================
            /*
                - toda classe que eu crio, vira um tipoo novo, um tipo complexo
                - se uma classe tem muitos metodos, muitas propriedades, quebre em classes menores
                ex:
                    public class Pagamento
                    {
                        DateTime Vencimento;

                        void Pagar() {}
                        Endereco Cobranca;      >> na patrica, é igua o DateTime por exemplo
                    }

                    public class Endereco {
                        string Cep;
                    }
            

            */

            //PROPRIEDADES ==============================================================================================
            /*
                - A gente não escreve as variaveis como variaveis em classes (embora eu possa ter sim)
                - criamos as propriedades!
                - exemplo DateTime Vencimento;  Endereco EnderecoCobranca;
                - atalho para criar uma propriedade: escreva Prop + Tab
                - é comum ver projetos com variaveis privadas com _ antes do nome ex: private DateTime _datePagamento;

                **Acessores, atribui e informa valores
                ex:
                public DateTime DataPagamento
                {
                    get { return _dataPagamento; }
                    set { _dataPagamento = value;  }
                }

                ex 2:

                public class Pagamento
                {
                    public string NumeroBoleto;

                       public DateTime DataPagamento
                            {
                                get 
                                {
                                    Console.WriteLine("lendo o valor");     << são interessantes para tratar dados antes de salvar algo etc..
                                    return _dataPagamento.AddDays(1); 
                                }
                                set 
                                { 
                                    Console.WriteLine("Atribuindo valor");
                                    _dataPagamento = value; >> sempre que recebo um valor aqui, tem essa palavra reservada que vem o valor passado dentro dela 
                                }
                            }
                }

                **USANDO!!
                var pagamento = new Pagamento();
                pagamento.NumeroBoleto = "1215";
                pagamento.DataPagamento = DateTime.Now;     >> essa data e hr de AGORA, vai pra classe em "value" no set


                        obs: se tenho algo mais simples, posso usar a versão resumida de get e set
                        ex: public DateTime Vencimento {get {} set{}}       >> isso quando tenho algo que n precisa ser manipulada

                        **PROPFULL

                        private int myVar;

                        public int MyProperty
                        {
                            get { return myVar; }
                            set { myVar = value; }
                        }
            */

            //MÉTODOS =========================================================================================================================
            /*
                - Em tese, fazem e trazem tudo que as funções são, só que com os modificadores de acesso
                - sobrecarga de metodos (o nome do metodo é pagar, mas a assinatura é void pagar string numero, e o outro é void pagar string numero, datetime vencimento, por exemplo)
                    EX:
                        public void Pagar(string numero) {}
                        public void Pagar(string numero, DateTime vencimento) {}  >> posso fazer isso, usar o mesmo metodo, e dar sobrecarga nele (ex de sobrecarga: string numero
                        public void Pagar(string numero, DateTime vencimento, bool PagarAoVencimento = false); >> sobrecarreguei mais o metodo! é comum
                - tbm posso usar o virtual no pai e override no metodo filho (para o metodo ser sobreescrito)       
                -   EX:
                        public class Pagamento
                        {
                            public virtual void Pagar(string numero){
                                Console.WriteLine("Pagar")
                            }
                        }

                        public class PagamentoCartao: Pagamento
                        {
                            public override void Pagar(string numero){
                                base.Pagar(numero); >> aqui eu chamo o original, do paii
                                Console.WriteLine("Pagar cartão");
                            }
                        }


                        USANDO ISSO!!

                        class Programa  >>
                        {
                            static void Main(string[] args)
                            {
                                var pagamento = new PagamentoCartao();
                                pagamento.Pagar("1234");
                            }
                        }

                        RESULTADO ISSO SERIA
                        pagar       >> resultado pai
                        pagar cartão    >> resultado filho 


                        ***METODO CONSTRUTOR >> É CHAMADO SEMPRE QUE UMA CLASSE É INSTÂNCIADA!!, tem que ter o mesmo nome da classe
                        EX: atalho "ctor"
                            public class Pagamento
                            {
                                public Pagamento()  << esse é o construtor, ele n tem retorno, ele é chamado assim que damos um "new Pagamento" quando estamos instanciando ela
                                {
                                    Console.WriteLine("Iniciando o Pagamento")
                                    DataPagamento = DateTime.Now;       >> serve tbm para inicializar variaveis
                                }

                                public DateTime DataPagamento {get; set;}

                                public virtual void Pagar(string numero)
                                {
                                    Console.WriteLine("Pagar");
                                }

                            }

                        **uma observação é que posso passar um parametro pro construtor, mas pra isso, pode ser que vá precisar passar uma herença do pai tipo
                            public PagamentoCartao(DateTime vencimento): base(vencimento)
                                {
                                
                                }

            
            */

            //USING E DISPOSE=====================================================================================================
            /*
                
                - Garbage collector -> como o C# é uma linguagem gerenciada, quando tenho algo que não estou usando, variavel, algo nulo, o c# exclui da memoria
                - sempre que acessamos o banco de dados, o banco tem um limite de 5 conexões ao mesmo tempo, por exemplo, então é de muita importância garantiar que eu entrei no db, peguei o que queria, e encerrei a conexão
                - nesse caso temos o metodo "destrutor"

                public class Pagamento : IDisposable            >> caso precise, implemente interface
                {
                    public Pagamento()
                    {
                        Console.WritelWriteLine("iniciando o pagamento");
                    }

                    public void Dispose()               >> metodo que é chamado quando to destruindo um objeto
                    {
                       Console.WriteLine("Finalizando o pagamento");
                    }
                }


                **USANDO!!
                    var pagamento = new Pagamento();
                    pagamento.Dispose();    >> aqui ele iniciaria o construtor, daria a mensagem, em seguida destruiria o metodo, daria a mensagem, mas é de grande chance o programador esquecer de usar esse codigo
                                            >> para isso, em vez disso, use o using, abaixo:
                    faça assim: dentro do metodo Main

                        using (var pagamento = new Pagamento())     >> assim ele automaticamente abre e fecha o dispose
                        {
                            Console.WriteLine("Processando o pagamento...");
                        }


                o resultado no console será:
                    - iniciando o pagamento
                    - Processando o pagamento...
                    - Finalizando o pagamento

                    ele passa pelo construtor, pelo using, e finaliza no dispose
                                      

            */

            //CLASSES ESTÁTICAS =============================================================================================
            /*
                - toda classe com static NÃO pode ser instanciada (com aquele new)
                - classe estatica, metodo estatico, propriedades estaticas
                - Quando usar ?: quando eu tenho classes que não mudam muito, que sempre uso sem alterar, tipo configurações, eu uso
                - Uma classe como pagamento mesmo, provavelmente não vou usar static
                - o balta mesmo usa uma classe setting que dentro ele passa API_URL
                - uma vez criada com static, a classe vai dar a mesma informação a todos, sem o static cada new Pagamento, é um pagamento novo por exemplo, diferente para cada usuario
                ex:
                    public static class Pagamento
                    {
                        public static DateTime Vencimento {get; set;}  
                    }
                
                **USANDO!!
                        Pagamento.Vencimento = DateTime.Now;

            */

            //CLASSES SELADAS ====================================================================================================================
            /*
                - Num cenário onde eu quero que uma classe NÃO SEJA HERDADA de forma alguma
                ex: 
                    public sealed class Pagamento   >> isso bloqueia herança!
                    {
                        public DateTime Vencimento { get; set; }    
                    } 
            
            
            */

            //PARTIAL CLASS ======================================================================================================================
            /*
                - se eu tenho uma classe, que dentro tem muito muito codigo, e uma parte faz algo sobre regra de negocios por exemplo, e outra parte faz outra, eu posso repartir
                >> crio 2 arquivos separados, e faço o mesmo namespace em cada, com "partial" no nome na classe
                ex: 2 arquivos com exatamente a mesma estrutura, e ao compilar ele junta tudo

                        namespace Payments
                        {
                            public partial class Payment
                            {
                                public int PropriedadeA { get; set; }   >> no outro arquivo posso por PropriedadeB
                            }
                        
                        }


                        **USANDO 
                        var payment = new Payment();
                        payment.PropriedadeA = 1;
                        payment.PropriedadeB = 2;
                        ou só payment.PropriedadeA;
            */
            //INTERFACES (SEMPRE SEMPRE USE INTERFACES, PENSE BEM NELAS======================================================================================================================
            /*
                - toda vez que definimos uma interface, é como se fosse um contrato, é COMO UMA CLASSE DEVE SER !
                - toda interface começa com I
                - no ex abaixo, tudo que eu definiri em interface, metodos, propriedades etc, a classe Pagamento TEM que seguir obrigatoriamente.
                - não precisa de modificadores de acesso na interface
                - implement é ctrl + .

                    ex: 

                        public interface IPagamento
                        {
                            DateTime Vencimento { get; set; }       >> defini que ele precisa ter essa propriedade em classe

                            void Pagar(double valor);       >> defini um metodo, sem as chaves aqui!!
                        }



                        public class Pagamento : IPagamento     >> se eu não seguir o "contrato" da interface, IPagamento vai ficar vermelhinho embaixo
                        {
                            public Datetime Vencimento { get; set;}

                            public void Pagar(double valor)
                            {
                            
                            }
                        }

                        obs: ai caso for criar outra classe de pagamento que use a mesma interface!!!
                        
                        public class PagamentoCartaoCredito : IPagamento {
                            public Datetime Vencimento { get; set;}

                            public void Pagar(double valor)
                            {
                            
                            }
                        }

            */

            //CLASSES ABSTRATAS===========================================================================================================================



        }
    }
}