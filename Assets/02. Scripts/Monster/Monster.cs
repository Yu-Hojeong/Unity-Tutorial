using UnityEngine;

public abstract class Monster : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    protected float hp = 3f;
    protected float moveSpeed = 3f;
    int dir = 1;
    public abstract void Init();

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        Init();
    }
    void OnMouseDown()
    {
        Hit(1);
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
    void Hit(float damage)
    {
        hp -= damage;
        if (hp<=0)
        {
            Destroy(gameObject);
        }
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