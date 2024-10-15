namespace AbpSolution.Permissions;

public static class AbpSolutionPermissions
{
    public const string GroupName = "AbpSolution";



    //Add your own permission names. Example:
    //public const string MyPermission1 = GroupName + ".MyPermission1";


    // *** ADDED a NEW NESTED CLASS ***
    public static class Books
    {
        public const string Default = GroupName + ".Books";
        public const string Create = Default + ".Create";
        public const string Edit = Default + ".Edit";
        public const string Delete = Default + ".Delete";
    }

    public static class Authors
    {
        public const string Default = GroupName + ".Authors";
        public const string Create = Default + ".Create";
        public const string Edit = Default + ".Edit";
        public const string Delete = Default + ".Delete";
    }
}
