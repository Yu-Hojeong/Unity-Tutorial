using UnityEngine;

public class Gun : MonoBehaviour, IDropItem
{
    public void Grab(Transform GrabPos)
    {
        Debug.Log("총을 주웠다.");
        transform.SetParent(GrabPos);
        transform.localPosition = Vector3.zero;
        transform.localRotation = Quaternion.identity;
    }

    public void Use()
    {
        Debug.Log("총을 발사한다.");
    }

    public void Drop()
    {
        Debug.Log("총을 버렸다.");
        transform.SetParent(null);
        transform.position = Vector3.zero;
    }
}