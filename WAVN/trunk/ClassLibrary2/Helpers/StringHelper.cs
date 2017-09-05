using System;

namespace WAVN.Services.Helpers
{
    public static class StringHelper
    {
        public static bool IsNumber(this string symbol) {
            return Int32.TryParse(symbol, out int number);
        }
    }
}
