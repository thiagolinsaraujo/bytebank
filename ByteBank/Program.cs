using System;

namespace ByteBank
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ContaCorrente contaThiago = new ContaCorrente(1234, 19878);
            contaThiago.Titular = new Cliente();
            contaThiago.Titular.Nome = "Thiago Araújo";
            contaThiago.Titular.Profissao = "Engenheiro de Software";
            contaThiago.Titular.CPF = "098.099.299-87";
            Console.WriteLine("Nome..................: " + contaThiago.Titular.Nome);
            Console.WriteLine("Profissão.............: " + contaThiago.Titular.Profissao);
            Console.WriteLine("CPF...................: " + contaThiago.Titular.CPF);
            Console.WriteLine("Agência...............: " + contaThiago.Angencia);
            Console.WriteLine("Conta Corrente........: " + contaThiago.Numero);
            Console.WriteLine("Saldo Atual...........: " + contaThiago.Saldo);

            Console.WriteLine("####################################################");
            contaThiago.Depositar(500);
            Console.WriteLine("Saldo após depósito...........: " + contaThiago.Saldo);

            contaThiago.Sacar(50);
            Console.WriteLine("Saldo após saque..............: " + contaThiago.Saldo);

            ContaCorrente contaNatalia = new ContaCorrente(1234, 19879);
            contaThiago.Transferir(100, contaNatalia);

            Console.WriteLine("Saldo após tranferência.......: " + contaThiago.Saldo);
            Console.WriteLine("Salda da conta Natália........: " + contaNatalia.Saldo);

            Console.ReadLine();
        }
    }
}