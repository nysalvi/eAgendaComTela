using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
using Dominio.Compartilhado;

namespace Dominio
{
    public class Contato : Entidade
    {
        public Contato()
        {

        }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Empresa { get; set; }
        public string Cargo { get; set; }

        public Contato(string nome, string email, string telefone, string empresa, string cargo)
        {
            Nome = nome;
            Email = email;
            Telefone = telefone;
            Empresa = empresa;
            Cargo = cargo;
        }
        public override string Validar()
        {
            if (string.IsNullOrEmpty(Nome))
                return "O campo nome não pode ser Vazio";
            if (Email == null || !ValidarEmail())
                return "O email não pode ser vazio e deve seguir um formato Válido";
            if (ValidarTelefone())
                return "O telefone não pode ser vazio e deve seguir um formato Válido";
            if (string.IsNullOrEmpty(Empresa))
                return "";
            return "sucesso";
        }
        public bool ValidarTelefone()
        {
            string pais = @" *(\+ *[0-9] *[0-9] *)? *";
            string ddd = @"(([0-9] *[0-9] *)|(\( *[0-9] *[0-9] *\) *))?";
            string numero = @"([0-9] *){5}\-?([0-9] *){4}";

            Regex regex = new Regex("^" + pais + ddd + numero + "$");
            return regex.IsMatch(Telefone);
        }
        public bool ValidarEmail()
        {
            EmailAddressAttribute e = new EmailAddressAttribute();
            return e.IsValid(Email);
        }
        public override string ToString()
        {
            return "ID " + Numero + " :\n\tNome : " + Nome + "\n\tEmail : " + Email + "\n\tTelefone : "
                + Telefone + "\n\tEmpresa : " + Empresa + "\n\tCargo : " + Cargo + "\n\t//////////";
        }
    }
}
