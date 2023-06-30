namespace signupmvc.Models
{
    public class Signup
    {
        public string username { get; set; }
        public string gender { get; set; }
        public bool subject1{ get; set; }
        public bool subject2 { get; set; }
        public string city { get; set; }
        public citytype getcitytype { get; set; }
    }
    public enum citytype
    {
        Nagpur,Mumbai,Pune
    }
}
