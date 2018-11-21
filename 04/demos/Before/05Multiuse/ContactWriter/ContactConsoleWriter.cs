using System;
using System.Diagnostics;
using System.Reflection;
using System.Text;
using static System.Console;

namespace ContactWriter
{
    public class ContactConsoleWriter
    {
        private readonly Contact _contact;
        private ConsoleColor _color;

        public ContactConsoleWriter(Contact contact)
        {
            _contact = contact;
        }

        //[Obsolete("This will be removed in version 2", true)]
        public void Write()
        {
            UseDefaultColor();

            WriteFirstName();

            WriteAge();
        }


        private void UseDefaultColor()
        {
            DefaultColorAttribute defaultColorAttribute = (DefaultColorAttribute)
                Attribute.GetCustomAttribute(typeof(Contact), typeof(DefaultColorAttribute));

            if (defaultColorAttribute != null)
            {
                ForegroundColor = defaultColorAttribute.Color;
            }
        }

        private void WriteFirstName()
        {
            PropertyInfo firstNameProperty =
                typeof(Contact).GetProperty(nameof(Contact.FirstName));

            DisplayAttribute firstNameDisplayAttribute = (DisplayAttribute)
                Attribute.GetCustomAttribute(firstNameProperty, typeof(DisplayAttribute));

            PreserveForegroundColor();

            StringBuilder sb = new StringBuilder();

            if (firstNameDisplayAttribute != null)
            {
                ForegroundColor = firstNameDisplayAttribute.Color;
                sb.Append(firstNameDisplayAttribute.Label);
            }

            if (_contact.FirstName != null)
            {
                sb.Append(_contact.FirstName);
            }

            WriteLine(sb);

            RestoreForegroundColor();
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

        private void PreserveForegroundColor()
        {
            _color = ForegroundColor;
        }

        private void RestoreForegroundColor()
        {
            ForegroundColor = _color;
        }
    }
}
