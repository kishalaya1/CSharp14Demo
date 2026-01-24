using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp14Demo
{
    public class FieldExample
    {
        private string _oldName;
        public string OldName
        {
            get => _oldName;
            set => _oldName = value ?? throw new ArgumentNullException(nameof(value));
        }

        public string NewName
        {
            get;
            set => field = value ?? throw new ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Demonstrates usage of the auto-property backing storage accessed via the C# 14 'field' variable
        /// (used in the NewName setter above). Shows normal assignment and the null-guard behavior.
        /// </summary>
        public void ShowFieldUsage()
        {
            Console.WriteLine("Field usage demo:");

            // Using OldName (explicit backing field _oldName)
            OldName = "The Teacher";
            Console.WriteLine($"OldName set to: {OldName}");

            // Using NewName (auto-property uses 'field' in setter)
            NewName = "Sir Leigh Teabing";
            Console.WriteLine($"NewName set to: {NewName}");

            // Demonstrate null guard: setter throws ArgumentNullException when null is assigned
            try
            {
                NewName = null!;
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"Setting NewName to null threw: {ex.GetType().Name} - {ex.ParamName}");
            }

            // Show that values remain unchanged after failed assignment
            Console.WriteLine($"Final NewName value: {NewName}");
        }

        /// <summary>
        /// Convenience static demo entry to call from a static context (for example Program.cs).
        /// </summary>
        public static void Demo()
        {
            var example = new FieldExample();
            example.ShowFieldUsage();
        }
    }
}

