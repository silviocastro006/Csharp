using Microsoft.AspNetCore.Mvc;
using ScreenSound.API.Requests;
using ScreenSound.API.Response;
using ScreenSound.Banco;
using ScreenSound.Shared.Modelos.Modelos;

namespace ScreenSound.API.Endpoints
{
    public static class GenerosExtensions
    {
         public static void addEndPointsGeneros(this WebApplication app)
        {
                app.MapGet("/Generos",([FromServices] DAL<Genero> dal) => 
                {
                    return Results.Ok(dal.Listar());
                });

                app.MapGet("/Generos/{nome}",([FromServices] DAL<Genero> dal,string nome) => 
                {
                    var Genero = dal.RecuperarPor(a => a.Nome.ToUpper() == nome.ToUpper());
                    if(Genero is null)
                    {
                        return Results.NotFound();
                    }
                    return Results.Ok(Genero);
                });

                app.MapPost("/Generos",([FromServices] DAL<Genero> dal,[FromBody]GeneroRequest GeneroRequest) =>{
                    
                    var Genero = new Genero(GeneroRequest.Nome, GeneroRequest.Descricao);
                    dal.Adicionar(Genero);
                    return Results.Ok();

                });

                app.MapDelete("/Generos/{id}",([FromServices] DAL<Genero> dal, int id) => {
                    
                    var Genero = dal.RecuperarPor(a => a.Id == id);
                    if (Genero is null){
                        return Results.NotFound();
                    }
                    dal.Deletar(Genero);
                    return Results.NoContent();
                });

                app.MapPut("/Generos", ([FromServices] DAL<Genero> dal, [FromBody] GeneroRequestEdit GeneroRequestEdit) => {
                var GeneroAAtualizar = dal.RecuperarPor(a => a.Id == GeneroRequestEdit.Id);
                if (GeneroAAtualizar is null)
                {
                    return Results.NotFound();
                }
                GeneroAAtualizar.Nome = GeneroRequestEdit.Nome;
                GeneroAAtualizar.Descricao = GeneroRequestEdit.Descricao;        
                dal.Atualizar(GeneroAAtualizar);
                return Results.Ok();
            });

        }
    
    }
}