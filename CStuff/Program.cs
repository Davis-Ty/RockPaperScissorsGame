// Program.cs
using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Game;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
else
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.MapRazorPages();

app.MapGet("/", async context =>
{
    await context.Response.WriteAsync(@"
        <html>
        <head><title>Rock, Paper, Scissors Game</title></head>
        <body>
            <h1>Rock, Paper, Scissors Game</h1>
            <form method='post' action='/play'>
                <label for='move'>Choose your move:</label>
                <select id='move' name='move'>
                    <option value='Rock'>Rock</option>
                    <option value='Paper'>Paper</option>
                    <option value='Scissors'>Scissors</option>
                </select>
                <button type='submit'>Play</button>
            </form>
        </body>
        </html>");
});

app.MapPost("/play", async context =>
{
    var form = await context.Request.ReadFormAsync();
    var move = form["move"].ToString();

    GameDo game = new GameDo();
    var result = game.Play(move);

    await context.Response.WriteAsync($@"
        <html>
        <head><title>Rock, Paper, Scissors Game</title></head>
        <body>
            <h1>Rock, Paper, Scissors Game</h1>
            <p>{result}</p>
            <a href='/'>Play Again</a>
        </body>
        </html>");
});

app.Run();



