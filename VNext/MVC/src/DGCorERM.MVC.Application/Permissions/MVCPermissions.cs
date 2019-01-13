using System;

namespace DGCorERM.MVC.Permissions
{
    public static class MVCPermissions
    {
        public const string GroupName = "MVC";

        //Add your own permission names. Example:
        //public const string MyPermission1 = GroupName + ".MyPermission1";

        public static string[] GetAll()
        {
            //Return an array of all permissions
            return Array.Empty<string>();
        }
    }
}