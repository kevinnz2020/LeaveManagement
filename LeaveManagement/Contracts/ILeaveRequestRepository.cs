using LeaveManagement.Data;
using LeaveManagement.Models;

namespace LeaveManagement.Contracts
{
    public interface ILeaveRequestRepository: IGenericRespository<LeaveRequest>
    {
        Task<bool> CreateLeaveRequest(LeaveRequestCreateVM model);
        Task<EmployeeLeaveRequestViewVM> GetMyLeaveDetails();
        Task<List<LeaveRequest>> GetAllAsync(string employeeId);
        Task<LeaveRequestVM?> GetLeaveRequestAsync(int? id);
        Task ChangeApprovalStatus(int leaveRequestId, bool approved);
        
        Task CancelLeaveRequest(int leaveRequestId);

        Task<AdminLeaveRequestViewVM> GetAdminLeaveRequestList();

    }
}
