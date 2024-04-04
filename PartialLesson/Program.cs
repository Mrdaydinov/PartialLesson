namespace PartialLesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User("name", "name@gmail.com", "pasSword1");

            user.ShowInfo();
            Console.WriteLine(user.PasswordChecker(user.Password));
        }
    }
}
