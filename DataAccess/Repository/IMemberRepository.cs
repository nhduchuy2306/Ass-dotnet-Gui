using BussinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository;

public interface IMemberRepository
{
    List<Member> GetAll();
    Member GetById(int id);
    List<Member> GetByEmail(string email);
    bool Add(Member member);
    bool Update(Member member);
    bool Delete(int id);
}
