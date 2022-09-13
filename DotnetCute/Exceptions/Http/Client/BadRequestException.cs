﻿using System.Net;
using DotnetCute.Attributes;

namespace DotnetCute.Exceptions.Http.Client;

[HttpResponseCode(Code = HttpStatusCode.BadRequest)]
public class BadRequestException : ResponseException
{
    public BadRequestException(string description, params string[] additional) 
        : base(description, additional)
    {
    }
}