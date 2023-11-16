﻿using Microsoft.EntityFrameworkCore;
using UDash.Models;

namespace SistemaContatos.Data
{
	public class Context : DbContext
	{
		public Context(DbContextOptions<Context> options) : base(options)
		{
		}
		public DbSet<UserModel> Users { get; set; }



	}
}