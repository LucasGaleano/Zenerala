/*
 * Creado por SharpDevelop.
 * Usuario: S.Otero
 * Fecha: 6/8/2018
 * Hora: 8:05 AM
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;

namespace Zenerala
{
	/// <summary>
	/// Description of ClassDiceShaker.
	/// </summary>
	public class ClassDiceShaker
	{
		//Lista de dados en cubilete
		List<ClassDice> lstDiceInShaker = new List<ClassDice>();
		//CREA RANDOM
		Random randomNumber = new Random();
		
		//Crea los 5 dados y los agrega al cubilete
		public ClassDiceShaker()
		{
			ClassDice dice1 = new ClassDice();
			ClassDice dice2 = new ClassDice();
			ClassDice dice3 = new ClassDice();
			ClassDice dice4 = new ClassDice();
			ClassDice dice5 = new ClassDice();					
			lstDiceInShaker.Add(dice1);
			lstDiceInShaker.Add(dice2);
			lstDiceInShaker.Add(dice3);
			lstDiceInShaker.Add(dice4);
			lstDiceInShaker.Add(dice5);
		}
		
		//Recibe un dado, y lo agrega a la lista de dados en cubilete
		public void PutDieInShaker(ClassDice diceX)
		{
			lstDiceInShaker.Add(diceX);
		}
		
		//Recibe la mesa de juego y por cada dado en cubilete
		//lo lanza, lo agrega a la mesa del cubilete y luego 
		//borra todos los dados del cubilete
		public void ShakerRollDice(ClassTable table)
		{
			foreach (ClassDice x in lstDiceInShaker)
			{
				x.RollDice(randomNumber);
				table.lstDiceInTable.Add(x);
			}	
			lstDiceInShaker.Clear();
		}
	}
}
