using Entities.Models;
using Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.EF_Core
{
    internal class RepositorySlills: RepositoryBase<Skills>, IRepositorySkills
    {
        public RepositorySlills(RepositoryContext context) : base(context)
        {
            
        }

        public IQueryable<Skills> GetSkills(int id, bool trackchanges) => GenericReadExpression(x => x.SkillId == id, trackchanges);

    }
}
