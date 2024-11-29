using ServiceCenter.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceCenter.Application.DTOS;

public class EmployeeResponseDto
{
   
    public string Id { get; set; } = "";
    public string Email { get; set; } = "";
    public string UserName { get; set; } = "";
    public ContactResponseDto Contact { get; set; }
}
