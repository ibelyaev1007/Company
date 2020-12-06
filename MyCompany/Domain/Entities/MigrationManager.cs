using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MyCompany.Domain.Entities
{
    public static class MigrationManager
    {
		private static int _numberOfRetries;

		public static IHost MigrateDatabase(this IHost host)
		{
			using (var scope = host.Services.CreateScope())
			{
				using (var appContext = scope.ServiceProvider.GetRequiredService<AppDbContext>())
				{
					try
					{
						appContext.Database.Migrate();
					}
					catch (SqlException)
					{
						if (_numberOfRetries < 6)
						{
							Thread.Sleep(10000);

							_numberOfRetries++;
							Console.WriteLine($"The server was not found or was not accessible. Retrying... #{_numberOfRetries}");

							MigrateDatabase(host);
						}

						throw;
					}
				}
			}

			return host;
		}
	}
}
