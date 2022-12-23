using UnityEngine;

public class SliderMovement : MonoBehaviour
{

    public Transform leftSide, rightSide;
    private Transform target;
    public GameObject sliderPointer;
    private Rigidbody2D rb;

    private float moveSpeed = .01f;

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

    private void movement()
    {
        transform.position = Vector3.Lerp(transform.position, target.position, moveSpeed);

        if (Mathf.Abs(transform.position.x - target.position.x) < 1f)
        {
            if (target == rightSide) target = leftSide;
            else target = rightSide;
        }
    }

    private void FixedUpdate()
    {
        movement();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
