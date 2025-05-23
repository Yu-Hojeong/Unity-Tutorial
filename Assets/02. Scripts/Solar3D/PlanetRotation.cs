using UnityEngine;

public class PlanetRotation : MonoBehaviour
{
    public Transform targetPlanet;
    public float rotationSpeed = 30f;
    public float revolutionSpeed = 100f;
    
    void Start()
    {
        
    }


    void Update()
    {
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
        transform.RotateAround(targetPlanet.position, Vector3.up, revolutionSpeed * Time.deltaTime);
    }
}
