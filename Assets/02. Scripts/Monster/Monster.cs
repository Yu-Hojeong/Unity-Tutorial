using System.Collections;
using UnityEngine;

public abstract class Monster : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    protected float hp = 3f;
    protected float moveSpeed = 3f;
    int dir = 1;
    public abstract void Init();
    public MonsterSpawner monsterSpawner;

    Animator animator;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
        monsterSpawner = FindFirstObjectByType<MonsterSpawner>();
        Init();
    }
    void OnMouseDown()
    {
        StartCoroutine(Hit(1));
    }

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        transform.position += Vector3.right * dir * moveSpeed * Time.deltaTime;
        if (transform.position.x > 8f)
        {
            dir = -1;
            spriteRenderer.flipX = true;
        }
        else if (transform.position.x < -8f)
        {
            dir = 1;
            spriteRenderer.flipX = false;
        }
    }
    public IEnumerator Hit(float damage)
    {
        hp -= damage;
        animator.SetTrigger("Hit");

        if (hp <= 0)
        {
            Destroy(gameObject);
            monsterSpawner.DropCoin(transform.position);

        }
        yield return new WaitForSeconds(0.5f);
    }
}





    // public string name;
    // public float damage;
    // public float hp;

    // //몬스터 클래스의 생성자
    // public Monster(string name, float damage, float hp)
    // {
    //     this.name = name;
    //     this.damage = damage;
    //     this.hp = hp;
    // }

    // void Start()
    // {
    //     Monster m1 = new Monster("slime",5,20);
    //     Monster m2 = new Monster("goblin",8,30);
    //     Monster m3 = new Monster("golem",20,50);
    // }