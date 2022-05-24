using Microsoft.AspNetCore.Hosting;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTravelersDatabase.Data
{
	public class TTDbSeeder
	{
		private readonly IWebHostEnvironment _hosting;

		public TTDbSeeder(IWebHostEnvironment hosting)
		{
			_hosting = hosting;
			///	TODO
			///	add db context
			///	add userManager
		}

		/// <summary>
		/// Generate seed
		/// </summary>
		/// <returns></returns>
		public async Task SeedAsync()
		{
			///	TODO
			await Task.FromResult(0);
		}
	}
}
