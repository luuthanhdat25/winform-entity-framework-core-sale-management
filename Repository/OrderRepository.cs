using AutomobileWinform.Repository;
using Winform.DBContext;
using Winform.Model;
using Microsoft.EntityFrameworkCore;

namespace Winform.Repository;

public class OrderRepository: IRepository<Order, Int32>
{
    public IEnumerable<Order> ListAll()
    {
        using var dbcontext = new SaleManagementDBContext();
        return dbcontext.Orders.ToList();
    }

    public bool InsertObject(Order obj)
    {
        using var dbcontext = new SaleManagementDBContext();
        dbcontext.Add(obj);
        return dbcontext.SaveChanges() > 0;
    }

    public bool DeleteById(int id)
    {
        using var dbcontext = new SaleManagementDBContext();
        var findObj = dbcontext.Orders.Find(id);
        if (findObj != null)
        {
            dbcontext.Remove(findObj);
            int rowEffective = dbcontext.SaveChanges();
            return rowEffective > 0;
        }
        return false;
    }

    public bool UpdateByObject(Order obj)
    {
        using var dbcontext = new SaleManagementDBContext();
        var findObj = dbcontext.Orders.Find(obj.OrderId);
        if (findObj != null)
        {
            findObj.MemberId  = findObj.MemberId;
            findObj.OrderDate  = findObj.OrderDate;
            findObj.RequiredDate  = findObj.RequiredDate;
            findObj.ShippedDate  = findObj.ShippedDate;
            findObj.Freight  = findObj.Freight;

            dbcontext.Entry(findObj).State = EntityState.Modified;

            return dbcontext.SaveChanges() > 0;
        }

        return false;
    }
}