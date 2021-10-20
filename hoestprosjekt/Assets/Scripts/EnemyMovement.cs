using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyMovement : MonoBehaviour
{
    public Transform target;
    Transform enemyTransform;
    public float speed = 3f;
    public float rotationSpeed = 3f;


    //public Transform Player;
    //int MoveSpeed = 4;
    //int MaxDist = 10;
    //int MinDist = 5;


    private Rigidbody2D rb;
    private Animator anim;
    private SpriteRenderer rend;

    private Vector3 change;


    //public bool isDead;
    //public bool isMoving;
    //public bool isAttacking;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rend = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        //target = GameObject.FindWithTag("Player").transfrom;
        Vector3 targetHeading = target.position - transform.position;
        Vector3 targetDirection = targetHeading.normalized;
                //Rotate to look at Player
        //transform.rotation = Quaternion.LookRotation(targetDirection); //Converts target direction vector to Quaternion.
        //transform.eulerAngles = new Vector3(0, transform.eulerAngles.y, 0);

        //Move towards the Player
        enemyTransform.position += enemyTransform.up * speed * Time.deltaTime;



        //transform.LookAt(Player);
        
        //if (Vector3.Distance(transform.position, Player.position) >= MinDist)
        {
            //transform.position += transform.forward * MoveSpeed * Time.deltaTime;


            
            //if (Vector3.Distance(transform.position, Player.position) <= MaxDist)
            {
                //Hit Player
            }
        }


        //change = Vector3.zero;
        //change.x = Input.GetAxisRaw("Horizontal");
        //change.y = Input.GetAxisRaw("Vertical");
        
    }

}
