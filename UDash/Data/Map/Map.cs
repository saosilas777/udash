using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UDash.Models;
using UDash.Models.ViewModels;

namespace SistemaContatos.Data.Map
{
	public class ContatoMap : IEntityTypeConfiguration<LoginModel>
	{
		public void Configure(EntityTypeBuilder<LoginModel> builder)
		{
			builder.HasKey(x => x.Id);
			builder.HasOne(x => x.User);
		}
	}
}