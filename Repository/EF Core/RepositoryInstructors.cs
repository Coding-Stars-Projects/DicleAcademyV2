using Entities.Models;
using Entities.ModelsDto;
using Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.EF_Core
{
    public class RepositoryInstructors : RepositoryBase<Instructors>, IRepositoryInstructors
    {
        public RepositoryInstructors(RepositoryContext context) : base(context)
        {
        }

        public IQueryable<Instructors> GetInstructors(int id, bool trackchanges) => GenericReadExpression(x => x.InstructorId == id, trackchanges);

    }
}

