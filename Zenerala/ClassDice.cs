/*
 * Creado por SharpDevelop.
 * Usuario: S.Otero
 * Fecha: 6/8/2018
 * Hora: 7:53 AM
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Zenerala
{
	public class ClassDice
	{
		private int numDice;
		
		public ClassDice()
		{
		}
		
		public int NumDice
		{
			get
			{
				return numDice;
			}
			set
			{
				numDice = value;
			}
		}
		
		//Genera un nuevo valor del dado
		public void RollDice(Random randomNumber)
		{
			//Random randomNumber = new Random();
			numDice = randomNumber.Next(1,6);
		}
	}
}
