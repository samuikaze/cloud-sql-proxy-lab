using System;
using System.Collections.Generic;

namespace CloudSQLAuthProxy.Lab.Repository.Models;

public partial class User
{
    public int UserId { get; set; }

    public string Username { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string? Nickname { get; set; }

    public short Sex { get; set; }

    public string Email { get; set; } = null!;

    public DateTime? CreateDate { get; set; }

    public DateTime? UpdateDate { get; set; }
}
