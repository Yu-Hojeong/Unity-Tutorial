using UnityEngine;

public class StudyUnityEvents : MonoBehaviour
{
    void Awake()
    {
        Debug.Log("AWAKE");
    }

    void OnEnable()
    {
        Debug.Log("ONENABLE");
    }
    void Start()
    {
        Debug.Log("START");
    }
    void OnDisable()
    {
        Debug.Log("ONDISBLE");
    }

    
    void Update()
    {
        
    }
}
