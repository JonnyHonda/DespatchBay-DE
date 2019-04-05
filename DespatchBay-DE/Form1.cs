using DespatchBay_DE.com.despatchbay.api.account;
using DespatchBay_DE.com.despatchbay.api.addressing;

using eBay.Service.Core.Sdk;
using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DespatchBay_DE
{
    public partial class Form1 : Form
    {
        public SQLiteConnection sQLiteConnection;
        public Dictionary<string, int> AddressLookupList = new Dictionary<string, int>();
        public Form1()
        {
            InitializeComponent();
            BuildApplicationCache();
        }

        /// <summary>
        /// This function connects to DespatchBay and pulls regularily used data and stores it in sqlite 
        /// </summary>
        public void BuildApplicationCache()
        {
            // Create our local sqlite cache database
            SQLiteConnection sQLiteConnection;
            string ApiUser = "";
            string ApiKey = "";
            string dbPath = System.IO.Path.Combine(
                    System.Environment.GetFolderPath(System.Environment.SpecialFolder.ApplicationData),
                    "DespatchBayCache.db3");
            sQLiteConnection = new SQLiteConnection(dbPath);
            sQLiteConnection.CreateTable<Account>();
            sQLiteConnection.DeleteAll<Account>();

            sQLiteConnection.CreateTable<SenderAddress>();
            sQLiteConnection.DeleteAll<SenderAddress>();

            sQLiteConnection.CreateTable<AddressService>();
            sQLiteConnection.DeleteAll<AddressService>();

            sQLiteConnection.CreateTable<DespatchBayCredentials>();

            sQLiteConnection.CreateTable<Service>();
            sQLiteConnection.DeleteAll<Service>();

            sQLiteConnection.CreateTable<Courier>();
            sQLiteConnection.DeleteAll<Courier>();
            List<DespatchBayCredentials> credentials =
                sQLiteConnection.Query<DespatchBayCredentials>("SELECT * FROM DespatchBayCredentials WHERE `IsEnabled`= 1 ORDER BY `UpdatedDateTime` DESC LIMIT 1");
            if (credentials.Count == 1)
            {
                foreach (var latestCreds in credentials)
                {
                    ApiUser = latestCreds.ApiUser;
                    ApiKey = latestCreds.ApiKey;
                }
            }
            else
            {
                MessageBox.Show("No valid credentials saved");
                return;
            }
            AccountService MyAccountService = new AccountService();
            DespatchBayAPI despatchBay = new DespatchBayAPI(ApiUser, ApiKey);
            MyAccountService = despatchBay.AuthenticateWithDespatchBay(MyAccountService);

            AccountType MyAccount = new AccountType();
            try
            {
                // Fetch an populate account table
                MyAccount = MyAccountService.GetAccount();
                AccountBalanceType accountBalanceType = new AccountBalanceType();
                accountBalanceType = MyAccount.AccountBalance;
                Account accountRecord = new Account
                {
                    AccountID = MyAccount.AccountID,
                    AccountName = MyAccount.AccountName,
                    Balance = accountBalanceType.Balance,
                    AvailableBalance = accountBalanceType.AvailableBalance,
                    CreatedDateTime = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss"),
                    UpdatedDateTime = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss")
                };
                sQLiteConnection.Insert(accountRecord);
                // Update tool strip
                toolStripAccountIDLabel.Text = "Account ID: " + MyAccount.AccountID.ToString();
                toolStripBalanceLabel.Text = "Balance: " + accountBalanceType.Balance.ToString() + "CR";
                toolStripAvailableBalanceLabel.Text = "Available Balance: " + accountBalanceType.AvailableBalance.ToString() + "CR";

                // Fetch and populate Sender Addresses
                SenderAddressType[] SenderAddresses = new SenderAddressType[] { };
                SenderAddresses = MyAccountService.GetSenderAddresses();
                SenderAddress senderAddressRecord = new SenderAddress();
                foreach (var addressDetail in SenderAddresses)
                {
                    senderAddressRecord.ExternalID = addressDetail.SenderAddressID;
                    senderAddressRecord.SenderEmail = addressDetail.SenderEmail;
                    senderAddressRecord.SenderName = addressDetail.SenderName;
                    senderAddressRecord.SenderTelephone = addressDetail.SenderTelephone;
                    com.despatchbay.api.account.AddressType address = new com.despatchbay.api.account.AddressType();
                    address = addressDetail.SenderAddress;
                    AddressService addressRecord = new AddressService();
                    addressRecord.CompanyName = address.CompanyName;
                    addressRecord.CountryCode = address.CountryCode;
                    addressRecord.County = address.County;
                    addressRecord.Locality = address.Locality;
                    addressRecord.PostalCode = address.PostalCode;
                    addressRecord.Street = address.Street;
                    addressRecord.TownCity = address.Street;
                    addressRecord.ID = senderAddressRecord.ExternalID;
                    sQLiteConnection.Insert(addressRecord);
                    sQLiteConnection.Insert(senderAddressRecord);

                }

                // Fetch and populate Services
                ServiceType[] Services = new ServiceType[] { };
                Services = MyAccountService.GetServices();
                Service serviceRecord = new Service();

                foreach (var service in Services)
                {
                    serviceRecord.ServiceID = service.ServiceID;
                    serviceRecord.Format = service.Format;
                    serviceRecord.Name = service.Name;
                    serviceRecord.Cost = service.Cost;
                    //  serviceRecord.CourierID = service.Courier;
                    CourierType courier = new CourierType();
                    courier = service.Courier;
                    serviceRecord.CourierID = courier.CourierID;
                    try
                    {
                        Courier courierRecord = new Courier();
                        courierRecord.CourierID = courier.CourierID;
                        courierRecord.CourierName = courier.CourierName;
                        courierRecord.CreatedDateTime = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss");
                        courierRecord.UpdatedDateTime = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss");
                        sQLiteConnection.Insert(courierRecord);
                    }
                    catch { }


                    serviceRecord.CreatedDateTime = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss");
                    serviceRecord.UpdatedDateTime = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss");
                    sQLiteConnection.Insert(serviceRecord);
                }


            }
            catch { MessageBox.Show("Connection Error - Check credentials and try again"); }



        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string dbPath = System.IO.Path.Combine(
                    System.Environment.GetFolderPath(System.Environment.SpecialFolder.ApplicationData),
                    "DespatchBayCache.db3");
            sQLiteConnection = new SQLiteConnection(dbPath);
            
            List <SenderAddress> senderAddresses = sQLiteConnection.Query<SenderAddress>("SELECT ID,SenderName from SenderAddress");
            SenderAddress.DataSource = senderAddresses;
            SenderAddress.DisplayMember = "SenderName";
            SenderAddress.ValueMember = "ID";
           

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void despatchBayCredentialsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowPreferencesDialogBox();
        }

        public void ShowPreferencesDialogBox()
        {
            Form_API_Preferences PreferencesDialog = new Form_API_Preferences();

            // Show testDialog as a modal dialog and determine if DialogResult = OK.
            if (PreferencesDialog.ShowDialog(this) == DialogResult.OK)
            {
                BuildApplicationCache();

            }
            else
            {
                //this.txtResult.Text = "Cancelled";
                //MessageBox.Show("Save failed");
            }

            PreferencesDialog.Dispose();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void SenderAddress_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = this.SenderAddress.SelectedValue;
            string dbPath = System.IO.Path.Combine(
                    System.Environment.GetFolderPath(System.Environment.SpecialFolder.ApplicationData),
                    "DespatchBayCache.db3");
            sQLiteConnection = new SQLiteConnection(dbPath);
            List<SenderAddress> senderAddresses = sQLiteConnection.Query<SenderAddress>("SELECT * from SenderAddress WHERE ID = ? LIMIT 1", index);
            foreach (var address in senderAddresses) {
                txt_SenderName.Text = address.SenderName;
                txt_SenderEmail.Text = address.SenderEmail;
                txt_SenderTelephone.Text = address.SenderTelephone;
                    }
        }

        private void SenderAddress_Click(object sender, EventArgs e)
        {
            
        }
    }
}
