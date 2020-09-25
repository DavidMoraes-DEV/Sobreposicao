using System;
using Sobreposicao_PalavraVirtual_Override_Base.Entities;

namespace Sobreposicao_PalavraVirtual_Override_Base
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            * SOBREPOSIÇÃO OU SOBRESCRITA:
            - É a implementação de um método de uma superclasse na subclasse.
            - Para que um método comun (não abstrato) passa ser sobreposto, deve ser incluído nele o prefixo "virtual".
            - Ao sobrescrever um método, devemos incluir nele o prefixo "override".
             */

            Account acc1 = new Account(1001, "Alex", 500.0);
            Account acc2 = new SavingsAccount(1002, "Anna", 500.0, 0.01);

            acc1.Withdraw(10.0);
            acc2.Withdraw(10.0);

            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);

        }
    }
}