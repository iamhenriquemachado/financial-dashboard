namespace FinancialDashboard.Entities
{
    public class Message
    {
        // Default Success Messages
        public string SUCCESS_DEFAULT = "Operation completed successfully.";
        public string SUCCESS_CREATED = "The resouce was created successfully.";
        public string SUCCESS_UPDATED = "The resource was updated successfully.";
        public string SUCCESS_DELETED = "The resource was deleted successfully.";


        // Default Error Messages
        public string ERROR_DEFAULT = "An unexpected error occurred. Please try again later.";
        public string ERROR_NOT_FOUND = "The requested  resource could not be found.";
        public string ERROR_INVALID_ID = "The provided ID is not valid.";

        // Default Authentication Messages
        public string AUTH_LOGIN_SUCCESS = "You have been successfully logged in.";
        public string AUTH_LOGIN_FAILED = "Invalid credentials.";
        public string AUTH_LOGOUT_SUCCESS = "You have been sucessfully logged out.";
        public string AUTH_REQUIRED = "Authentication is required to access this resource.";
        public string AUTH_FORBIDDEN = "You do not have permission to perform this action.";

        // Default Validation Messages
        public string VALIDATION_FAILED = "Validation failed. Check the fields.";
        public string VALIDATION_REQUIRED = "The field is required.";
        public string VALIDATION_INVALID_EMAIL = "Please enter a valid email address.";
        public string VALIDATION_PASSWORD_SHORT = "Password must be at least 8 characters.";
        public string VALIDATION_PASSWORDS_NO_MATCH = "Passwords do not match.";


    }
}
