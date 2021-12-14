using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalAreaPOO {
	public class Triangulo : Forma {
		public double Base { get; set; }
		public double Altura { get; set; }
		public override double CalcularArea => (this.Base * this.Altura) / 2;
	}
}
