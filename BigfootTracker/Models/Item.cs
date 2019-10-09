using System.Collections.Generic;

namespace BigfootTracker.Models
{
    public class Item
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Purchased { get; set; }
        public int Weight { get; set; }
        public int Id { get; }
        public static List<Item> _instances = new List<Item> {};

        public Item (string Name, string Description, bool Purchased, int Weight)
        {
            Name = name;
            Description = description;
            Purchased = purchased;
            Weight = weight;
            Id = _instances.Count;
            _instances.Add(this);
        }

        public static List<Item> GetAll()
        {
        return _instances;
        }

        public static Item Find(int searchId)
        {
        return _instances[searchId-1];
        }

        public static void ClearAll()
        {
        _instances.Clear();
        }


    }
}