namespace ApartmentRental_v2
{
    public static class CurrentSession
    {
        public static int UserID { get; set; }
        public static string Username { get; set; }
        public static string FullName { get; set; }
        public static string Role { get; set; }
        public static string Phone { get; set; }

        public static bool IsAdmin
        {
            get { return Role == "Администратор"; }
        }

        public static bool IsRealtor
        {
            get { return Role == "Риелтор" || Role == "Администратор"; }
        }

        public static bool IsClient
        {
            get { return Role == "Клиент"; }
        }

        public static void Clear()
        {
            UserID = 0;
            Username = null;
            FullName = null;
            Role = null;
            Phone = null;
        }
    }
}
