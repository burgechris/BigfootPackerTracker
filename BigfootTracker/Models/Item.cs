using System.Collections.Generic;
using System.Linq;

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
        public static int _backpackWeight { get; set; }
        private static int _idCounter = 0;

        public Item (string name, string description, string purchased, int weight)
        {
            Name = name;
            Description = description;
            Purchased = purchased;
            Weight = weight;
            _instances.Add(this);
            _idCounter ++;
            Id = _idCounter;
            _backpackWeight = 0;
        }

        public static List<Item> GetAll()
        {
        return _instances;
        }

        public static Item Find(int searchId)
        {
        return _instances.Where(item => item.Id == searchId).FirstOrDefault();
        }

        public static void ClearAll()
        {
        _instances.Clear();
        }

        public static void BackpackWeight()
        {
            _backpackWeight = 0;
            foreach (Item item in _instances)
            {
                _backpackWeight += item.Weight;
            }
        }

        public static string TooHeavy()
        {
            if (_backpackWeight > 80)
            {
                string message = "Your backpack is too heavy!";
                return message;
            }
            else
            {
                string message = "Add more shit!";
                return message;
            }
        }

    }
}