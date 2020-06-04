namespace MyCompany.Service
{
    /// <summary>
    /// Class according appsettings.json
    /// </summary>
    public class Config
    {
        /// <summary>
        /// Connection to DataBase
        /// </summary>
        public static string ConnectionString { get; set; }

        /// <summary>
        /// Company Name
        /// </summary>
        public static string CompanyName { get; set; }

        /// <summary>
        /// Company Phone
        /// </summary>
        public static string CompanyPhone { get; set; }

        /// <summary>
        /// Company Short Phone
        /// </summary>
        public static string CompanyPhoneShort { get; set; }

        /// <summary>
        /// Company e-mail
        /// </summary>
        public static string CompanyEmail { get; set; }
    }
}
