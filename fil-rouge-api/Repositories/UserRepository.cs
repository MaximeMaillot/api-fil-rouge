using fil_rouge_api.Data;
using EFHelper.Repositories;
using fil_rouge_api.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.Linq.Expressions;

namespace fil_rouge_api.Repositories
{
    public class UserRepository : GenericRepository<User>
    {
        public UserRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
