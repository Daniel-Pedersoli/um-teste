using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using MinhaPrimeiraApiPosQuad.Infra;
using MinhaPrimeiraApiPosQuad.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RouteAttribute = Microsoft.AspNetCore.Components.RouteAttribute;

namespace MinhaPrimeiraApiPosQuad.Controllers
{
    //'[ApiController]'  desnecessário 
    [Route("api/aluno")] ////////////////
    public class AnimalController : MainController
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public AnimalController(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> ObterTodos(Guid id)
        {
            var animal = await _applicationDbContext.Animal.FindAsync(id);

            if (animal == null) 
            {
                return NotFound();
            }

            return Ok(animal);
        }

        [HttpPost("adicionar")]
        public ActionResult AdiconarAnimal(string nome, string especie, string raca, int idade)
        {
            var animal = new AnimalModels(nome, especie, raca, idade);

            _applicationDbContext.Animal.Add(animal);

            _applicationDbContext.SaveChanges();

            return Ok();

        }

        [HttpPut("editar")]
        public async Task<ActionResult> EditarAnimal(Guid id, string nome, string especie, string raca, int idade)
        {
            var animal = await _applicationDbContext.Animal.FindAsync(id);

            if (animal == null)
            {
                return NotFound();
            }

            animal.Nome = nome;
            animal.Especie = especie;
            animal.Raca = raca;
            animal.Idade = idade;

            _applicationDbContext.Update(animal);
            await _applicationDbContext.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("deletar")]
        public async Task<ActionResult> DeletarAnimal(Guid id)
        {
            var animal = await _applicationDbContext.Animal.FindAsync(id);

            if (animal == null)
            {
                return NotFound();
            }

            _applicationDbContext.Animal.Remove(animal);
            await _applicationDbContext.SaveChangesAsync();

            return Ok();

        }

    }
}
