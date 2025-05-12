
using AutoMapper;
using Curso_Api.Data.Dtos;
using Curso_Api.infra;
using Curso_Api.Models;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;


namespace Curso_Api.Controllers;

[ApiController]
[Route("[controller]")]

public class FilmeController : ControllerBase
{

    private IMapper _mapper;

    public FilmeController(IMapper mapper)
    {
        _mapper = mapper;
    }

    [HttpPost]
    public IActionResult AdicionaFilme([FromBody]CreateFilmeDto filmeDto)
    {
        Filme filme = _mapper.Map<Filme>(filmeDto);
        using var sessao = HibernateUtil.GetSession(); 
        using var transacao = sessao.BeginTransaction();
        
        sessao.Save(filme);
        transacao.Commit();

        return CreatedAtAction( nameof(RecuperaFilmeporID), new { id = filme.Id}, filme);
    }

    [HttpGet]
    public IEnumerable<ReadFilmeDto> RecuperaFilme([FromQuery] int skip = 0, [FromQuery] int take = 50)
    {
        using var sessao = HibernateUtil.GetSession(); 
        var filmes = sessao.Query<Filme>().ToList();


        
        return _mapper.Map<List<ReadFilmeDto>>(filmes.Skip(skip).Take(take));
    }

    [HttpGet("{id}")]
    public IActionResult RecuperaFilmeporID(int id)
    {
        using var sessao = HibernateUtil.GetSession();
        var filme = sessao.Get<Filme>(id);

        if (filme == null) return NotFound("Filme não localizado");
        
        var filmeDto = _mapper.Map<ReadFilmeDto>(filme);

        return Ok(filmeDto);
    }

    [HttpPut("{id}")]
    public IActionResult AtualizaFilme(int id, [FromBody]UpdateFilmeDto filmeDto)
    {
        using var sessao = HibernateUtil.GetSession();
        using var transacao = sessao.BeginTransaction();
        var filme = sessao.Query<Filme>().FirstOrDefault(x => x.Id == id);

        if (filme == null) return NotFound();

        _mapper.Map(filmeDto, filme);
        sessao.Update(filme);
        transacao.Commit();

        return NoContent();
    }

    [HttpPatch("{id}")]
    public IActionResult AtualizaFilmeParcial(int id, JsonPatchDocument<UpdateFilmeDto> patch)
    {
        using var sessao = HibernateUtil.GetSession();
        using var transacao = sessao.BeginTransaction();
        var filme = sessao.Query<Filme>().FirstOrDefault(x => x.Id == id);

        if (filme == null) return NotFound();

        var filmeParaAtualizar = _mapper.Map<UpdateFilmeDto>(filme);
        patch.ApplyTo(filmeParaAtualizar, ModelState);
        if(!TryValidateModel(filmeParaAtualizar))
        {
            return ValidationProblem(ModelState);
        }

        _mapper.Map(filmeParaAtualizar, filme);
        sessao.Update(filme);
        transacao.Commit();

        return NoContent(); 
    } 

    [HttpDelete("{id}")]
    public IActionResult DeletaFilme(int id)
    {
        using var sessao = HibernateUtil.GetSession();
        using var transacao = sessao.BeginTransaction();
        var filme = sessao.Query<Filme>().FirstOrDefault(x => x.Id == id);

        if (filme == null) return NotFound();

        sessao.Delete(filme);
        transacao.Commit();
        return NoContent();
    } 
}