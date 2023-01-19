/// Class Name: clsCustomer
/// Purpose: A container to hold all attributes and methods in a class 
/// Change Log: B.Grant 1/18/2023

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Brent_Csharp_WPF.Entity
{
    internal class clsCustomer
    {
        /*
         Private Attributes
         */
        private int intCustomerID; 
        private string strCustomerFirstName;
        private string strCustomerLastName;
        private string strCustomerAddress;
        private string strCustomerState;
        private string strCustomerCity;
        private string strCustomerZip;
        private string strCustomerEmail;
        private string strCustomerPhone;

        public int CustomerID 
        { 
        
            get
            {
                return intCustomerID;
            }
            set
            {
                if (value > 0)
                {
                    intCustomerID = value;
                }
                else
                {
                    // Nothing exist at this time
                    intCustomerID= -1;
                }
            }
        }

        public string CustomerFirstName 
        {
            get
            {
                return strCustomerFirstName;
            }
            set
            {
                if (value != string.Empty)
                {
                    strCustomerFirstName = value;
                }
                else
                {
                    strCustomerFirstName = "Null String";
                }
            }
        }

        public string CustomerLastName 
        {
            get
            {
                return strCustomerLastName;
            }
            set
            {
                if (value != string.Empty)
                {
                    strCustomerLastName = value;
                }
                else
                {
                    strCustomerLastName = "Null String";
                }
            }
        }

        public string CustomerAddress 
        {
            get
            {
                return strCustomerAddress;
            }
            set
            {
                if (value != string.Empty)
                {
                    strCustomerAddress = value;
                }
                else
                {
                    strCustomerAddress = "Null String";
                }
            }
        }

        public string CustomerState
        {
            get
            {
                return strCustomerState;
            }
            set
            {
                if (value != string.Empty)
                {
                    strCustomerState = value;
                }
                else
                {
                    strCustomerState = "Null String";
                }
            }
        }

        public string CustomerCity 
        {
            get
            {
                return strCustomerCity;
            }
            set
            {
                if (value != string.Empty)
                {
                    strCustomerCity = value;
                }
                else
                {
                    strCustomerCity = "Null String";
                }
            }
        }
        public string CustomerZip 
        {
            get
            {
                return strCustomerZip;
            }
            set
            {
                if (value != string.Empty)
                {
                    strCustomerZip = value;
                }
                else
                {
                    strCustomerZip = "Null String";
                }
            }
        }
        public string CustomerPhoneNumber 
        {
            get
            {
                return strCustomerPhone;
            }
            set
            {
                if (value != string.Empty)
                {
                    strCustomerPhone = value;
                }
                else
                {
                    strCustomerPhone = "Null String";
                }
            }
        }

        public string CustomerEmail 
        {
            get
            {
                return strCustomerEmail;
            }
            set
            {
                if (value != string.Empty)
                {
                    strCustomerEmail = value;
                }
                else
                {
                    strCustomerEmail = "Null String";
                }
            }
        }

        /*
         Constructor
         */

        // default constructor
        public clsCustomer()
        {
            intCustomerID= 0;
            strCustomerFirstName = string.Empty;
            strCustomerLastName = string.Empty;
            strCustomerAddress = string.Empty;
            strCustomerCity = string.Empty;
            strCustomerState= string.Empty;
            strCustomerZip = string.Empty;  
            strCustomerPhone= string.Empty;
            strCustomerEmail= string.Empty;
        }

        // parameter based constructor
        public clsCustomer(int AintCustomerID, string AstrCusomerFirstName, string AstrCustomerLastName, string AstrCustomerAddress,
            string AstrCustomerCity, string AstrCustomerState, string AstrCustomerZip, string AstrCustomerPhone, string AstrCustomerEmail)
        { 
            intCustomerID= AintCustomerID;
            strCustomerFirstName = AstrCusomerFirstName; 
            strCustomerLastName = AstrCustomerLastName;
            strCustomerAddress= AstrCustomerAddress;
            strCustomerCity = AstrCustomerCity;
            strCustomerState= AstrCustomerState;
            strCustomerZip = AstrCustomerZip;
            strCustomerPhone = AstrCustomerPhone;
            strCustomerEmail = AstrCustomerEmail;
        }

    }
}
