using System;
namespace CarLotSimulator
{
	public class Car
	{
		public Car()
		{
			CarLot.NumberOfCars++;
			//class name. static member
		}
		public Car(int Year, string Make, string Model)
		{

		}
		public int Year { get; set; }
		public string Make { get; set; }
		public string Model { get; set; }
		public string EngineNoise { get; set; }
		public string HonkNoise { get; set; }
		public bool IsDrivable { get; set; }
	}
	//public void MakeEngineNoise(string EngineNoise)
//	{
//		Console.WriteLine($"The {Make}'s engine goes like {EngineNoise}");
//	}
//public void MakeHonkNoise(string HonkNoise)
//{
//	Console.WriteLine($"The {Make}'s honk sounds like {HonkNoise}");
//}
}

