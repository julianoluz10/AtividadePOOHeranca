
using AtividadeHeranca;

Carro Honda = new Carro();
Honda.Modelo = "Civic";
Honda.QuantidadePortas = 4;
Honda.Marca = "Honda";

Honda.ExibirInformacoes();
System.Console.WriteLine($"Quantidades de Portas: {Honda.QuantidadePortas}");


Motocicleta Harley = new Motocicleta();
Harley.Modelo = "StreetBoy";
Harley.Marca = "Harley";
Harley.Cilindradas = 1923;

Harley.ExibirInformacoes();
System.Console.WriteLine($"Quantidades de Cilindradas: {Harley.Cilindradas} ");


Ebook l1 = new Ebook();
Ebook l2 = new Ebook(" C++",30, 350);
Console.WriteLine($"Titulo {l2.Nome} - Preco {l2.Preco:C} - Quantidade de Paginas {l2.QuantidadePaginas} " );



CursoOnline C1 = new CursoOnline("Javascript", 450, 80);
System.Console.WriteLine($"Curso: {C1.Nome} - Preco {C1.Preco:C} - Quantidade de horas {C1.CargaHoraria}");

JogoFisico ps1 = new JogoFisico("Resident Evil", "Console");
ps1.ApresentarJogos();

JogoDigital Pc1 = new JogoDigital("Gta6" , "Online");
Pc1.ApresentarJogos();


Notificacao N1 = new Notificacao();
NotificacaoEmail N2 = new NotificacaoEmail();
NotificacaoSms N3 = new NotificacaoSms();
NotificacaoPush N4 = new NotificacaoPush();
N1.Enviar();
N2.Enviar();
N3.Enviar();
N4.Enviar();


EntregaExpress e1 = new EntregaExpress();
e1.CalcularFrete(10);

EntregaEconomica e2 = new EntregaEconomica();
e2.CalcularFrete(10);

RetiradaLocal e3 = new RetiradaLocal();
e3.CalcularFrete(10);


List<double> Entrega = new List<double>();


System.Console.WriteLine();

Contrato ctr1 = new Contrato();
ctr1.imprimir();

Relatorio rtr1 = new Relatorio();
rtr1.Exportar();
rtr1.imprimir();

