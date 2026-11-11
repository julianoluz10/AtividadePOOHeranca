// 2. Sistema de produtos digitais
// Uma plataforma comercializa diferentes tipos de produtos digitais.
// Crie uma classe abstrata ProdutoDigital , contendo as propriedades Nome e
// Preco .
// Implemente um construtor para inicializar essas propriedades.
// Em seguida, crie duas classes derivadas:
// Ebook : deve possuir a propriedade QuantidadePaginas .
// CursoOnline : deve possuir a propriedade CargaHoraria .
// Utilize base para chamar o construtor da classe base.

namespace AtividadeHeranca
{
    public class Ebook : ProdutoDigital
    {
        public int QuantidadePaginas { get; set; }

        public Ebook ()
        {
            
        }

        public Ebook(string nome, decimal preco , int quantidadepaginas) : base( nome, preco)
        {
            QuantidadePaginas = quantidadepaginas;
        }

        
    }
}