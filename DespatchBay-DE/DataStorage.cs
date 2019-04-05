using SQLite;

/// <summary>
/// This storage class is only to be used for offline storage of the API results to reduce the amount of calls require to the despatch bay systems. 
/// </summary>
namespace DespatchBay_DE
{
    class DataStorage
    {
    }

    /// <summary>
    /// Account.
    /// </summary>
    public class Account
    {
        [PrimaryKey]
        [AutoIncrement]
        public int ID { get; set; } // an auto increment data base ID

        public int AccountID { get; set; } // the Client account ID as stored in Despatch Bay 
        public string AccountName { get; set; }
        public double Balance { get; set; }
        public double AvailableBalance { get; set; }
        public string CreatedDateTime { get; set; }
        public string UpdatedDateTime { get; set; }

        public override string ToString()
        {
            return string.Format("[Account: ID={0}, AccountID={1}, AccountName={2}, Balance={3}, AvailableBalance={4}, CreatedDateTime={5}, UpdatedDateTime={6}]", ID, AccountID, AccountName, Balance, AvailableBalance, CreatedDateTime, UpdatedDateTime);
        }

    }

    /// <summary>
    /// SenderAddress
    /// </summary>
    public class SenderAddress
    {
        [PrimaryKey]
        [AutoIncrement]
        public int ID { get; set; } // an auto increment data base ID
        public int ExternalID { get; set; } // the id as storded in the external system
       // public int SenderAddressID { get; set; } // the sender drress id in despatch bay
       // public int AddressID { get; set; } // our internal id of the address
        public string SenderName { get; set; }
        public string SenderTelephone { get; set; }
        public string SenderEmail { get; set; }

        public override string ToString()
        {
            return string.Format("[SenderAddress: ID={0}, ExternalID={1}, SenderName={2}, SenderTelephone={3},  SenderEmail={4}]", ID, ExternalID, SenderName, SenderTelephone, SenderEmail);
        }
    }

    /// <summary>
    /// Address
    /// </summary>
    public class AddressService
    {
        [PrimaryKey]
        public int ID { get; set; } // an auto increment data base ID - the External ID in SenderAddress
        public string CompanyName { get; set; }
        public string Street { get; set; }
        public string Locality { get; set; }
        public string TownCity { get; set; }
        public string County { get; set; }
        public string PostalCode { get; set; }
        public string CountryCode { get; set; }
        public override string ToString()
        {
            return string.Format("[Address: ID={0}, CompanyName={1}, Street={2}, Locality={3}, TownCity={4}, County={5}, PostalCode={6}, CountryCode={6}]", ID, CompanyName, Street, Locality, TownCity, County, PostalCode, CountryCode);
        }
    }

    public class DespatchBayCredentials{
        [PrimaryKey]
        [AutoIncrement]
        public int ID { get; set; } // an auto increment data base ID
        public string ApiUser { get; set; }
        public string ApiKey { get; set; }
        public bool IsEnabled { get; set; }
        public string CreatedDateTime { get; set; }
        public string UpdatedDateTime { get; set; }

        public override string ToString()
        {
            return string.Format("[DespatchBayCredentials: ID={0}, ApiUser={1}, ApiKey={2}, IsEnabled={3}, CreatedDateTime={4}, UpdatedDateTime={5}]", ID, ApiUser, ApiKey, IsEnabled, CreatedDateTime, UpdatedDateTime);
        }
    }


    public class Service
    {
        [PrimaryKey]
        [AutoIncrement]
        public int ID { get; set; } // an auto increment data base ID

        [Unique]
        public int ServiceID { get; set; }
        public string Format { get; set; }
        public string Name { get; set; }
        public double Cost { get; set; }
        public string CourierID { get; set; } // ID Courier in this database and Despatch BAY
        public string CreatedDateTime { get; set; }
        public string UpdatedDateTime { get; set; }

        public override string ToString()
        {
            return string.Format("[Service: ID={0}, ServiceID={1}, Format={2}, Name={3}, Cost={4}, CourierID={5}, CreatedDateTime={6}, UpdatedDateTime={7}]", ID, ServiceID, Format, Name, Cost, CourierID, CreatedDateTime, UpdatedDateTime);
        }
    }

    public class Courier
    {
        [PrimaryKey]
        [Unique]
        // public int ID { get; set; } // an auto increment database ID
        public string CourierID { get; set; } // the ID in DespatchBay
        public string CourierName { get; set; }
        public string CreatedDateTime { get; set; }
        public string UpdatedDateTime { get; set; }
    }
}