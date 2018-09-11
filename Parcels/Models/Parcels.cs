using System.Collections.Generic;
using System;

namespace Parcels.Models
{
  public class Parcel
  {
    public int length { get; set; }
    public int width { get; set; }
    public int heighth { get; set; }
    public int weight { get; set; }
    public int cost = 0;
    private static List<Parcel> _instances = new List<Parcel> { };

    public Parcel(string newLength, string newWidth, string newHeighth, string newWeight)
    {
      length = int.Parse(newLength);
      width = int.Parse(newWidth);
      heighth = int.Parse(newHeighth);
      weight = int.Parse(newWeight);
    }

    public int Volume()
    {
      return (length * width * heighth);
    }

    public int costToShip()
    {
      cost = weight * 2;
      return cost;
    }

    public static List<Parcel> GetAll()
    {
      return _instances;
    }

    public void Save()
    {
      _instances.Add(this);
    }
  }
}
