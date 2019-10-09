using System.Collections.Generic;

namespace BigfootTracker.Models
{
    public class Item
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Purchased { get; set; }
        public int Weight { get; set; }
        public int Id { get; }
        public static List<Item> _instances = new List<Item> {};

        public Item (string name, string description, string purchased, int weight)
        {
            Name = name;
            Description = description;
            Purchased = purchased;
            Weight = weight;
            _instances.Add(this);
            Id = _instances.Count;
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