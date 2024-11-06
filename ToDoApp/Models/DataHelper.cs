using System;
using System.Collections.Generic;

namespace ToDoApp.Models
{
    public static class DataHelper
    {
        public static List<ComboBoxItem> GetYears(DateTime startDate)
        {
            var years = new List<ComboBoxItem>();

            for (int i = -5; i <= 5; i++)
            {
                var year = startDate.Year + i;
                years.Add(new ComboBoxItem
                {
                    ID = year,
                    Name = year.ToString()
                });
            }

            return years;
        }
    }
}