using System;

abstract class Product
{
  string _name;
  double _cost;
  string _brand;
  int _barCode;
  int _qtyAvailable;

  public Product(
    string name,
    double cost,
    string brand,
    int barCode,
    int qtyAvailable
  )
  {

    _name = name;
    _cost = cost;
    _brand = brand;
    _barCode = barCode;
    _qtyAvailable = qtyAvailable;

  }

  public bool IsAvailable()
  {
    return _qtyAvailable == 0;
  }

  virtual public string GetDetailsString()
  {
    return $"{_name}, brand: {_brand}, barcode: {_barCode}; Cost: {_cost}, Available Qty: {_qtyAvailable}";
  }

  virtual public string GetStringRepresentation()
  {
    return "";
  }

  public void DecrementQty()
  {

  }

  public void IncrementQty()
  {

  }

  public int GetQty()
  {
    return 0;
  }
  public double GetCost()
  {
    return 0.00;
  }
}