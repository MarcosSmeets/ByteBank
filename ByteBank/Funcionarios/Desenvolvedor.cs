using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    internal class Desenvolvedor : Funcionario
    {
        public Desenvolvedor(string cpf, double salario) : base(cpf, salario)
        {
        }

        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }

        public override double getBonificacao()
        {
            return Salario * .1;
        }
    }
}
