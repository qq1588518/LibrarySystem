using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class Admin
    {
        private string tbAdminID;
        private int adminType;
        private string tbAdminPassWordOK;
        private string cbDisable;

        public string CbDisable
        {
            get { return cbDisable; }
            set { cbDisable = value; }
        }

        public int AdminType
        {
            get { return adminType; }
            set { adminType = value; }
        }

        public string TbAdminID
        {
            get { return tbAdminID; }
            set { tbAdminID = value; }
        }

        public string TbAdminPassWordOK
        {
            get { return tbAdminPassWordOK; }
            set { tbAdminPassWordOK = value; }
        }
    }
}
