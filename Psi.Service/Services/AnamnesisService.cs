using AutoMapper;
using Psi.Domain.Entities;
using Psi.Domain.Enums;
using Psi.Domain.Interfaces.Repositories;
using Psi.Domain.Interfaces.Services;
using Psi.Domain.Models.Anamnesis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Psi.Service.Services
{
    public class AnamnesisService : IAnamnesisService
    {
        private readonly IMapper _mapper;
        private readonly IGlobalUnitOfWork _globalUoW;

        public AnamnesisService(IMapper mapper, IGlobalUnitOfWork globalUoW)
        {
            _mapper = mapper;
            _globalUoW = globalUoW;
        }

        public List<AnamnesisModel> ListAnamnesisByTenantId(int tenantId)
        {
            var anamnesis = _mapper.Map<List<AnamnesisModel>>(_globalUoW.AnamnesisRepository.ListAnamnesisByTenantId(tenantId));

            return anamnesis;
        }

        public void CreateAnamnesis()
        {
            var fields = new List<AnamnesisFieldModel> {
                    new AnamnesisFieldModel{
                        AnamnesisFieldType = AnamnesisFieldTypeEnum.SingleOption,
                        Title = "title",
                        Options = new string[] { "abcddd", "abc" },
                        Order = 0
                    },
                     new AnamnesisFieldModel{
                        AnamnesisFieldType = AnamnesisFieldTypeEnum.TextField ,
                        Title = "title 2",
                        Order = 1
                    }
                };

            var topics = new List<AnamnesisTopicModel>
            {
                new AnamnesisTopicModel{
                    Name = "Histórico",
                    Order = 0,
                    AnamnesisFields = fields
                }
            };

            var anamnesis = new AnamnesisModel
            {
                CreationDateUtc = DateTime.UtcNow,
                GroupName = "Adulto",
                TenantFk = 1,
                AnamnesisTopics = topics
            };

            var anamModel = _mapper.Map<Anamnesis>(anamnesis);

            _globalUoW.AnamnesisRepository.Insert(anamModel);
        }
    }
}
