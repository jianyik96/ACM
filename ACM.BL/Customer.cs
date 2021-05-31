using Acme.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Customer : EntityBase, ILoggable
    {
        public Customer(): this(0)
        {

        }
        public Customer(int customerId)
        {
            CustomerId = customerId;
            AddressList = new List<Address>();
        }

        public List<Address> AddressList { get; set; }
        public int CustomerId { get; private set; }
        public int CustomerType { get; set; }
        public string EmailAddress { get; set; }
        public string FullName
        {
            get
            {
                // return LastName + ", " + FirstName;
                string fullname = LastName;
                
                
                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(fullname))
                    {
                        fullname += ", ";
                    }
                    fullname += FirstName;
                }
                return fullname;
            }
        }
        public static int InstanceCount { get; set; }
        public string FirstName { get; set; }
        private string _lastName;
        public string LastName
        { 
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;  
            }
        }

        //public string Log()
        //{
        //    var logString = CustomerId + ": " + FullName + " " + "Email: " + EmailAddress + " " + "Status: " + EntityState.ToString();
        //    return logString;
        //}

        public string Log() => 
            $"{CustomerId}: {FullName} Email: {EmailAddress} Status: {EntityState}";

        public override string ToString() => FullName;

        /// <summary>
        /// Retrieve one customer
        /// </summary>
        //public Customer Retrieve(int customerId)
        //{
        //    // Code that retrieves the defined customer
        //    return new Customer();
        //}

        /// <summary>
        /// Retrieve all customer
        /// </summary>
        //public List<Customer> Retrieve()
        //{
        //    // Code that retrieves all of the customer

        //    return new List<Customer>();
        //}

        /// <summary>
        /// Saves the current customer
        /// </summary>
        //public bool Save()
        //{
        //    // Code that saves the defined customer
        //    return true;
        //}

        /// <summary>
        /// Validates the customer data
        /// </summary>
        /// <returns></returns>
        public override bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;

            return isValid;
        }
    }
}
