using System;
namespace Obj
{
    class Program
    {
        static void Main(string[] args)
        {
            var room = new Room(3);
            room.RoomSoldOutEvent += OnRoomSoldOut;
            room.ReserveSeat();
            room.ReserveSeat();
            room.ReserveSeat();
            room.ReserveSeat();
            room.ReserveSeat();
        }

        static void OnRoomSoldOut(object sender, EventArgs e)
        {
            Console.WriteLine("Room is already full");
        }
    }

    public class Room
    {
        public int Seats { get; set; }

        public Room(int seats)
        {
            Seats = seats;
            seatsInUse = 0;
        }

        private int seatsInUse = 0;

        public void ReserveSeat()
        {
            seatsInUse++;
            if (seatsInUse >= Seats)
            {
                OnRoomSoldOut(EventArgs.Empty);
            }
            else
            {
                Console.WriteLine("Seat reserved");
            }
        }

        public event EventHandler RoomSoldOutEvent;

        protected virtual void OnRoomSoldOut(EventArgs e)
        {
            EventHandler handler = RoomSoldOutEvent;
            handler?.Invoke(this, e);
        }
    }
}