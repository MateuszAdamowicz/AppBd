namespace Shop.Domain.Model.Worker
{
    public class Activity
    {
        public int Id { get; set; }
        public string EntityName { get; set; }
        public int EntityId { get; set; }
        public string Description { get; set; }
    }
}