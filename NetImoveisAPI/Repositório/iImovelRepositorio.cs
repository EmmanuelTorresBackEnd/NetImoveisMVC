using NetImoveisAPI.Models;
using System.Collections.Generic;

namespace NetImoveisAPI.Repositório
{
	public interface IImovelRepositorio
	{
		ImovelModel ListarPorId(int id);
		List<ImovelModel> BuscarTodos();
		ImovelModel Adicionar(ImovelModel IMovel);
		ImovelModel Atualizar(ImovelModel IMovel);
		bool Apagar(int Id);

	}
}
