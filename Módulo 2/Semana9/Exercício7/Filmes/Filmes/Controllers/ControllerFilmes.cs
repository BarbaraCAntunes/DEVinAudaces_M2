﻿using Microsoft.AspNetCore.Mvc;
using Filmes.Models;
using Filmes.Mocks;


namespace Filmes.Controllers
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class FilmesController : ControllerBase
    {
        /// <summary>
        /// Recupera todos os filmes.
        /// </summary>
        [HttpGet]
        [MapToApiVersion("1.0")]
        public ActionResult<IEnumerable<Filme>> GetFilmes()
        {
            return MockData.Filmes;
        }

        /// <summary>
        /// Recupera um filme específico pelo id.
        /// </summary>
        [HttpGet("{id}")]
        [MapToApiVersion("1.0")]
        public ActionResult<Filme> GetFilme(int id)
        {
            var filme = MockData.Filmes.FirstOrDefault(f => f.Id == id);

            if (filme == null)
            {
                return NotFound();
            }

            return filme;
        }

        /// <summary>
        /// Atualiza um filme específico.
        /// </summary>
        [HttpPut("{id}")]
        [MapToApiVersion("1.0")]
        public IActionResult PutFilme(int id, Filme filme)
        {
            if (id != filme.Id)
            {
                return BadRequest();
            }

            var filmeExistente = MockData.Filmes.FirstOrDefault(f => f.Id == id);

            if (filmeExistente == null)
            {
                return NotFound();
            }

            var index = MockData.Filmes.IndexOf(filmeExistente);
            MockData.Filmes[index] = filme;

            return NoContent();
        }

        /// <summary>
        /// Cria um novo filme.
        /// </summary>
        [HttpPost]
        [MapToApiVersion("1.0")]
        public ActionResult<Filme> PostFilme(Filme filme)
        {
            filme.Id = MockData.Filmes.Max(f => f.Id) + 1;
            MockData.Filmes.Add(filme);

            return CreatedAtAction("GetFilme", new { id = filme.Id }, filme);
        }

        /// <summary>
        /// Deleta um filme específico pelo id.
        /// </summary>
        [HttpDelete("{id}")]
        [MapToApiVersion("1.0")]
        public IActionResult DeleteFilme(int id)
        {
            var filme = MockData.Filmes.FirstOrDefault(f => f.Id == id);

            if (filme == null)
            {
                return NotFound();
            }

            MockData.Filmes.Remove(filme);

            return NoContent();
        }
    }
}
