using Leave_managemenmt_system.Data;

namespace Leave_management_system.Data
{
    public class LeaveType : BaseEntity
    {
       
        public string Name { get; set; }
        public int DefaultDays { get; set; }
       
    }
}
