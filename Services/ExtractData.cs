using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GiftCalculator.Services
{
    public class ExtractData
    {
        public object FetchMeTheData(string SupportOffice)
        {
            if (SupportOffice == "" || SupportOffice.Trim().Length == 0)
            {
                return "No Data Avaialble";
            }

            if (SupportOffice == "Australia")
            {
                //Code to fetch data from Autralian Database
            }
            else if (SupportOffice == "USA")
            {
                //Code to fetch data from USA APIs
            }
            else if (SupportOffice == "CANADA")
            {
                //Code to fetch data from CANADA NoSQL DB
            }
            else if (SupportOffice == "UK")
            {
                //Code to fetch data from UK APIs
            }
            else if (SupportOffice == "NZ")
            {
                //Code to fetch data from NZ Database
            }

            return "Country not found";
        }
    }
}
