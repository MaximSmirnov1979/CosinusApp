namespace CosinusApp.Model.Entity
{
    // класс известных серверу хостов
    public class KnownHost
    {
        public int Id { get; set; }
        public string NameHost { get; set; }
       public List<Request> Requests { get; set; }
        public override string ToString()
        {
            return $"{Id} - {NameHost}";
        }
    }
}
