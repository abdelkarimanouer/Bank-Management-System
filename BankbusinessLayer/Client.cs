using BankDataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankbusinessLayer
{
    public class clsClient
    {
        public string AccountNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public double Balance { get; set; }

        enum enMode { AddNew = 0, Update = 1 };
        enMode _Mode;

        private bool _AddNewClient()
        {
            return (clsClientData.AddNewClient(this.AccountNumber, this.FirstName, this.LastName, this.Email, this.Phone, this.Password, this.Balance)) ;
        }

        private bool _UpdateClient()
        {
            return (clsClientData.UpdateClient(this.AccountNumber, this.FirstName, this.LastName, this.Email, this.Phone, this.Password, this.Balance));
        }

        public static clsClient FindClientByAccountNumber(string AccountNumber)
        {
            string firstname = null, lastname = null, email = null, phone = null, password = null;
            double balance = 0;

            if (clsClientData.GetInfoClient(AccountNumber, ref firstname, ref lastname, ref email, ref phone, ref password, ref balance))
            {
                return new clsClient(AccountNumber, firstname, lastname, email, phone, password, balance);
            }
            else
            {
                return null;
            }
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    return _AddNewClient();

                case enMode.Update:
                    return _UpdateClient();
            }

            return false;
        }

        public static bool DeleteClient(string AccountNumber)
        {
            return clsClientData.DeleteClient(AccountNumber);
        }

        public static DataTable GetAllClients()
        {
            return clsClientData.GetListsClient();
        }

        public bool Deposite(double Amount)
        {
            this.Balance += Amount;
            return _UpdateClient();
        }

        public bool Withraw(double Amount)
        {
            

            if (Amount <= this.Balance)
            {
                this.Balance -= Amount;
                return _UpdateClient();
            }
            else
            {
                return false;
            }

        }

        public bool Transfer(string ReceiverAccountNumber, double Amount)
        {
            this.Withraw(Amount);

            clsClient Receiverclient = FindClientByAccountNumber(ReceiverAccountNumber);

            if (ReceiverAccountNumber != null)
            {
                Receiverclient.Deposite(Amount);

                this._UpdateClient();
                Receiverclient._UpdateClient();
                return true;
            }
            return false;

        }

        public bool TransferLog(string ReceiverAccountNumber, double Amount, string username)
        {
            clsClient Receiverclient = FindClientByAccountNumber(ReceiverAccountNumber);

            return clsClientData.SaveTransferLog(this.AccountNumber, Receiverclient.AccountNumber, this.Balance, Receiverclient.Balance, Amount, username);

        }

        public static DataTable GetListsTransferLog()
        {
            return clsClientData.GetListsTransferLog();
        }


        public clsClient() 
        {
            this.AccountNumber = string.Empty;
            this.FirstName = string.Empty;
            this.LastName = string.Empty;
            this.Email = string.Empty;
            this.Phone = string.Empty;
            this.Password = string.Empty;
            this.Balance = 0;

            _Mode = enMode.AddNew;

        }

        private clsClient(string accountnumber, string firstname, string lastname, string email, string phone, string password, double balance)
        {
            this.AccountNumber = accountnumber;
            this.FirstName = firstname;
            this.LastName = lastname;
            this.Email = email;
            this.Phone = phone;
            this.Password = password;
            this.Balance = balance;

            _Mode = enMode.Update;
        }

    }
}
