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
                - VER AULA!!
            
            */


        }
    }
}