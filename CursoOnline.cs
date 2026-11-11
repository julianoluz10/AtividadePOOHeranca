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
    public class CursoOnline : ProdutoDigital
    {

        public decimal CargaHoraria { get; set; }

        public CursoOnline()
        {
            
        }

        public CursoOnline(string nome, decimal preco, decimal cargahoraria) : base( nome, preco)
        {

            CargaHoraria = cargahoraria;
            
        }

        
    }
}