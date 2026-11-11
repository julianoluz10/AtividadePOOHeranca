// 6. Sistema de documentos
// Desenvolva um pequeno sistema de gerenciamento de documentos utilizando
// interfaces em C#.
// 1. Crie uma interface IImprimivel com o método Imprimir() .
// 2. Crie uma interface IExportavel com o método Exportar() .
// 3. Crie uma classe Relatorio que implemente as duas interfaces.
// 4. Crie uma classe Contrato que implemente apenas a interface IImprimivel .
// 5. Implemente os métodos de acordo com o comportamento de cada classe,
// exibindo mensagens no console.
// 6. No programa principal, instancie os objetos e execute os métodos
// disponíveis.
namespace AtividadeHeranca
{
    public interface IExploravel
    {
        public void Exportar();
        
    }
}