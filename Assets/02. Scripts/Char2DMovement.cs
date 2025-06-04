using UnityEngine;

public class Char2DMovement : MonoBehaviour
{
    Rigidbody2D charRB;
    public SpriteRenderer[] renderers;
    public float moveSpeed = 20f;
    public float jumpPower = 10f;
    float h;

    void Start()
    {
        charRB = GetComponent<Rigidbody2D>();
        renderers = GetComponentsInChildren<SpriteRenderer>();
    }
    void Update()
    {
        h = Input.GetAxis("Horizontal");
        if (Input.GetButtonDown("Jump"))
        {
            charRB.AddForceY(jumpPower, ForceMode2D.Impulse);
        }

        

    }

    private void FixedUpdate()
    {
        
        Move();

    }

    private void Move()
    {
        if (h != 0)
        {
            renderers[0].gameObject.SetActive(false);
            renderers[1].gameObject.SetActive(true);
            charRB.linearVelocityX = h * moveSpeed;
        }
        else
        {
            renderers[1].gameObject.SetActive(false);
            renderers[0].gameObject.SetActive(true);

        }

        if (h < 0)
        {
            renderers[1].flipX = true;
            renderers[0].flipX = true;
        }
        else if (h > 0)
        {
            renderers[1].flipX = false;
            renderers[0].flipX = false;
        }
    }
}
