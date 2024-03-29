﻿namespace Tuber.Domain.Models;
public class User
{
    public static readonly string FriendlyName = "User";

    public Guid UserId { get; set; }
    public string FullName { get; set; } = "";
    public bool IsCoreUser { get; set; }
    public bool IsDeleted { get; set; }
}
