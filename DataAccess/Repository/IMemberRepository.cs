﻿using BussinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository;

public interface IMemberRepository
{
    List<Member> GetMembers();
    string GetEmailAdmin();
    string GetPassAdmin();
}
