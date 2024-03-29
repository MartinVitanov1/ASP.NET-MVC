﻿using System;
using System.Collections.Generic;
using System.Linq;
using ToDo.Domain.Enums;
using ToDo.Domain.Models;
using Type = ToDo.Domain.Enums.Type;

namespace ToDoApplication.Models
{
    public class TaskViewModel
    {
        public int UserId { get; set; }
        public string Title { get; set; }
        public string Descripton { get; set; }
        public Status Status { get; set; }
        public Type Type { get; set; }
        public Importance Importance { get; set; }
    }
}
