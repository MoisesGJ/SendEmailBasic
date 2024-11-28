# SendEmailBasic
Este proyecto es una aplicación en .NET para enviar correos electrónicos utilizando la API de [Resend](https://www.nuget.org/packages/Resend#readme-body-tab)  

PASOS PREVIOS:
 * 1. Genera un token en resend.com.
 * 2. Añade un dominio en resend.com.
 * 3. Ajusta los registros DNS TXT y MX según las indicaciones proporcionadas por resend.com.

## Instalación

1. Clona el repositorio:
    ```bash
    git clone https://github.com/MoisesGJ/SendEmailBasic.git
    cd SendEmailBasic
    ```

2. Restaura los paquetes NuGet:
    ```bash
    dotnet restore
    ```

3. Configura las variables necesarias en tu archivo de configuración o directamente en el código:

    ```csharp
    var apiToken = "YOUR TOKEN SECRET FROM RESEND.COM";
    var From = "YOUR EMAIL WITH DOMAIN PERSONALIZED IN RESEND";
    var To = new[] { "EMAIL TO SEND" };
    var Subject = "Prueba desde Resend";
    var HtmlBody = "<h1>¡Hola!</h1><p>Este es un correo de prueba.</p>";
    ```

4. Ejecuta la aplicación:
    ```bash
    dotnet run
    ```

## Uso

Este proyecto envía un correo electrónico de prueba utilizando la API de Resend. Asegúrate de reemplazar las variables `apiToken`, `From`, `To`, `Subject` y `HtmlBody` con tus propios valores antes de ejecutar la aplicación.

## Licencia

Este proyecto está licenciado bajo la Licencia MIT. Consulta el archivo `LICENSE` para más detalles.
