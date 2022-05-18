using ByteBank;
using ByteBank.Funcionarios;
using ByteBank.Sistemas;

CalcularBonificacao();
UsarSistema();

void CalcularBonificacao(){
    GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

    Designer pedro = new Designer("397.691.618-88", 3000);
    pedro.Nome = "Pedro";

    Diretor roberta = new Diretor("123.456.789-99", 5000);
    roberta.Nome = "roberta";

    GerenteDeConta camila = new GerenteDeConta("987.654.321-11", 4000);
    camila.Nome = "camila";

    Auxiliar igor = new Auxiliar("258.147.369-79", 2000);
    igor.Nome = "igor";

    gerenciadorBonificacao.Registrar(pedro);
    gerenciadorBonificacao.Registrar(camila);
    gerenciadorBonificacao.Registrar(igor);
    gerenciadorBonificacao.Registrar(roberta);

    Console.WriteLine("Total bonificação: " + gerenciadorBonificacao.getTotalBonificacao());
}

void UsarSistema()
{
    SistemaInterno sistemaInterno = new SistemaInterno();
    Diretor diretor = new Diretor("123.456.789-99", 5000);
    diretor.Nome = "Roberta";
    diretor.Senha = "123456";

    GerenteDeConta gerente = new GerenteDeConta("987.654.321-11", 4000);
    gerente.Nome = "Camila";
    gerente.Senha = "teste";

    sistemaInterno.Logar(diretor,"123456");
    sistemaInterno.Logar(gerente, "teste");
}