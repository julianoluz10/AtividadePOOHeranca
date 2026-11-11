// 2. Sistema de produtos digitais
// Uma plataforma comercializa diferentes tipos de produtos digitais.
// Crie uma classe abstrata ProdutoDigital , contendo as propriedades Nome e
// Preco .
// Implemente um construtor para inicializar essas propriedades.
// Em seguida, crie duas classes derivadas:
// Ebook : deve possuir a propriedade QuantidadePaginas .

// Lista de Exercícios — Herança em C# 1

// CursoOnline : deve possuir a propriedade CargaHoraria .
// Utilize base para chamar o construtor da classe base.

namespace AtividadeHeranca
{
    public abstract class ProdutoDigital
    {
        public string? Nome { get; set; }

        public decimal Preco { get; set; }

        public ProdutoDigital()
        {
            
        }

        public ProdutoDigital(string nome, decimal preco)
        {
            Nome = nome;
            Preco = preco;
        }

        
    }
}