using DespatchBay_DE.com.despatchbay.api.account;
using DespatchBay_DE.com.despatchbay.api.addressing;

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
using eBay.Service.Core.Sdk;
using eBay.Service.Call;
using eBay.Service.Core.Soap;
using eBay.Service.Util;

namespace DespatchBay_DE
{
    public partial class Form1 : Form
    {
        public SQLiteConnection sQLiteConnection;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DespatchBayAPI despatchBay = new DespatchBayAPI("D2KJX-C4B5F316", "82A7E251433E60C64AB1");
            AccountService MyAccountService = new AccountService();
            MyAccountService = despatchBay.AuthenticateWithDespatchBay(MyAccountService);

            AccountType MyAccount = new AccountType();
            MyAccount = MyAccountService.GetAccount();
            AccountBalanceType accountBalanceType = new AccountBalanceType();
            accountBalanceType = MyAccount.AccountBalance;
            Account accountRecord = new Account
            {
                AccountID = MyAccount.AccountID,
                AccountName = MyAccount.AccountName,
                Balance = accountBalanceType.Balance,
                AvailableBalance = accountBalanceType.AvailableBalance
            };

            toolStripAccountIDLabel.Text = "Account ID: " + MyAccount.AccountID.ToString();
            toolStripBalanceLabel.Text = "Balance: " + accountBalanceType.Balance.ToString() + "CR";
            toolStripAvailableBalanceLabel.Text = "Available Balance: " + accountBalanceType.AvailableBalance.ToString() + "CR";
            sQLiteConnection.Insert(accountRecord);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Create our local sqlite cache database
            string dbPath = System.IO.Path.Combine(
                    System.Environment.GetFolderPath(System.Environment.SpecialFolder.ApplicationData),
                    "DespatchBayCache.db3");
            sQLiteConnection = new SQLiteConnection(dbPath);
            sQLiteConnection.CreateTable<Account>();
            sQLiteConnection.CreateTable<SenderAddress>();
            sQLiteConnection.CreateTable<AddressService>();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ApiContext context = new ApiContext();

            //set the User token
            context.ApiCredential.eBayToken = "YOUR_TOKEN_HERE";



            //set the server url

            context.SoapApiServerUrl ="https://api.sandbox.ebay.com/wsapi";
        }
    }
}
