using Abc.Projects.Share.Core._Business.Entities;
using Abc.Projects.Share.Core.Business.Dto;
using Abp.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Abc.Projects.Application
{
    public class RandomResultSevice : Abp.Application.Services.ApplicationService
    {
        private readonly IRepository<ResRand, Guid> _RandomRepository;

        public RandomResultSevice(IRepository<ResRand, Guid> RandomRepository)
        {
            _RandomRepository = RandomRepository;
        }

        // TODO: Implement the methods here...
        [RemoteService(isEnabled: true)]
        public async Task<List<ResRanđto>> GetListAsync()
        {
            var items = await _RandomRepository.GetListAsync();
            return items
                .Select(item => new ResRanđto
                {
                    Id = item.Id,
                    Text = item.Text
                }).ToList();
        }
        public async Task DeleteAsync(Guid id)
        {
            await _RandomRepository.DeleteAsync(id);
        }
        public async Task<ResRanđto> CreateAsync(string text, Guid id)
        {
            var todoItem = await _RandomRepository.InsertAsync(
                new ResRand { Text = text, Id = id }
            );

            return new ResRanđto
            {
                Id = todoItem.Id,
                Text = todoItem.Text
            };
        }
    }
}
