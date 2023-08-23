using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace emprestimo.Classes
{
    public class Cliente
    {
        public Cliente(int clienteId, string cpf) 
        {
            this.ClienteId = clienteId;
            this.CPF = cpf;
        }

        public int ClienteId { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public List<Emprestimo> Emprestimos { get; set; }

        public bool ValidarCPF()
        {
            // Remover máscaras
            string cpf = this.CPF.Trim().Replace(".", "").Replace("-", "");

            // Garantir que o CPF tem 11 dígitos e não possui uma sequência de dígitos repetidos (ex.: "111.111.111-11")
            if (cpf.Length != 11 || cpf.Distinct().Count() == 1)
                return false;

            // Cálculo do 1º dígito verificador
            int soma = 0;
            for (int i = 0; i < 9; i++)
                soma += int.Parse(cpf[i].ToString()) * (10 - i);

            int resto = soma % 11;
            if (resto < 2) resto = 0;
            else resto = 11 - resto;

            if (resto != int.Parse(cpf[9].ToString()))
                return false;

            // Cálculo do 2º dígito verificador
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(cpf[i].ToString()) * (11 - i);

            resto = soma % 11;
            if (resto < 2) resto = 0;
            else resto = 11 - resto;

            if (resto != int.Parse(cpf[10].ToString()))
                return false;

            return true;
        }
    }
}
