using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IntroduccionCsharp.Models
{
    public class Multiplicacion
    {
        public int A {  get; set; }
        public int B { get; set; }
        public String Res { get; set; }
        public String Cadena { get; set; }

        public void Calcular()
        {
            int i = 0;
            int result = 0;

            for (i = 0; i < B; i++)
            {
                this.Cadena += " + " + Convert.ToString(this.A);
                result += this.A;
            }
            
            this.Res = this.Cadena + " = " + Convert.ToString(result);

        }

    }
}