using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using AppManager8_Desktop.Models;
using AppManager8_Desktop.ViewModels;

namespace AppManager8_Desktop
{
    class Program
    {
        public static void Main()
        {
            Console.Write("Cek Connection Database : ");
            var vm = new ProfileViewModel();
            if (vm.OpenConnection())
            {
                Console.WriteLine("Database Connected");
            } else
            {
                Console.WriteLine("Database Not Connected");
            }
            vm.CloseConnection();

            /*Console.Write("Insert Profile : ");
            var model = new Profile
            {
                Guid = "101202111190002",
                Username = "jhon doe",
                Alias = "jhondoe",
                KeyPass = "12345678",
            };
            if (vm.Create(model))
            {
                Console.WriteLine("Insert Successfully");
            }
            else
            {
                Console.WriteLine("Insert Failed");
            }*/

            /*Console.WriteLine("Data Profile");
            var collections = vm.Read();
            foreach (var data in collections)
            {
                Console.WriteLine($"Uid : {data.Uid}");
                Console.WriteLine($"Guid : {data.Guid}");
                Console.WriteLine($"User : {data.Username}");
                Console.WriteLine($"Alias : {data.Alias}");
                Console.WriteLine($"KeyPass : {data.KeyPass}");
                Console.WriteLine();
            }*/
            
            /*Console.Write("Update Profile : ");
            var model = new Profile
            {
                Uid = 3,
                Guid = "101202111190003",
                Username = "dean kasie",
                Alias = "dean",
                KeyPass = "deankasie"
            };
            if (vm.Update(model))
            {
                Console.WriteLine("Update Successfully");
            }
            else
            {
                Console.WriteLine("Update Failed");
            }*/
            
            /*Console.Write("Delete Profile : ");
            var model = new Profile
            {
                Uid = 5
            };
            if (vm.Delete(model))
            {
                Console.WriteLine("Delete Successfully");
            }
            else
            {
                Console.WriteLine("Delete Failed");
            }*/

            Console.ReadKey();
        }
    }
}
