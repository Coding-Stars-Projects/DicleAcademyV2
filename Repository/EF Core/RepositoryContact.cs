using Entities.Models;
using Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.EF_Core
{
    public class RepositoryContact : RepositoryBase<Contact>, IRepositoryContact
    {
        public RepositoryContact(RepositoryContext context) : base(context)
        {

        }

        public IQueryable<Contact> GetContact(int id, bool trackchanges) => GenericReadExpression(x => x.ContactId == id, trackchanges);

    }
}
