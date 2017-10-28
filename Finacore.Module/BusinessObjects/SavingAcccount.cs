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
    [DefaultClassOptions]
   
    public class SavingAcccount : Account
    {
        private string _AccountDescription;

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string AccountDescription
        {
            get { return _AccountDescription;}
            set { SetPropertyValue("AccountDescription", ref _AccountDescription, value); }
        }
        public SavingAcccount(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
          
        }
        
    }
}