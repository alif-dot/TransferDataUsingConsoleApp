using POS_SDSIS;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Text;
using System.Net.Http.Headers;
using Microsoft.Extensions.Configuration;

#region retrive Sale & SaleDetail table Data
//public class Program
//{
//    public static async Task Main(string[] args)
//    {
//        using (var context = new AppDbContext())
//        {
//            var sales = await context.Sale
//                .Include(s => s.SaleDetails)
//                .ToListAsync();

//            DisplaySalesData(sales);
//        }

//        Console.WriteLine("Press any key to exit...");
//        Console.ReadKey();
//    }

//    private static void DisplaySalesData(IEnumerable<Sale> sales)
//    {
//        foreach (var sale in sales)
//        {
//            Console.WriteLine("------------------------------------------------------------");
//            Console.WriteLine($"Sale ID: {sale.Id}");
//            Console.WriteLine($"Sequence: {sale.Sequence}");
//            Console.WriteLine($"Company ID: {sale.CompanyId}");
//            Console.WriteLine($"Branch ID: {sale.BranchId}");
//            Console.WriteLine($"Customer ID: {sale.CustomerId}");
//            Console.WriteLine($"Customer Name 1: {sale.CustomerName1}");
//            Console.WriteLine($"Customer Name: {sale.CustomerName}");
//            Console.WriteLine($"Customer Address: {sale.CustomerAddress}");
//            Console.WriteLine($"Customer Phone: {sale.CustomerPhone}");
//            Console.WriteLine($"Sale Order ID: {sale.SaleOrderId}");
//            Console.WriteLine($"Customer Type: {sale.CustomerType}");
//            Console.WriteLine($"Customer Discount in %: {sale.CustomerDiscountInPercentage}");
//            Console.WriteLine($"Customer Discount in Amount: {sale.CustomerDiscountInAmount}");
//            Console.WriteLine($"Customer Discount Amount: {sale.CustomerDiscountAmount}");
//            Console.WriteLine($"Customer Total Discount Amount: {sale.CustomerTotalDiscountAmount}");
//            Console.WriteLine($"Customer Due Amount: {sale.CustomerDueAmount}");
//            Console.WriteLine($"Customer Advance Amount: {sale.CustomerAdvanceAmount}");
//            Console.WriteLine($"Sale No: {sale.SaleNo}");
//            Console.WriteLine($"Sale Date: {sale.SaleDate}");
//            Console.WriteLine($"Loading Charge: {sale.LoadingCharge}");
//            Console.WriteLine($"Transport Charge: {sale.TransportCharge}");
//            Console.WriteLine($"Other Charges: {sale.OthersCharge}");
//            Console.WriteLine($"Total Boxes: {sale.TotalBoxes}");
//            Console.WriteLine($"Total Pcses: {sale.TotalPcses}");
//            Console.WriteLine($"Total Quantity: {sale.TotalQuantity}");
//            Console.WriteLine($"Total Price: {sale.TotalPrice}");
//            Console.WriteLine($"Discount in Percentage: {sale.DiscountInPercentage}");
//            Console.WriteLine($"Discount in Amount: {sale.DiscountInAmount}");
//            Console.WriteLine($"Discount Amount: {sale.DiscountAmount}");
//            Console.WriteLine($"Overall Discount: {sale.OverAllDiscount}");
//            Console.WriteLine($"Overall Discount in Percentage: {sale.OverAllDiscountInPercentage}");
//            Console.WriteLine($"Total Discount: {sale.TotalDiscount}");
//            Console.WriteLine($"Total Amount: {sale.TotalAmount}");
//            Console.WriteLine($"Total Profit: {sale.TotalProfit}");
//            Console.WriteLine($"Total VAT: {sale.TotalVat}");
//            Console.WriteLine($"Total SD: {sale.TotalSD}");
//            Console.WriteLine($"Net Amount: {sale.NetAmount}");
//            Console.WriteLine($"Retail Total: {sale.RetailTotal}");
//            Console.WriteLine($"Paid Amount: {sale.PaidAmount}");
//            Console.WriteLine($"Change Amount: {sale.ChangeAmount}");
//            Console.WriteLine($"Due Amount: {sale.DueAmount}");
//            Console.WriteLine($"Is Approved Needed: {sale.IsApprovedNeeded}");
//            Console.WriteLine($"Is Approved: {sale.IsApproved}");
//            Console.WriteLine($"Approved By: {sale.ApprovedBy}");
//            Console.WriteLine($"Is Fully Delivered: {sale.IsFullyDelivered}");
//            Console.WriteLine($"Is Fully Returned: {sale.IsFullyReturned}");
//            Console.WriteLine($"Payment Type: {sale.PaymentType}");
//            Console.WriteLine($"Card Type: {sale.CardType}");
//            Console.WriteLine($"Card Number: {sale.CardNumber}");
//            Console.WriteLine($"Bank Name: {sale.BankName}");
//            Console.WriteLine($"Cheque No: {sale.ChequeNo}");
//            Console.WriteLine($"Cheque Date: {sale.ChequeDate}");
//            Console.WriteLine($"Is Active: {sale.IsActive}");
//            Console.WriteLine($"Is Archive: {sale.IsArchive}");
//            Console.WriteLine($"Is Synchronized: {sale.IsSynchronized}");
//            Console.WriteLine($"Is Updated: {sale.IsUpdated}");
//            Console.WriteLine($"Synchronization Type: {sale.SynchronizationType}");
//            Console.WriteLine($"Comments: {sale.Comments}");
//            Console.WriteLine($"Delivery Address: {sale.DeliveryAddress}");
//            Console.WriteLine($"Is VAT Applicable: {sale.IsVatApplicable}");
//            Console.WriteLine($"Is Posted: {sale.IsPosted}");
//            Console.WriteLine($"Delivery Date: {sale.DeliveryDate}");
//            Console.WriteLine($"Document No: {sale.DocumentNo}");
//            Console.WriteLine($"Is Delivery Confirm: {sale.IsDeliveryConfirm}");
//            Console.WriteLine($"Sale Person: {sale.SalePerson}");
//            Console.WriteLine($"Total Weight: {sale.TotalWeight}");
//            Console.WriteLine($"VAT in Percentage: {sale.VATInPercentage}");
//            Console.WriteLine($"Driver ID: {sale.DriverId}");
//            Console.WriteLine($"Driver Name: {sale.DriverName}");
//            Console.WriteLine($"Fitter ID: {sale.FitterId}");

//            Console.WriteLine("\nSale Details:");
//            Console.WriteLine("------------------------------------------------------------------");

//            foreach (var detail in sale.SaleDetails)
//            {
//                Console.WriteLine($"Detail ID: {detail.Id}");
//                Console.WriteLine($"Detail Sequence: {detail.Sequence}");
//                Console.WriteLine($"Company ID: {detail.CompanyId}");
//                Console.WriteLine($"Branch ID: {detail.BranchId}");
//                Console.WriteLine($"Sale ID: {detail.SaleId}");
//                Console.WriteLine($"Item ID: {detail.ItemId}");
//                Console.WriteLine($"Project ID: {detail.ProjectId}");
//                Console.WriteLine($"Sale Order ID: {detail.SaleOrderId}");
//                Console.WriteLine($"Sale Order Detail ID: {detail.SaleOrderDetailId}");
//                Console.WriteLine($"Item Code: {detail.ItemCode}");
//                Console.WriteLine($"Item Name: {detail.ItemName}");
//                Console.WriteLine($"UOM ID: {detail.UOMId}");
//                Console.WriteLine($"Size ID: {detail.SizeId}");
//                Console.WriteLine($"Color ID: {detail.ColorId}");
//                Console.WriteLine($"Grade ID: {detail.GradeId}");
//                Console.WriteLine($"Supplier ID: {detail.SupplierId}");
//                Console.WriteLine($"Brand ID: {detail.BrandId}");
//                Console.WriteLine($"Item Category ID: {detail.ItemCategoryId}");
//                Console.WriteLine($"Item SubCategory ID: {detail.ItemSubCategoryId}");
//                Console.WriteLine($"Item Subsidiary Category ID: {detail.ItemSubsidiaryCategoryId}");
//                Console.WriteLine($"Sale Date: {detail.SaleDate}");
//                Console.WriteLine($"Sale Detail Date: {detail.SaleDetailDate}");
//                Console.WriteLine($"Quantity: {detail.Quantity}");
//                Console.WriteLine($"Boxes: {detail.Boxes}");
//                Console.WriteLine($"Pcses: {detail.Pcses}");
//                Console.WriteLine($"Upper Conversion: {detail.UpperConversion}");
//                Console.WriteLine($"Lower Conversion: {detail.LowerConversion}");
//                Console.WriteLine($"Unit: {detail.Unit}");
//                Console.WriteLine($"Stock Quantity: {detail.StockQty}");
//                Console.WriteLine($"Unit Price: {detail.UnitPrice}");
//                Console.WriteLine($"Purchase Price: {detail.PurchasePrice}");
//                Console.WriteLine($"Discount Per Unit: {detail.DiscountPerUnit}");
//                Console.WriteLine($"Discount Amount: {detail.DiscountAmount}");
//                Console.WriteLine($"Discount in Percentage: {detail.DiscountInPercentage}");
//                Console.WriteLine($"Discount in Amount: {detail.DiscountInAmount}");
//                Console.WriteLine($"Profit Per Unit: {detail.ProfitPerUnit}");
//                Console.WriteLine($"Loading Charge Per Unit: {detail.LoadingChargePerUnit}");
//                Console.WriteLine($"Loading Charge Amount: {detail.LoadingChargeAmount}");
//                Console.WriteLine($"Profit Amount: {detail.ProfitAmount}");
//                Console.WriteLine($"VAT in Percentage: {detail.VatInPercentage}");
//                Console.WriteLine($"VAT in Amount: {detail.VatInAmount}");
//                Console.WriteLine($"Tax Rate: {detail.TaxRate}");
//                Console.WriteLine($"Tax Amount: {detail.TaxAmount}");
//                Console.WriteLine($"SD Rate: {detail.SDRate}");
//                Console.WriteLine($"SD Amount: {detail.SDAmount}");
//                Console.WriteLine($"VAT Per Unit: {detail.VatPerUnit}");
//                Console.WriteLine($"VAT Amount: {detail.VatAmount}");
//                Console.WriteLine($"Total Amount: {detail.TotalAmount}");
//                Console.WriteLine($"Is Returned: {detail.IsReturned}");
//                Console.WriteLine($"Is Delivered: {detail.IsDelivered}");
//                Console.WriteLine($"Is Active: {detail.IsActive}");
//                Console.WriteLine($"Is Archive: {detail.IsArchive}");
//                Console.WriteLine($"Is Synchronized: {detail.IsSynchronized}");
//                Console.WriteLine($"Is Updated: {detail.IsUpdated}");
//                Console.WriteLine($"Synchronization Type: {detail.SynchronizationType}");
//                Console.WriteLine($"Comments: {detail.Comments}");
//                Console.WriteLine("------------------------------------------------------------------");
//            }
//        }
//    }
//}
#endregion

#region Push Sale & SaleDetail table data into another DB
//public static class Program
//{
//    public static async Task Main(string[] args)
//    {
//        using (var sourceContext = new AppDbContext())
//        using (var destinationContext = new TargetDbContext())
//        {
//            // Retrieve unsynchronized sales from the source database
//            var unsynchronizedSales = await sourceContext.Sale
//                .Include(s => s.SaleDetails)
//                .Where(s => !s.IsSynchronized)
//                .ToListAsync();

//            if (unsynchronizedSales.Count > 0)
//            {
//                // Transfer data to destination database
//                foreach (var sale in unsynchronizedSales)
//                {
//                    // Check if sale already exists in destination
//                    var existingSale = await destinationContext.Sale
//                        .Include(s => s.SaleDetails)
//                        .FirstOrDefaultAsync(s => s.Id == sale.Id);

//                    if (existingSale == null)
//                    {
//                        // Add sale and sale details to destination database
//                        await destinationContext.Sale.AddAsync(sale);
//                    }
//                }

//                await destinationContext.SaveChangesAsync();

//                // Update IsSynchronized in the source database
//                foreach (var sale in unsynchronizedSales)
//                {
//                    sale.IsSynchronized = true;
//                    sourceContext.Sale.Update(sale);

//                    // Update SaleDetail records
//                    foreach (var detail in sale.SaleDetails)
//                    {
//                        detail.IsSynchronized = true;
//                        sourceContext.SaleDetail.Update(detail);
//                    }
//                }

//                await sourceContext.SaveChangesAsync();

//                Console.WriteLine("Data transfer and synchronization completed.");
//            }
//            else
//            {
//                Console.WriteLine("No unsynchronized data found.");
//            }
//        }

//        Console.WriteLine("Press any key to exit...");
//        Console.ReadKey();
//    }
//}
#endregion

#region Send Data to API
public static class Program
{
    private static IConfigurationRoot configuration;

    public static async Task Main(string[] args)
    {
        #region Configuration
        // Build configuration
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
        configuration = builder.Build();

        // Retrieve the API URL and Connection String from appsettings.json
        string saleApiUrl = configuration.GetSection("ApiSettings:SaleApiUrl").Value;
        string purchaseApiUrl = configuration.GetSection("ApiSettings:PurchaseApiUrl").Value;
        string kotApiUrl = configuration.GetSection("ApiSettings:KOTApiUrl").Value;
        string goodsReceiveApiUrl = configuration.GetSection("ApiSettings:GoodsReceiveApiUrl").Value;

        string connectionString = configuration.GetConnectionString("DefaultConnection");
        #endregion

        using (var sourceContext = new AppDbContext(connectionString))
        {
            #region Send Sale data
            // Retrieve unsynchronized sales from the source database
            var unsynchronizedSales = await sourceContext.Sale
                .Include(s => s.SaleDetails)
                .Where(s => !s.IsSynchronized)
                .ToListAsync();

            if (unsynchronizedSales.Count > 0)
            {
                // Loop through each unsynchronized sale
                foreach (var sale in unsynchronizedSales)
                {
                    // Example of setting default values before sending data
                    foreach (var detail in sale.SaleDetails)
                    {
                        detail.ModifiedBy = detail.ItemSubsidiaryCategoryId ?? "admin";
                        detail.ModifiedIP = detail.ItemSubsidiaryCategoryId ?? "::1";
                        detail.ModifiedDate = detail.ModifiedDate ?? new DateTime(2024, 1, 1);
                        detail.CreatedBy = detail.CreatedBy ?? "admin";
                        detail.CreatedIP = detail.CreatedIP ?? "::1";
                        detail.CreatedDate = detail.CreatedDate ?? new DateTime(2024, 1, 1);
                    }

                    // Convert sale object to JSON
                    //var jsonData = JsonConvert.SerializeObject(sale);
                    var jsonData = JsonConvert.SerializeObject(sale, new JsonSerializerSettings
                    {
                        ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                    });

                    var isSuccess = await SendDataToApiAsync(saleApiUrl, jsonData);

                    if (isSuccess)
                    {
                        // Update IsSynchronized flag for Sale and its SaleDetails in source database
                        sale.IsSynchronized = true;
                        sourceContext.Sale.Update(sale);

                        foreach (var detail in sale.SaleDetails)
                        {
                            detail.IsSynchronized = true;
                            sourceContext.SaleDetail.Update(detail);
                        }

                        await sourceContext.SaveChangesAsync();
                    }
                }

                Console.WriteLine("Data transfer and synchronization completed.");
            }
            else
            {
                Console.WriteLine("No unsynchronized data found.");
            }
            #endregion Sale data send end

            #region Send Purchase data
            // Retrieve unsynchronized purchases from the source database
            var unsynchronizedPurchases = await sourceContext.Purchase
                .Include(p => p.PurchaseDetails)
                .Where(p => !p.IsSynchronized)
                .ToListAsync();

            if (unsynchronizedPurchases.Count > 0)
            {
                // Loop through each unsynchronized purchase
                foreach (var purchase in unsynchronizedPurchases)
                {
                    // Example of setting default values before sending data
                    foreach (var detail in purchase.PurchaseDetails)
                    {
                        //detail.Unit = detail.Unit ?? "";
                        //detail.SizeId = detail.SizeId ?? "";
                        //detail.ColorId = detail.ColorId ?? "";
                        //detail.BrandId = detail.BrandId ?? "";
                        //detail.Comments = detail.Comments ?? "";
                        detail.ModifiedBy = detail.ModifiedBy ?? "admin";
                        detail.ModifiedIP = detail.ModifiedIP ?? "::1";
                        detail.ModifiedDate = detail.ModifiedDate ?? new DateTime(2024, 1, 1);
                        detail.CreatedBy = detail.CreatedBy ?? "admin";
                        detail.CreatedIP = detail.CreatedIP ?? "::1";
                        detail.CreatedDate = detail.CreatedDate ?? new DateTime(2024, 1, 1);
                    }

                    // Convert purchase object to JSON
                    var jsonData = JsonConvert.SerializeObject(purchase, new JsonSerializerSettings
                    {
                        ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                    });

                    var isSuccess = await SendDataToApiAsync(purchaseApiUrl, jsonData);

                    if (isSuccess)
                    {
                        // Update IsSynchronized flag for Purchase and its PurchaseDetails in source database
                        purchase.IsSynchronized = true;
                        sourceContext.Purchase.Update(purchase);

                        foreach (var detail in purchase.PurchaseDetails)
                        {
                            detail.IsSynchronized = true;
                            sourceContext.PurchaseDetail.Update(detail);
                        }

                        await sourceContext.SaveChangesAsync();
                    }
                }

                Console.WriteLine("Purchase data transfer and synchronization completed.");
            }
            else
            {
                Console.WriteLine("No unsynchronized purchase data found.");
            }
            #endregion Purchase data send end

            #region Send KOT Order data
            // Retrieve unsynchronized KOT orders from the source database
            var unsynchronizedKOTOrders = await sourceContext.KOTOrderMaster
                .Include(k => k.KOTOrderDetails)
                .Where(k => !k.IsSynchronized)
                .ToListAsync();

            if (unsynchronizedKOTOrders.Count > 0)
            {
                foreach (var kotOrder in unsynchronizedKOTOrders)
                {
                    // Convert KOT order object to JSON
                    var jsonData = JsonConvert.SerializeObject(kotOrder, new JsonSerializerSettings
                    {
                        ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                    });

                    var isSuccess = await SendDataToApiAsync(kotApiUrl, jsonData);

                    if (isSuccess)
                    {
                        // Update IsSynchronized flag for KOTOrderMaster and its KOTOrderDetails
                        kotOrder.IsSynchronized = true;
                        sourceContext.KOTOrderMaster.Update(kotOrder);

                        foreach (var detail in kotOrder.KOTOrderDetails)
                        {
                            detail.IsSynchronized = true;
                            sourceContext.KOTOrderDetail.Update(detail);
                        }

                        await sourceContext.SaveChangesAsync();
                    }
                }

                Console.WriteLine("KOT Order data transfer and synchronization completed.");
            }
            else
            {
                Console.WriteLine("No unsynchronized KOT Order data found.");
            }
            #endregion

            #region Send Goods Receive data
            // Retrieve unsynchronized goods receive data from the source database
            var unsynchronizedGoodsReceives = await sourceContext.GoodsReceive
                .Include(gr => gr.GoodsReceiveDetail)
                .Where(gr => !gr.IsSynchronized)
                .ToListAsync();

            if (unsynchronizedGoodsReceives.Count > 0)
            {
                // Loop through each unsynchronized goods receive entry
                foreach (var goodsReceive in unsynchronizedGoodsReceives)
                {
                    // Convert goodsReceive object to JSON
                    var jsonData = JsonConvert.SerializeObject(goodsReceive, new JsonSerializerSettings
                    {
                        ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                    });

                    var isSuccess = await SendDataToApiAsync(goodsReceiveApiUrl, jsonData);

                    if (isSuccess)
                    {
                        // Update IsSynchronized flag for GoodsReceive and its details
                        goodsReceive.IsSynchronized = true;
                        sourceContext.GoodsReceive.Update(goodsReceive);

                        foreach (var detail in goodsReceive.GoodsReceiveDetail)
                        {
                            detail.IsSynchronized = true;
                            sourceContext.GoodsReceiveDetail.Update(detail);
                        }

                        await sourceContext.SaveChangesAsync();
                    }
                }

                Console.WriteLine("Goods Receive data transfer and synchronization completed.");
            }
            else
            {
                Console.WriteLine("No unsynchronized goods receive data found.");
            }
            #endregion
        }

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }

    private static async Task<bool> SendDataToApiAsync(string url, string jsonData)
    {
        //var apiKey = configuration.GetSection("ApiSettings:ApiKey").Value; // Retrieve the API key from configuration

        using (var client = new HttpClient())
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            //client.DefaultRequestHeaders.Add("X-Api-Key", apiKey);

            var content = new StringContent(jsonData, Encoding.UTF8, "application/json");

            try
            {
                var response = await client.PostAsync(url, content);

                if (response.IsSuccessStatusCode)
                {
                    Console.WriteLine("Data sent successfully.");
                    return true;
                }
                else
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    Console.WriteLine($"Failed to send data to {url}. Status: {response.StatusCode}. Error: {errorContent}");
                    return false;
                }
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"HttpRequestException: {ex.Message}");
                if (ex.InnerException != null)
                {
                    Console.WriteLine($"Inner exception: {ex.InnerException.Message}");
                }
                return false;
            }
        }
    }

}
#endregion
