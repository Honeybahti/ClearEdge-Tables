﻿using Microsoft.AspNetCore.Mvc.Rendering;

namespace ClearEdge_Tables.Models.ViewModels
{
    public class RoleManagementViewModel
    {
            public Customer ApplicationUser { get; set; }
            public IEnumerable<SelectListItem> RoleList { get; set; }
    }
}
