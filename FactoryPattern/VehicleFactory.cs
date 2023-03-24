using System;
namespace FactoryPattern
{
	public static class VehicleFactory
	{
		public static IVehicle GetVehicle(string vehicleType)
		{
			switch(vehicleType.ToLower())
			{
				case "car":
				case "vehicle":
				case "truck":
				case "suv":
					return new Car();
				case "motorcycle":
				case "motobike":
				case "crotch rocket":
					return new Motorcycle();
				default:
					return new Car();
			}
		}
	}
}

