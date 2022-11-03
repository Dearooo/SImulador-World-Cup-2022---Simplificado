using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Simulador_de_Mata_Mata_World_Cup_2022.Models.Operacoes
{
    public class Operacoes
    {   
        //Essa função ficara responsavel para facilitar as disputas na main.
        public static void Disputa_FG(Time time1, Time time2){   

            int t1;
            Console.WriteLine(time1.name + "(1) X (2)" + time2.name);

            Console.WriteLine("Quem Vence: ");
            t1 = int.Parse(Console.ReadLine());
            
            if (t1 == 1)
            {
                time1.vitoria = time1.vitoria + 1;
                time2.derrota = time2.derrota + 1;
            }
            else if(t1 == 2){
                time2.vitoria = time2.vitoria + 1;
                time1.derrota = time1.derrota + 1;
            }
        }

        public static void Controle_FG(Time[] T){
            Disputa_FG(T[0], T[1]);
            Disputa_FG(T[2], T[3]);
            Disputa_FG(T[1], T[2]);
            Disputa_FG(T[3], T[0]);
            Disputa_FG(T[0], T[2]);
            Disputa_FG(T[3], T[1]);
            Console.Clear();
        }

        public static Time[] Selecao_quartas(Time[] T){
            Time Exemp = new Time("kaka");
            Time[] finalistas = new Time[2];
            finalistas[0] = Exemp.Cadastro("Teste1");
            finalistas[1] = Exemp.Cadastro("Teste2");
            for (int i = 0; i < 4; i++)
            {
                if (T[i].vitoria > finalistas[0].vitoria)
                {
                    finalistas[0] = T[i];
                }
                else if(T[i].vitoria > finalistas[1].vitoria)
                {     
                    finalistas[1]=T[i];   
                }
            }

            return finalistas;
        }

        //Essa função será responsavel para facilitar a montagem das dispustas nas quartas;
        public static Time Disputa_MM(Time time1, Time time2){   
            
            int t1;
            Console.WriteLine(time1.name + "(1) X (2)" + time2.name);

            Console.WriteLine("Quem Vence: ");
            t1 = int.Parse(Console.ReadLine());
            
            if (t1 == 1)
            {
                return time1;
            }
            else if(t1 == 2)
            {
               return time2;
            }
            else{
                throw new ArgumentException("Nenhuma situação aceita!");
            }
        }
        
    }
}