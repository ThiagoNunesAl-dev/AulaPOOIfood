using System;

namespace AulaPOOIfood
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente thiago = new Cliente("Thiago", "Rua 0");

            Restaurante bk = new Restaurante("Burger King", "Rua 1");

            Pedido pedido = new Pedido();
            pedido.Nome = thiago.Nome;
            pedido.Restaurante = bk.Restaurante;
            pedido.Itens = "1 Whopper furioso, 1 refri, 1 batata";
            pedido.FormaDePGTO = "Cartão";
            pedido.PedidoPago = true;

            System.Console.WriteLine(bk.MostrarDados());
            System.Console.WriteLine(thiago.MostrarDados());
            System.Console.WriteLine(pedido.EntregarPedido());
        }
    }
}
