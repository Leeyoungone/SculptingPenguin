using UnityEngine;

public class SliderMovement : MonoBehaviour
{

    public Transform leftSide, rightSide;
    private Transform target;
    public GameObject sliderPointer;
    private Rigidbody2D rb;

    private float moveSpeed = .1f;


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
}
