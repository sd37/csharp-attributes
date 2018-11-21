using System.Diagnostics;

namespace ContactWriter
{
    [DebuggerDisplay("First Name={FirstName} and Age In Years={AgeInYears}")]
    [DebuggerTypeProxy(typeof(ContactDebugDisplay))]
    [DefaultColor(Color = System.ConsoleColor.Magenta)]
    public class Contact
    {
        [Display("First Name: ", System.ConsoleColor.Cyan)]
        public string FirstName { get; set; }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int AgeInYears { get; set; }
    }
}
