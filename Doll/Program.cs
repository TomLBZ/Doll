var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
app.UseHttpsRedirection();
var doll = new API.Doll();
// when the api endpoints receives a string, it will pass it to doll.Main() and return the result
app.MapPut("/main", (string input) => doll.Main(input));
app.MapGet("/main", () => doll.MainDescription);
app.Run();