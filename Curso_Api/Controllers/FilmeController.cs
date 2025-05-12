
using Curso_Api.infra;
using Curso_Api.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;


namespace Curso_Api.Controllers;

[ApiController]
[Route("[controller]")]

public class FilmeController : ControllerBase
{

    [HttpPost]
    public IActionResult AdicionaFilme([FromBody]Filme filme)
    {

        using var sessao = HibernateUtil.GetSession(); 
        using var transacao = sessao.BeginTransaction();
        
        sessao.Save(filme);
        transacao.Commit();

        return CreatedAtAction( nameof(RecuperaFilmeporID), new { id = filme.Id}, filme);
    }

    [HttpGet]
    public IEnumerable<Filme> RecuperaFilme([FromQuery] int skip = 0, [FromQuery] int take = 50)
    {
        using var sessao = HibernateUtil.GetSession(); 
        var filmes = sessao.Query<Filme>().ToList();
        
        return filmes.Skip(skip).Take(take);
    }

    [HttpGet("{id}")]
    public IActionResult RecuperaFilmeporID(int id)
    {
        using var sessao = HibernateUtil.GetSession();
        var filme = sessao.Get<Filme>(id);

        if (filme == null) return NotFound("Filme não localizado");

        return Ok(filme);
    }

}