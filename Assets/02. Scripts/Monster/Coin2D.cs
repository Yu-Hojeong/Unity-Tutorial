using UnityEngine;

public class Coin2D : MonoBehaviour,IItem
{
    public enum CoinType { one, two, three }
    public CoinType coinType;
    public float price;

    Inventory inventory;

    void Start()
    {
        inventory = FindFirstObjectByType<Inventory>();
        obj = gameObject;
    }



    void OMouseDown()
    {
        Get();
    }
    public GameObject obj{ get; set; }

    public void Get()
    {
        Debug.Log("Get");
        inventory.AddItem(this);
        gameObject.SetActive(false);
    }
}
