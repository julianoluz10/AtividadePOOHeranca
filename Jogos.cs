// 3. Sistema de jogos
// Uma desenvolvedora precisa representar diferentes tipos de jogos.
// Crie uma classe abstrata Jogo , contendo:
// Propriedade Nome .
// Campo protegido Plataforma .
// Método para apresentar as informações do jogo.
// Crie duas classes derivadas:
// JogoDigital : deve apresentar informações sobre o formato digital.
// JogoFisico : deve apresentar informações sobre o formato físico.
// Utilize construtores para inicializar os dados e permita que as classes
// derivadas acessem o campo Plataforma .
namespace AtividadeHeranca
{
    public abstract class Jogos
    {
        public string? Nome { get; set; }

        protected string? Plataforma { get; set; }

        public abstract void ApresentarJogos();
      
        
        
    }
}