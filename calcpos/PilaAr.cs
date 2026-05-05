using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PilaArreglo {
    internal class PilaAr {
        //dato
        private double[] datos = Array.Empty<double>();
        
        //inserta valor
        public void Push(double valor) {
            Array.Resize(ref datos, datos.Length+1);
            datos[datos.Length - 1] = valor;
        }
        public double Pop() {
            double valor = datos[datos.Length - 1];
            Array.Resize(ref datos, datos.Length - 1);
            return valor;
        }
        public double Top() {
            return datos[datos.Length - 1];
        }
        public int Size() {
            return datos.Length;
        }
        public bool Empty() {
            return datos.Length == 0;
        }
        public override string? ToString() {
            string str = "";
            foreach (int i in datos) {
                str += i.ToString() + ",";
            }
            return str;
        }

    }
}
/*




*/
