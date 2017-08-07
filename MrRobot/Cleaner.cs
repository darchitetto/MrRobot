using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrRobot
{
	public class Cleaner
	{
		//Constructor
		public Cleaner(int _startingX, int _startingY)
		{
			startingX = _startingX;
			startingY = _startingY;
		}

		//Properties
		public int startingX { get; set; }
		public int startingY { get; set; }
		private List<Point> cleanedPoints { get; set; } = new List<Point>();
		
		//Methods
		public int CleanRoom(List<Direction> directions)
		{
			var X = this.startingX;
			var Y = this.startingY;

			//clean the starting point
			Clean(new Point(X, Y));

			foreach (var d in directions)
			{
				for (int i = 0; i < d.Steps; i++)
				{
					//change the X, Y point based on the directions
					switch (d.Dir)
					{
						case "N": Y--; break;
						case "S": Y++; break;
						case "E": X++; break;
						case "W": X--; break;
					}

					//clean the point passing in the new coordinate
					Clean(new Point(X, Y));
					
				}
			}

			//return the unique cleaned points
			return cleanedPoints.Count();
		}

		private void Clean(Point point)
		{
			//if the point has not been cleaned, add it to the cleanedPoints list
			if (!hasVisited(point.X, point.Y))
			{
				cleanedPoints.Add(point);
			}
		}

		private bool hasVisited(int x, int y)
		{
			//determine if the point has been visited based on the cleanedPoints list
			var numberOfVisits = cleanedPoints.Where(i => i.X == x && i.Y == y).Count();
			if (numberOfVisits > 0)
				return true;

			return false;
		}
	}
	

	
}
