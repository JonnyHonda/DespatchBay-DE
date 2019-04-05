using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eBay.Service.Call;
using eBay.Service.Core.Sdk;
using eBay.Service.Core.Soap;
using eBay.Service.Util;

namespace DespatchBay_DE
{
    class Ebay
    {
    }
    public class AddFixedPriceItem
    {
        public void getSellerProfiles()
        {
            //create the context
            ApiContext context = new ApiContext();

            //set the User token
            context.ApiCredential.eBayToken = "AgAAAA**AQAAAA**aAAAAA**imCbXA**nY+sHZ2PrBmdj6wVnY+sEZ2PrA2dj6wFk4GkCZGKqQWdj6x9nY+seQ**UzUEAA**AAMAAA**MkSqad5luzLeJmNClKehjHdM+ldeDlfwYkDT4yV4I5vP2L19mrhH/FTgpJ007mmthRyAWTu9fwOAq8d7aCAVL+IQb+Aynt3NmgxJmHVruojV7fbOOkNjPCgLSUXeFIaTq+tlmr4ExLtiiArU2kFz60P2B8uVLREVDiyuYvLhZKdkNb1RADMSxGGjJBifrBCu2VgioR6tzoCKDn5FUm76FpTn6ghZ3LNgqpaNjLmXLaWFnDlGTmj2zVSfYDGVz3cFsrv8o+lA8FiqCc8v7ueSXeV0HoMt/k7+DAeeDGWpVstT91UjwgerZoPw/b2x9G7KfR6gfsgGBQ6f+YHqDeNy+4BOv++20BDiTPDD8Y7WsrmZBGY3ZCIIdBsfqVuwo6jyKHLAGnDwjGBEAsVZjCtW4Wn2j4LXzrAankErmPJn8rPmhg0MsyJ5nszkQO+JjZ5mR8BK2lYhXdhhTl/dB3+8ENZKiBnPYCV2+SZumof0j60NuFO3KoNy1bBic52aaR5XSYUIijKAXCXN2Q6sSu7TmLQ9KovV+kM8CDoIV4J0PoXQ/79HXK5POfefy+mJFzzMBCXiKHPYx7h0cwHbic2GgQXWcChf4mvLlLC5mPhHc3rAc3ujbSF1pFtRiXcrnWIshyYdC73GGk24cWmehvCwd6Edvv1BAZcNcbuHmXjlTbjRGkeC5ImlFgRH3CjbKhyByTGsc9PGrf99J1MqrfoEx/iHJMwL7Ka3inyK8dq4spOw8HWulvx5TOc7lsz+RLdc";
            //set the server url
            context.SoapApiServerUrl = "https://api.sandbox.ebay.com/wsapi";

            //enable logging
            context.ApiLogManager = new ApiLogManager();
            context.ApiLogManager.ApiLoggerList.Add(new FileLogger("log.txt", true, true, true));
            context.ApiLogManager.EnableLogging = true;

            //set the version
            context.Version = "1085";
            context.Site = SiteCodeType.UK;

        }
        public void AddFPItemCatalog()
        {


            //create the context
            ApiContext context = new ApiContext();

            //set the User token
            context.ApiCredential.eBayToken = "AgAAAA**AQAAAA**aAAAAA**imCbXA**nY+sHZ2PrBmdj6wVnY+sEZ2PrA2dj6wFk4GkCZGKqQWdj6x9nY+seQ**UzUEAA**AAMAAA**MkSqad5luzLeJmNClKehjHdM+ldeDlfwYkDT4yV4I5vP2L19mrhH/FTgpJ007mmthRyAWTu9fwOAq8d7aCAVL+IQb+Aynt3NmgxJmHVruojV7fbOOkNjPCgLSUXeFIaTq+tlmr4ExLtiiArU2kFz60P2B8uVLREVDiyuYvLhZKdkNb1RADMSxGGjJBifrBCu2VgioR6tzoCKDn5FUm76FpTn6ghZ3LNgqpaNjLmXLaWFnDlGTmj2zVSfYDGVz3cFsrv8o+lA8FiqCc8v7ueSXeV0HoMt/k7+DAeeDGWpVstT91UjwgerZoPw/b2x9G7KfR6gfsgGBQ6f+YHqDeNy+4BOv++20BDiTPDD8Y7WsrmZBGY3ZCIIdBsfqVuwo6jyKHLAGnDwjGBEAsVZjCtW4Wn2j4LXzrAankErmPJn8rPmhg0MsyJ5nszkQO+JjZ5mR8BK2lYhXdhhTl/dB3+8ENZKiBnPYCV2+SZumof0j60NuFO3KoNy1bBic52aaR5XSYUIijKAXCXN2Q6sSu7TmLQ9KovV+kM8CDoIV4J0PoXQ/79HXK5POfefy+mJFzzMBCXiKHPYx7h0cwHbic2GgQXWcChf4mvLlLC5mPhHc3rAc3ujbSF1pFtRiXcrnWIshyYdC73GGk24cWmehvCwd6Edvv1BAZcNcbuHmXjlTbjRGkeC5ImlFgRH3CjbKhyByTGsc9PGrf99J1MqrfoEx/iHJMwL7Ka3inyK8dq4spOw8HWulvx5TOc7lsz+RLdc";
            //set the server url
            context.SoapApiServerUrl = "https://api.sandbox.ebay.com/wsapi";

            //enable logging
            context.ApiLogManager = new ApiLogManager();
            context.ApiLogManager.ApiLoggerList.Add(new FileLogger("log.txt", true, true, true));
            context.ApiLogManager.EnableLogging = true;

            //set the version
            context.Version = "1085";
            context.Site = SiteCodeType.UK;

            string UPC = "753759090913"; //Garmin nuvi 1350 GPS
            string Brand = "Garmin";
            string MPN = "010-00782-20";

            //create the call object
            AddFixedPriceItemCall AddFPItemCall = new AddFixedPriceItemCall(context);

            AddFPItemCall.AutoSetItemUUID = true;

            //create an item object and set the properties
            ItemType item = new ItemType();

            //set the item condition depending on the value from GetCategoryFeatures
            item.ConditionID = 1000; //new

            //Basic properties of a listing
            item.Country = CountryCodeType.GB;
            item.Currency = CurrencyCodeType.GBP;

            //Track item by SKU
            item.InventoryTrackingMethod = InventoryTrackingMethodCodeType.SKU;
            item.SKU = "PROD1234";

            item.Description = "test - do not bid or buy";
            item.Title = "test - do not bid or buy";
            item.SubTitle = "Test Item";
            item.ListingDuration = "Days_7";

            item.PaymentMethods = new BuyerPaymentMethodCodeTypeCollection();
            item.PaymentMethods.Add(BuyerPaymentMethodCodeType.PayPal);
            item.PayPalEmailAddress = "test@test.com";
            item.PostalCode = "2001";

            //Specify Shipping Services
            item.DispatchTimeMax = 3;
            item.ShippingDetails = new ShippingDetailsType();
            item.ShippingDetails.ShippingServiceOptions = new ShippingServiceOptionsTypeCollection();

            ShippingServiceOptionsType shipservice1 = new ShippingServiceOptionsType();
            shipservice1.ShippingService = "UK_Parcelforce24";
            shipservice1.ShippingServicePriority = 1;
            shipservice1.ShippingServiceCost = new AmountType();
            shipservice1.ShippingServiceCost.currencyID = CurrencyCodeType.GBP;
            shipservice1.ShippingServiceCost.Value = 1.0;

            shipservice1.ShippingServiceAdditionalCost = new AmountType();
            shipservice1.ShippingServiceAdditionalCost.currencyID = CurrencyCodeType.GBP;
            shipservice1.ShippingServiceAdditionalCost.Value = 1.0;

            item.ShippingDetails.ShippingServiceOptions.Add(shipservice1);

            ShippingServiceOptionsType shipservice2 = new ShippingServiceOptionsType();
            shipservice2.ShippingService = "UK_Parcelforce48";
            shipservice2.ShippingServicePriority = 2;
            shipservice2.ShippingServiceCost = new AmountType();
            shipservice2.ShippingServiceCost.currencyID = CurrencyCodeType.GBP;
            shipservice2.ShippingServiceCost.Value = 4.0;

            shipservice2.ShippingServiceAdditionalCost = new AmountType();
            shipservice2.ShippingServiceAdditionalCost.currencyID = CurrencyCodeType.GBP;
            shipservice2.ShippingServiceAdditionalCost.Value = 1.0;

            item.ShippingDetails.ShippingServiceOptions.Add(shipservice2);

            //Specify Return Policy
            item.ReturnPolicy = new ReturnPolicyType();
            item.ReturnPolicy.ReturnsAcceptedOption = "ReturnsAccepted";

            item.Quantity = 10;
            item.StartPrice = new AmountType();
            item.StartPrice.currencyID = CurrencyCodeType.GBP;
            item.StartPrice.Value = 10;

            item.PrimaryCategory = new CategoryType();
            item.PrimaryCategory.CategoryID = "184797"; 

            item.ProductListingDetails = new ProductListingDetailsType();

            //Specifying UPC as the product identifier. Other applicable product identifiers
            //include ISBN, EAN, Brand-MPN.

            item.ProductListingDetails.UPC = UPC;

            //If multiple product identifiers are specified, eBay uses the first one that
            //matches a product in eBay's catalog system.
            item.ProductListingDetails.BrandMPN = new BrandMPNType();
            item.ProductListingDetails.BrandMPN.Brand = Brand;
            item.ProductListingDetails.BrandMPN.MPN = MPN;

            //For listing to be pre-filled with product information from the catalog
            item.ProductListingDetails.IncludePrefilledItemInformation = true;

            //Include the eBay stock photo with the listing if available and use it as the gallery picture
            item.ProductListingDetails.IncludeStockPhotoURL = true;
            item.ProductListingDetails.UseStockPhotoURLAsGallery = true;
            item.ProductListingDetails.UseStockPhotoURLAsGallerySpecified = true;

            //If multiple prod matches found, list the item with the 1st product's information
            item.ProductListingDetails.UseFirstProduct = true;
            // List the item even if no product match found
            item.ProductListingDetails.ListIfNoProduct = true;

            //Add pictures
            item.PictureDetails = new PictureDetailsType();

            //Specify GalleryType
            item.PictureDetails.GalleryType = GalleryTypeCodeType.None;
            item.PictureDetails.GalleryTypeSpecified = true;

            AddFPItemCall.Item = item;

            //set the item and make the call
            AddFPItemCall.Execute();

            Console.WriteLine(AddFPItemCall.ApiResponse.Ack + " " + AddFPItemCall.ApiResponse.ItemID);

        }
    }
}
