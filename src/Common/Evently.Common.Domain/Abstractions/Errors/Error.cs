﻿namespace Evently.Common.Domain.Abstractions.Errors;
public record class Error
{
    public string Code { get; }
    public string Description { get; }
    public ErrorType Type { get; }

    public Error(
        string code,
        string description,
        ErrorType type)
    {
        Code = code;
        Description = description;
        Type = type;
    }

    public static readonly Error None = new(
        string.Empty,
        string.Empty,
        ErrorType.Failure);

    public static readonly Error NullValue = new(
        "General.NullValue",
        "NullValue was provided",
        ErrorType.Failure);

    public static Error Failure(string code, string description) => new Error(code, description, ErrorType.Failure);
    public static Error NotFound(string code, string description) => new Error(code, description, ErrorType.NotFound);
    public static Error Problem(string code, string description) => new Error(code, description, ErrorType.Problem);
    public static Error Conflict(string code, string description) => new Error(code, description, ErrorType.Conflict);
}
