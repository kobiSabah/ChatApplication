using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApplication
{
    public class ContactItemDesignModel : ContactItemViewModel
    {
        #region SingleTon

        private static ContactItemDesignModel s_Instance;
        public static ContactItemDesignModel Instance => s_Instance ?? (s_Instance = new ContactItemDesignModel());

        #endregion

        public ContactItemDesignModel()
        {
            Name = "Sabah Kobi";
            NickName = "SK";
            ProfileColor = "#4b86b4";
            Message = "Hi, How are you today ?? every thing is good.... ?";
        }

    }
}
