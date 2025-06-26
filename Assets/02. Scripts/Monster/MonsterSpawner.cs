using System.Collections;
using UnityEngine;

public class MonsterSpawner : MonoBehaviour
{
    [SerializeField] GameObject[] monsters;
    [SerializeField] GameObject coinPrefab;
    // [SerializeField] private GameObject[] items;



    IEnumerator Start()
    {
        while (true)
        {
            yield return new WaitForSeconds(3f);
            var randomIndex = Random.Range(0, monsters.Length);
            var randomX = Random.Range(-8, 9);
            var randomY = Random.Range(-3, 5);
            var createPos = new Vector3(randomX, randomY, 0);

            var monsterObj = Instantiate(monsters[randomIndex], createPos, Quaternion.identity);
        var monster = monsterObj.GetComponent<Monster>();
        if (monster != null)
        {
            monster.monsterSpawner = this;
        }
        else
        {
            Debug.LogWarning("Monster component not found on instantiated object.");
        }


        }
    }
    public void DropCoin(Vector3 dropPos)
    {
        GameObject item = Instantiate(coinPrefab, dropPos, Quaternion.identity);
        Rigidbody2D itemRb = item.GetComponent<Rigidbody2D>();
        Vector2 force = new Vector2(Random.Range(-2f, 2f), 3);
        itemRb.AddForce(force, ForceMode2D.Impulse);
    }
}
