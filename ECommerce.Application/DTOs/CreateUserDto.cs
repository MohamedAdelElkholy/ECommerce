using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Application.DTOs
{
    public class CreateUserDto
    {
        public string FullName { get; set; } = default!;

        public string Email { get; set; } = default!;

        public string Password { get; set; } = default!;
    }
}
