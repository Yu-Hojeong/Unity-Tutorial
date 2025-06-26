using UnityEngine;
using UnityEngine.EventSystems;

public class JoystickController : MonoBehaviour, IPointerDownHandler, IDragHandler, IPointerUpHandler
{
    [SerializeField] KCJoystick kCJoystick;
    [SerializeField] GameObject backgroundUI;
    [SerializeField] GameObject handlerUI;
    Vector2 startPos, currentPos;

    void Start()
    {
        backgroundUI.SetActive(false);
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        backgroundUI.SetActive(true);
        backgroundUI.transform.position = eventData.position;
        startPos = eventData.position;
    }

    public void OnDrag(PointerEventData eventData)
    {

        currentPos = eventData.position;
        Vector2 dragDirection = currentPos - startPos;

        float maxDistance = Mathf.Min(dragDirection.magnitude, 100f);
        handlerUI.transform.position = startPos + dragDirection.normalized * maxDistance;

        kCJoystick.InputJoystick(dragDirection.x, dragDirection.y);

        // handlerUI.transform.position = eventData.position;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        handlerUI.transform.position = Vector2.zero;
        backgroundUI.SetActive(false);
        kCJoystick.InputJoystick(0, 0);
    }
}
