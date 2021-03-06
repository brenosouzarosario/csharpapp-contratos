﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Contratos.Entities
{
    class HourContract
    {
        public DateTime Date { get; set; }
        public Double ValuePerHour { get; set; }
        public int Hours { get; set; }

        public HourContract()
        {

        }

        public HourContract(DateTime date, double valuePerHour, int hours)
        {
            Date = date;
            ValuePerHour = valuePerHour;
            Hours = hours;
        }

        public Double TotalValue()
        {
            return Hours * ValuePerHour;
        }
    }
}
