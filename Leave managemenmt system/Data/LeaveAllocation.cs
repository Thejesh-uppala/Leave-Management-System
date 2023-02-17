﻿using Leave_managemenmt_system.Data;
using System.ComponentModel.DataAnnotations.Schema;

namespace Leave_management_system.Data
{
    public class LeaveAllocation : BaseEntity
    {
         
        public int NumberOfDays { get; set; }
        [ForeignKey("LeaveTypeId")]
        public LeaveType LeaveType { get; set;}
        public int LeaveTypeId { get; set; }
        public string EmployeeId { get; set; }


    }
}
