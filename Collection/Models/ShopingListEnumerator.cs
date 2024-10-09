using System;
using System.Collections;

namespace Collection.Models;

public class ShopingListEnumerator : IEnumerator
{
    private string[] _items { get; set; }
    private int position = -1;
    public ShopingListEnumerator(string[] items)
    {
        _items = items;
    }
    public object Current
    {
        get
        {
            return _items[position];
        }
    }

    public bool MoveNext()
    {
        position++;

        if (position < _items.Length)
        {

            return true;
        }
        else
        {
            return false;
        }
    }

    public void Reset()
    {
        position = -1;
    }
}
