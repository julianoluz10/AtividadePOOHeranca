// 1. Sistema de veículos
// Uma empresa precisa representar diferentes tipos de veículos.
// Crie uma classe base Veiculo , contendo as propriedades Marca e Modelo e um
// método ExibirInformacoes() .
// Em seguida, crie duas classes derivadas:
// Carro : deve possuir a propriedade QuantidadePortas .
// Motocicleta : deve possuir a propriedade Cilindradas .
// Crie objetos das duas classes e apresente suas informações.
namespace AtividadeHeranca
{
    public class Veiculos

    {
        public string? Marca { get; set; }
        public string? Modelo { get; set; }


        public void ExibirInformacoes()
        {
            Console.WriteLine($" Marca {Marca} - Modelo {Modelo}");
        }
        
    }
}