using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade2
{
    public class TV
    {
        //Atributos 
        public int CanalAtual; 
        public int VolumeAtual;

         //Métodos 
         //Retornar o valor do Canal 
        public int getCanalAtual(){
            {return CanalAtual;}
        }

        public void MudarCanal(int novoCanal){
            if(novoCanal > 1 && novoCanal <= 100){
                CanalAtual = novoCanal;
            }
            else{
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nErro! Canal não suportad só pode ter canais de 1 a 100");
                Console.ResetColor();
            }
        }
        public void AumentarVolume(){
            if(VolumeAtual < 10){
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"\nVolume Atual: {VolumeAtual}");
                VolumeAtual++;
                Console.ResetColor();
            }
            else{
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"\nVolume: {VolumeAtual}");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nVolume Máximo atingido!");
                Console.ResetColor();
            }
        }
        public void DiminuirVolume(){
            if(VolumeAtual > 0){
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"\nVolume Atual: {VolumeAtual}");
                VolumeAtual--;
                Console.ResetColor();
            }
            else{
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"\nVolume: {VolumeAtual}");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nVolume Mínimo atingido!");
                Console.ResetColor();
            }
        }
    }
}