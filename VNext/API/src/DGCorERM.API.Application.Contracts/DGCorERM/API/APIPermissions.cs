namespace DGCorERM.API
{
    public class APIPermissions
    {
        public const string GroupName = "API";

        public static string[] GetAll()
        {
            return new[]
            {
                GroupName
            };
        }
    }
}