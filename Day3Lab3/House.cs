using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composition
{
    internal class House
    {
        public string Address { get; set; }
        public Room Room;
        public House(string address, string roomType)
        {
            Address = address;
            Room = new Room(roomType);
        }

        public void ShowHouseDetails()
        {
            Console.WriteLine($"House address at {Address}, and has room of: {Room.Type}");
        }


    }
}
