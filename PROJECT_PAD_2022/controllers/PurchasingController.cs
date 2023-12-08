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
                                  Rating = v.CreditRating == 1 ? "Superior" :
                                           v.CreditRating == 2 ? "Excellent" :
                                           v.CreditRating == 3 ? "Above average" :
                                           v.CreditRating == 4 ? "Average" : "Below Average"
                              }).ToList();
            return vendordata.Cast<object>().ToList();
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
        

    }
}
