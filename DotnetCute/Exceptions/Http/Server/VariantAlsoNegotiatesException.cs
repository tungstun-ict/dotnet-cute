﻿using System.Net;
using DotnetCute.Attributes;

namespace DotnetCute.Exceptions.Http.Server;

[HttpResponseCode(Code = HttpStatusCode.VariantAlsoNegotiates)]
public class VariantAlsoNegotiatesException : ResponseException
{
    public VariantAlsoNegotiatesException(string description, params string[] additional) : base(description, additional)
    {
    }
}