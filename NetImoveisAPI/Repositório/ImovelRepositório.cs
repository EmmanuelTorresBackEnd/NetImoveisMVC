using NetImoveisAPI.Data;
using NetImoveisAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NetImoveisAPI.Repositório
{
	public class ImovelRepositório : IImovelRepositorio
	{
		private readonly BancoContext _BancoContext;
		public ImovelRepositório(BancoContext bancoContext) 
		{
			_BancoContext = bancoContext;
		}
		public ImovelModel ListarPorId(int id)
		{
			return _BancoContext.Imovel.FirstOrDefault(x => x.Id == id);
		}

		public List<ImovelModel> BuscarTodos()
		{
			return _BancoContext.Imovel.ToList();
		}

		public ImovelModel Adicionar(ImovelModel IMovel)
		{
			_BancoContext.Imovel.Add(IMovel);
			_BancoContext.SaveChanges();

			return IMovel;
		}

		public ImovelModel Atualizar(ImovelModel IMovel)
		{
			ImovelModel ImovelDB = ListarPorId(IMovel.Id);

			if (ImovelDB == null) throw new System.Exception("Houve um erro na Atualização");

			ImovelDB.TipoImovel = IMovel.TipoImovel;
			ImovelDB.ValorVendaImovel = IMovel.ValorVendaImovel;
			ImovelDB.ValorLocacaoImovel = IMovel.ValorLocacaoImovel;
			ImovelDB.Endereco = IMovel.Endereco;
			ImovelDB.Numero = IMovel.Numero;
			ImovelDB.Complemento = IMovel.Complemento;
			ImovelDB.Bairro = IMovel.Bairro;
			ImovelDB.Cidade = IMovel.Cidade;
			ImovelDB.Estado = IMovel.Estado;
			ImovelDB.CEP = IMovel.CEP;

			_BancoContext.Imovel.Update(ImovelDB);
			_BancoContext.SaveChanges();
		

			return ImovelDB;
		}

		public bool Apagar(int Id)
		{
			ImovelModel ImovelDB = ListarPorId(Id);

			if (ImovelDB == null) throw new System.Exception("Houve um erro ao Deletar o Imovel");
			_BancoContext.Imovel.Remove(ImovelDB);
			_BancoContext.SaveChanges();

			return true;
		}
	}
}
