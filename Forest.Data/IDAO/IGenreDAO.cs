using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Forest.Data.IDAO;
using Forest.Data.Models.Domain;
using Forest.Data.Models.Repository;
namespace Forest.Data.DAO
{
    public class GenreDAO : IGenreDAO
    {
        private ForestContext context;

        public GenreDAO()
        {
            context = new ForestContext();
        }

        public IList<Genre> GetGenres()
        {
            return context.Genres.ToList(); 
        }
    }
}
