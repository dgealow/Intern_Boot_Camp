using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Intern.Models;

namespace Intern.Domains
{
    public interface IDatabaseService
    {
        Task<IEnumerable<Image>> GetAllImages();
    }
}
