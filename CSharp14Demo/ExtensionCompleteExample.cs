using CSharp14Demo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp14Demo
{
    public static class ExtensionCompleteExample
    {
        extension(Developer)
        {
            public static Developer CreateDefault() =>
                new Developer
                {
                    Name = "Unnamed Product",
                    RatePerHour = 20,
                    YearsOfExperience = 4,
                    Category = "General",
                    CreatedDate = DateTime.UtcNow
                };

            public static bool IsSeniorDeveloper(int yearsOfExperience) =>
                yearsOfExperience >= 5;

            public static string DefaultCategory => "General";
        }
    }   
}
