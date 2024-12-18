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
                ver aula
            */



        }
    }
}