// Screen Sound

using System.Net.Http.Headers;
using Microsoft.VisualBasic;

//List<string> listaDeBandas = new List<string> {"U2", "The Beatles", "Calypso"};

Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>(); 

bandasRegistradas.Add("Linkin Park", new List<int>{ 10, 8, 6});
bandasRegistradas.Add("The Beatles", new List<int>());
bandasRegistradas.Add("Tears for Fears", new List<int>{ 10, 9, 7});


void ExibirBoasVindas(){

    Console.WriteLine();
    Console.WriteLine("BEM-VINDOS AO SCREEN SOUND!");
    Console.WriteLine("---------------------------");

}

void ExibirMenu(){

    ExibirBoasVindas();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar a lista de bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite 0 para sair");
    Console.Write("\nDigite sua opção: ");

    int opcaoEscolhida = int.Parse(Console.ReadLine()!);

    switch(opcaoEscolhida){

        case 1: RegistrarBanda();
        break;

        case 2: MostrarBandas();
        break;

        case 3: AvaliarBandas();
        break;

        case 4: CalcularMediaBandas();
        break;

        case 0: Console.WriteLine("Tchau tchau! :)");
        break;

        default: Console.WriteLine("Opção Inválida!");
        break;
    }

}

void RegistrarBanda(){
    Console.Clear();
    ExibirTitulo("REGISTRO DE BANDAS");
    Console.Write("\nDigite o nome da banda que você deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    bandasRegistradas.Add(nomeDaBanda, new List<int>());
    Console.WriteLine($"Banda {nomeDaBanda} registrada com sucesso!");
    Console.Write("\nPressione qualquer tecla para continuar");
    Console.ReadKey();
    Thread.Sleep(1000);
    Console.Clear();
    ExibirMenu();

}

void MostrarBandas(){

    Console.Clear();
    ExibirTitulo("LISTA DE BANDAS REGISTRADAS");

    //for (int i = 0; i < listaDeBandas.Count; i++){
    //    Console.WriteLine($"{i+1}: {listaDeBandas[i]}");
    //}

    foreach (string banda in bandasRegistradas.Keys){
        Console.WriteLine($"{banda}");
    }

    Console.Write("\nPressione qualquer tecla para continuar");
    Console.ReadKey();
    Thread.Sleep(1000);
    Console.Clear();
    ExibirMenu();

}

void AvaliarBandas(){

    Console.Clear();
    ExibirTitulo("AVALIAR BANDAS REGISTRADAS");
    Console.Write("Digite o nome da banda: ");
    
    string nomeDaBanda = Console.ReadLine()!;

    if (bandasRegistradas.ContainsKey(nomeDaBanda)){

        Console.Write($"Digite sua nota para a banda {nomeDaBanda} de 0 a 10: ");
        int notaDaBanda = int.Parse(Console.ReadLine()!);

        bandasRegistradas[nomeDaBanda].Add(notaDaBanda);
        Console.WriteLine($"\nA nota para a banda {nomeDaBanda} foi registrada com sucesso!");
        Console.Write("\nPressione qualquer tecla para continuar");
        Console.ReadKey();
        Thread.Sleep(1000);
        Console.Clear();
        ExibirMenu();

    } else {
        Console.WriteLine("\nBanda não encontrada!");
        Console.WriteLine("Pressione qualquer tecla para continuar");
        Console.ReadKey();
        Console.Clear();
        ExibirMenu();
    }


}

void CalcularMediaBandas(){

    Console.Clear();
    ExibirTitulo("MÉDIA DAS BANDAS");
    Console.Write("Digite o nome da banda: ");
    string nomeDaBanda = Console.ReadLine()!;

    if (bandasRegistradas.ContainsKey(nomeDaBanda)){

        double mediaNotasBandas = bandasRegistradas[nomeDaBanda].Average();
        Console.WriteLine($"Média da banda {nomeDaBanda} é : " + mediaNotasBandas);
        Console.Write("\nPressione qualquer tecla para continuar");
        Console.ReadKey();
        Thread.Sleep(1000);
        Console.Clear();
        ExibirMenu();
    
    }else {
        Console.WriteLine("\nBanda não encontrada!");
        Console.WriteLine("Pressione qualquer tecla para continuar");
        Console.ReadKey();
        Console.Clear();
        ExibirMenu();
    }



}

void ExibirTitulo(string titulo){
    int quantidadeDeLetras = titulo.Length;
    string linhas = string.Empty.PadLeft(quantidadeDeLetras, '-');
    Console.WriteLine(linhas);
    Console.WriteLine(titulo);
    Console.WriteLine(linhas + "\n");
}

 ExibirMenu();

//Dictionary<string, List<int>> vendasCarros = new Dictionary<string, List<int>> {
//    { "Bugatti Veyron", new List<int> { 10, 15, 12, 8, 5 } },
//    { "Koenigsegg Agera RS", new List<int> { 2, 3, 5, 6, 7 } },
//    { "Lamborghini Aventador", new List<int> { 20, 18, 22, 24, 16 } },
//    { "Pagani Huayra", new List<int> { 4, 5, 6, 5, 4 } },
//    { "Ferrari LaFerrari", new List<int> { 7, 6, 5, 8, 10 } }
//};

//int somaTotal = 0;
//int media = 0;

// acessar os valores das chaves
// calcular a média dos valores
// exibir a média na tela


//Console.Write("Digite o nome do carro: ");
//string nomeDoCarro = Console.ReadLine()!;

//if (vendasCarros.ContainsKey(nomeDoCarro)){
//    for (int i = 0; i < vendasCarros.Count; i++) {
//        somaTotal += vendasCarros[nomeDoCarro][i];    
//    }

//media = somaTotal / vendasCarros.Count;

//Console.WriteLine($"A média do carro {nomeDoCarro} é {media}");

//}

