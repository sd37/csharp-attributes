using System;
using System.Diagnostics;
using static System.Console;

namespace ContactWriter
{
    public class ContactConsoleWriter
    {
        private readonly Contact _contact;

        public ContactConsoleWriter(Contact contact)
        {
            _contact = contact;
        }

        //[Obsolete("This will be removed in version 2", true)]
        public void Write()
        {
            WriteFirstName();

            WriteAge();
        }

        private void WriteFirstName()
        {
            WriteLine(_contact.FirstName);
        }

        private void WriteAge()
        {
            OutputDebugInfo();
            OutputExtraInfo();
            WriteLine(_contact.AgeInYears);
        }

        [Conditional("DEBUG")]
        private void OutputDebugInfo()
        {
            WriteLine("***DEBUG MODE***");
        }

        [Conditional("EXTRA")]
        private void OutputExtraInfo()
        {
            WriteLine("***EXTRA INFO***");
        }
    }
}
