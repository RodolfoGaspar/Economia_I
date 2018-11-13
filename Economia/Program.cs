using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Economia
{
	class Program
	{
		static void Main(string[] args)
		{

			Console.WriteLine("Economia - Atividade para Avaliação - Semana 3\n");

			var Q = 10; // Quantidade
			double C = 0; // Custo

			Console.WriteLine($"Quantidade de produtos (Q): {Q}");
			Console.WriteLine("Fórmula Custo (C): C(Q) = 400+3Q²");

			C = 400 + 3 * Math.Pow(Q, 2);

			Console.WriteLine($"Custo = {C}");

			Q = 20;
			double P = 100;

			Console.WriteLine($"Quantidade de produtos (Q): {Q}");
			Console.WriteLine($"Preço Unitário (P): {P}");
			Console.WriteLine("Fórmula Custo (C): C(Q) = 400+3Q²");

			C = 400 + 3 * Math.Pow(Q, 2);

			Console.WriteLine($"Custo = {C}");

			Console.WriteLine("Fórmula Lucro (L): L=RT-CT");
			Console.WriteLine("Fórmula Receita Total (L): RT=Q*P");

			var L = P * Q - C;

			Console.WriteLine($"Lucro = {L}");

			Console.ReadKey();

		}
	}
}
