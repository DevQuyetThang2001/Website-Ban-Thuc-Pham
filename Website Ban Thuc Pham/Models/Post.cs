using System;
using System.Collections.Generic;

namespace Website_Ban_Thuc_Pham.Models;

public partial class Post
{
    public long PostId { get; set; }

    public string? Title { get; set; }

    public string? Abstract { get; set; }

    public string? Contents { get; set; }

    public string? Images { get; set; }

    public string? Link { get; set; }

    public string? Author { get; set; }

    public DateTime? CreatedDate { get; set; }

    public bool? IsActive { get; set; }

    public int? PostOrder { get; set; }

    public int? MenuId { get; set; }

    public int? Category { get; set; }

    public int? Status { get; set; }

    public virtual Menu? Menu { get; set; }
}
