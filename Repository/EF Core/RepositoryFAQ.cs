using Entities.Models;
using Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.EF_Core
{
    public class RepositoryFAQ : RepositoryBase<FAQ>, IRepositoryFAQ
    {
        public RepositoryFAQ(RepositoryContext context) : base(context)
        {

        }

        public IQueryable<FAQ> GetFAQ(int id, bool trackchanges) => GenericReadExpression(x => x.FAQId == id, trackchanges);

    }
}
