namespace TodoApi.Models
{
    public class TodoItem
    {
        public long Id { get; set; }
        public long RollNum { get; set; }
        public string? Name { get; set; }
        public string? Department { get; set; }
        public double? GPA { get; set; }
        public bool IsComplete { get; set; }
    }
}
