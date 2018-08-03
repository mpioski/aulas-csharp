using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula0208_POO.Modelos
{
    class Barco : Veiculo, IMotorizado
    {
        public int Velocidade { get; set; }
        public void Acelerar() { 
            Console.WriteLine("BARCO: Acelerando...");
            Velocidade += 15;
        }

        public void Frenar() {
            Console.WriteLine("BARCO: Freiando...");
            Velocidade -= 9;
        }
    }
}
