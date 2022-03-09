using System;
using dioseries.Classes;
using dioseries.Enum;
using static System.Console;

class program
{
    static SerieRepositorio repositorio = new SerieRepositorio();
    static void Main()
    {
        string opcaoUsuario = ObterOpcaoDoUsuario();

        while (opcaoUsuario.ToUpper() != "X")
        {
            switch (opcaoUsuario)
            {
                case "1":
                    ListarSeries();
                    break;
                case "2":
                    InserirSerie();
                    break;
                case "3":
                    AtualizarSeries();
                    break;
                case "4":
                    ExcluirSeries();
                    break;
                case "5":
                    VisualizarSeries();
                    break;
                case "C":
                    Clear();
                    break;

            }
            opcaoUsuario = ObterOpcaoDoUsuario();
        }

        WriteLine("Até a próxima!!!");
        WriteLine("Digite [enter] para sair");
        ReadLine();
    }

    public static string ObterOpcaoDoUsuario()
    {

        Clear();
        WriteLine(" ");
        WriteLine("DIOFlix\n\n***************");
        WriteLine("Informe a opção desejada:");
        WriteLine("1 - Listar séries");
        WriteLine("2 - Inserir nova série");
        WriteLine("3 - Atualizar série");
        WriteLine("4 - Excluir série");
        WriteLine("5 - Visualizar série");
        WriteLine("C - Limpar tela");
        WriteLine("X - Sair");
        string opcaoUsuario = Console.ReadLine().ToUpper();
        WriteLine("");
        return opcaoUsuario;
    }

    public static void ListarSeries()
    {
        Clear();
        WriteLine("** Listar Séries **\n\n");
        var lista = repositorio.Lista();
        if (lista.Count == 0)
        {
            WriteLine("O cadastro de séries está vazio!!");
            return;
        }
        foreach (var item in lista)
        {
            if (item.RetornaExcluido())
            {
                WriteLine($"EXCLUIDO!! ID:{item.RetornaId()} Título:{item.RetornaTitulo()}");
            }
            else
            {
                WriteLine($"ID:{item.RetornaId()} Título:{item.RetornaTitulo()}");
            }
        }
        WriteLine("\n\n Digite [enter] para voltar ao menu principal");
        ReadLine();
    }

    public static void InserirSerie()
    {
        Clear();
        WriteLine("** Inserir nova série **\n\n");
        WriteLine("Lista de generos:");
        foreach (int i in Enum.GetValues(typeof(Genero)))
        {
            WriteLine($"{i} - {Enum.GetName(typeof(Genero), i)}");
        }
        Write("Digite o código do genero que deseja cadastrar:");
        int entradaGenero = int.Parse(ReadLine());
        WriteLine(Enum.GetName(typeof(Genero), entradaGenero));
        Write("Digite o título da série:");
        string entradaTitulo = ReadLine();
        Write("Digite o ano de início da série:");
        int entradaAno = int.Parse(ReadLine());
        Write("Digite a descrição da série:");
        string entradaDescricao = ReadLine();
        Serie novaSerie = new Serie(
             Id: repositorio.ProximoId(),
            genero: (Genero)entradaGenero,
            titulo: entradaTitulo,
            descricao: entradaDescricao,
            ano: entradaAno);
        repositorio.Insere(novaSerie);
        //WriteLine(novaSerie.ToString());
        WriteLine("\n\n Digite [enter] para voltar ao menu principal");
        ReadLine();
    }

    public static void AtualizarSeries()
    {
        Clear();
        WriteLine("** Atualizar Série **\n\n");
        Write("Digite o Id da Série: ");
        int indiceSerie = int.Parse(ReadLine());

        // Lista os generos disponiveis
        foreach (int i in Enum.GetValues(typeof(Genero)))
        {
            WriteLine($"{i} - {Enum.GetName(typeof(Genero), i)}");
        }
        Write("Digite o código do genero que deseja cadastrar:");
        int entradaGenero = int.Parse(ReadLine());
        WriteLine(Enum.GetName(typeof(Genero), entradaGenero));

        //Entrada dos demais dados da série
        Write("Digite o título da série:");
        string entradaTitulo = ReadLine();

        Write("Digite o ano de início da série:");
        int entradaAno = int.Parse(ReadLine());

        Write("Digite a descrição da série:");
        string entradaDescricao = ReadLine();

        //monta o objeto série
        Serie atualizaSerie = new Serie(
                     Id: repositorio.ProximoId(),
                    genero: (Genero)entradaGenero,
                    titulo: entradaTitulo,
                    descricao: entradaDescricao,
                    ano: entradaAno);

        repositorio.Atualiza(indiceSerie, atualizaSerie);

        WriteLine("\n\n Digite [enter] para voltar ao menu principal");
        ReadLine();
    }

    public static void ExcluirSeries()
    {
        Clear();
        WriteLine("** Excluir Série ** \n\n");
        Write("Digite o Id da Série: ");
        int indiceSerie = int.Parse(ReadLine());

        repositorio.Exclui(indiceSerie);

        WriteLine("\n\n Digite [enter] para voltar ao menu principal");
        ReadLine();
    }

    public static void VisualizarSeries()
    {
        Clear();
        WriteLine("** Visualizar Série ** \n\n");
        Write("Digite o Id da Série: ");
        int indiceSerie = int.Parse(ReadLine());

        var serie = repositorio.RetornaPorId(indiceSerie);

        WriteLine(serie.ToString());
        WriteLine("\n\n Digite [enter] para voltar ao menu principal");
        ReadLine();

    }




}
