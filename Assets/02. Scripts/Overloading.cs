using UnityEngine;

public class Overloading : MonoBehaviour
{

    void Start()
    {
        Attack();
        Attack(true);
        Attack(10f);

        GameObject monsterObj = new GameObject("monster");
        Attack(10f, monsterObj);

    }

    void Attack()
    {

    }
    void Attack(bool isMagic)
    {

    }
    void Attack(float damage)
    {

    }
    void Attack(float damage, GameObject target)
    {

    }
    

}
