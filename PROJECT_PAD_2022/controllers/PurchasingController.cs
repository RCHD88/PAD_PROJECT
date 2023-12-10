using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services.Description;
using System.Windows.Forms;

namespace PROJECT_PAD_2022.controllers
{
    public class PurchasingController
    {
        protected AdventureWorks2022Entities database;
        Employee employee;
        public PurchasingController(AdventureWorks2022Entities database, Employee employee)
        {
            this.database = database;
            this.employee = employee;
        }
        public List<object> LoadVendor(bool active)
        {
            var vendordata = (from Vendor v in database.Vendors
                              where v.ActiveFlag == active
                              select new
                              {
                                  ID = v.BusinessEntityID,
                                  Nama = v.Name,
                                  Web = v.PurchasingWebServiceURL != null ? v.PurchasingWebServiceURL : "-",
                                  Rating = v.CreditRating == 1 ? "Superior (1)" :
                                           v.CreditRating == 2 ? "Excellent (2)" :
                                           v.CreditRating == 3 ? "Above average (3)" :
                                           v.CreditRating == 4 ? "Average (4)" : "Below Average (5)"
                              }).ToList();
            return vendordata.Cast<object>().ToList();
        }
        public List<object> OrderVendorAsc(bool active,int orderby)
        {
            if (orderby==0)
            {
                
                var vendordata = (from Vendor v in database.Vendors
                                  .OrderByDescending(v => v.CreditRating)
                                  where v.ActiveFlag == active
                                  select new
                                  {
                                      ID = v.BusinessEntityID,
                                      Nama = v.Name,
                                      Web = v.PurchasingWebServiceURL != null ? v.PurchasingWebServiceURL : "-",
                                      Rating = v.CreditRating == 1 ? "Superior (1)" :
                                               v.CreditRating == 2 ? "Excellent (2)" :
                                               v.CreditRating == 3 ? "Above average (3)" :
                                               v.CreditRating == 4 ? "Average (4)" : "Below Average (5)"
                                  })
                                  .ToList();
                return vendordata.Cast<object>().ToList();
            }
            else if(orderby==1)
            {
                var vendordata = (from Vendor v in database.Vendors
                                  .OrderBy(v => v.CreditRating)
                                  where v.ActiveFlag == active
                                  select new
                                  {
                                      ID = v.BusinessEntityID,
                                      Nama = v.Name,
                                      Web = v.PurchasingWebServiceURL != null ? v.PurchasingWebServiceURL : "-",
                                      Rating = v.CreditRating == 1 ? "Superior (1)" :
                                               v.CreditRating == 2 ? "Excellent (2)" :
                                               v.CreditRating == 3 ? "Above average (3)" :
                                               v.CreditRating == 4 ? "Average (4)" : "Below Average (5)"
                                  })
                                  .ToList();
                return vendordata.Cast<object>().ToList();
            }
            return null;
        }

        public bool updateData(bool status,int id)
        {
            var selectedvendor = database.Vendors.Where(v => v.BusinessEntityID == id).FirstOrDefault();
            if (selectedvendor != null)
            {
                DbContextTransaction transaksi = database.Database.BeginTransaction();
                try
                {
                    selectedvendor.ActiveFlag = status;
                    database.SaveChanges();
                    transaksi.Commit();
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.ToString(), "Gagal update");
                    transaksi.Rollback();
                }
                database.SaveChanges();
                return true;
            }
            return false;
            
        }

        public List<object> loadProductItem()
        {

            var productlist = database.Products
                                .Where(p =>  p.MakeFlag==false && p.SellEndDate ==null)
                                .Select(p => new
                                {
                                    ProductID = p.ProductID,
                                    Name = p.Name,
                                    Class = p.Class == "H" ? "High" : (p.Class == "M" ? "Medium" : (p.Class == "S" ? "Small" : "Unknown")),
                                    Color = p.Color,
                                    Size = p.Size,
                                    Style = p.Style,
                                    Weight = p.Weight,
                                    Price = p.ListPrice
                                })
                                .ToList();
            return productlist.Cast<object>().ToList();   
        }
        
        public Vendor searchVendor(int id)
        {
            Vendor searchedvendor = database.Vendors.Where(v=>v.BusinessEntityID == id).FirstOrDefault();

            return searchedvendor;
        }

        public List<object> LoadAvailableVendor(int a)
        {
            var temp = (from ProductVendor pv in database.ProductVendors
                       join Vendor v in database.Vendors on pv.BusinessEntityID equals v.BusinessEntityID
                       where v.ActiveFlag == true && pv.ProductID.Equals(a)
                       select new
                       {
                           ID = v.BusinessEntityID,
                           Nama = v.Name,
                           Web = v.PurchasingWebServiceURL != null ? v.PurchasingWebServiceURL : "-",
                           Rating = v.CreditRating == 1 ? "Superior (1)" :
                                              v.CreditRating == 2 ? "Excellent (2)" :
                                              v.CreditRating == 3 ? "Above average (3)" :
                                              v.CreditRating == 4 ? "Average (4)" : "Below Average (5)"
                       }).ToList();
            return temp.Cast<object>().ToList();
        }
        

    }
}
