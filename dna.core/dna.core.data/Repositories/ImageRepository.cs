using dna.core.data.Entities;
using dna.core.data.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dna.core.data.Repositories
{
    public class ImageRepository : EntityReadWriteBaseRepository<Image>, IImageRepository
    {
        public IDnaCoreContext DnaCoreContext
        {
            get { return _context as IDnaCoreContext; }
        }
        public ImageRepository(IDnaCoreContext context) : base(context)
        {
           
        }
    }
    public interface IImageRepository : IWriteBaseRepository<Image>, IReadBaseRepository<Image>
    {

    }
}
