using Revisao;

Funcionario fun = new Funcionario();
Dependente den = new Dependente();
Automovel aut = new Automovel();

fun.PlacaVeiculo = "JUAN4433";
if (fun.VerificarVeiculo(aut))
{
    Console.WriteLine("A placa contém 7 caracteres!");
}
else
{
    Console.WriteLine("Nao existe 7 Caracteres na Placa!");
}

if (fun.Contatar())
{
    Console.WriteLine("Contato Realizado com Sucesso!!");
}

int MatriculaFuncionario = fun.MatriculaFuncionario();
Console.WriteLine(MatriculaFuncionario);