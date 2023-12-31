﻿using System;
using System.Collections.Generic;

namespace Website_Ban_Thuc_Pham.Models;

public partial class Menu
{
    public int MenuId { get; set; }

    public string? MenuName { get; set; }

    public bool? IsActive { get; set; }

    public string? ControllerName { get; set; }

    public string? ActionName { get; set; }

    public int? Levels { get; set; }

    public int? ParentId { get; set; }

    public string? Link { get; set; }

    public int? MenuOrder { get; set; }

    public int? Position { get; set; }

    public virtual ICollection<Post> Posts { get; set; } = new List<Post>();
}
