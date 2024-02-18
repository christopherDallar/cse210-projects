using System;

class Cart
{

  List<Order> _orders = new List<Order>();
  Client _client;
  List<Product> _products = new List<Product>();

  DateTime _birthday;

  public Cart()
  {

  }

  public void Start()
  {
    while (true)
    {

      Console.WriteLine("Menu Options:");
      Console.WriteLine("1. Show Inventory");
      Console.WriteLine("2. Create new Product");
      Console.WriteLine("3. Update stock");
      Console.WriteLine("4. Record a sale");
      Console.WriteLine("5. Upload Inventory File");
      Console.WriteLine("6. Save Inventory Balance");
      Console.WriteLine("7. Quit");
      Console.Write("Select a choice from the menu: ");
      int option = int.Parse(Console.ReadLine());

      if (option == 7)
      {
        break;
      }

      switch (option)
      {
        case 1:
          ListProducts();

          break;
        case 2:
          CreateNewProduct();

          break;
        case 3:
          UpdateProductStock();

          break;
        case 4:
          RecordSale();

          break;
        case 5:
          LoadInventory();

          break;
        case 6:
          SaveInventory();

          break;
      }
    }
  }

  double GetTotal()
  {
    return 0.00;
  }

  void NewOrder()
  {

  }

  void DeleteOrder()
  {

  }

  void ListOrderDetails()
  {

  }

  void ListOrderNames()
  {

  }

  List<Product> GetAvailableProducts()
  {
    return _products;
  }

  void ListProducts()
  {
    for (int i = 0; i < _products.Count(); i++)
    {
      Product product = _products[i];

      Console.WriteLine($"{i + 1}. {product.GetDetailsString()}");
    }
  }

  void CreateNewProduct()
  {
    Console.WriteLine("The categories of Product are:");
    Console.WriteLine("1. Food");
    Console.WriteLine("2. Electronic");
    Console.WriteLine("3. Clothing");
    Console.WriteLine("4. Fabrics");
    Console.WriteLine("5. Plant");
    Console.WriteLine("6. Car");
    Console.Write("Which category of product would you like to create? ");
    int option = int.Parse(Console.ReadLine());

    Console.Write("What is the name of your product? ");
    string name = Console.ReadLine();

    Console.Write("What is the cost of your product? ");
    double cost = double.Parse(Console.ReadLine());

    Console.Write("What is the brand of your product? ");
    string brand = Console.ReadLine();

    Console.Write("What is the barCode of your product? ");
    int barCode = int.Parse(Console.ReadLine());

    Console.Write("What is the qty available of your product? ");
    int qtyAvailable = int.Parse(Console.ReadLine());

    switch (option)
    {
      case 1:
        Console.Write("What is the expiration date of your product? ");
        DateTime expirationDate = DateTime.Parse(Console.ReadLine());

        Product product = new Food(name, cost, brand, barCode, qtyAvailable, expirationDate);
        _products.Add(product);
        break;
      case 2:
        Console.Write("What is the warranty period of your product? ");
        string warrantyPeriod = Console.ReadLine();

        product = new Electronic(name, cost, brand, barCode, qtyAvailable, warrantyPeriod);
        _products.Add(product);
        break;
      case 3:
        Console.Write("What is the size of your product? ");
        string size = Console.ReadLine();

        Console.Write("What is the color of your product? ");
        string color = Console.ReadLine();

        product = new Clothing(name, cost, brand, barCode, qtyAvailable, size, color);
        _products.Add(product);
        break;
      case 4:
        Console.Write("What is the width of your product? ");
        double width = double.Parse(Console.ReadLine());

        Console.Write("What is the height of your product? ");
        double height = double.Parse(Console.ReadLine());

        Console.Write("What is the material of your product? ");
        string material = Console.ReadLine();

        product = new Fabrics(name, cost, brand, barCode, qtyAvailable, width, height, material);
        _products.Add(product);
        break;
      case 5:
        Console.Write("Does the plant need shade? Type 1 for True and 0 for False: ");
        bool needShade = int.Parse(Console.ReadLine()) == 1;

        product = new Plant(name, cost, brand, barCode, qtyAvailable, needShade);
        _products.Add(product);
        break;
      case 6:
        Console.Write("What is the mileage of your product? ");
        double mileage = double.Parse(Console.ReadLine());

        Console.Write("What is the horse power of your product? ");
        int horsePower = int.Parse(Console.ReadLine());

        Console.Write("What is the color of your product? ");
        color = Console.ReadLine();

        product = new Car(name, cost, brand, barCode, qtyAvailable, mileage, horsePower, color);

        _products.Add(product);
        break;
      default:
        Console.WriteLine("Please type some category of product");
        break;
    }

  }

  void UpdateProductStock()
  {

  }

  void RecordSale()
  {

  }

  void LoadInventory()
  {

  }

  void SaveInventory()
  {

  }


}