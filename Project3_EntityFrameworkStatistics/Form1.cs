using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project3_EntityFrameworkStatistics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DbIstatisticEntities db=new DbIstatisticEntities();
        private void Form1_Load(object sender, EventArgs e)
        {
            //Toplam Kategori Sayısı
            int categoryCount=db.TblCategory.Count();
            lblCategoryCount.Text = categoryCount.ToString();

            //Toplam Ürün sayısı
            int productCount=db.TblProduct.Count();
            lblProductCount.Text = productCount.ToString();

            //Toplam Müşteri Sayısı
            int cutomerCount=db.TblCustomer.Count();
            lblCustomerCount.Text = cutomerCount.ToString();

            //Toplam Sipariş Sayısı
            int orderCount=db.TblOrder.Count();
            lblOrderCount.Text = orderCount.ToString();

            //Toplam Stok Sayısı
            var totalProductStockCount = db.TblProduct.Sum(x => x.ProductStock);
            lblTotalStockCount.Text = totalProductStockCount.ToString();

            //Ortalama Ürün Fiyatı
            var avarageProductPrice = db.TblProduct.Average(x => (decimal?)x.ProductPrice) ?? 0;
            lblProductAvaragePrice.Text = avarageProductPrice.ToString("F2") + " TL";

            //Toplam Meyve Stoğu
            var totalFruitStock=db.TblProduct.Where(x=>x.CategoryId==1).Sum(y=>y.ProductStock);
            lblTotalFuitCount.Text = totalFruitStock.ToString();

            //Gazoz İsimliÜrünün toplam işlem hacmi
            var totalPriceByProductNameGazozGetStock=db.TblProduct.Where(x=>x.ProductName=="Gazoz").Select(y=>y.ProductStock).FirstOrDefault();
            var totalPriceByProductNameGazozGetPrice=db.TblProduct.Where(x=>x.ProductName=="Gazoz").Select(y=>y.ProductPrice).FirstOrDefault();
            var totalPriceByProductNameGazoz = totalPriceByProductNameGazozGetStock * totalPriceByProductNameGazozGetPrice;
            lblGazozTotalVolume.Text= totalPriceByProductNameGazoz.ToString();

            //Stok sayısı 100 den küçük ürün sayısı
            var productCountByStockUndertheHundred = db.TblProduct.Where(x => x.ProductStock < 100).Count();
            lblStockUnitUnderHundred.Text=productCountByStockUndertheHundred.ToString();

            //Aktif Sebze sayısı
           
            var productStokcCountByCategoryNameIsSebzeandStatusIsTrue = db.TblProduct.Where(x => x.CategoryId == db.TblCategory.Where(c => c.CategoryName == "Sebze").Select(y => y.CategoryId).FirstOrDefault() && x.ProductStatus == true).Sum(y => y.ProductStock);
            lblAktiveFruitCount.Text= productStokcCountByCategoryNameIsSebzeandStatusIsTrue.ToString();

            //Türkiyeden gelen sipariş sayısı SqlQuery
            var orderbyTurkiye=db.Database.SqlQuery<int>("Select count(*) From TblOrder where CustomerId In (Select CustomerId From TblCustomer Where CustomerCountry='Türkiye')").FirstOrDefault();
            lblOrderByTurkiye.Text= orderbyTurkiye.ToString();

            //Türkiyeden gelen sipariş sayısı Ef
            var turkCustomerId=db.TblCustomer.Where(x=>x.CustomerCountry=="Türkiye")
                                                .Select(y => y.CustomerId)
                                                   .ToList();
            var orderCountTurkiye = db.TblOrder.Count(z => turkCustomerId.Contains(z.CustomerId.Value));
            lblOrderByTurkiyeEf.Text= orderCountTurkiye.ToString();

            //Siparişler iiçinde Kategorisi Meyve olan ürünleri toplam satış fiyatı SQL
            var orderTotalPriceByMeyve = db.Database.SqlQuery<decimal>("Select Sum(o.TotalPrice) from TblOrder o join TblProduct p On o.ProductId=p.ProductId Join TblCategory c On p.CategoryId=c.CategoryId where c.CategoryName='Meyve'").FirstOrDefault();
            lblTotalEarnFromFruit.Text= orderTotalPriceByMeyve.ToString();

            //Siparişler iiçinde Kategorisi Meyve olan ürünleri toplam satış fiyatı EntitFrameWork
            var orderTotalPriceByMeyveEf = (from o in db.TblOrder
                                            join p in db.TblProduct on o.ProductId equals p.ProductId
                                            join c in db.TblCategory on p.CategoryId equals c.CategoryId
                                            where c.CategoryName == "Meyve"
                                            select o.TotalPrice).Sum();
            lblTotalEarnFromFruitEf.Text= orderTotalPriceByMeyveEf.ToString();

            //Son eklenen Ürün Adı
            var lastProduct=db.TblProduct.OrderByDescending(x=>x.ProductId).Select(y=>y.ProductName).FirstOrDefault();
            lblLastAddedProductName.Text=lastProduct.ToString();

            //Son Eklenen Ürünün Kategorisi
            var lastProductCategoryID = db.TblProduct.OrderByDescending(x => x.ProductId).Select(y => y.CategoryId).FirstOrDefault();
            var lastProductCategory=db.TblCategory.Where(x=>x.CategoryId==lastProductCategoryID).Select(y=>y.CategoryName).FirstOrDefault();
            lblLastAddedProductCategory.Text=lastProductCategory.ToString();

            //Aktif Ürün Sayısı
            var aktiveProductCount=db.TblProduct.Where(x=>x.ProductStatus==true).Count();
            lblAktiveProductCount.Text=aktiveProductCount.ToString();

            //Toplam Kola satışından Beklenen kar
            var colaStok=db.TblProduct.Where(x=>x.ProductName=="Kola").Select(y=>y.ProductStock).FirstOrDefault();
            var colaPrice=db.TblProduct.Where(y=>y.ProductName=="Kola").Select(x=>x.ProductPrice).FirstOrDefault();
            var totalStockPrice = colaPrice * colaStok;
            lblTotalEarnByCola.Text=totalStockPrice.ToString();


            //Son eklenen Müşteri adı
            var lastCostumer = db.TblCustomer.OrderByDescending(x => x.CustomerId).Select(y => y.CustomerName).FirstOrDefault();
            lblLastCustomerName.Text = lastCostumer.ToString();

            //Ülke Sayısı
            var countryCount=db.TblCustomer.Select(x=>x.CustomerCountry).Distinct().Count();
            lblCountryCount.Text=countryCount.ToString();
        }
    }
}
