using AutoMapper;
using LikeToLike.API.Models.Output;
using LikeToLike.BLL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LikeToLike.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        private ITaskRepository _taskRepository;
        private IMapper _mapper;

        public TasksController(IMapper mapper, ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
            _mapper = mapper;
        }

        /// <summary>
        /// Get one Homework by id
        /// </summary>
        /// <param name="homeworkId">Id Homework</param>
        /// <returns>Return one searchable HomeworkOutputModel </returns>
        // https://localhost:44365/api/homework/42
        [ProducesResponseType(typeof(List<TaskOutputModel>), StatusCodes.Status200OK)]
        [HttpGet]
        //[Authorize(Roles = "Админ, Преподаватель, Тьютор, Студент")]
        public ActionResult<List<TaskOutputModel>> GetTasks()
        {
            var result = _mapper.Map<List<TaskOutputModel>>(_taskRepository.GetTasks());
            return Ok(result);
        }
    }
}
