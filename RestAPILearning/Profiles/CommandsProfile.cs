﻿using AutoMapper;
using RestAPILearning.Dtos;
using RestAPILearning.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestAPILearning.Profiles
{
    public class CommandsProfile : Profile
    {
        public CommandsProfile()
        {
            //source --> destination
            CreateMap<Command, CommandReadDto>();

            CreateMap<CommandCreateDto, Command>();

            CreateMap<CommandUpdateDto, Command>();

            CreateMap<Command, CommandUpdateDto>();
        }
    }
}
