﻿using Infrastructure.Data.Postgres.Entities;

namespace Business.Models.Request.Update;

public class UserUpdateDTO
{

    public string tc_no { get; set; } = default!;
    public string UserName { get; set; } = default!;
    public string Email { get; set; } = default!;
    public string phone { get; set; } = default!;
    public UserType UserType { get; set; }
}