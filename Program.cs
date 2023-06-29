using System;
namespace Pessoa
{
    internal class Program
    {
        private static bool dataNascimentoPessoa;

        static void Main(string[] args)
        {
         Console.WriteLine("Digite o nome da pessoa");
         var nomePessoa =Console.ReadLine();

            Console.WriteLine("Digite a data de nacimento");
            var dataNascimentoPessoa = Console.ReadLine();
            var dataNascimento = Convert.ToDateTime(dataNascimentoPessoa);

            var anoAtual = DateTime.Now.Year;
            var idade = anoAtual - dataNascimento.Year;

            Console.WriteLine("Digite a altura");
            var altura = Convert.ToDecimal( Console.ReadLine());
            Console.WriteLine("Digite o peso");
            var peso = Convert.ToDecimal (Console.ReadLine ());

            var imc = Math.Round ((peso / (altura * altura) * 10000) , 2);

            Console.WriteLine("Digite o salario bruto da pessoa");
            var salario = Convert.ToDouble (Console.ReadLine());

            var aliquota = 7.5;
            var inss = (salario * aliquota) / 100;

            Console.WriteLine("O nome da pessoa é:" + nomePessoa);
            Console.WriteLine("A idade da pessoa " + nomePessoa + "é " + idade + "anos");
            Console.WriteLine("O IMC da pessoa é :" + imc);
            Console.WriteLine("O desconto do INSS é:" + inss);
            


            }
           
                }
            }

      
