using LikeToLike.BLL.Models;
using System.Collections.Generic;

namespace LikeToLike.BLL
{
    public interface ITaskRepository
    {
        List<TaskModel> GetTasks();
    }
}