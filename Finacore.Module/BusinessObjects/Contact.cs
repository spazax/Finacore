using System;
using System.Linq;
using System.Text;
using DevExpress.Xpo;
using DevExpress.ExpressApp;
using System.ComponentModel;
using DevExpress.ExpressApp.DC;
using DevExpress.Data.Filtering;
using DevExpress.Persistent.Base;
using System.Collections.Generic;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;

namespace Finacore.Module.BusinessObjects
{
    [DomainComponent, DefaultClassOptions, ImageName("BO_Contact")]
       public class Contact : XPObject
    {
        [PersistentAlias(@"[City] +'  '+ [Address]+'  '+[State]")]

        public string FullAddress
        {
            get { return (string)(EvaluateAlias("FullAddress")); }
        }

        private string _city;
        private string _address;
        private string _state;

        public string Address
        {
            get { return _address; }
            set { SetPropertyValue("Address", ref _address, value); }
        }

        public string State
        {
            get { return _state; }
            set { SetPropertyValue("State", ref _state, value); }



        }

        private Customer customer;

        [Association("Customer-Contact")]
         public Customer Customer
        {
            get { return customer; }
           set { SetPropertyValue("Customer", ref customer, value); }
         }
        //  [Association ("Customer-Contact")]
        //  public XPCollection<Customer> Customer
        // {
        //   get
        //   {
        //      return GetCollection<Customer>("Customer");
        //  }
        // }

        public string City
        {
            get { return _city; }
            set { SetPropertyValue("City", ref _city, value); }
        }

        public Contact(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            
        }
       
    }
}