using System;
using Microsoft.AspNetCore.Mvc;
using MVC_Clase.Models;

namespace MVC_Clase
{
    public class Demo:Controller{

        public string Texto()
        {
            string texto=" Clase de MVC 2da Parte";
            return "Bienveindo al ejemplo"+ texto;
        }
        public IActionResult vistaNueva(){
            
            ViewBag.Saludar="esto es un mensaje";
            return View();            
        }
        public IActionResult Vista2(){
            Curso b = new Curso();
            
            return View("Vista2",b);
        }
        [HttpPost]
        public IActionResult FuncionJ(String diaBuscado){
            Curso v = new Curso();
            foreach (var itemA in v.dia)
            {
            if(v.Dias.ToString()==diaBuscado){
                ViewBag.Dd = diaBuscado;
            }
            else{
            string aux= "No hay Coincidencia";
            return View("Vista3",aux);

            }   
            }
            return View();
        }
    }
}