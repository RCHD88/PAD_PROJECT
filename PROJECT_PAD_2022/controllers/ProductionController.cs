using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT_PAD_2022.controllers
{
    public class ProductionController
    {
        protected AdventureWorks2022Entities database;
        Employee employee;
        public ProductionController(AdventureWorks2022Entities database, Employee employee)
        {
            this.database = database;
            this.employee = employee;
        }
        public List<Object> getProductList()
        {
            var products = (from p in database.Products
                join m in database.UnitMeasures
                on p.SizeUnitMeasureCode equals m.UnitMeasureCode into unitMeasureGroup
                from m in unitMeasureGroup.DefaultIfEmpty()
                select new
                {
                    ProductId = p.ProductID,
                    ProductName = p.Name,
                    StandardCost = p.StandardCost,
                    ListPrice = p.ListPrice,
                    UnitMeasureName = m != null ? m.Name : ""
                }).ToList();
            return products.Cast<object>().ToList();
        }
        public List<Object> getSortedByListPrice()
        {
            var products = (from p in database.Products
                            join m in database.UnitMeasures
                            on p.SizeUnitMeasureCode equals m.UnitMeasureCode into unitMeasureGroup
                            from m in unitMeasureGroup.DefaultIfEmpty()
                            orderby p.ListPrice
                            select new
                            {
                                ProductId = p.ProductID,
                                ProductName = p.Name,
                                StandardCost = p.StandardCost,
                                ListPrice = p.ListPrice,
                                UnitMeasureName = m != null ? m.Name : "",
                                Size = m != null ? p.Size : ""
                            }).ToList();
            return products.Cast<object>().ToList();
        }
    }
}
