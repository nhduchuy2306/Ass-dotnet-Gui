using BussinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository;

public class MemberRepository : IMemberRepository
{
    private SaleManagementContext _context;

    public MemberRepository()
    {
        _context = new SaleManagementContext();
    }

    public bool Add(Member member)
    {
        _context.Members.Add(member);
        return _context.SaveChanges() > 0;
    }

    public bool Delete(int id)
    {
        Member member = GetById(id);
        _context.Members.Remove(member);
        return _context.SaveChanges() > 0;
    }

    public List<Member> GetAll()
    {
        var mem = from m in _context.Members select m;
        return mem.ToList();
    }

    public Member GetById(int id)
    {
        var mem = (from m in _context.Members
                   where m.MemberId == id
                   select m).FirstOrDefault();
        return mem;
    }

    public List<Member> GetByEmail(string email)
    {
        var mem = (from m in _context.Members
                   where m.Email.ToLower().Contains(email.ToLower().Trim())
                   select m);
        return mem.ToList();
    }

    public bool Update(Member member)
    {
        Member newMem = GetById(member.MemberId);

        if (newMem != null)
        {
            newMem.MemberId = member.MemberId;
            newMem.Email = member.Email;
            newMem.CompanyName = member.CompanyName;
            newMem.Country = member.Country;
            newMem.City = member.City;
            newMem.Password = newMem.Password;

            return _context.SaveChanges() > 0;
        }
        return false;
    }
}
