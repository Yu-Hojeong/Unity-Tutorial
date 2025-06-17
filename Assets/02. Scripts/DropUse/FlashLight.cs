using UnityEngine;

public class FlashLight : MonoBehaviour, IDropItem
{
    public GameObject lightObj;
    public void Grab(Transform GrabPos)
    {
        Debug.Log("손전등을 주웠다.");
        transform.SetParent(GrabPos);
        transform.localPosition = Vector3.zero;
        transform.localRotation = Quaternion.identity;
    }

    public void Use()
    {
        Debug.Log("손전등을 켠다.");
        lightObj.SetActive(!lightObj.activeSelf);
    }

    public void Drop()
    {
        Debug.Log("손전등을 버렸다.");
        transform.SetParent(null);
        transform.position = Vector3.zero;
    }
}