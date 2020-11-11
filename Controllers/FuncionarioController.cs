using System;
using System.Linq;
using EFCore.Database;
using EFCore.Models;
using Microsoft.AspNetCore.Mvc;

namespace EFCore.Controllers
{
    public class FuncionarioController : Controller
    {
        private readonly ApplicationDBContext _database;

        public FuncionarioController(ApplicationDBContext database)
        {
            this._database = database;
        }

        [HttpGet]
        public IActionResult Index(){
            var funcionarios = _database.Funcionarios.ToList();
            return View(funcionarios);
        }

        [HttpGet]
        public IActionResult Cadastrar(){
            return View();
        }
                
        [HttpGet]
        public IActionResult Editar(int id){
            var funcionario = _database.Funcionarios.First(func => func.Id == id);
            return View("Cadastrar", funcionario);
        }

        [HttpGet]
        public IActionResult Deletar(int id){
            var funcionario = _database.Funcionarios.First(func => func.Id == id);
            _database.Funcionarios.Remove(funcionario);
            _database.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Salvar(Funcionario modelo){
            if(modelo.Id == 0){
                _database.Funcionarios.Add(modelo);
            }
            else{
                //Este objeto já está na memoria do entity framework e por isso não precisa de método update
                //simplesmente modificar o objeto já faz alterar
                var funcionario = _database.Funcionarios.First(func => func.Id == modelo.Id);
                funcionario.Nome = modelo.Nome;
                funcionario.Cpf = modelo.Cpf;
                funcionario.Salario = modelo.Salario;
            }
            _database.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}