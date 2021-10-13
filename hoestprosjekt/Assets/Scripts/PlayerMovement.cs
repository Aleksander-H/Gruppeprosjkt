using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator anim;
    private SpriteRenderer rend;

    public float speed;
    public float x;
    public float y;

    public bool isDead;
    public bool isMoving;
    public bool isAttacking;

    public int playerHealth;

    public GameObject attackHitbox;
    public Transform attackSpawnStartPos;
    public Vector3 attackSpawn;
    private float time;
    public float attackDelay;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rend = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(isDead == false)
        {
            if(isAttacking == false)
            {
                x = Input.GetAxis("Horizontal");
                y = Input.GetAxis("Vertical");

                rb.velocity = new Vector2(x, y) * speed;

                if (Input.GetKeyDown(KeyCode.Space))
                {
                    if(time <= 0)
                    {
                        Instantiate(attackHitbox, attackSpawnStartPos.position, Quaternion.identity);
                        time = attackDelay;
                    } 
                }
            }
        }
        
    }

    private void DeadPlayer()
    {
        isDead = true;
    }

    private void OnDestroy()
    {
        
    }
}
