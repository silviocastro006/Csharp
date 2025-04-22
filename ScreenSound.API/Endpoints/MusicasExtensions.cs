using Microsoft.AspNetCore.Mvc;
using ScreenSound.API.Requests;
using ScreenSound.API.Response;
using ScreenSound.Banco;
using ScreenSound.Modelos;
using ScreenSound.Shared.Modelos.Modelos;

namespace ScreenSound.API.Endpoints
{
    public static class MusicasExtensions
    {
        public static void AddEndpointsMusicas(this WebApplication app)
        {
            app.MapGet("/Musicas",([FromServices] DAL<Musica> dal) => 
            {
                return Results.Ok(dal.Listar());
            });


            app.MapGet("/Musicas/{nome}",([FromServices] DAL<Musica> dal,string nome) => 
            {
                var musica = dal.RecuperarPor(a => a.Nome.ToUpper() == nome.ToUpper());
                if(musica is null)
                {
                    return Results.NotFound();
                }               
                return Results.Ok(musica);
            });

            app.MapPost("/Musicas",([FromServices] DAL<Musica> dal,[FromBody]MusicaRequest musicarequest,[FromServices] DAL<Genero> dalGenero) =>{

                var musica = new Musica(musicarequest.nome)
                    {   
                        ArtistaId = musicarequest.ArtistaId,
                        AnoLancamento = musicarequest.anoLancamento,
                        Generos = musicarequest.Generos is not null ? GeneroRequestConverter(musicarequest.Generos,dalGenero) : new List<Genero>()
                    };

                dal.Adicionar(musica);
                return Results.Ok();

            });

            app.MapDelete("/Musicas/{id}",([FromServices] DAL<Musica> dal, int id) => {
                
                var musica = dal.RecuperarPor(a => a.Id == id);
                if (musica is null){
                    return Results.NotFound();
                }
                dal.Deletar(musica);
                return Results.NoContent();
            });

            app.MapPut("/Musicas", ([FromServices] DAL<Musica> dal, [FromBody] MusicaRequestEdit musicaRequestEdit) => {
            var musicaAAtualizar = dal.RecuperarPor(a => a.Id == musicaRequestEdit.Id);
            if (musicaAAtualizar is null)
            {
                return Results.NotFound();
            }
            musicaAAtualizar.Nome = musicaRequestEdit.nome;
            musicaAAtualizar.AnoLancamento = musicaRequestEdit.anoLancamento;

            dal.Atualizar(musicaAAtualizar);
            return Results.Ok();
        });
        }

        private static ICollection<Genero> GeneroRequestConverter(ICollection<GeneroRequest> generos,DAL<Genero> dalGenero)
        {
            var listaDeGeneros = new List<Genero>();

            foreach (var item in generos)
            {
                var entity = RequestToEntity(item);
                var genero = dalGenero.RecuperarPor(g => g.Nome.ToUpper().Equals(item.Nome.ToUpper()));
                if (genero is not null)
                {
                    listaDeGeneros.Add(genero);
                } else {
                    listaDeGeneros.Add(entity);
                }
            }

            return listaDeGeneros;
        }

        private static Genero RequestToEntity(GeneroRequest a)
        {
            return new Genero(a.Nome, a.Descricao);
        }

        private static ICollection<MusicaResponse> EntityListToResponseList(IEnumerable<Musica> musicaList)
        {
            return musicaList.Select(a => EntityToResponse(a)).ToList();
        }

        private static MusicaResponse EntityToResponse(Musica musica)
        {
            return new MusicaResponse(musica.Id, musica.Nome!, musica.Artista!.Id, musica.Artista.Nome);
        }
    }
}