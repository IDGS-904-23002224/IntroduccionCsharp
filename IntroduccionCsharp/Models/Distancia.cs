using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IntroduccionCsharp.Models
{
    public class Distancia
    {
        public Double x1 { get; set; }
        public Double y1 { get; set; }
        public Double x2 { get; set; }
        public Double y2 { get; set; }
        public Double Res { get; set; }

    public void calcular()
        {
            this.Res = Math.Sqrt((Math.Pow((this.x2 - this.x1),2) + Math.Pow((this.y2 - this.y1),2))); 
        }

    }
}