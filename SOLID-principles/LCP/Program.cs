namespace LCP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person student= new Student();
            Developer developer= new Developer();
            student.GetFullName();
            developer.GetFullName();
            developer.GetExperience();
        }
    }
}