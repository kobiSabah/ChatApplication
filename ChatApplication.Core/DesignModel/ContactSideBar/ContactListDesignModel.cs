using System.Collections.Generic;

namespace ChatApplication.Core
{
    public class ContactListDesignModel : ContactListViewModel
    {
        #region Singleton

        private static ContactListDesignModel s_Instance;

        public static ContactListDesignModel Instance => s_Instance ?? (s_Instance = new ContactListDesignModel());

        #endregion

        #region Defulte Constructor

        public ContactListDesignModel()
        {
            Items = new List<ContactItemViewModel>
                        {
                            new ContactItemDesignModel
                                {
                                    Name = "Sabah Kobi",
                                    NickName = "SK",
                                    ProfileColor = "#4b86b4",
                                    Message = "Hi, How are you today ?? every thing is good.... ?"
                                },

                            new ContactItemDesignModel
                                {
                                    Name = "Jack",
                                    NickName = "JK",
                                    ProfileColor = "#2ec4b6",
                                    Message = "Hi, How are you today ?? every thing is good.... ?"
                                },

                            new ContactItemDesignModel
                                {
                                    Name = "Mia Mia",
                                    NickName = "MM",
                                    ProfileColor = "#ff9f1c",
                                    Message = "Hi, How are you today ?? every thing is good.... ?"
                                },
                            new ContactItemDesignModel
                                {
                                    Name = "Emma Emma",
                                    NickName = "EE",
                                    ProfileColor = "#ff5588",
                                    Message = "Hi, How are you today ?? every thing is good.... ?"
                                },

                            new ContactItemDesignModel
                                {
                                    Name = "Dan Dan",
                                    NickName = "DD",
                                    ProfileColor = "#ff9f1c",
                                    Message = "Hi, How are you today ?? every thing is good.... ?"
                                },

                            new ContactItemDesignModel
                                {
                                    Name = "Dan Dan",
                                    NickName = "DD",
                                    ProfileColor = "#ff9f1c",
                                    Message = "Hi, How are you today ?? every thing is good.... ?"
                                },

                            new ContactItemDesignModel
                                {
                                    Name = "Dan Dan",
                                    NickName = "DD",
                                    ProfileColor = "#ff9f1c",
                                    Message = "Hi, How are you today ?? every thing is good.... ?"
                                },

                            new ContactItemDesignModel
                                {
                                    Name = "Dan Dan",
                                    NickName = "DD",
                                    ProfileColor = "#ff9f1c",
                                    Message = "Hi, How are you today ?? every thing is good.... ?"
                                },

                        };
        }

        #endregion
    }
}
