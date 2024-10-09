using CloudSQLAuthProxy.Lab.Repository.DBContexts;
using CloudSQLAuthProxy.Lab.Repository.Repositories.Abstracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudSQLAuthProxy.Lab.Repository.Repositories.Carousel
{
    public class UserRepository : GenericRepository<Models.User>, IUserRepository
    {
        private CloudSqlAuthProxyLabContext _context;

        public UserRepository(CloudSqlAuthProxyLabContext context) : base(context)
        {
            _context = context;
        }
    }
}
