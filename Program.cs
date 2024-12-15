using DesafioFundamentos.Models;


decimal precoInicial;
decimal precoPorHora;
int indice = 0;


Console.WriteLine("Seja bem vindo ao sistema de estacionamento!");

Console.WriteLine("Digite o preço inicial");
precoInicial = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Agora digite o preço por hora");
precoPorHora = Convert.ToDecimal(Console.ReadLine());

Estacionamento estacionamento = new Estacionamento(precoInicial, precoPorHora);

while(indice != 4){

    Console.Clear();

    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar veiculo");
    Console.WriteLine("2 - Remover veiculo");
    Console.WriteLine("3 - Listar veiculo");
    Console.WriteLine("4 - Encerrar");
    int opcao = Convert.ToInt16(Console.ReadLine());

    switch(opcao){
        case 1:
            estacionamento.AdicionarVeiculo();
            break;
        case 2:
            estacionamento.RemoverVeiculo();
            break;
        case 3:
            estacionamento.ListarVeiculos();
            break;
        case 4:
            indice = 4;
            Console.WriteLine("Pressione uma tecla para continuar");
            Console.ReadKey();
            break;
        default:
            Console.WriteLine("A Opção selecionada não existe");
            break;
    }
}
Console.WriteLine(" ");
Console.WriteLine("O programa se incerrou");