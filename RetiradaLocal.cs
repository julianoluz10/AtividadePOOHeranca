// 5. Sistema de cálculo de frete
// Uma loja virtual precisa calcular o frete de acordo com a modalidade de
// entrega.
// Crie uma classe abstrata Entrega com:
// Propriedade Distancia .
// Método abstrato CalcularFrete() .
// Crie três classes derivadas:
// EntregaExpressa : calcula o frete considerando uma taxa adicional.
// EntregaEconomica : calcula o frete utilizando uma tarifa reduzida.
// RetiradaLocal : não possui custo de frete.
// Implemente o cálculo em cada classe utilizando override .
// Em seguida, crie uma lista do tipo Entrega , adicione objetos das três
// modalidades e utilize foreach para apresentar o valor do frete de cada uma.
namespace AtividadeHeranca
{
    public class RetiradaLocal :Entrega
    {
         public override decimal CalcularFrete()
        {
            // Distancia = distancia;
            // System.Console.WriteLine("Sem custo de frete");

            return 0.00m;
        }
        
    }
}