using System;
using System.Collections;

namespace Collection.Models;

public class ShopingList : IEnumerable
{
    string[] items = new string[3] { "Bread", "Milk", "Beans" };
    public IEnumerator GetEnumerator()
    {
        return new ShopingListEnumerator(items);
    }
}

