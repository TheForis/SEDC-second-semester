namespace ModelsDemo02
{
    public abstract class BaseClass
    {
        public int Id { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedAt { get; set;}

        protected BaseClass (string createdBy)
        {
            Random rnd = new Random();
            Id = rnd.Next(1,Int32.MaxValue);
            CreatedBy = createdBy;
            CreatedAt = DateTime.Now;

        }

    }
}
