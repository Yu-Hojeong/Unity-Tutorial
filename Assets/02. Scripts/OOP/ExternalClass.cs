using UnityEngine;

public class ExternalClass : MonoBehaviour
{
    public StudyProperty studyProperty;
    void Start()
    {
        int num1 = studyProperty.N1;
        studyProperty.N1 = 100;
        int num2 = studyProperty.n2;
    }
}
