using System;

namespace CalAreaPOO {
	class Program {

		public enum OpcoesMenu {
			Sair = 0,
			Quadrado,
			Retângulo,
			Triângulo,
			Circulo
		}
		static void Main(String[] args) {
			OpcoesMenu escolha = OpcoesMenu.Quadrado;
			while ((escolha = GetEscolha()) != OpcoesMenu.Sair) {
				Forma forma = null;
				switch (escolha) {
					case OpcoesMenu.Quadrado:
						forma = CriaQuadrado();
						break;
					case OpcoesMenu.Retângulo:
						forma = CriaRetangulo();
						break;
					case OpcoesMenu.Triângulo:
						forma = CriaTriangulo();
						break;
					case OpcoesMenu.Circulo:
						forma = CriaCirculo();
						break;
					default:
						break;
				}
				Console.WriteLine($"A área do {escolha} é: {forma.CalcularArea}\n");
			}
			Environment.Exit(0);
		}
		public static OpcoesMenu GetEscolha() {
			Console.WriteLine("Escolha a figura para qual deseja calcular a área: ");
			Console.WriteLine("\t{0} - Quadrado", (int)OpcoesMenu.Quadrado);
			Console.WriteLine($"\t{(int)OpcoesMenu.Retângulo} - Retângulo.");
			Console.WriteLine($"\t{(int)OpcoesMenu.Triângulo} - Triângulo.");
			Console.WriteLine($"\t{(int)OpcoesMenu.Circulo} - Circulo.");
			Console.WriteLine($"\t{(int)OpcoesMenu.Sair} - Para sair.");
			Console.Write("Escolha: ");
			string valor = Console.ReadLine();
			OpcoesMenu escolha;
			if (!Enum.TryParse(valor, out escolha)) {
				Console.WriteLine("Opção inválida.");
				return GetEscolha();
			}
			return escolha;
		}

		public static double GetDouble (string prompt) {
			bool isValido = false;
			double valor = 0;
			while (!isValido) {
				Console.Write(prompt);
				isValido = double.TryParse(Console.ReadLine(), out valor);
			}
			return valor;
		}

		private static Quadrado CriaQuadrado() {
			double lado = GetDouble("Lado do quadrado: ");
			return new Quadrado() { Lado = lado };
		}

		private static Retangulo CriaRetangulo() {
			double baseT = GetDouble("Base do retangulo: ");
			double altura = GetDouble("Altura do retângulo: ");
			return new Retangulo() { Base = baseT,
									 Altura = altura};
		}

		private static Triangulo CriaTriangulo() {
			double baseT = GetDouble("Base do triângulo: ");
			double altura = GetDouble("Altura do triângulo: ");
			return new Triangulo() { Base = baseT, 
									 Altura = altura};
		}

		private static Circulo CriaCirculo() {
			double raio = GetDouble("Valor do raio: ");
			return new Circulo() { Raio = raio };
		}
	}
}
