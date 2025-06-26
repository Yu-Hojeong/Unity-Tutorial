using UnityEngine;

public class MathDot : MonoBehaviour
{
    public Vector3 vecA = new Vector3(1, 0, 0);
    public Vector3 vecB = new Vector3(0, 1, 0);

    void Start()
    {
        float result1 = Vector3.Dot(vecA, vecB);

        Debug.Log($"벡터의 내적 : {result1}");


        var result2 = Vector3.Cross(vecA, vecB);

        Debug.Log($"벡터의 외적 : {result2}");
    }


}
