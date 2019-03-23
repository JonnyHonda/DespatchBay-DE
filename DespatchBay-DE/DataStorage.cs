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

        public override string ToString()
        {
            return string.Format("[Account: ID={0}, AccountID={1}, AccountName={2}, Balance={3}, AvailableBalance={4}]", ID, AccountID, AccountName, Balance, AvailableBalance);
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
        public int SenderAddressID { get; set; } // the sender drress id in despatch bay
        public int AddressID { get; set; } // our internal id of the address
        public string SenderName { get; set; }
        public string SenderTelephone { get; set; }
        public string SenderEmail { get; set; }

        public override string ToString()
        {
            return string.Format("[SenderAddress: ID={0}, ExternalID={1}, SenderAddressID={2}, AddressID={3}, SenderName={4}, SenderTelephone={5},  SenderEmail={6}]", ID, ExternalID, SenderAddressID, AddressID, SenderName, SenderTelephone, SenderEmail);
        }
    }

    /// <summary>
    /// Address
    /// </summary>
    public class AddressService
    {
        [PrimaryKey]
        [AutoIncrement]
        public int ID { get; set; } // an auto increment data base ID
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

}