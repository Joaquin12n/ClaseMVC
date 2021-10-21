using MVC_Clase.Models;
using System;
namespace MVC_Clase{

    public class Curso{
        public String[] dia = new String[2]{"Lunes","Miercoles"};
        public string horario= "horario de 19 a 20 ";
        public string[] Dias{
            get {return dia;}
        }
        public string Horas{
            get{return horario;}
        }
        
    }
}