using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MrRobot;
using System.Collections;
using System.Collections.Generic;

namespace MrRobotTest
{
	[TestClass]
	public class CleanerTest
	{
		[TestMethod]
		public void Cleaner_Should_Return_Cleaned_4()
		{
			// 2
			// 10 22
			// E 2
			// N 1
			

			Cleaner cleaner = new Cleaner(10,22);
			var directions = new List<Direction>();

			directions.Add(new Direction() { Dir = "E", Steps = 2 });
			directions.Add(new Direction() { Dir = "N", Steps = 1 });

			int numberUniqueSteps = cleaner.CleanRoom(directions);

			Assert.AreEqual(4, numberUniqueSteps);


		}

		[TestMethod]
		public void Cleaner_Goes_In_A_Circle_Should_Return_6()
		{
			// 6
			// 10 22
			// E 2
			// N 1
			// W 2
			// S 1
			// E 2
			// N 1

			Cleaner cleaner = new Cleaner(10,22);
			var directions = new List<Direction>();

			directions.Add(new Direction() { Dir = "E", Steps = 2 });
			directions.Add(new Direction() { Dir = "N", Steps = 1 });
			directions.Add(new Direction() { Dir = "W", Steps = 2 });
			directions.Add(new Direction() { Dir = "S", Steps = 1 });
			directions.Add(new Direction() { Dir = "E", Steps = 2 });
			directions.Add(new Direction() { Dir = "N", Steps = 1 });
			

			int numberUniqueSteps = cleaner.CleanRoom(directions);

			Assert.AreEqual(6, numberUniqueSteps);

		}

		[TestMethod]
		public void Cleaner_Goes_Left_Then_Right()
		{
			// 2
			// 10 22
			// W 6
			// E 7
		

			Cleaner cleaner = new Cleaner(10,22);
			var directions = new List<Direction>();

			directions.Add(new Direction() { Dir = "W", Steps = 6 });
			directions.Add(new Direction() { Dir = "E", Steps = 7 });


			int numberUniqueSteps = cleaner.CleanRoom(directions);

			Assert.AreEqual(8, numberUniqueSteps);

		}

		[TestMethod]
		public void Cleaner_Goes_In_A_Figure_Eight_Should_Return_27()
		{
			// 8
			// 30 50
			// E 4
			// S 4
			// W 4
			// S 4
			// E 4
			// N 4
			// W 4
			// N 4

			Cleaner cleaner = new Cleaner(30, 50);
			var directions = new List<Direction>();

			directions.Add(new Direction() { Dir = "E", Steps = 4 });
			directions.Add(new Direction() { Dir = "S", Steps = 4 });
			directions.Add(new Direction() { Dir = "W", Steps = 4 });
			directions.Add(new Direction() { Dir = "S", Steps = 4 });
			directions.Add(new Direction() { Dir = "E", Steps = 4 });
			directions.Add(new Direction() { Dir = "N", Steps = 4 });
			directions.Add(new Direction() { Dir = "W", Steps = 4 });
			directions.Add(new Direction() { Dir = "N", Steps = 4 });


			int numberUniqueSteps = cleaner.CleanRoom(directions);

			Assert.AreEqual(27, numberUniqueSteps);

		}
	}
}
