namespace WAVN.Web.Models
{
    public class UIOutputModel
    {
        public int Result { get; set; }
        public string Message { get; set; }
        public bool Valid => string.IsNullOrEmpty(Message);
    }
}