﻿using Aula0208_POO.Modelos;
using System;

namespace Aula0208_POO
{

    class Program {

        static void Main(string[] args){
            Carro car = new Carro();
            car.Modelo = "Ferarri";

            ExecutaTesteMotor(car);

            //car.Acelerar();

            //Console.WriteLine("Velocidade: " + car.Velocidade);
            Console.ReadKey();
        }

        static void ExecutaTesteMotor(IMotorizado vec) {

            Console.WriteLine("Velocidade atual: "+ vec.Velocidade);
            vec.Acelerar();
            vec.Acelerar();
            vec.Acelerar();
            Console.WriteLine("Velocidade atual: " + vec.Velocidade);
            vec.Frenar();
            vec.Frenar();
            Console.WriteLine("Velocidade atual: " + vec.Velocidade);
        }
    }
}
