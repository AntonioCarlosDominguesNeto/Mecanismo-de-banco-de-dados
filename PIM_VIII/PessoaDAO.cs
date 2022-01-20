using System;
using System.Data.SqlClient;

namespace PIM_VIII
{
    public class PessoaDAO : Pessoa
    { 
        //Métodos
        bool Pessoa = true;
        public void exclua()
        {
            bool Pessoa = false;
        }

        public void insira()
        {
            bool Pessoa = true;
        }

        public void altere()
        {
            if (Pessoa = true)
            {
                Pessoa = false;
            }
            else
            {
                Pessoa = true;
            }
        }

        public void consulte()
        {
            long consulta;
            Console.WriteLine("Digite o cpf que deseja consultar:");
            consulta = long.Parse(Console.ReadLine());
            if (consulta == cpf)
            {
                return Pessoa;
            }
        }
    }
}