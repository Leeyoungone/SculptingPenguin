using UnityEngine;

public class SliderMovement : MonoBehaviour
{

    public Transform leftSide, rightSide;
    private Transform target;
    public GameObject sliderPointer;
    private Rigidbody2D rb;

    private float moveSpeed = .1f;

    private bool collidedHitbox = false;
    //public Collider2D pointer;
    public Collider2D hitBox;

    private void Awake()
    {
        sliderPointer = GameObject.Find("Slider");
    }

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        target = leftSide;
    }

    private void FixedUpdate()
    {
        movement();
        spacebarHit();
    }

    private void movement()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.position, moveSpeed);

        if(transform.position.x == target.position.x)
        {
            if (target == rightSide) target = leftSide;
            else target = rightSide;
        }
    }

    private void spacebarHit()
    {
        if ((hitBox.IsTouchingLayers(LayerMask.GetMask("PointerLayer"))) && Input.GetKey("space"))
        {
            Debug.Log("they touchin");
        }


        //if(Input.GetKey("space") && collidedHitbox)
        //{
        //    Debug.Log("hitbox space clicked");
        //}


    }

    //void OnCollisionEnter(Collision collision)
    //{
    //    if (collision.gameObject.tag == "hitBox")
    //    {
    //        Debug.Log("collieded");
    //        collidedHitbox = true;
    //    }
    //    else collidedHitbox = false;
    //}
}
