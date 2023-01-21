/// Class Name: clsCustomerDA
/// Purpose: A container to hold methods that can provide data access
/// Change Log: B.Grant 1/20/2023

using Brent_Csharp_WPF.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Connection to database
using System.Data.OleDb;

namespace Brent_Csharp_WPF.DataAccess
{
    internal class clsCustomerDA
    {
        // B.Grant - 1/19/2023 - Created the structure of the method 
        /*
         * Method Name: GetRecords
         * Parameter: Nothing
         * Return: All the records of this entity - Dataset
         * Change Log: B.Grant 1/20/203
         */
        public static DataSet GetRecords() 
        {
            
        }
        public static int DeleteRecord(string aPrimaryKey) 
        {

        }

        public static int AddRecord(clsCustomer aCustomer) 
        {

        }

        public static int UpdateRecord(clsCustomer aCustomer) 
        {

        }

    }
}
