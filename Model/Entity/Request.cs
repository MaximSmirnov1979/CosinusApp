namespace CosinusApp.Model.Entity
{
    public class Request
    {
        public int Id { get; set; }
        public string Method { get; set; }
        public string Url { get; set; }

        public int KnownHostId { get; set; }
        public KnownHost KnownHost { get; set; }
        public override string ToString()
        {
            return $"{Id} - {Method} - {Url}";
        }
    }
}
