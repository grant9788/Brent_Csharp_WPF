/// Class Name: clsCustomer
/// Purpose: A container to hold all attributes and methods in a class 
/// Change Log: B.Grant 1/18/2023

using Brent_Csharp_WPF.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
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

        /*
         Property methods - getters and setters
         */

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

        /*
         Class Methods
         */

        /*
         * Method Name: classInfo
         * Purpose: To obtain all the records from the database for this enity
         * Parameter: None
         * Return: All the records for this entity - DataSet
         * Change Log: B.Grant 1/19/2023
         */

        public string classInfo() 
        {
            return "customer ID =" + CustomerID + "\r" + "customer First Name: " + CustomerFirstName + "\r" + "customer Last Name: " + CustomerLastName + "\r" + "customer Address: " + CustomerAddress + "\r" +
                "customer City: " + CustomerCity + "\r" + "customer State: " + CustomerState + "\r" + "customer Zip: " + CustomerZip + "\r" + "customer Phone: " + CustomerPhoneNumber + "\r" + "customer Email: " + CustomerEmail + "\r" + "\r";
        }

        /*
         Method Name: GetRecords
         Purpose: To obtain all the records from the database for this entity
         Parameter: None
         Return: All the records for this entity - Dataset
         Change Log: B.Grant 1/19/2023
         */

        public static DataSet GetRecords()
        {
            try
            {
                return clsCustomerDA.GetRecords(); // This is coming for the clsCustomerDA method of GetRecords
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error occurred in Class: clsCustomer. Method: GetRecords().Error: " + ex.Message);
                return null; //Error Possible but still need to code out clsCustomerDA
            }
        }

        /*
         Method Name: DeleteRecords
         Purpose: To obtain all the records from the database for this entity
         Parameter: Primary Key - String
         Return: Result (number of rows affected) - Integer
         Change Log: B.Grant 1/19/2023
         */

        public static int DeleteRecord(string aPrimaryKey) 
        {
            try
            {
                return clsCustomerDA.DeleteRecord(aPrimaryKey);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error occurred in Class: clsCustomer. Method: DeleteRecord(String). Error: " + ex.Message);
                return -9;
            }
        }

        /*
         Method Name: AddRecords
         Purpose: To obtain all the records from the database for this entity
         Parameter: Object (customer) - clsCustomer
         Return: Result (number of rows affected) - Integer
         Change Log: B.Grant 1/19/2023
         */

        public static int AddRecord(clsCustomer aCustomer) 
        {
            try
            {
                return clsCustomerDA.AddRecord(aCustomer);
            }
            catch (Exception)
            {

                return -9;
            }
        }

        /*
         Method Name: UpdateRecords
         Purpose: To obtain all the records from the database for this entity
         Parameter: Object (customer) - clsCustomer
         Return: Result (number of rows affected) - Integer
         Change Log: B.Grant 1/19/2023
         */

        public static int UpdateRecord(clsCustomer aCustomer) 
        {
            try
            {
                return clsCustomerDA.UpdateRecord(aCustomer);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred in Class: clsCustomer. Method: UpdateRecored(Object). Error: " + ex.Message);
                return -9;
            }
        }
    }

}
