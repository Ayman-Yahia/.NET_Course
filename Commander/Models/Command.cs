namespace Commander.Models
{
    public class Command
    {
        public Command(int v, object p1, object p2, object p3)
        {
            V = v;
            P1 = p1;
            P2 = p2;
            P3 = p3;
        }

        public int id { get; set; }
        public string HowTo { get; set; }
        public string Line { get; set; }
        public string Platform { get; set; }
        public int V { get; }
        public object P1 { get; }
        public object P2 { get; }
        public object P3 { get; }
    }
}