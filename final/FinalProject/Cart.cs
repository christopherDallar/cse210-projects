using System;
using System.IO;

class Cart
{

  List<Order> _orders = new List<Order>();
  Client _client;
  List<Product> _products = new List<Product>();

  public Cart()
  {

  }

  public void Start()
  {
    while (true)
    {

      Console.WriteLine("");
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

      Console.WriteLine("");

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

    Console.Write("What is the brand of your product? ");
    string brand = Console.ReadLine();

    Console.Write("What is the cost of your product? ");
    double cost = double.Parse(Console.ReadLine());

    Console.Write("What is the barCode of your product? ");
    int barCode = int.Parse(Console.ReadLine());

    Console.Write("What is the qty available of your product? ");
    int qtyAvailable = int.Parse(Console.ReadLine());

    switch (option)
    {
      case 1:
        Console.Write("What is the expiration date of your product (Format: mm-dd-yyyy)? ");
        DateTime expirationDate = DateTime.Parse(Console.ReadLine());

        Product product = new Food(name, cost, brand, barCode, qtyAvailable, expirationDate);
        _products.Add(product);
        break;
      case 2:
        Console.Write("What is the warranty (string) period of your product? ");
        string warrantyPeriod = Console.ReadLine();

        product = new Electronic(name, cost, brand, barCode, qtyAvailable, warrantyPeriod);
        _products.Add(product);
        break;
      case 3:
        Console.Write("What is the size of your product (Example: XS, S, M, L, XL, XXL)? ");
        string size = Console.ReadLine();

        Console.Write("What is the color of your product? ");
        string color = Console.ReadLine();

        product = new Clothing(name, cost, brand, barCode, qtyAvailable, size, color);
        _products.Add(product);
        break;
      case 4:
        Console.Write("What is the width (number) of your product? ");
        double width = double.Parse(Console.ReadLine());

        Console.Write("What is the height (number) of your product? ");
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
        Console.Write("What is the mileage (number) of your product? ");
        double mileage = double.Parse(Console.ReadLine());

        Console.Write("What is the horse power (number) of your product? ");
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
    ListProducts();

    Console.WriteLine("");
    Console.Write("Select a product to update the stock: ");
    int productIdx = int.Parse(Console.ReadLine()) - 1;

    Console.WriteLine("");
    Console.Write("Type 1 for increase or 0 for decrease stock quantity: ");
    bool toIncrease = int.Parse(Console.ReadLine()) == 1;

    Console.WriteLine("");
    Console.Write("Type quantity (units): ");
    int qty = int.Parse(Console.ReadLine());

    Product product = _products[productIdx];

    if (toIncrease)
    {
      product.IncrementQty(qty);
    }
    else
    {
      product.DecrementQty(qty);
    }


    Console.WriteLine("");
    Console.WriteLine("Product Stock Updated");
    Console.WriteLine($"{productIdx + 1}. {product.GetDetailsString()}");

  }

  void RecordSale()
  {

  }

  void LoadInventory()
  {
    _products = new List<Product>();

    Console.Write("What is the filename for the products file? ");
    string fileName = Console.ReadLine();

    string[] lines = System.IO.File.ReadAllLines(fileName);

    for (int i = 0; i < lines.Length; i++)
    {
      string line = lines[i];

      string[] data = line.Split("|");

      string category = data[0];
      string name = data[1];
      string brand = data[2];
      int barCode = int.Parse(data[3]);
      double cost = double.Parse(data[4]);
      int qtyAvailable = int.Parse(data[5]);

      switch (category)
      {
        case "car":
          double mileage = double.Parse(data[6]);
          int horsePower = int.Parse(data[7]);
          string color = data[8];

          Product product = new Car(name, cost, brand, barCode, qtyAvailable, mileage, horsePower, color);

          _products.Add(product);

          break;
        case "clothing":
          string size = data[6];
          color = data[7];

          product = new Clothing(name, cost, brand, barCode, qtyAvailable, size, color);

          _products.Add(product);
          break;
        case "electronic":

          string warrantyPeriod = data[6];

          product = new Electronic(name, cost, brand, barCode, qtyAvailable, warrantyPeriod);

          _products.Add(product);

          break;
        case "fabrics":
          double width = double.Parse(data[6]);
          double height = double.Parse(data[7]);
          string material = data[8];

          product = new Fabrics(name, cost, brand, barCode, qtyAvailable, width, height, material);

          _products.Add(product);
          break;
        case "food":

          DateTime expirationDate = DateTime.Parse(data[6]);

          product = new Food(name, cost, brand, barCode, qtyAvailable, expirationDate);

          _products.Add(product);

          break;
        case "plant":
          bool needShade = bool.Parse(data[6]);

          product = new Plant(name, cost, brand, barCode, qtyAvailable, needShade);

          _products.Add(product);
          break;
      }
    }
  }

  void SaveInventory()
  {
    Console.Write("What is the filename for the products file? ");
    string fileName = Console.ReadLine();

    using (StreamWriter outputFile = new StreamWriter(fileName))
    {
      foreach (var product in _products)
      {
        outputFile.WriteLine(product.GetStringRepresentation());
      }
    }
  }


}