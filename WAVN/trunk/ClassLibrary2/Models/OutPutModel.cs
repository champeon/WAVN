namespace WAVN.Services.Models
{
    public class OutPutModel : ICanBeNumber
    {
        public OutPutModel(bool isNumber, string value) {
            IsNumber = isNumber;
            Value = value;
        }
        public bool IsNumber { get; private set; }
        public string Value { get; private set; }
    }
}
