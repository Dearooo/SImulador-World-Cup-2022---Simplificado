using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Simulador_de_Mata_Mata_World_Cup_2022.Models
{
    public class Time
    {

        public string name {get ;set ;}
        public int vitoria{get ;set ;}
        public int derrota{get ;set;}

        public Time(string name){
            this.name = name;
            this.vitoria = 0;
            this.derrota = 0;
        }

        public Time Cadastro(string n){
            Time t = new Time(n);
            t.vitoria = 0;
            t.derrota = 0;
            return t;
        }

        public void Imprimir(){
            Console.WriteLine(name + "\t" + vitoria + "\t" + derrota + "\t");
        }
    }
 
}