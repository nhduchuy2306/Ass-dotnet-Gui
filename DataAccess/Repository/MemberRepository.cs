using BussinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository;

public class MemberRepository : IMemberRepository
{
    private SaleManagementContext _saleManagementContext;
    public MemberRepository(SaleManagementContext saleManagementContext)
    {
        _saleManagementContext = saleManagementContext;
    }
    public MemberRepository()
    {
        _saleManagementContext = new SaleManagementContext();
    }

    public List<Member> GetMembers() => _saleManagementContext.Members.ToList();
    public string GetEmailAdmin() => _saleManagementContext.GetEmailAdmin();
    public string GetPassAdmin() => _saleManagementContext.GetPassAdmin();
}
