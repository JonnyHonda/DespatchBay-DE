using DespatchBay_DE.com.despatchbay.api.account;
using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DespatchBay_DE
{
    public partial class Form_API_Preferences : Form
    {
        public Form_API_Preferences()
        {
            InitializeComponent();
        }

        private void Form_API_Preferences_Load(object sender, EventArgs e)
        {
            // Create our local sqlite cache database
            SQLiteConnection sQLiteConnection;
            string dbPath = System.IO.Path.Combine(
                    System.Environment.GetFolderPath(System.Environment.SpecialFolder.ApplicationData),
                    "DespatchBayCache.db3");
            sQLiteConnection = new SQLiteConnection(dbPath);
            List<DespatchBayCredentials> credentials = 
                sQLiteConnection.Query<DespatchBayCredentials>("SELECT * FROM DespatchBayCredentials WHERE `IsEnabled`= 1 ORDER BY `UpdatedDateTime` DESC LIMIT 1");
            foreach (var latestCreds in credentials)
            {
                txt_ApiUser.Text = latestCreds.ApiUser;
                txt_ApiKey.Text = latestCreds.ApiKey;
            }
            
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


        private void btn_Save_Click(object sender, EventArgs e)
        {
            SQLiteConnection sQLiteConnection;
            string dbPath = System.IO.Path.Combine(
                    System.Environment.GetFolderPath(System.Environment.SpecialFolder.ApplicationData),
                    "DespatchBayCache.db3");
            sQLiteConnection = new SQLiteConnection(dbPath);
            DespatchBayCredentials Creds = new DespatchBayCredentials();
            Creds.ApiUser = txt_ApiUser.Text;
            Creds.ApiKey = txt_ApiKey.Text;
            Creds.IsEnabled = true;
            Creds.CreatedDateTime = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss");
            Creds.UpdatedDateTime = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss");
            try
            {
                sQLiteConnection.Insert(Creds);
               MessageBox.Show("New credentials saved");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.DialogResult = DialogResult.Abort;
            }
        }

        private void btn_Test_Click(object sender, EventArgs e)
        {
            DespatchBayAPI despatchBay = new DespatchBayAPI(txt_ApiUser.Text, txt_ApiKey.Text);
            AccountService MyAccountService = new AccountService();
            MyAccountService = despatchBay.AuthenticateWithDespatchBay(MyAccountService);

            

            string message= "Successfully Connected";
            try
            {
                AccountType MyAccount = new AccountType();
                MyAccount = MyAccountService.GetAccount();
            }
            catch
            {
                message = "Connection Failed";
            }
            MessageBox.Show(message);
        }
    }
}
