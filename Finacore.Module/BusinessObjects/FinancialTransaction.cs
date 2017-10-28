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
    [System.ComponentModel.DefaultProperty("Account")]
    public class FinancialTransaction : Account
    {
        private Account _Account;
        [Association("FinancialTransaction-Account")]
        public Account Account
        {
            get { return Account; }
            set { SetPropertyValue("Account", ref _Account, value); }
        }

        public FinancialTransaction(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
         
        }
        
    }
}