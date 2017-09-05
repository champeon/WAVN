using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WAVN.Services.Constants;
using WAVN.Services.Helpers;
using WAVN.Services.Models;

namespace WAVN.Services
{
    public class CalculateService : ICalculateService
    {
        public int Calculate(string text)
        {
            return CanCalculate(text)
                 ? Sum(text)
                 : 0;
        }

        private List<OutPutModel> GetOutPutModels(string text)
        {
            return Process(text, new StringBuilder(), 0).ToString()
                .Split(Constant.NUMBER_SEPARATOR)
                 .Select(c => ConvertToOutPutModel(c))
                 .ToList();
        }

        private int Sum(string text)
        {
            var numbers = GetOutPutModels(text)
              .Where(i => i.IsNumber)
              .Select(i => int.Parse(i.Value))
              .ToList();

            return numbers.Sum();
        }

        private bool CanCalculate(string text)
        {
            return !string.IsNullOrEmpty(text);
        }

        private OutPutModel ConvertToOutPutModel(string symbol)
        {
            bool result = Int32.TryParse(symbol, out int number);

            return new OutPutModel(result, symbol.ToString());
        }

        public string Process(string text, StringBuilder builder, int index)
        {
            if (string.IsNullOrEmpty(text))
            {
                return builder.ToString();
            }

            builder.Append(
                text[index].ToString().IsNumber()
                ? text[index].ToString()
                : Constant.NUMBER_SEPARATOR.ToString());

            index++;
            Process(text.Substring(index), builder, 0);

            return builder.ToString();
        }
    }
}
