namespace RazorDemo.Services
{
    public class DataService
    {
        public List<string> GetData()
        {
            return new List<string>
            {
                "Laptop",
                "Mobile",
                "Tablet",
                "Smart Watch",
                "Headphones"
            };
        }
    }
}