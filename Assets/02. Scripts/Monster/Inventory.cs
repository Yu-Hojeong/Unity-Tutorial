using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public List<GameObject> items = new List<GameObject>();
    public void AddItem(IItem item)
    {
        items.Add(item.obj); //이거 하려고 get set 한거임
    }
}
