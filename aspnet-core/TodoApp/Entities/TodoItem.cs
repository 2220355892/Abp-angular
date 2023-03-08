using Volo.Abp.Domain.Entities;

namespace TodoApp.Entities
{
    public class TodoItem : BasicAggregateRoot<Guid>
    {
        public Guid Id { get; set; }
        public string Text { get; set; }
    }
}
