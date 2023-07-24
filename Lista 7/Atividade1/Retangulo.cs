using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade1
{
    public class Retangulo
    {
        //Atributos 
        public double Base; 
        public double Altura; 

        //Metodos 
        public void MudarValorDosLados(double novaBase, double novaAltura){
            Base = novaBase;
            Altura = novaAltura;

        }
        public double RetornarValorDosLados(){
            return Base
            + Altura; 

        }
        public double CalcularArea(){
            return Base * Altura;

        }
        public double CalcularPerimetro(){
            return 2 * Base + 2 * Altura;

        }
    }
}