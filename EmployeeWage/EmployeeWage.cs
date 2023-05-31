﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    internal class EmployeeWage
    {
        public const byte FULL_TIME = 1;
        public const byte PART_TIME = 2;
        public const byte PART_WORKING_HOURS = 4;
        public const byte FULL_WORKING_HOURS = 8;
        public const int WAGE_PER_HOUR = 20;
        public const byte WORKING_DAYS_PER_MONTH = 20;

        public  int CheckAttendance()
        {
            Random random = new Random();
            int attendance = random.Next(0, 3);

            if (attendance == FULL_TIME)
            {
                Console.WriteLine("Employee is present");
                return FULL_TIME;
            }

            else if (attendance == PART_TIME)
            {
                Console.WriteLine("Employee is parttime present");
                return PART_TIME;
            }
            else
            {
                Console.WriteLine("Employee is absent");
                return 0;
            }
        }

       
    }

    
}