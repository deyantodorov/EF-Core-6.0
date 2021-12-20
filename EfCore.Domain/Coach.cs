namespace EfCore.Domain
{
    public class Coach : BaseEntity<int>
    {
        public string Name { get; set; }

        public int? TeamId { get; set; }

        public virtual Team Team { get; set; }
    }
}
