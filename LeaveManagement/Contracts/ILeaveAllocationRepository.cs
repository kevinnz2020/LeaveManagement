﻿using LeaveManagement.Data;
using LeaveManagement.Models;

namespace LeaveManagement.Contracts
{
    public interface ILeaveAllocationRepository: IGenericRespository<LeaveAllocation>
    {
        Task LeaveAllocation(int leaveTypeId);
        Task<bool> AllocationExists(string employeeId, int leaveTypeId, int period);

        Task<EmployeeAllocationVM> GetEmployeeAllocations(string employeeId);
        Task<LeaveAllocationEditVM> GetEmployeeAllocation(int id);
        Task<bool> UpdateEmployeellocation(LeaveAllocationVM model);

    }
}
