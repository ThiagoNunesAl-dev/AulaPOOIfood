namespace AulaPOOIfood
{
    public class Cliente : DadosBase
    {
        public Cliente (string _nome, string _enderecoAtual) {
            this.Nome = _nome;
            this.EnderecoCliente = _enderecoAtual;
        }

        public string MostrarDados() {
            return $"Nome do cliente: {Nome}\nEndereço de entrega: {EnderecoCliente}.\n";
        }
    }
}