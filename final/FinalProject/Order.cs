using System;

class Order
{

  Product _product;
  int _qty;

  DateTime _birthday;

  public Order(
    Product product,
    int qty
  )
  {
    _product = product;
    _qty = qty;
  }

  public double GetSubtotal()
  {
    return 0.00;
  }

}