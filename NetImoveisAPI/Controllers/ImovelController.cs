using Microsoft.AspNetCore.Mvc;
using NetImoveisAPI.Models;
using NetImoveisAPI.Repositório;
using System.Collections.Generic;

namespace NetImoveisAPI.Controllers
{
	public class ImovelController : Controller
	{
		private readonly IImovelRepositorio _imovelRepositorio;
		public ImovelController(IImovelRepositorio imovelRepositorio)
		{
			_imovelRepositorio = imovelRepositorio;
		}
		public IActionResult Index()
		{
			List<ImovelModel> imoveis = _imovelRepositorio.BuscarTodos();

			return View(imoveis);

		}

		public IActionResult Cadastrar()
		{
			return View();
		}

		public IActionResult Alterar(int Id)
		{
			ImovelModel Imovel = _imovelRepositorio.ListarPorId(Id);
			return View(Imovel);
		}

		public IActionResult DeletarConfirmacao(int Id)
		{
			ImovelModel Imovel = _imovelRepositorio.ListarPorId(Id);
			return View(Imovel);
		}
		public IActionResult Deletar(int Id)
		{
			_imovelRepositorio.Apagar(Id);
			return RedirectToAction("Index");
		}

		[HttpPost]

		public IActionResult Cadastrar(ImovelModel imovel)
		{
			if (ModelState.IsValid)
			{
				_imovelRepositorio.Adicionar(imovel);

				return RedirectToAction("Index");
			}
			return View(imovel);
		}
		[HttpPost]
		public IActionResult Alterar(ImovelModel imovel)
		{
			_imovelRepositorio.Atualizar(imovel);

			return RedirectToAction("Index");
		}

	}
}
