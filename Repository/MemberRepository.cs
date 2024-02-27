using AutomobileWinform.Repository;
using Winform.Model;
using Winform.DBContext;
using Microsoft.EntityFrameworkCore;

namespace Winform.Repository
{
    internal class MemberRepository : IRepository<Member, Int32>
    {
        public bool DeleteById(int id)
        {
            using var dbcontext = new SaleManagementDBContext();
            var member = dbcontext.Members.Find(id);
            if (member != null)
            {
                dbcontext.Remove(member);
                int rowEffective = dbcontext.SaveChanges();
                return rowEffective > 0;
            }
            return false;
        }

        public bool InsertObject(Member obj)
        {
            using var dbcontext = new SaleManagementDBContext();
            dbcontext.Add(obj);
            return dbcontext.SaveChanges() > 0;
        }

        public IEnumerable<Member> ListAll()
        {
            using var dbcontext = new SaleManagementDBContext();
            return dbcontext.Members.ToList();
        }

        public bool UpdateByObject(Member obj)
        {
            using var dbcontext = new SaleManagementDBContext();
            var member = dbcontext.Members.Find(obj.MemberId);
            if (member != null)
            {
                member.Email = obj.Email;
                member.CompanyName = obj.CompanyName;
                member.City = obj.City;
                member.Country = obj.Country;
                member.Password = obj.Password;

                dbcontext.Entry(member).State = EntityState.Modified;

                return dbcontext.SaveChanges() > 0;
            }

            return false;
        }
    }
}
