using UnityEngine;

public class SliderMovement : MonoBehaviour
{

    public Transform leftSide, rightSide;
    private Transform target;
    public GameObject sliderPointer;
    private Rigidbody2D rb;

    private float moveSpeed = .1f;

    public bool collidedHitbox = false;
    public Collider2D pointer;
    public Collider2D hitBox;

    //debugging purposes
    public int counter = 0;

    //accessing PenguinScript
    PenguinScript penguinScript;
    [SerializeField] GameObject penguin;

    private void Awake()
    {
        sliderPointer = GameObject.Find("Slider");
        penguinScript = penguin.GetComponent<PenguinScript>();
        //arrowScript = arrow.GetComponent<ArrowScript>();
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
    }

    private void Update()
    {
        spacebarHit();
        if (!pointer.IsTouching(hitBox)) collidedHitbox = false;
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
        if (Input.GetKeyDown("space")) {
            if (pointer.IsTouching(hitBox))
            {
                collidedHitbox = true;
                counter += 1;
                Debug.Log("hit box: " + counter);
                penguinScript.boxModification();

                penguinScript.GoodAnimation();

                //call function to check which block is colliding

                Debug.Log("they touchin");
            }
            else Debug.Log("non hit area");
        }
    }
}