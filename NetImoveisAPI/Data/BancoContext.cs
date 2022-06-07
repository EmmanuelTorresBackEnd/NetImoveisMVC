using Microsoft.EntityFrameworkCore;
using NetImoveisAPI.Models;

namespace NetImoveisAPI.Data
{
	public class BancoContext : DbContext
	{
		public BancoContext(DbContextOptions<BancoContext> options) : base(options)
		{
		}
		public DbSet<ImovelModel> Imovel { get; set; }
	}
}
