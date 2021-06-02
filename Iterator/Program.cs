using System;
using System.Collections;
using System.Collections.Generic;

// Generate list of the number of days per month starting at Year 4 and ending
// at Year 5. Iterate through the list and display in the console.


namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            var collection = new DaysInMonthCollection();
            foreach(var monthWithDays in collection)
            {
                Console.WriteLine($"Days in {monthWithDays.Date} - {monthWithDays.Days}");
            }

        }
    }
// Create a template for the Collection
    class MonthWithDays 
    {
        public string Date {get; set;}
        public int Days {get; set;}


    }

    class DaysInMonthEnumerator : IEnumerator<MonthWithDays>
    {
        private int year = 1;
        private int month = 0;  // 0 because MoveNext initializes by first moving 1 unit right
        public MonthWithDays Current => new MonthWithDays() { // create a new collection
            Date = $"{year.ToString().PadLeft(4,'0')}--{month}",
            Days = DateTime.DaysInMonth(year, month)
        }; 
        
        object IEnumerator.Current => Current;
    

        public void Dispose()
        {
        }

        public bool MoveNext()
        {
        month++;
        if (month > 12) {
            month = 1;
            year++;
        }
        return year < 5;
        }

        public void Reset(){
        month = 0;
        year = 1;
        }
    }

    class DaysInMonthCollection : IEnumerable<MonthWithDays>
    {
      public IEnumerator<MonthWithDays> GetEnumerator()
      {
        return new DaysInMonthEnumerator();
      }

      IEnumerator IEnumerable.GetEnumerator()
      {
        return GetEnumerator();
      }
    }

}
