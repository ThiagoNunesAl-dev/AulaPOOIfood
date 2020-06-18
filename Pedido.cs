namespace AulaPOOIfood
{
    public class Pedido : DadosBase
    {
        public string Itens { get; set; }
        public string FormaDePGTO { get; set; }
        public bool PedidoPago { get; set; }
        public string EntregarPedido() {
            return $"Pedido entregue a {Nome}.\nConteúdo do pedido: {Itens}.";
        }
        
    }
}