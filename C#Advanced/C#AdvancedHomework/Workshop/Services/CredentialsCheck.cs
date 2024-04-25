namespace Services
{
    public static class CredentialsCheck
    {
        public static string NameCheck(string input)
        {
            if (input == null || input.Length <= 2)
            {
                throw new Exception("The input for First and Last name should not be lower than 2 characters!");
            }
            else { return input; }
        }
        public static string UsernameCheck(string input)
        {
            if (input == null || input.Length < 6)
            {
                throw new Exception("The username must contain at least 6 characters!");
            }
            else { return input; }
        }
        public static string PasswordCheck(string input)
        {
            if (input == null || input.Length < 6 || !input.Any(x => char.IsDigit(x)))
            {
                throw new Exception("The password must contain at least 6 characters and 1 number!");
            }
            else { return input; }
        }





    }
}
