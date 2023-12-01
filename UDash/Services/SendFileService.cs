using OfficeOpenXml;
using System.ComponentModel;
using UDash.Interfaces;
using UDash.Models;
using LicenseContext = System.ComponentModel.LicenseContext;

namespace UDash.Services
{
	public class SendFileService
	{
		private readonly ISection _section;

		public SendFileService(ISection section)
		{
			_section = section;
		}

		public List<CustomerModel> ReadXls(IFormFile uploadFile)
		{
			var streamFile = ReadStrem(uploadFile);

			string token = _section.GetUserSection();
			UserModel user = TokenService.GetDataInToken(token);
			List<CustomerModel> response = new();
			ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;


			using (ExcelPackage package = new((Stream)streamFile))
			{
				
				ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
				int colCount = worksheet.Dimension.End.Column;
				int rowCount = worksheet.Dimension.End.Row;




				for (int row = 2; row <= rowCount; row++)
				{
					

					CustomerModel customer = new()
					{
						Id = Guid.NewGuid(),

						IdSense = worksheet.Cells[row, 1].Value.ToString(),
						IdStarford = worksheet.Cells[row, 2].Value.ToString(),
						Cnpj = worksheet.Cells[row, 3].Value.ToString(),
						RazaoSocial = worksheet.Cells[row, 4].Value.ToString(),
						Status = true,
						Loja = worksheet.Cells[row, 6].Value.ToString(),
						Cliente = worksheet.Cells[row, 7].Value.ToString(),
						ProdutoFiscal = worksheet.Cells[row, 8].Value.ToString(),
						Fr = worksheet.Cells[row, 9].Value.ToString(),
						ValorMensal = double.Parse(worksheet.Cells[row, 10].Value.ToString()),
						UserId = user.Id


					};

					response.Add(customer);
				}
			}
			return response;

		}

		public MemoryStream ReadStrem(IFormFile file)
		{
			using var stream = new MemoryStream();

			file?.CopyTo(stream);
			var byteArray = stream.ToArray();
			return new MemoryStream(byteArray);
		}
	}
}
