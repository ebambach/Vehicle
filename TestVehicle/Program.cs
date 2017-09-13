using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleLibrary;

namespace TestVehicle {
	class Program {
		static void Main(string[] args) {
			new Program().Run();
		}
		void Run() {
			Console.WriteLine("Journey by airplane:");
			Airplane myPlane = new Airplane();
			myPlane.StartEngine("Contact");
			myPlane.TakeOff();
			myPlane.Drive();
			myPlane.Land();
			myPlane.StopEngine("Whirr");

			Console.WriteLine("");

			Console.WriteLine("Journey by car:");
			Car myCar = new Car();
			myCar.StartEngine("Brm brm");
			myCar.Accelerate();
			myCar.Drive();
			myCar.Brake();
			myCar.StopEngine("Phut phut");

			Console.WriteLine("");

			Console.WriteLine("Testing polymorphism (the condition of occurring in several different forms)");
			Vehicle v = myCar;
			v.Drive();
			v = myPlane;
			v.Drive();
		}
	}
}
