using Microsoft.AspNetCore.Mvc;
using ScreenSound.API.Requests;
using ScreenSound.API.Response;
using ScreenSound.Banco;
using ScreenSound.Modelos;

namespace ScreenSound.API.Endpoints
{
    public static class ArtistasExtensions
    {
        public static void AddEndpointsArtistas(this WebApplication app)
        {
                app.MapGet("/Artistas",([FromServices] DAL<Artista> dal) => 
                {
                    return Results.Ok(dal.Listar());
                });

                app.MapGet("/Artistas/{nome}",([FromServices] DAL<Artista> dal,string nome) => 
                {
                    var artista = dal.RecuperarPor(a => a.Nome.ToUpper() == nome.ToUpper());
                    if(artista is null)
                    {
                        return Results.NotFound();
                    }
                    return Results.Ok(artista);
                });

                app.MapPost("/Artistas",([FromServices] DAL<Artista> dal,[FromBody]ArtistaRequest artistarequest) =>{
                    
                    var artista = new Artista(artistarequest.nome, artistarequest.bio);
                    dal.Adicionar(artista);
                    return Results.Ok();

                });

                app.MapDelete("/Artistas/{id}",([FromServices] DAL<Artista> dal, int id) => {
                    
                    var artista = dal.RecuperarPor(a => a.Id == id);
                    if (artista is null){
                        return Results.NotFound();
                    }
                    dal.Deletar(artista);
                    return Results.NoContent();
                });

                app.MapPut("/Artistas", ([FromServices] DAL<Artista> dal, [FromBody] ArtistaRequestEdit artistaRequestEdit) => {
                var artistaAAtualizar = dal.RecuperarPor(a => a.Id == artistaRequestEdit.Id);
                if (artistaAAtualizar is null)
                {
                    return Results.NotFound();
                }
                artistaAAtualizar.Nome = artistaRequestEdit.nome;
                artistaAAtualizar.Bio = artistaRequestEdit.bio;        
                dal.Atualizar(artistaAAtualizar);
                return Results.Ok();
            });

        }

        private static ICollection<ArtistaResponse> EntityListToResponseList(IEnumerable<Artista> listaDeArtistas)
        {
            return listaDeArtistas.Select(a => EntityToResponse(a)).ToList();
        }

        private static ArtistaResponse EntityToResponse(Artista artista)
        {
            return new ArtistaResponse(artista.Id, artista.Nome, artista.Bio, artista.FotoPerfil);
        }
    
    }
}