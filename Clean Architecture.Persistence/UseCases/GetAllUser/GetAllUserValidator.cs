﻿using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.UseCases.GetAllUser
{
    public class GetAllUserValidator : AbstractValidator<GetAllUserRequest>
    {
        public GetAllUserValidator()
        {
            //nenhuma validação implementada    
        }
    }
}
