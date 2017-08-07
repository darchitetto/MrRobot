using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MrRobot;


namespace MrRobot
{
	public class Program
	{
		public static void Main(string[] args)
		{

			var directions = new List<Direction>();

			Console.WriteLine("Please enter your inputs.");

			//read the inputs
			var numCommands = int.Parse(Console.ReadLine());
			var startingPoint = Console.ReadLine();

			//split the starting point on a space
			string[] coordinates = startingPoint.Split(' ');
			var startingX = int.Parse(coordinates[0]);
			var startingY = int.Parse(coordinates[1]);

			//for each command, add to the directions list
			for (var i = 1; i <= numCommands; i++)
			{
				var direction = new Direction();
				string[] argDirections = Console.ReadLine().Split(' ');

				direction.Dir = argDirections[0];
				direction.Steps = int.Parse(argDirections[1]);

				directions.Add(direction);
			}

			//instantiate the cleaner with the starting point
			Cleaner cleaner = new Cleaner(startingX, startingY);
			
			//clean the room and return the unique points
			Console.WriteLine(String.Format("=> Cleaned: {0:N0}", cleaner.CleanRoom(directions)));
			Console.ReadKey();
		}
	}

}

