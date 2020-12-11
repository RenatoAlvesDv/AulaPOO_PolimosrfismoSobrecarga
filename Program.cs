using System;
using AulaPOO_PolimosrfismoSobrecarga.Classe;

namespace AulaPOO_PolimosrfismoSobrecarga
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciamos nossa classe Funcionario
            Funcionario fun = new Funcionario();
            fun.Mostrar();
            fun.Mostrar ("Tsuka");
            fun.Mostrar(7);

            Console.Beep();
        }

    }
}
