using Abc.Projects.Share.Core._Business.Entities;
using AutoMapper;

using Volo.Abp.Application.Dtos;

namespace Abc.Projects.Share.Core.Business.Dto
{
    [AutoMap(typeof(ResRand))]
    public class ResRanđto : EntityDto<Guid>
    {
        public Guid? Id { get; set; }
        public string Text { get; set; }
    }
}
