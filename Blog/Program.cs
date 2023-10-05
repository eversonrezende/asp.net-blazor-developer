using Blog.Data;
using Blog.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services
       .AddControllers()
       .ConfigureApiBehaviorOptions(opt =>
       {
           opt.SuppressModelStateInvalidFilter = true;
       });

builder.Services.AddDbContext<BlogDataContext>();
builder.Services.AddTransient<TokenService>(); // Sempre cria um novo

var app = builder.Build();

app.MapControllers();

app.Run();
