﻿using MediatR;
using Week3.API_Odev.DTOs;

namespace Week3.API_Odev.Queries.GetAll
{
    public class CarGetAllQuery : IRequest<ResponseDto<List<CarRequestDto>>>
    {
    }
}
