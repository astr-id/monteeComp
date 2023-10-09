using monteeCompBack.Models;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace monteeCompBack.Repository
{
    public interface IVoitureRepository
    {
        public List<Voiture> GetVoitures();
        public Voiture GetVoiture(int _id);
        public Voiture CreateVoiture(Voiture _voiture);
        public Voiture UpdateVoiture(Voiture _voiture, int _id);
        public bool DeleteVoiture(int _id);
    }
}
