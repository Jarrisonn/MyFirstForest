using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Forest.Data.Models.Domain;
namespace Forest.Data.IDAO
{
    public interface IGenreDAO
    {
        IList<Genre> GetGenres();
    }
}
