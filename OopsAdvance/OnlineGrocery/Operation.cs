using System;
using System.Collections.Generic;
namespace OnlineGrocery;
class Operation 
{
    private static CustomerDetail currentUser=null;
    public static List<CustomerDetail> customerList=new List<CustomerDetail>( );
     static List<ProductDetail> productList=new List<ProductDetail>( );
    static List<BookingDetail> bookingList=new List<BookingDetail>( );
    static List<OrderDetail> orderList=new List<OrderDetail>( );

    public static void MainMenu( )
    {

         string choice="yes" ;
        do
        {
            DefaultData( );
            System.Console.WriteLine("Main Menu ");
            System.Console.WriteLine("Select the option : 1.Customer Registration 2. Customer Login 3.MainMenu Exit");
            int option=int.Parse(Console.ReadLine());
            switch(option)
            {
               case 1:
              {
                 
                 CustomerRegistration( );
                 break;
              }
              case 2:
              {
                
                CustomerLogin( );
                break;
               }
              case 3: 
              {
                System.Console.WriteLine("MainMenu Exit ");
                choice="no";
                break;
              }
            }
            
            
        }while(choice=="yes");

        
       
    }

    

    public static void CustomerRegistration( )
    {
        System.Console.WriteLine("Enter your Name: ");
        string name=Console.ReadLine();
        System.Console.WriteLine("Enter your Father Name : ");
        string fatherName=Console.ReadLine();
        System.Console.WriteLine("Enter your Gender: ");
        Gender gender=Enum.Parse<Gender>(Console.ReadLine());
        System.Console.WriteLine("Enter your mobile number: ");
        long mobileNumber=long.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter your DOB: ");
        DateTime dob=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
        System.Console.WriteLine("Enter your mail Id: ");
        string mailId=Console.ReadLine();
        CustomerDetail customer1=new CustomerDetail(name,fatherName,gender,mobileNumber,dob,mailId);
        customerList.Add(customer1);
        System.Console.WriteLine("your id is : "+customer1.CustomerID);
        
    }

    public static void CustomerLogin( )
    {
        System.Console.WriteLine("Enter your id: ");
        string customerId=Console.ReadLine().ToUpper( );
        int flag=0;
        foreach(CustomerDetail data in customerList)
        {
            if(customerId==data.CustomerID)
            {
                currentUser=data;
                System.Console.WriteLine("Login successful...");
                SubMenu( );
                flag=1;

            }
           
        }
        if(flag==0)
        {
            System.Console.WriteLine("Invalid user id");
        }
        

    }

    public static void SubMenu( )
    {
         string choice="yes";
        do
        {

             System.Console.WriteLine("Select the option: 1.Show customer Details 2.Show Product Details 3.Wallet recharge 4.Take order 5.Modify order 6. Cancel order 7.Sub menu Exit");
        int option=int.Parse(Console.ReadLine());

        switch(option)
        {
            case 1:
            {
                System.Console.WriteLine("Show customer details ");
                currentUser.ShowCustomerDetails( );
                break;
            }
            case 2:
            {
                System.Console.WriteLine("Show Product Details ");
                ShowProductDetails( );
                break;
            }
            case 3:
            {
                System.Console.WriteLine("Wallet Recharge ");
                currentUser.WalletRecharge( );
                break;
            }
            case 4:
            {
                System.Console.WriteLine("Take order");
                TakeOrder( );
                break;
            }
            case 5:
            {
                System.Console.WriteLine("Modify order");
                break;
            }
            case 6:
            {
                System.Console.WriteLine("Cancel order ");
                break;
            }
            case 7:
            {
                System.Console.WriteLine("Sub Menu Exit ");
                choice="no";
                break;
            }
        }
            
            
        }while(choice=="yes");

       
    }

    public static void DefaultData( )
    {
        //CustomerDetail datas
        CustomerDetail customer1=new CustomerDetail("Baskaran","Sethurajan",Gender.Male,678686,new DateTime(1999,11,11),"basakaran@gmail.com");
        CustomerDetail customer2=new CustomerDetail("Ravi","Ettapparajan",Gender.Male,974774646,new DateTime(1999,11,11),"ravi@gmail.com");
        customerList.Add(customer1);
        customerList.Add(customer2);
        //Productdetails data
        ProductDetail product1=new ProductDetail("Sugar",	20	,40);
        ProductDetail product2=new ProductDetail("Rice",	100	,50);
        ProductDetail product3=new ProductDetail("Milk",	10,	40);
         ProductDetail product4=new ProductDetail("Coffee",10,10);
         ProductDetail product5=new ProductDetail("Tea",10,10);
         ProductDetail product6=new ProductDetail("MasalaPowder",10,20);
         ProductDetail product7=new ProductDetail("Salt",10,10);
         ProductDetail product8=new ProductDetail("Turmeric Powder",10,25);
          ProductDetail product9=new ProductDetail("Chilli Powder",10,20);
          ProductDetail product10=new ProductDetail("Groundnut Oil",10,140);
         productList.Add(product1);
         productList.Add(product2);
         productList.Add(product3);
         productList.Add(product4);
        productList.Add(product5);
         productList.Add(product6);
          productList.Add(product7);
           productList.Add(product8);
            productList.Add(product9);
             productList.Add(product10);

         //Booking Details

         BookingDetail booking1=new BookingDetail("CID3001",220,new DateTime(2022,07,26),BookingStatus.Booked);
         BookingDetail booking2=new BookingDetail("CID3002",400,new DateTime(2022,07,26),BookingStatus.Booked);
         BookingDetail booking3=new BookingDetail("CID3001",280,new DateTime(2022,07,26),BookingStatus.Cancelled);
         BookingDetail booking4=new BookingDetail("CID3002",0,new DateTime(2022,07,26),BookingStatus.Initiated);
        bookingList.Add(booking1);
        bookingList.Add(booking2);
        bookingList.Add(booking3);
        bookingList.Add(booking4);
         //Order details
         OrderDetail order1=new OrderDetail("BID3001","PID101",2,80);
         OrderDetail order2=new OrderDetail("BID3001","PID102",2,100);
         OrderDetail order3=new OrderDetail("BID3001","PID103",1,40);
         OrderDetail order4=new OrderDetail("BID3002","PID101",1,40);
         OrderDetail order5=new OrderDetail("BID3002","PID102",4,200);
         OrderDetail order6=new OrderDetail("BID3002","PID110",1,140);
         OrderDetail order7=new OrderDetail("BID3002","PID109",1,20);
         OrderDetail order8=new OrderDetail("BID3003","PID102",2,100);
         OrderDetail order9=new OrderDetail("BID3003","PID108",4,100);
         OrderDetail order10=new OrderDetail("BID3003","PID101",2,80);
         orderList.Add(order1);
         orderList.Add(order2);
         orderList.Add(order3);
         orderList.Add(order4);
         orderList.Add(order5);
         orderList.Add(order6);
         orderList.Add(order7);
         orderList.Add(order8);
         orderList.Add(order9);
         orderList.Add(order10);
        

    }

    public static void ShowProductDetails()
    {
         foreach(ProductDetail product in productList)
        {
            System.Console.WriteLine(product.ProductId+"\t"+product.ProductName+"\t"+product.QuantityAvailable+"\t"+product.PricePerQuantity);
        }
    }

    public static void TakeOrder( )
    {
        //create a Booking object
        BookingDetail booking3=new BookingDetail(currentUser.CustomerID,0,DateTime.Now,BookingStatus.Initiated);
        // create a local objectList
        List<OrderDetail> temporaryOrderList=new List<OrderDetail>();
        

        string choice="yes";
        do 
        {
            //Show Product detailed list
        ShowProductDetails( );
        //Select a product and check for product
        System.Console.WriteLine("Select a product from above list using the Product Id: ");
        string productId1=Console.ReadLine().ToUpper();
        double price1;
        int flag=0;
        foreach(ProductDetail product in productList)
        {
            if(productId1==product.ProductId)
            {
                System.Console.WriteLine(" Product is available ");
                //Get the Quantity and check for quantity
                 System.Console.WriteLine("Enter the quantity");
                 int quantity1=int.Parse(Console.ReadLine());
                 if(quantity1<=product.QuantityAvailable)
                 {
                    //calculate price and compare with wallet
                    price1=quantity1*product.PricePerQuantity;
                    product.QuantityAvailable-=1;
                    //Take order and create object & add in local order list
                    OrderDetail order1=new OrderDetail(booking3.BookingId,productId1,quantity1,price1);
                    temporaryOrderList.Add(order1);
                         
                    
                 }
                 flag=1;
            }
            if(flag==0)
            {
                System.Console.WriteLine("Product is not available");
            }
        }
        System.Console.WriteLine("Do you want to add the product ?");
        choice=Console.ReadLine();
            
       
        
        
        }while(choice=="yes");
        double totalPrice=0;
        foreach(OrderDetail price in temporaryOrderList)
        {
            totalPrice+=price.PriceOfOrder;
        }
        
        System.Console.WriteLine("Do you want to complete this Process ?");
        string proceed=Console.ReadLine().ToLower();
        while(proceed=="yes")
        {
            if(totalPrice<=currentUser.Balance)
            {
            
               currentUser.Balance-=totalPrice;
               booking3.BookingStatus1=BookingStatus.Booked;
               booking3.TotalPrice=totalPrice;
               break;
            }
            else 
           {
              
              System.Console.WriteLine("Insufficient balance .Please Recharge with "+totalPrice);
              currentUser.WalletRecharge( );
              
            }

        }

        orderList.AddRange(temporaryOrderList); 
    }

}