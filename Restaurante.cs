namespace AulaPOOIfood
{
    public class Restaurante : DadosBase
    {
        public Restaurante (string _nomeFantasia, string _endereco) {
            this.Restaurante = _nomeFantasia;
            this.EnderecoRestaurante = _endereco;
        }
        public string MostrarDados() {
            return $"Restaurante: {Restaurante}\nEndereço: {EnderecoRestaurante}.\n";
        }
    }
}