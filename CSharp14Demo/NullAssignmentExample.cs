using CSharp14Demo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp14Demo
{
    public class NullAssignmentExample
    {
        /// <summary>
        /// null assignment using the null-conditional operator
        /// </summary>
        public static void NullAssignmentDemo()
        {
            Tester tester = new Tester();
            tester?.RatePerHour = 200;
            Console.WriteLine("rate per hour set to " + tester?.RatePerHour.ToString());
        }

        #region Old Legacy Null assignment example

        /// <summary>
        /// null assignment without using the null-conditional operator in previoud C# versions
        /// </summary>
        public static void OldLegacyNullAssignmentDemo()
        {
            Tester legacyTester = null;
            // The following line would throw a NullReferenceException
            // legacyTester.RatePerHour = 150; 
            if (legacyTester != null)
            {
                legacyTester.RatePerHour = 150;
                Console.WriteLine("rate per hour set to " + legacyTester.RatePerHour.ToString());
            }
            else
            {
                Console.WriteLine("legacyTester is null, cannot set RatePerHour.");
            }
        }

        #endregion

    }
}
