using System.Linq;

namespace WAVN.Services
{
    public class CalculateService : ICalculateService
    {
        public int Calculate(string text){
            if (string.IsNullOrEmpty(text)) { return 0; }

            var numbers = text
                .Split(',')
                .Select(int.Parse)
                .ToList();

            return numbers.Sum();
        }
    }
}
