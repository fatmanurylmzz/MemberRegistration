﻿using MemberRegistration.Business.Abstract;
using MemberRegistration.Business.DependencyResolvers.Ninject;
using MemberRegistration.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberRegistration.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            var memberService = InstanceFactory.GetInstance<IMemberService>();
            memberService.Add(new Member { Email = "fatmanurylmzz@gmail.com", FirstName = "Fatmanur", LastName = "Yılmaz", DateOfBirth = new DateTime(1994, 12, 4), TcNo = "55927531502" });
            Console.WriteLine("Eklendi");
            Console.ReadLine();
        }
    }
}
