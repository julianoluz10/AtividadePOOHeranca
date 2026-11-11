// 4. Sistema de notificações
// Uma aplicação precisa enviar notificações por diferentes canais.
// Crie uma classe base Notificacao com um método virtual Enviar() que
// apresente uma mensagem genérica.
// Crie três classes derivadas:
// NotificacaoEmail .
// NotificacaoSMS .
// NotificacaoPush .
// Cada classe deverá sobrescrever o método Enviar() , apresentando uma
// mensagem específica de acordo com o canal utilizado.

namespace AtividadeHeranca
{
    public class NotificacaoSms : Notificacao
    {
        public override void Enviar( )
        {
            System.Console.WriteLine("Mensagem Enviada com sucesso via SMS");
        }
    }
}