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
    [DomainComponent, DefaultClassOptions]
    
      public class Account : BaseObject
    {

        private int _AccNo;
        private string _AccName;

        public string AccName
        {
            get { return _AccName; }

            set { SetPropertyValue("AccountName", ref _AccName, value); }
        }

        public int AccountNo
        {
            get { return _AccNo; }
            set { SetPropertyValue("AccountNo", ref _AccNo, value); }

        }

        private Customer customer;

        [Association("Customer-Account")]
        public Customer Customer
        {
            get { return customer; }
            set { SetPropertyValue("Customer", ref customer, value); }
        }

        [Association("FinancialTransaction-Account")]
        public XPCollection<FinancialTransaction> FinancialTransaction
        {
            get
            {
                return GetCollection<FinancialTransaction>("FinancialTransaction");
            }
        }

        public Account(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();

        }
       
    }
}