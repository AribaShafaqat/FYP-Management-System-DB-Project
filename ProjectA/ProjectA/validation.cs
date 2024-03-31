using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectA
{
    internal class validation
    {
        public static class Validation
        {
            public static bool ValidateStudent(string registrationNumber, string email, string dateOfBirth)
            {
                if (!ValidateRegistrationNumber(registrationNumber))
                {
                    MessageBox.Show("Please enter a valid registration number with the format yyyy-(department)-(numbers).");
                    return false;
                }

                if (!ValidateEmail(email))
                {
                    MessageBox.Show("Please enter a valid email address with a gmail.com domain.");
                    return false;
                }

                if (!ValidateDateOfBirth(dateOfBirth))
                {
                    MessageBox.Show("Please enter a date of birth where the year does not exceed 2009.");
                    return false;
                }

                if (IsRegistrationNumberDuplicate(registrationNumber))
                {
                    MessageBox.Show("Registration number already exists. Please enter a unique registration number.");
                    return false;
                }

                if (IsEmailDuplicate(email))
                {
                    MessageBox.Show("Email address already exists. Please enter a unique email address.");
                    return false;
                }

                return true;
            }
            public static bool ValidateFirstName(string firstName)
            {
                return Regex.IsMatch(firstName, @"^[a-zA-Z]+$");
            }

            public static bool ValidateLastName(string lastName)
            {
                return Regex.IsMatch(lastName, @"^[a-zA-Z]+$");
            }

            public static bool ValidateRegistrationNumber(string registrationNumber)
            {
                return Regex.IsMatch(registrationNumber, @"^\d{4}-[A-Za-z]+-\d+$");
            }

            public static bool ValidateEmail(string email)
            {
                return Regex.IsMatch(email, @"^\w+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$");

            }
            public static bool ValidateContact(string contact)
            {
                return Regex.IsMatch(contact, @"^03\d{2}-\d{7}$");
            }

            public static bool ValidateDateOfBirth(string dob)
            {
                if (DateTime.TryParse(dob, out DateTime dateOfBirth))
                {
                    return dateOfBirth.Year <= 2009;
                }
                else
                {
                    return false;
                }
            }

            public static bool IsRegistrationNumberDuplicate(string registrationNumber)
            {
                SqlConnection con = Configuration.getInstance().getConnection();
                {
                    SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Student WHERE RegistrationNo = @RegistrationNo", con);
                    cmd.Parameters.AddWithValue("@RegistrationNo", registrationNumber);

                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }

            }

            public static bool IsEmailDuplicate(string email)
            {
                SqlConnection con = Configuration.getInstance().getConnection();
                {
                    SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Person WHERE Email = @Email", con);
                    cmd.Parameters.AddWithValue("@Email", email);
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }
    }
}
