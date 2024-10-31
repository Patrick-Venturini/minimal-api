var builder = WebApplication.CreateBuilder(args); //inicializa a aplicação com as configurações e serviços padrão do .NET, usando os argumentos args da linha de comando.
var app = builder.Build(); //cria e configura a instância app, a aplicação em si. Ele transforma o builder em uma aplicação pronta para rodar.

app.MapGet("/", () => "Hello World!");

app.MapPost("/login", (minimal_api.Dominio.DTOs.LoginDTO loginDTO) => {
    if(loginDTO.Email == "adm@teste.com" && loginDTO.Senha == "1234656")
        return Results.Ok("Login com sucesso!");
    else
        return Results.Unauthorized();
});

app.Run();

