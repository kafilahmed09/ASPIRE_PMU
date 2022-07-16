using System.Collections.Generic;

namespace ASPIRE.Constants
{
public static class Permissions
{
    public static List<string> GeneratePermissionsForModule(string module)
    {
        return new List<string>()
        {
            $"Permissions.{module}.Create",
            $"Permissions.{module}.View",
            $"Permissions.{module}.Edit",
            $"Permissions.{module}.Delete",
        };
    }

    public static class Country
    {
        public const string View = "Permissions.Country.View";
        public const string Create = "Permissions.Country.Create";
        public const string Edit = "Permissions.Country.Edit";
        public const string Delete = "Permissions.Country.Delete";
    }

    public static class Division
    {
        public const string View = "Permissions.Division.View";
        public const string Create = "Permissions.Division.Create";
        public const string Edit = "Permissions.Division.Edit";        
        public const string Delete = "Permissions.Division.Delete";        
    }
    public static class District
    {
        public const string View = "Permissions.District.View";
        public const string Create = "Permissions.District.Create";
        public const string Edit = "Permissions.District.Edit";        
        public const string Delete = "Permissions.District.Delete";        
    }
    public static class Administrator
    {
        public const string View = "Permissions.Administrator.View";
        public const string Create = "Permissions.Administrator.Create";
        public const string Edit = "Permissions.Administrator.Edit";
        public const string Delete = "Permissions.Administrator.Delete";
    }
        public static class SuperAdmin
        {
            public const string View = "Permissions.SuperAdmin.View";
            public const string Create = "Permissions.SuperAdmin.Create";
            public const string Edit = "Permissions.SuperAdmin.Edit";
            public const string Delete = "Permissions.SuperAdmin.Delete";
        }
        public static class FormEntry
        {
            public const string Create = "Permissions.FormEntry.Create";            
        }
        public static class Guest
        {
            public const string View = "Permissions.Guest.View";
        }
    }
}