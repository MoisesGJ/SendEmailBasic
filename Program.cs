using Microsoft.Extensions.Options;
using Resend;

class Program
{
    static async Task Main(string[] args)
    {
        var apiToken = "YOUR TOKEN SECRET FROM RESEND.COM"!;
        
        var options = Options.Create(new ResendClientOptions
        {
            ApiToken = apiToken
        });

        var httpClient = new HttpClient();

        var resendClient = new ResendClient(options, httpClient);

        var message = new EmailMessage
        {
            From = "YOUR EMAIL WITH DOMAIN PERSONALIZED IN RESEND",
            To = { "EMAIL TO SEND" },
            Subject = "Prueba desde Resend",
            HtmlBody = "<h1>¡Hola!</h1><p>Este es un correo de prueba.</p>"
        };

        try
        {
            var response = await resendClient.EmailSendAsync(message);
            Console.WriteLine($"Correo enviado exitosamente. {response}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error al enviar el correo: {ex.Message}");
        }
    }
}
