using System;
using TaskFlow.Services;

public class UserService
    {
        private readonly TaskItemService _service;
        public UserService(TaskItemService service)
        {
            _service = service;
        }
        public void CreateUser(){}
        public void EditUser(){}
        public void DeleteUser(){}
        public void ListUsers(){}
        public void AssignTaskToUser(int taskId, int userId){}
        public void UnassignTaskFromUser(int taskId, int userId){}
        public void ListTasksByUser(int userId){}
    }