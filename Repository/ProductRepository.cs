using AutomobileWinform.Repository;
using DataAccessLayer.DBContext;
using DataAccessLayer.Model;
using Microsoft.EntityFrameworkCore;

namespace EFCore_DataAccessLayer.Repository;

public class ProductRepository: IRepository<Product, Int32>
{
    public IEnumerable<Product> ListAll()
    {
        using var dbcontext = new SaleManagementDBContext();
        return dbcontext.Products.ToList();
    }

    public bool InsertObject(Product obj)
    {
        using var dbcontext = new SaleManagementDBContext();
        dbcontext.Add(obj);
        return dbcontext.SaveChanges() > 0;
    }

    public bool DeleteById(int id)
    {
        using var dbcontext = new SaleManagementDBContext();
        var findObj = dbcontext.Products.Find(id);
        if (findObj != null)
        {
            dbcontext.Remove(findObj);
            int rowEffective = dbcontext.SaveChanges();
            return rowEffective > 0;
        }
        return false;
    }

    public bool UpdateByObject(Product obj)
    {
        using var dbcontext = new SaleManagementDBContext();
        var findObj = dbcontext.Products.Find(obj.ProductId);
        if (findObj != null)
        {
            findObj.CategoryId = findObj.CategoryId;
            findObj.ProductName = findObj.ProductName;
            findObj.Weight = findObj.Weight;
            findObj.UnitPrice = findObj.UnitPrice;
            findObj.UnitInStock = findObj.UnitInStock;

            dbcontext.Entry(findObj).State = EntityState.Modified;

            return dbcontext.SaveChanges() > 0;
        }

        return false;
    }
}