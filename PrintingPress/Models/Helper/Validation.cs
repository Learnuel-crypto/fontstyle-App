using System;
using System.Text.RegularExpressions;

namespace WindowsFormsApplication1.Modification.Models.Helper
{
    public static class Validation
    {

        private static string invalidNames = @"([0-9@!#$^&*()~]+)"; 
        private static string invalidContact = @"[a-zA-Z]"; 
        private static string validMail = @"^(\w.+)@(\w.+).([a-z]+)$";
        internal static string ValidAmount = @"^([0-9.]+)$";
        private static string validCode = @"^([0-9]+)$";
        private static string validCNIC = @"^([0-9]+)-([0-9]+)-([0-9]+)$";

        /// <summary>
        /// Validate CNIC Number
        /// </summary>
        /// <param name="cnic"></param>
        /// <returns></returns>
        public static bool CNIC(string cnic)
        {
            if (string.IsNullOrEmpty(cnic))
                throw new Exception("cnic cannot be empty");
            if (cnic.Length < 15 || cnic.Length > 15)
                throw new Exception("Invalid CNIC Number");
            Match match = Regex.Match(cnic, validCNIC);
            if (!match.Success)
                throw new Exception("Invalid CNIC Number");
            return true;
        }
        /// <summary>
        /// Check if provided email is a valid email signature
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public static bool Email(string email)
        {
            if (string.IsNullOrEmpty(email))
                throw new Exception("Email cannot be empty");
            Match match = Regex.Match(email, validMail);
            if (!match.Success)
                throw new Exception("Invalid email");
            return true;
        }
        /// <summary>
        /// Check if contact matches valid format
        /// </summary>
        /// <param name="contact">Contact digits only</param>
        /// <returns></returns>
        public static bool Contact(string contact)
        {
            Match match = Regex.Match(contact, invalidContact);
            if (string.IsNullOrEmpty(contact) || match.Success)
                throw new Exception("Invalid contact");
            return true;
        }
        /// <summary>
        /// Check if the expense code is digits only
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public static bool ExpenseCode(string code)
        {
            Match match = Regex.Match(code, validCode);
            if (string.IsNullOrEmpty(code) || !match.Success)
                throw new Exception("Invalid expense code");
            return true;
        }
        /// <summary>
        /// Check if contact matches valid format and length
        /// </summary>
        /// <param name="contact">Contact digits only</param>
        /// <param name="maxLength">Maximum length of contact</param>
        /// <returns> true</returns>
        public static bool Contact(string contact, int maxLength)
        {
            Match match = Regex.Match(contact, invalidContact);
            if (string.IsNullOrEmpty(contact) || match.Success || maxLength <= contact.Length)
                throw new Exception("Invalid contact");
            return true;
        }
        /// <summary>
        /// check if contact matches valid format and provide min and max length
        /// </summary>
        /// <param name="contact">Contact digits only</param>
        /// <param name="minlength">minimum contact length</param>
        /// <param name="maxLength">maximum contact length</param>
        /// <returns></returns>
        public static bool Contact(string contact, int minlength, int maxLength)
        {
            Match match = Regex.Match(contact, invalidContact);
            if (string.IsNullOrEmpty(contact) || match.Success || minlength != contact.Length && maxLength != contact.Length)
                throw new Exception("Invalid contact");
            return true;
        }
        /// <summary>
        /// Validate patient id
        /// </summary>
        /// <param name="patientid"></param>
        /// <returns></returns>
        //public static bool PatientID(string patientid)
        //{
        //    Match match = Regex.Match(patientid, invalidContact);
        //    if (match.Success)
        //        throw new Exception("Invalid Patient registration number");
        //    return true;
        //}
        /// <summary>
        /// Check if username already exist in database
        /// </summary>
        /// <param name="username">username of new user</param>
        /// <returns></returns>
        public static bool Username(string username)
        {
            Match match = Regex.Match(username, invalidNames);
            if (string.IsNullOrEmpty(username) || match.Success)
                throw new Exception("Invalid character in name");
            return true;
        }
        /// <summary>
        /// Check if name is only letters
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static bool Name(string name)
        {
            Match match = Regex.Match(name, invalidNames);
            if (string.IsNullOrEmpty(name) || match.Success)
                throw new Exception("Invalid character in name");
            return true;
        }
        /// <summary>
        /// Validate amount to two decimal place
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        public static bool Amount(string amount)
        {
            Match match = Regex.Match(amount, ValidAmount);
            if (string.IsNullOrEmpty(amount) || !match.Success)
                throw new Exception("Invalid Amount value");
            if (amount.Contains("."))
            {
                var left = amount.Substring(amount.IndexOf(".") + 1);
                if (!string.IsNullOrEmpty(left))
                {
                    if (left.Contains(".") || left.Length > 2)
                        throw new Exception("Invalid Amount value");
                }
            }
            return true;
        }


    }
}
