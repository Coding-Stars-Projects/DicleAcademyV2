using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Contracts
{
    public  interface IRepositoryCourseDetails: IRepositoryBase<CourseDetails>
    {
        IQueryable<IRepositoryCourseDetails> GetCourseDetails(int id, bool trackchanges);
        
    }
}
