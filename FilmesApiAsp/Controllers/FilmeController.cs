using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using FilmesApiAsp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace FilmesApiAsp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FilmeController : ControllerBase
    {
        // private readonly ILogger<FilmeController> _logger;

        // public FilmeController(ILogger<FilmeController> logger)
        // {
        //     _logger = logger;
        // }

        // public IActionResult Index()
        // {
        //     return View();
        // }

        // [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        // public IActionResult Error()
        // {
        //     return View("Error!");
        // }
        private static int id = 0;
        private static List<Filme> Filmes = new List<Filme>();

        [HttpPost]
        public void adicionarFilme([FromBody] Filme filme){
            filme.id=id++;
            Filmes.Add(filme);
        }

        [HttpGet]
        public IEnumerable<Filme> buscarTodosFilmes(){
            return Filmes;
        }

        [HttpGet("{id}")]
        public Filme? buscarFilmePorId(int id){
            return Filmes.FirstOrDefault(filme => filme.id == id);
        }
    }
}