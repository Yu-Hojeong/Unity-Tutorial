using UnityEngine;

public class Potion2D : MonoBehaviour,IItem
{
    public enum PotionType { one, two, three }
    public PotionType coinType;
    public float HealAmount;

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
