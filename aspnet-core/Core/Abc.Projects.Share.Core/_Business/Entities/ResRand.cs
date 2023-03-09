using System;
using Volo.Abp.Domain.Entities;

namespace Abc.Projects.Share.Core._Business.Entities
{
    public class ResRand: Entity<Guid>
    {
        public Guid Id { get; set; }
        public string Text { get; set; }
    }
}
