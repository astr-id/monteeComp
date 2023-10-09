using Microsoft.EntityFrameworkCore;
using monteeCompBack.Contexts;
using monteeCompBack.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Server.HttpSys;

namespace monteeCompBack.Repository
{
    public class VoitureRepository : IVoitureRepository
    {
        private readonly VoitureContext _context;
        public VoitureRepository(VoitureContext context)
        {
            _context = context;
        }
        
        // recupere une voiture avec son id
        public Voiture GetVoiture(int _id)
        {
            var voiture = _context.Voiture.Find(_id);
            if(voiture == null) {
                throw new Exception("Cette voiture n'existe pas");
                
            }
            return voiture;
        }

        // recupere la liste des voitures
        public List<Voiture> GetVoitures() {
            return _context.Voiture.ToList();

        }

        // créer une voiture
        public Voiture CreateVoiture(Voiture _voiture)
        {
            
            _context.Voiture.Add(_voiture);
            _context.SaveChanges();
            return _voiture;

        }

        //modifier une voiture
        public Voiture UpdateVoiture(Voiture _voiture, int _id)
        {
            //vérifie si l'ID de la voiture à update correspond à l'ID de la voiture recherchée et si une voiture avec cette ID existe dans la base de donnée
            if (_voiture.Id == _id && _context.Voiture.Any(voiture => voiture.Id == _id)) {
               
                    _context.Entry(_voiture).State = EntityState.Modified;
                    _context.SaveChanges();
                      return _voiture;
            }

             throw new Exception("Cette voiture n'existe pas");
        }


        // suppr une voiture
        public bool DeleteVoiture(int _id)
        {
            var voiture = _context.Voiture.Find(_id);
            if (voiture == null)
            {
                return false;
            }
            _context.Voiture.Remove(voiture);
            _context.SaveChanges();
            return true;
        }

    }
    }
