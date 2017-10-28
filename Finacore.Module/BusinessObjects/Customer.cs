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
   
    public class Customer : BaseObject


    {
        private int _id;
        public int Id { get { return _id; }

        protected set { SetPropertyValue("Id", ref _id, value); } }

        private  int _idno ;
        public int IdNo {
            get { return _idno; }
            set { SetPropertyValue("IdNo", ref _idno, value); }
        }
        [PersistentAlias(@"[FirstName] +'  '+ [MiddleName]+'  '+[LastName]")]

        public string FullName
         {
             get { return (string)(EvaluateAlias("FullName")); }
         }
        private string _firstname;
        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string FirstName
        {
            get { return _firstname; }
            set { SetPropertyValue("FirstName", ref _firstname, value); }
        }
        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        private string _middlename;
        public string MiddleName { get { return _middlename; }
            set { SetPropertyValue("MiddleName", ref _middlename, value); }
        }

        private string _lastname;
        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string LastName
        {
            get { return _lastname; }
            set { SetPropertyValue("LastName", ref _lastname, value); }
        }
      
      

       
      
        public int PhoneNo { get; set; }

        [ImageEditor(ListViewImageEditorCustomHeight = 75, DetailViewImageEditorFixedHeight = 150)]
        public byte[] Photo { get; set; }




        [Association("Customer-LoanContract")]
        public XPCollection<LoanContract> LoanContract
        {
            get
            {
                return GetCollection<LoanContract>("LoanContract");
            }
        }



        [Association("Customer-Account")]
        public XPCollection<Account> Account
        {
            get
            {
                return GetCollection<Account>("Account");
            }
        }
        [Association("Customer-Contact")]
        public XPCollection<Contact> Contact
        {
            get
            {
                return GetCollection<Contact>("Contact");
            }
        }




        public Customer(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
           
        }
       
    }
}