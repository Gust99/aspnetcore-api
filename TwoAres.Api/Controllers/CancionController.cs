using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TwoAres.Core.Entities;
using TwoAres.Services;

namespace TwoAres.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CancionController : ControllerBase
    {
        private readonly ICancionService _cancionService;

        public CancionController(ICancionService cancionService)
        {
            this._cancionService = cancionService;
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Cancion>> GetCancionById(int id)
        {
            var cancion = await this._cancionService.GetCancionByID(id);
            return Ok(cancion);
        }

        //[HttpGet("{IdArtista}")]
        //public async Task<ActionResult<IEnumerable<Cancion>>> GetAllCancionByIdArtista(int IdArtista)
        //{
        //    var canciones = await this._cancionService.GetCancionesByIdArtista(IdArtista);
        //    return Ok(canciones);
        //}
        [HttpGet()]
        public async Task<ActionResult<Cancion>> GetAllCanciones()
        {
            var canciones = await this._cancionService.GetAllCanciones();
            return Ok(canciones);
        }
        [HttpPost]
        public async Task<ActionResult<Cancion>> CreateCancion([FromBody] Cancion cancion)
        {
            var cancionNew = await this._cancionService.CreateCancion(cancion);
            return Ok(cancionNew);
        }
        [HttpDelete("{idCancion}")]
        public async Task<ActionResult<Cancion>> DeleteCancion(int idCancion)
        {
            var cancion = await this._cancionService.GetCancionByID(idCancion);
            await this._cancionService.DeleteCancion(cancion);
            return Ok(cancion);
        }
    }
}
