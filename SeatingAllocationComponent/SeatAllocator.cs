using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace SeatingAllocationComponent
{
    public class SeatAllocator
    {
        public static void allocateSeats(List<Booking> bookings, Coach coach)
        {
            foreach (Booking b in bookings)
            {
                b.deleteAllocatedSeatsFromDb();
            }

            int totalSeats = 0;
            foreach (Booking b in bookings)
            {
                totalSeats += b.NumberOfSeats;
            }
            int spacing=0;
            if (bookings.Count > 1)
            {
                spacing = (coach.Capacity - totalSeats) / (bookings.Count - 1);
            }
            
            int rowCounter = 1, columnCounter = 0;

            foreach (Booking b in bookings)
            {
                List<String> allocatedSeats = new List<String>();
                for (int i = 0; i < b.NumberOfSeats; i++)
                {
                    if (columnCounter > coach.SeatsPerRow)
                    {
                        columnCounter = 0;
                        rowCounter++;
                    }
                    string seat = rowCounter + getColumnName(columnCounter);
                    b.AllocatedSeats.Add(seat);
                    columnCounter++;
                }
                for (int j = 0; j < spacing; j++)
                {
                    if (columnCounter > coach.SeatsPerRow)
                    {
                        columnCounter = 1;
                        rowCounter++;
                    }
                    columnCounter++;
                }
            }

            foreach (Booking b in bookings)
            {
                b.insertAllocatedSeatsToDb();
            }
        }

        /*
        * Adapted from http://stackoverflow.com/questions/10373561/convert-a-number-to-a-letter-in-c-sharp-for-use-in-microsoft-excel
        * Accessed [15/03/2014]
        */
        private static string getColumnName(int index)
        {
            const string letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            var value = "";

            if (index >= letters.Length)
                value += letters[index / letters.Length - 1];

            value += letters[index % letters.Length];

            return value;
        }
    }
}