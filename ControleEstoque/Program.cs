using System.Collections;

namespace ControleEstoque
{  
    class Program
    {
        static void Main()
        {
            MenuPrincipal menu = new MenuPrincipal();
            menu.MenuOpcao();
        }
    }

    class MenuPrincipal
    {
        Loja loja = new Loja();
        public void MenuOpcao()
        {

            while (true)
            {
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1 - Cadastrar produto");
                Console.WriteLine("2 - Lista produtos");
                Console.WriteLine("3 - Comprar produto");
                Console.WriteLine("4 - Sair");
                Console.Write("Digite sua opção: ");

                string? opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        loja.cadastrarProduto();
                        break;
                    case "2":
                        loja.ListarProdutos();
                        break;
                    case "3":
                        loja.ComprarProduto();
                        break;
                    default:
                        return;
                }
            }
        }

    }
    class Produtos
    {
        public string? Nome { get; set; }
        public int Quantidade { get; set; }
        public double Preco { get; set; }

        public void ExibirProduto()
        {
            Console.WriteLine($"{Nome} a R$ {Preco} com {Quantidade} unidade");
        }

        public bool ConfirmaCadastro()
        {
            Console.WriteLine($"Você tem certeza que quer cadastrar {Nome} a R$ {Preco} com {Quantidade} unidade?");
            Console.WriteLine("1 - Sim");
            Console.WriteLine("2 - Não");

            string? sn = Console.ReadLine();

            if (sn == "1") return true;

            else return false;
        }

    }

    class Loja
    {

        List<Produtos> produtos = new List<Produtos>();
        public void cadastrarProduto()
        {
            Produtos produto = new Produtos();

            Console.WriteLine("Cadastre o seu produto:");

            Console.Write("Nome:");
            string? nome = Console.ReadLine();

            Console.Write("Quantidade:");
            string? quantidade = Console.ReadLine();

            Console.Write("Preço:");
            string? preco = Console.ReadLine();

            produto.Nome = nome;
            produto.Quantidade = int.Parse(quantidade);
            produto.Preco = double.Parse(preco);

            bool confirmou = produto.ConfirmaCadastro();

            if (confirmou)
            {
                produtos.Add(produto);
                Console.WriteLine("Produto cadastrado com sucesso");
            }
            else
            {
                Console.WriteLine("Produto não cadastrado");
            }

        }

        public void ListarProdutos()
        {
            if (produtos.Count == 0) { Console.WriteLine("Nenhum produto cadastrado"); return; }

            foreach (var item in produtos)
            {
                item.ExibirProduto();
            }

        }

        public void ComprarProduto()
        {
            Console.WriteLine("Qual produto você quer comprar?");
            foreach (var item in produtos)
            {
                Console.WriteLine($"{item.Nome} - {item.Quantidade} - R$ {item.Preco}");
            }
            string? comprar = Console.ReadLine();

            if (comprar != "")
            {
                bool encontou = false;
                foreach (var item in produtos)
                {
                    if (item.Nome == comprar)
                    {
                        if (item.Quantidade > 0)
                        {
                            item.Quantidade--;
                            Console.WriteLine("Compra realizada com sucesso!");
                            encontou = true;
                        }
                        else
                        {
                            Console.WriteLine("Sem estoque");
                        }
                    }
                }

                if (!encontou) Console.WriteLine("Produto não encontrado");
            }
            return;
        }

    }

}
