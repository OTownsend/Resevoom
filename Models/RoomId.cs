using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resevoom.Models
{
    public class RoomId
    {
        public int FloorNumber {get; }
        public int RoomNumber { get; }

        public RoomId(int floorNumber, int roomNumber)
        {
            FloorNumber = floorNumber;
            RoomNumber = roomNumber;    
        }
        public override string ToString()
        {
            return $"{FloorNumber}{RoomNumber}";
        }

        public override bool Equals(object? obj)
        {
            return obj is RoomId roomId && FloorNumber == roomId.FloorNumber && RoomNumber == roomId.RoomNumber;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(FloorNumber,RoomNumber);
        }
    }
}
