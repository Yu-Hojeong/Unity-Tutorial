using UnityEngine;
using UnityEngine.UI;

public class RouletteController : MonoBehaviour
{
    public float rotSpeed;
    public float goalSpeed = 300f;

    public bool isStopping = false;

    void Start()
    {
        rotSpeed = 0f;
    }

    void Update()
    {
        RouletteSpin();
    }

    public void RouletteSpin()
    {
        transform.Rotate(Vector3.forward * rotSpeed * Time.deltaTime);


        if (Input.GetMouseButtonDown(0))
        {
            rotSpeed = goalSpeed;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            isStopping = true;
        }

        if (isStopping == true)
        {
            rotSpeed *= 0.998f;

            if (rotSpeed < 0.05f)
            {
                rotSpeed = 0f;
                isStopping = false;
            }
        }
    }
}
