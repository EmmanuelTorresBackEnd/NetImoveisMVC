using System.ComponentModel.DataAnnotations;

namespace NetImoveisAPI.Models
{
	public class ImovelModel
	{
		public int Id { get; set; }
		[Required(ErrorMessage = "O Campo não pode ficar em branco")]
		public string TipoImovel { get; set; }
		[Required(ErrorMessage = "O Campo não pode ficar em branco")]
		public string ValorVendaImovel { get; set; }
		[Required(ErrorMessage = "O Campo não pode ficar em branco")]
		public string ValorLocacaoImovel { get; set; }
		[Required(ErrorMessage = "O Campo não pode ficar em branco")]
		public string Endereco { get; set; }
		[Required(ErrorMessage = "O Campo não pode ficar em branco")]
		public int Numero { get; set; }
		public string Complemento { get; set; }
		[Required(ErrorMessage = "O Campo não pode ficar em branco")]
		public string Bairro { get; set; }
		[Required(ErrorMessage = "O Campo não pode ficar em branco")]
		public string Cidade { get; set; }
		[Required(ErrorMessage = "O Campo não pode ficar em branco")]
		public string Estado { get; set; }
		[Required(ErrorMessage = "O Campo não pode ficar em branco")]
		public int CEP { get; set; }

	}
}
