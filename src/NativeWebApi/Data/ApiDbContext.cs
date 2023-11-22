using Microsoft.EntityFrameworkCore;

namespace NativeWebApi.Data
{
    public class ApiDbContext(DbContextOptions<ApiDbContext> options) : DbContext(options)
    {

    }
}
