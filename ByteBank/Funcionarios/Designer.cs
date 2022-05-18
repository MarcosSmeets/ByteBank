using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    internal class Designer : Funcionario
    {
        public Designer(string cpf, double salario) : base(cpf, 3000)
        {

        }

        public override void AumentarSalario()
        {
            Salario += 1.11;
        }

        public override double getBonificacao()
        {
            return Salario * .17;
        }
    }
}
