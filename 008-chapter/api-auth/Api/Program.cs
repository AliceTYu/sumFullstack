var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();
// тут фиксируются storages
builder.Services.AddSingleton<ContactStorage>();

builder.Services.AddCors(opt =>
opt.AddPolicy("CorsPolicy", policy =>
{
    policy.AllowAnyMethod().AllowAnyHeader().WithOrigins(args[0]);
}));

var app = builder.Build();
app.UseSwagger();
app.UseSwaggerUI();

app.MapControllers();
app.UseCors("CorsPolicy");
app.Run();
