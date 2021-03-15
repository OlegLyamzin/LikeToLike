using AutoMapper;
using LikeToLike.API.Models.Output;
using LikeToLike.BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LikeToLike.API
{
    public class AutomapperConfig : Profile
    {
        public AutomapperConfig()
        {
            CreateMap<TaskModel, TaskOutputModel>();
        }
    }
}
