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
using DevExpress.Xpo.Metadata;

namespace Finacore.Module.BusinessObjects
{
    [DomainComponent, DefaultClassOptions]
    
    public class LoanContract : XPObject
    {

        private DateTime _contractDateStart;
        private DateTime _contractDateEnd;
        private decimal _loanAmount;
        private int _MonthlyRepayent;

        public decimal LoanAmmount
        {
            get { return _loanAmount; }
            set { SetPropertyValue("LoanAmmount", ref _loanAmount, value); }
        }


        public int MonthlyRepayment
        {
            get { return _MonthlyRepayent; }
            set { SetPropertyValue("MonthlyRepayment", ref _MonthlyRepayent, value); }
        }

        public DateTime ContractDateEnd
        {
            get { return _contractDateEnd; }
            set { SetPropertyValue("ContractDateEnd", ref _contractDateEnd, value); }
        }
        public DateTime ContractDateStart
        {
            get { return _contractDateStart; }
            set { SetPropertyValue("ContractStartDate", ref _contractDateStart, value); }
        }

        private decimal _loanAmountdue;

        public decimal LoanAmountDue
        {
            get { return _loanAmountdue; }
            set { SetPropertyValue("LoanAmountDue", ref _loanAmountdue, value); }
        }



        private Customer customer;

        [Association("Customer-LoanContract")]
        public Customer Customer
        {
            get { return customer; }
            set { SetPropertyValue("Customer", ref customer, value); }
        }

        public LoanContract(Session session)
            : base(session)
        {
        }

        protected LoanContract()
        {
        }

        protected LoanContract(Session session, XPClassInfo classInfo) : base(session, classInfo)
        {
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
          
        }
        
        
    }
}