using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace Core3.Models.Repository
{
    public class CityRepository : RepositoryBase<Cities>, ICityRepository
    {
        public CityRepository(ClinicContext repositoryContext)
            : base(repositoryContext)
        {
        }


        public async Task<IEnumerable<Cities>> GetAllCities()
        {
            return await GetAll();
        }


        public void CreateCity(Cities Cities)
        {
            Create(Cities);
        }

        public void UpdateCity(Cities Cities)
        {
            Update(Cities);
        }

        public void DeleteCity(Cities Cities)
        {
            Delete(Cities);
        }
    }
}
