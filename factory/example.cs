/// Without Factory Method 


// using System;

// // Abstract class for Vehicles
// abstract class Vehicle
// {
//     public abstract void PrintVehicle(); // Abstract method
// }

// // Concrete class for TwoWheeler
// class TwoWheeler : Vehicle
// {
//     public override void PrintVehicle()
//     {
//         Console.WriteLine("I am two wheeler");
//     }
// }

// // Concrete class for FourWheeler
// class FourWheeler : Vehicle
// {
//     public override void PrintVehicle()
//     {
//         Console.WriteLine("I am four wheeler");
//     }
// }

// // Client (or user) class
// class Client
// {
//     private Vehicle _vehicle;

//     public Client(int type)
//     {
//         if (type == 1)
//         {
//             _vehicle = new TwoWheeler(); // Create TwoWheeler
//         }
//         else if (type == 2)
//         {
//             _vehicle = new FourWheeler(); // Create FourWheeler
//         }
//         else
//         {
//             _vehicle = null; // No vehicle created
//         }
//     }

//     public void Cleanup()
//     {
//         _vehicle = null; // Cleanup vehicle reference
//     }

//     public Vehicle GetVehicle()
//     {
//         return _vehicle; // Return the vehicle instance
//     }
// }

// // Driver program
// public class Program
// {
//     public static void Main(string[] args)
//     {
//         Client client = new Client(1); // Create a client for TwoWheeler
//         Vehicle vehicle = client.GetVehicle(); // Get the vehicle
//         if (vehicle != null)
//         {
//             vehicle.PrintVehicle(); // Print vehicle details
//         }
//         client.Cleanup(); // Cleanup vehicle reference
//     }
// }
