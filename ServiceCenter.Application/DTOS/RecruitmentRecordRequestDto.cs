﻿using ServiceCenter.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceCenter.Application.DTOS;

public class RecruitmentRecordRequestDto
{
    [Required]
    public Status Status { get; set; }
    [Required]
    public string ApplicantId { get; set; } = "";
    [Required]
    public int DepartmentId { get; set; }
}