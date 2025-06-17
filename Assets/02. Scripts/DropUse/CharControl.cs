using UnityEngine;

public class CharControl : MonoBehaviour
{
    [SerializeField] float moveSpeed = 3f;
    [SerializeField] Transform grabPos;
    IDropItem currentItem;

    void Update()
    {
        Move();
        Interaction();
    }

    private void Move()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(h, 0, v).normalized;

        transform.position += direction * moveSpeed * Time.deltaTime;
    }

    void Interaction()
    {
        if (currentItem == null) return;
        if (Input.GetMouseButtonDown(0))
        {
            currentItem.Use();
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            currentItem.Drop();
            currentItem = null;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<IDropItem>() != null)
        {
            var item = other.GetComponent<IDropItem>();
            currentItem = item;
            currentItem.Grab(grabPos);
        }
    }
}
