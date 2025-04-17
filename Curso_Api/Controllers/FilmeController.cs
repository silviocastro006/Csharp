using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Curso_Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace Curso_Api.Controllers;

[ApiController]
[Route("[controller]")]

public class FilmeController
{

    private static List<Filme> filmes = new List<Filme>();

    [HttpPost]
    public void AdicionaFilme([FromBody]Filme filme)
    {
        
        filmes.Add(filme);
        Console.WriteLine(filme.Titulo);
        Console.WriteLine(filme.Duracao);
    }

}