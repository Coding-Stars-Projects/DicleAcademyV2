using Entities.Models;
using Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.EF_Core
{
    public class RepositoryGetInTouchcs: RepositoryBase<GetInTouch>, IRepositoryGetInTouch

    {
        public RepositoryGetInTouchcs(RepositoryContext context) : base(context)
        {
            
        }
    public IQueryable<GetInTouch> GetGetInTouch(int id, bool trackchanges) => GenericReadExpression(x => x.GetInTouchId == id, trackchanges);

    }
}
