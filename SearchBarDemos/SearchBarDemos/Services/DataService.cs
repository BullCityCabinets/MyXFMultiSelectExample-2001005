﻿using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace SearchBarDemos.Services
{
    public static class DataService
    {
        public static ObservableCollection<string> Fruits { get; } = new ObservableCollection<string>
        {
            "Akee",
            "Apple",
            "Apricot",
            "Avocado",
            "Banana",
            "Bilberry",
            "Blackberry",
            "Blackcurrant",
            "Blood Orange",
            "Blueberry",
            "Boysenberry",
            "Cantaloupe",
            "Cherimoya",
            "Cherry",
            "Chico fruit",
            "Clementine",
            "Cloudberry",
            "Coconut",
            "Crab apples",
            "Cranberry",
            "Cucumber",
            "Currant",
            "Damson",
            "Date",
            "Dragonfruit",
            "Durian",
            "Elderberry",
            "Feijoa",
            "Fig",
            "Goji berry",
            "Gooseberry",
            "Grape",
            "Grapefruit",
            "Guava",
            "Honeyberry",
            "Honeydew",
            "Huckleberry",
            "Jabuticaba",
            "Jackfruit",
            "Jambul",
            "Japanese Plum",
            "Jostaberry",
            "Jujube",
            "Juniper Berry",
            "Kiwano",
            "Kiwifruit",
            "Kumquat",
            "Lemon",
            "Lime",
            "Longan",
            "Loquat",
            "Lychee",
            "Mandarine",
            "Mango",
            "Mangosteen",
            "Marionberry",
            "Miracle fruit",
            "Mulberry",
            "Nance",
            "Nectarine",
            "Orange",
            "Papaya",
            "Passionfruit",
            "Peach",
            "Pear",
            "Persimmon",
            "Pineapple",
            "Pineberry",
            "Pitaya",
            "Plantain",
            "Plum",
            "Pomegranate",
            "Pomelo",
            "Purple Mangosteen",
            "Quince",
            "Raspberry",
            "Redcurrant",
            "Salak",
            "Salal Berry",
            "Salmonberry",
            "Satsuma",
            "Soursop",
            "Star apple",
            "Star fruit",
            "Strawberry",
            "Surinam Cherry",
            "Tamarillo",
            "Tamarind",
            "Tangerine",
            "Ugli Fruit",
            "Watermelon",
            "White Currant",
            "White Sapote",
            "Yuzu"
        };

        public static ObservableCollection<string> GetSearchResults(string queryString)
        {
            var normalizedQuery = queryString?.ToLower() ?? "";
            var myList = Fruits.Where(f => f.ToLowerInvariant().Contains(normalizedQuery)).ToList();
            
            var myOC = new ObservableCollection<string>();
            foreach (var f in myList)
            {
                myOC.Add(f);
            }
            return myOC;

        }
    }
}
