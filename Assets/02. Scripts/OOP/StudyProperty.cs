using UnityEngine;

public class StudyProperty : MonoBehaviour
{
    private int n1 = 10;
    public int N1
    {
        get { return n1; } //데이터에 접근할 수 있음

        set { n1 = value; } // 데이터를 수정할 수 있음
    }
    public int n2 = 20;
}
