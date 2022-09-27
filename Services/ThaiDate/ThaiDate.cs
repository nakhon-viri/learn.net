using System.Globalization;

namespace ASPNETAPI.Services.ThaiDate
{
    public class ThaiDate : IThaiDate
    {
        public string ShowThaiDate()
        {
            return DateTime.Now.ToString("dd MMM yyyy", new CultureInfo("th-TH"));
        }
    }
}
