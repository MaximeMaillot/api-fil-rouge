using fil_rouge_api.Data;
using EFHelper.Repositories;
using fil_rouge_api.Models;
using Microsoft.EntityFrameworkCore;

namespace fil_rouge_api.Repositories
{
    public class CommentRepository : GenericRepository<Comment>
    {
        public CommentRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
