namespace Commander.Models
{
    public class Command
    {
        public int Id { get; set; }
        public string HowTo { get; set; }
        public string Line { get; set; }
        //CMD line snip-it
        public string Platform { get; set; }
        //application platform
        //in future vid this will be broken out into a parent class
    }
}