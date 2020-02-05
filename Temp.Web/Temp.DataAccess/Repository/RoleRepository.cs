using Microsoft.EntityFrameworkCore;

namespace Temp.DataAccess.Repository
{
    public class RoleRepository : Repository<Role>, IRoleRepository
    {
        public RoleRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}