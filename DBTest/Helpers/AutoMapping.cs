using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InspectionBlazor.Helpers
{
    using AutoMapper;
    using Database.Models.Models;
    using InspectionBlazor.AdapterModels;

    public class AutoMapping : Profile
    {
        public AutoMapping()
        {

            CreateMap<JobTitle, JobTitleAdapterModel>();
            CreateMap<JobTitleAdapterModel, JobTitle>();
        }
        
    }
}
