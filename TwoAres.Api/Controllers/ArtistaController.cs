using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TwoAres.Core.Entities;
using TwoAres.Services;

namespace TwoAres.Api.Controllers
{
    [Microsoft.AspNetCore.Mvc.Route("api/[controller]")]
    [ApiController]
    public class ArtistaController : ControllerBase
    {
        private readonly IArtistaService _artistaService;

        public ArtistaController(IArtistaService artistaService)
        {
            this._artistaService = artistaService;
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Artista>> GetArtistaById(int id)
        {
            var artista = await this._artistaService.GetArtistaByID(id);
            return Ok(artista);
        }

        //[HttpGet("{IdArtista}")]
        //public async Task<ActionResult<IEnumerable<Cancion>>> GetAllCancionByIdArtista(int IdArtista)
        //{
        //    var canciones = await this._cancionService.GetCancionesByIdArtista(IdArtista);
        //    return Ok(canciones);
        //}
        [HttpGet()]
        public async Task<ActionResult<Artista>> GetAllArtistas()
        {
            var artistas = await this._artistaService.GetAllArtistas();
            return Ok(artistas);
        }
        [HttpPost]
        public async Task<ActionResult<Artista>> CreateArtista([FromBody] Artista artista)
        {
            var artistaNew = await this._artistaService.CreateArtista(artista);
            return Ok(artistaNew);
        }
        [HttpDelete("{idArtista}")]
        public async Task<ActionResult<Artista>> DeleteArtista(int idArtista)
        {
            var artista = await this._artistaService.GetArtistaByID(idArtista);
            await this._artistaService.DeleteArtista(artista);
            return Ok(artista);
        }
    }
}
