﻿using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ToDo.DataAccess.Repositories;
using ToDo.DataAccess.Repositories.CacheRepositories;
using ToDo.Domain.Enums;
using ToDo.Domain.Models;
using ToDo.Services.Services;
using ToDoApplication.Models;

namespace ToDoApplication.Controllers
{
    public class TaskController : Controller
    {
        private IUserService _userRepository;
        private ITasksService _taskRepository;

        public TaskController(ITasksService taskRepository, IUserService userRepository)
        {
            _taskRepository = taskRepository;
            _userRepository = userRepository;
        }

        [HttpGet]
        public IActionResult Index()
        {
            TaskViewModel model = new TaskViewModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult Index(TaskViewModel model)
        {
            if(!string.IsNullOrEmpty(model.Title) && !string.IsNullOrEmpty(model.Descripton))
            {

                Task taskToAdd = new Task()
                {
                    UserId = model.UserId,
                    Title = model.Title,
                    Descripton = model.Descripton,
                    Status = model.Status,
                    Importance = model.Importance,
                    Type = model.Type
                };
                _taskRepository.CreateNewTask(taskToAdd);
                
            }
            return RedirectToAction("Index", "Home");
        }
        
        public IActionResult InProgress()
        {
            var allTasks = _taskRepository.GetAllTasks();
            List<TaskViewModel> inProgress = new List<TaskViewModel>();
            foreach (var task in allTasks)
            {
                if(task.Status == Status.InProgress)
                {
                    TaskViewModel taskForList = new TaskViewModel
                    {
                        Title = task.Title,
                        Descripton = task.Descripton,
                        Importance = task.Importance,
                        Status = task.Status,
                        Type = task.Type,
                    };
                    inProgress.Add(taskForList);
                }
            }

            TasksViewModel model = new TasksViewModel(){ Tasks = inProgress };

            return View(model);
        }

        public IActionResult NotDone()
        {
            var allTasks = _taskRepository.GetAllTasks();
            List<TaskViewModel> notDone = new List<TaskViewModel>();
            foreach (var task in allTasks)
            {
                if (task.Status == Status.NotDone)
                {
                    TaskViewModel taskForList = new TaskViewModel
                    {
                        Title = task.Title,
                        Descripton = task.Descripton,
                        Importance = task.Importance,
                        Status = task.Status,
                        Type = task.Type,
                    };
                    notDone.Add(taskForList);
                }
            }

            TasksViewModel model = new TasksViewModel(){ Tasks = notDone };
            return View(model);
        }


        public IActionResult Done()
        {
            var allTasks = _taskRepository.GetAllTasks();
            List<TaskViewModel> done = new List<TaskViewModel>();
            foreach (var task in allTasks)
            {
                if (task.Status == Status.Done)
                {
                    TaskViewModel taskForList = new TaskViewModel{
                        Title = task.Title,
                        Descripton = task.Descripton,
                        Importance = task.Importance,
                        Status = task.Status,
                        Type = task.Type,
                    };
                    done.Add(taskForList);
                }
            }

            TasksViewModel model = new TasksViewModel() { Tasks = done};
            return View(model);
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            if (id > 0)
            {
                Task gotById = _taskRepository.GetTaskById(id);
                TaskDetailsViewModel modelId = new TaskDetailsViewModel()
                {
                    Id = gotById.Id,
                    UserId = gotById.UserId,
                    Title = gotById.Title,
                    Descripton = gotById.Descripton,
                    Importance = gotById.Importance,
                    Type = gotById.Type,
                    Status = gotById.Status,
                    SubTasks = gotById.SubTasks
                };
                return View("_TaskDetailsView", modelId);
            };

            var allTasks = _taskRepository.GetAllTasks();
            List<TaskDetailsViewModel> tasksWithDetails = new List<TaskDetailsViewModel>();
            foreach (var task in allTasks)
            {
                TaskDetailsViewModel thisTask = new TaskDetailsViewModel()
                {
                    Id = task.Id,
                    UserId = task.UserId,
                    Title = task.Title,
                    Descripton = task.Descripton,
                    Importance = task.Importance,
                    Status = task.Status,
                    Type = task.Type,
                    SubTasks = task.SubTasks
                };
                tasksWithDetails.Add(thisTask);
            }

            TasksDetailsViewModel model = new TasksDetailsViewModel() { Details = tasksWithDetails};
            return View(model);
        }

        [HttpPost]
        public IActionResult Details(TaskDetailsViewModel model)
        {
            if(model != null)
            {
                Task toUpdate = new Task()
                {
                    Id = model.Id,
                    UserId = model.UserId,
                    Title = model.Title,
                    Descripton = model.Descripton,
                    Status = model.Status,
                    Importance = model.Importance,
                    Type = model.Type,
                    SubTasks = model.SubTasks
                };
                _taskRepository.UpdateTask(toUpdate);
            }
            
            return RedirectToAction("Index", "Home");
        }
    }
}