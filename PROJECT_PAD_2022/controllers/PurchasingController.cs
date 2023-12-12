using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services.Description;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
        public int getEmployeeID()
        {
            return employee.BusinessEntityID;
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
            }else if(orderby==2)
            {
                var vendordata = (from Vendor v in database.Vendors
                                  .OrderBy(v => v.Name)
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

            /*var productlist = database.Products
                                .Where(p =>  p.SellEndDate ==null && p.ListPrice>0)
                                .Select(p => new
                                {
                                    ProductID = p.ProductID,
                                    Name = p.Name,
                                    Class = p.Class == "H" ? "High" : (p.Class == "M" ? "Medium" : (p.Class == "S" ? "Small" : "-")),
                                    Color = p.Color,
                                    Size = p.Size,
                                    Style = p.Style == "M" ? "Mens" : (p.Style == "W" ? "Womens" : "Universal"),
                                    Weight = p.Weight,
                                    Price = p.ListPrice
                                })
                                .ToList();*/
            var product = (from Product p in database.Products
                           join ProductVendor pv in database.ProductVendors on p.ProductID equals pv.ProductID
                           join Vendor v in database.Vendors on pv.BusinessEntityID equals v.BusinessEntityID
                           where v.ActiveFlag == true 
                           select new
                           {
                               ProductID = pv.ProductID,
                               Name = p.Name,
                               price = pv.StandardPrice,
                               Class = p.Class == "H" ? "High" : (p.Class == "M" ? "Medium" : (p.Class == "S" ? "Small" : "-")),
                               Color = p.Color,
                               Size = p.Size,
                               Style = p.Style == "M" ? "Mens" : (p.Style == "W" ? "Womens" : "Universal"),
                           }).ToList();
            return product.Cast<object>().ToList();   
        }
        
        public Vendor searchVendor(int id)
        {
            Vendor searchedvendor = database.Vendors.Where(v=>v.BusinessEntityID == id).FirstOrDefault();

            return searchedvendor;
        }

        public List<object> LoadAvailableProduct(int a)
        {
            /*var temp = (from ProductVendor pv in database.ProductVendors
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
                                               v.CreditRating == 4 ? "Average (4)" : "Below Average (5)",
                            Price = pv.StandardPrice
                        }).ToList();
            return temp.Cast<object>().ToList();*/
            var product = (from Product p in database.Products
                           join ProductVendor pv in database.ProductVendors on p.ProductID equals pv.ProductID
                           join Vendor v in database.Vendors on pv.BusinessEntityID equals v.BusinessEntityID
                           where v.ActiveFlag == true && pv.BusinessEntityID==a
                           select new
                           {
                               ProductID = pv.ProductID,
                               Name = p.Name,
                               Price = pv.StandardPrice,
                               Class = p.Class == "H" ? "High" : (p.Class == "M" ? "Medium" : (p.Class == "S" ? "Small" : "-")),
                               Color = p.Color,
                               Size = p.Size,
                               Style = p.Style == "M" ? "Mens" : (p.Style == "W" ? "Womens" : "Universal"),
                           }).ToList();
            return product.Cast<object>().ToList();
        }

        public List<object> getShipmentMethod()
        {
            var shipmentMethod = database.ShipMethods.ToList();
            return shipmentMethod.Cast<object>().ToList();
        }

        public decimal getShipmentFee(int id,int count)
        {
            var shiprate = database.ShipMethods.Where(s => s.ShipMethodID == id).FirstOrDefault();
            return shiprate.ShipRate* count;

        }
        
        public void CheckOut(int employeeID,int VendorID,int ShipMethod,DateTime OrderDate,
            DateTime ShipDate,decimal SubTotal,decimal TaxAmt,decimal Freight,decimal TotalDue)
        {
            int ID = database.PurchaseOrderHeaders.ToList().Count()+1;
            DbContextTransaction transaksi = database.Database.BeginTransaction();
            try
            {
                var header = new PurchaseOrderHeader
                {
                    PurchaseOrderID = ID,
                    RevisionNumber = 1,
                    Status = 4,
                    EmployeeID = employeeID,
                    VendorID = VendorID,
                    ShipMethodID = ShipMethod, 
                    OrderDate = OrderDate,
                    ShipDate = ShipDate,
                    SubTotal = SubTotal, 
                    TaxAmt = TaxAmt,
                    Freight= Freight,
                    TotalDue =TotalDue,
                    ModifiedDate = ShipDate
                };
                database.PurchaseOrderHeaders.Add(header);
                database.SaveChanges();
                transaksi.Commit();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString(), "Gagal Insert Header");
                transaksi.Rollback();
            }
            database.SaveChanges();
            
        }
    }
}
