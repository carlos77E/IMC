using System;

public class CalculoIMC
{
	public static void Main()
	{
		float Peso = 0;
		float Estatura = 0;
		float IMC = 0;
		String Estado = "";
		Char Opcion = ' ';

		do
		{


			//Titulo de la Ventana
			Console.Title = "Calculo de IMC";

			//Solicitar Datos

			Console.WriteLine("Ingrese Peso");
			Peso = float.Parse(Console.ReadLine());

			Console.WriteLine("Ingrese Altura");
			Estatura = float.Parse(Console.ReadLine());

			//Realizar Calculo

			IMC = (Peso / (Estatura * Estatura));

			//Determinar estado de la persona

			if (IMC < 18.5)
			{
				Estado = "Bajo Peso";
			}

			if ((IMC >= 18.5) && (IMC < 25))
			{
				Estado = "Normal";
			}

			if ((IMC >= 25) && (IMC < 30))
			{
				Estado = "Obeso";
			}
			if ((IMC >= 30) && (IMC < 40))
			{
				Estado = "Obeso";
			}
			if (IMC >= 40)
			{
				Estado = "Obeso Morbido";
			}

			//Mostrar Resultado

			Console.WriteLine("Su IMC es de :" + IMC);
			Console.WriteLine("Su estado es :" + Estado);

			//Preguntar si repie calculo
			Console.WriteLine("Desea Continuar? (S = Si / N = No)");
			Opcion = Console.ReadKey(true).KeyChar;

		} while ((Opcion == 'S') || (Opcion == 's'));

	}
}
