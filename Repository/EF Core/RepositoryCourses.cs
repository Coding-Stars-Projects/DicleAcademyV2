using Entities.Models;
using Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.EF_Core
{
    public class RepositoryCourses: RepositoryBase<Courses>, IRepositoryCourses
    {
        public RepositoryCourses(RepositoryContext context) : base(context)
        {

        }
        public IQueryable<Courses> GetCoursest(int id, bool trackchanges) => GenericReadExpression(x => x.CourseId == id, trackchanges);
        
    }
}
