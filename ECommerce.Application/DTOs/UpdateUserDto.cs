using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Application.DTOs
{
    public class UpdateUserDto
    {
        public string FullName { get; set; } = default!;

        public string Role { get; set; } = default!;

        public bool IsActive { get; set; }
    }
}
