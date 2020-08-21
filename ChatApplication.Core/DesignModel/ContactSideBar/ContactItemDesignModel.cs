namespace ChatApplication.Core
{
    public class ContactItemDesignModel : ContactItemViewModel
    {
        #region SingleTon

        private static ContactItemDesignModel s_Instance;
        public static ContactItemDesignModel Instance => s_Instance ?? (s_Instance = new ContactItemDesignModel());

        #endregion

        #region Constructor

        public ContactItemDesignModel()
        {
            Name = "Sabah Kobi";
            NickName = "SK";
            ProfileColor = "#4b86b4";
            Message = "Hi, How are you today ?? every thing is good.... ?";
            IsSelected = false;
        }
        
        #endregion
    }
}
