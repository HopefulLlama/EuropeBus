using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;

namespace SeatAllocator
{
    public class SeatAllocator
    {
        public static void allocateSeats(List<Booking> bookings, Coach coach)
        {
            int rowCounter = 1;
            int columnCounter = 1;
            foreach (Booking b in bookings)
            {
                List<String> allocatedSeats = new List<String>();
                for(int i = 0; i < b.NumberOfSeats; i++)
                {
                    if (columnCounter == coach.SeatsPerRow)
                    {
                        columnCounter = 1;
                    }
                    string seat = getColumnName(rowCounter) + columnCounter;
                    b.AllocatedSeats.Add(seat);
                    columnCounter++;
                }
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
