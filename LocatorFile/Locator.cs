namespace software_assignment.LocatorFile
{
    public static class LocatorClass
    {
        // Login
        public const string UserName = "//input[@name='username']";
        public const string Password = "//input[@name='password']";
        public const string LoginButton = "//button[@type='submit']";

        // Dashboard
        public const string DashboardHeader = "//div[@class='oxd-topbar-header-title']";

        // Admin
        public const string AdminMenu = "//span[text()='Admin']";
        public const string AdminHeading = "//h6[@class='oxd-text oxd-text--h6 oxd-topbar-header-breadcrumb-level']";

        // User Management
        public const string SearchUsername =
    "//label[normalize-space()='Username']/../following-sibling::div//input";
        public const string UserRoleDropdown = "//div[@class='oxd-select-text-input'][normalize-space()='Admin']";
        public const string SearchButton = "//button[@type='submit']";
        public const string ResetButton = "//button[normalize-space()='Reset']";
    }
}