using lapirana_pc02.Data;
using lapirana_pc02.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace lapirana_pc02.Controllers
{
    public class UsuarioController: Controller
    {
        private UsuarioContext _context;
        public UsuarioController(UsuarioContext context){
            _context = context;
        }

        public IActionResult Registrar(){
            return View();
        }

        public IActionResult Editar(){
            return View();
        }

        public IActionResult Registrar(Usuario u){
            if(ModelState.IsValid){
                _context.Add(u);
                _context.SaveChanges();

                return View("Registrar");
            }
            return View(u);
        } 

       public IActionResult Editar(Usuario u){
           
       }
    }
}