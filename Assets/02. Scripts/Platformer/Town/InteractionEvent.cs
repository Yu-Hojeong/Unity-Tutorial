using System.Collections;
using UnityEngine;

public class InteractionEvent : MonoBehaviour
{
    public enum InteractionType { SIGN, DOOR, NPC }
    public InteractionType type;
    public GameObject signPopUp;
    public FadeRoutine fadeRoutine;

    public GameObject map;
    public GameObject house;

    public Vector3 indoorPos;
    public Vector3 outdoorPos;
    public bool isHouse;


    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Interaction(collision.transform);
        }
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            // Interaction(collision.transform);
            signPopUp.SetActive(false);
        }
    }

    void Interaction(Transform player)
    {
        switch (type)
        {
            case InteractionType.SIGN:
                signPopUp.SetActive(true);
                break;
            case InteractionType.DOOR:
                StartCoroutine(DoorRoutine(player));
                break;
            case InteractionType.NPC:
                signPopUp.SetActive(true);
                break;

        }
    }

    IEnumerator DoorRoutine(Transform Player)
    {
        yield return StartCoroutine(fadeRoutine.Fade(1f, Color.black, true));
        
            
            map.SetActive(isHouse);
            house.SetActive(!isHouse);
            var pos = isHouse? outdoorPos: indoorPos;
            Player.transform.position = pos;
        isHouse = !isHouse;

        yield return StartCoroutine(fadeRoutine.Fade(1f, Color.black, false));
    }
}
