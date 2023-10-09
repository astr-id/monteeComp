using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using monteeCompBack.Models;
using monteeCompBack.Repository;
using System;
using System.Collections.Concurrent;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class VoitureController : ControllerBase
    {
        private readonly IVoitureRepository voitureRepository;
        public VoitureController(IVoitureRepository voitureRepository)
        {
            this.voitureRepository = voitureRepository;
        }

        //GET :  recupere voiture avec id
        [HttpGet("voitures/{id}")]
        public async Task<ActionResult<Voiture>> GetVoiture(int id)
    
        {
            return voitureRepository.GetVoiture(id);
        }

        //GET :  recupere liste voitures
        [HttpGet("voitures")]
        public List<Voiture> GetVoitures()
        {
            return voitureRepository.GetVoitures();
        }

        //PUT : modifie une voiture
        [HttpPut("voiture/{id}")]
        public async Task<ActionResult<Voiture>> UpdateVoiture(int id, Voiture voiture)
        {
            try
            {
                return voitureRepository.UpdateVoiture(voiture, id);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }



        //POST : creer voiture
        [HttpPost("voitures")]
        public async Task<ActionResult<Voiture>> CreateVoiture(Voiture voiture)
        {
  
            try 
            {
                return voitureRepository.CreateVoiture(voiture);
            }
            catch(Exception e) { 
                return BadRequest(e.Message);
            }
        }
        [HttpDelete("voitures/{id}")]
        public async Task<ActionResult<bool>> DeleteVoiture(int id)
        {
            try
            {
                return voitureRepository.DeleteVoiture(id);
            }
            catch(Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
