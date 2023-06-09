﻿using AutoMapper;
using Todo.Application.Services.Commands.Category.Delete;
using Todo.Application.Services.Commands.Category.Insert;
using Todo.Application.Services.Commands.Category.Update;
using Todo.Application.Services.Commands.TodoItem.Delete;
using Todo.Application.Services.Commands.TodoItem.DeleteRange;
using Todo.Application.Services.Commands.TodoItem.Insert;
using Todo.Application.Services.Commands.TodoItem.Update;
using Todo.Application.Services.Commands.User.Insert;
using Todo.Application.Services.Commands.User.Login;
using Todo.Application.Services.Queries.Category.GetAll;
using Todo.Application.Services.Queries.TodoItem.GetAll;
using Todo.Application.Services.Queries.TodoItem.GetByFilterPriority;
using Todo.Application.Services.Queries.User.GetAll;
using Todo.Core.Entities;

namespace Todo.Application.MappingConfiguration
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<RegisterUserCommandRequest, User>().ReverseMap();
            CreateMap<GetAllUserQueriesResponse, User>().ReverseMap();
            CreateMap<LoginUserCommandResponse, User>().ReverseMap();

            CreateMap<InsertTodoItemCommandRequest, TodoItem>().ReverseMap();
            CreateMap<UpdateTodoItemCommandRequest, TodoItem>().ReverseMap();
            CreateMap<DeleteTodoItemCommandRequest, TodoItem>().ReverseMap();
            CreateMap<DeleteRangeTodoItemCommandRequest, TodoItem>().ReverseMap();
            CreateMap<GetAllTodoItemQueriesResponse, TodoItem>().ReverseMap();
            CreateMap<GetByFilterPriorityQueriesResponse, TodoItem>().ReverseMap();

            CreateMap<InsertCategoryCommandRequest, Category>().ReverseMap();
            CreateMap<DeleteCategoryCommandRequest, Category>().ReverseMap();
            CreateMap<UpdateCategoryCommandRequest, Category>().ReverseMap();
            CreateMap<GetAllCategoryQueriesResponse, Category>().ReverseMap();
        
        }
    }
}
