using DespatchBay_DE.com.despatchbay.api.account;
using DespatchBay_DE.com.despatchbay.api.addressing;
using DespatchBay_DE.com.despatchbay.api.shipping;
using DespatchBay_DE.com.despatchbay.api.tracking;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DespatchBay_DE
{

    class DespatchBayAPI
    {
        private  NetworkCredential netCredential = null;
        public DespatchBayAPI(string apiuser, string apikey)
        {
            netCredential = new NetworkCredential(apiuser, apikey);
        }

        public AccountService AuthenticateWithDespatchBay(AccountService Service)
        {
            // Create the service of type Shipping service

            Service.RequestEncoding = System.Text.Encoding.UTF8;
            Uri uri = new Uri(Service.Url);
            ICredentials credentials = SetAuthType(uri);
            // Apply the credentials to the service
            Service.Credentials = credentials;
            return Service;
        }


        public AddressingService AuthenticateWithDespatchBay(AddressingService Service)
        {
            // Create the service of type Shipping service

            Service.RequestEncoding = System.Text.Encoding.UTF8;
            Uri uri = new Uri(Service.Url);
            ICredentials credentials = SetAuthType(uri);
            // Apply the credentials to the service
            Service.Credentials = credentials;
            return Service;
        }

        public ShippingService AuthenticateWithDespatchBay(ShippingService Service)
        {
            // Create the service of type Shipping service

            Service.RequestEncoding = System.Text.Encoding.UTF8;
            Uri uri = new Uri(Service.Url);
            ICredentials credentials = SetAuthType(uri);
            // Apply the credentials to the service
            Service.Credentials = credentials;
            return Service;
        }

        public TrackingService AuthenticateWithDespatchBay(TrackingService Service)
        {
            // Create the service of type Shipping service

            Service.RequestEncoding = System.Text.Encoding.UTF8;
            Uri uri = new Uri(Service.Url);
            ICredentials credentials = SetAuthType(uri);
            // Apply the credentials to the service
            Service.Credentials = credentials;
            return Service;
        }

        private ICredentials SetAuthType(Uri uri)
        {
            return netCredential.GetCredential(uri, "Basic");
        }

    }


}
