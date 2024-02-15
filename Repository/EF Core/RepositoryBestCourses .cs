﻿using Entities.Models;
using Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.EF_Core
{
    public class RepositoryBestCourses: RepositoryBase<BestCourses>, IRepositoryBestCourses
    {
        public RepositoryBestCourses(RepositoryContext context) : base(context)
        {

        }

        public IQueryable<BestCourses> GetBestCourses(int id, bool trackchanges) => GenericReadExpression( x => x.BestCourseId == id, trackchanges);


    }
}
