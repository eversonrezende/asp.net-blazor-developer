var builder = WebApplication.CreateBuilder(args);
// Informar ao projeto que vamos trabalhar com RazorPages
builder.Services.AddRazorPages();

var app = builder.Build();

// Configura��o para trabalhar com browser

// Trabalhar com HTTPS
app.UseHttpsRedirection();
// Trabalhar com arquivos est�ticos
app.UseStaticFiles();

// Auxiliar no mapeamento das p�ginas
app.UseRouting();
app.MapRazorPages();


app.Run();
