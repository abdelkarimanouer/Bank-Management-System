using BankDataAccess;
using System.Data;


namespace BankbusinessLayer
{
    public class clsUser
    {
        
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public int Permissions { get; set; }


        public static int _PermissionsToCheck = 0;

        enum enMode { AddNew = 0, Update = 1 };
        enMode _Mode;

        public enum enPermissions
        {
            enAll = -1,
            enClientsList = 1, enAddClient = 2, enDeleteClient = 4, enFindClient = 8, enUpdateClient = 16,
            enUsersList = 32, enAddUser = 64, enDeleteUser = 128, enFindUser = 256, enUpdateUser = 512,
            enDeposite = 1024, enWithraw = 2048, enTotalBalances = 4096, enTransfer = 8192, enTransferLog = 16384,
        };

        private bool _AddNewUser()
        {
            return (clsUserData.AddNewUser(this.UserName, this.FirstName, this.LastName, this.Email, this.Phone, this.Password, this.Permissions));
        }

        private bool _UpdateUser()
        {
            return (clsUserData.UpdateUser(this.UserName, this.FirstName, this.LastName, this.Email, this.Phone, this.Password, this.Permissions));
        }

        public static clsUser FindUserByUserName(string UserName)
        {
            string firstname = null, lastname = null, email = null, phone = null, password = null;
            int permissions = 0;

            if ( clsUserData.GetInfoUser (UserName, ref firstname, ref lastname, ref email, ref phone, ref password, ref permissions))
            {
                return new clsUser(UserName, firstname, lastname, email, phone, password, permissions);
            }
            else
            {
                return null;
            }
        }

        public static clsUser FindUserByUserNameAndPassword(string UserName, string Password)
        {
            string firstname = null, lastname = null, email = null, phone = null;
            int permissions = 0;

            if (clsUserData.GetInfoUserByUserNameAndPassword(UserName, ref firstname, ref lastname, ref email, ref phone, Password, ref permissions))
            {
                return new clsUser(UserName, firstname, lastname, email, phone, Password, permissions);
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
                    return _AddNewUser();

                case enMode.Update:
                    return _UpdateUser();
            }

            return false;
        }

        public static bool DeleteUser(string UserName)
        {
            return clsUserData.DeleteUser(UserName);
        }

        public static DataTable GetAllUser()
        {
            return clsUserData.GetListsUser();
        }

        public bool SaveLoginsRegisters()
        {
            return clsUserData.SaveLoginRegisters(this.UserName, this.Password, this.Permissions);
        }

        public static DataTable GetLoginsRegisters()
        {
            return clsUserData.GetListsLoginRegisters();
        }

        public static bool CheckAccessPermission(enPermissions Per)
        {

            if (Per == enPermissions.enAll)
            {
                return true;
            }

            else if (((int)Per & _PermissionsToCheck) == ((int)Per))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public clsUser()
        {
            this.UserName = string.Empty;
            this.FirstName = string.Empty;
            this.LastName = string.Empty;
            this.Email = string.Empty;
            this.Phone = string.Empty;
            this.Password = string.Empty;
            this.Permissions = 0;

            _Mode = enMode.AddNew;

        }

        private clsUser(string username, string firstname, string lastname, string email, string phone, string password, int permissions)
        {
            this.UserName = username;
            this.FirstName = firstname;
            this.LastName = lastname;
            this.Email = email;
            this.Phone = phone;
            this.Password = password;
            this.Permissions = permissions;

            _Mode = enMode.Update;
        }

    }
}
