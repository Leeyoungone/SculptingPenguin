using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceRelated : MonoBehaviour
{
    private GameObject cube1, cube2, cube3, cube4;
    [SerializeField] SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        cube1 = GameObject.Find("Block1");
        cube2 = GameObject.Find("Block2");
        cube3 = GameObject.Find("Block3");
        cube4 = GameObject.Find("Block4");
    }

    // Update is called once per frame
    public void clickedFlip()
    {
        if (!Input.GetKeyDown("space"))
        {
            if (spriteRenderer.flipX) spriteRenderer.flipX = false;
            else spriteRenderer.flipX = true;
        }
    }
}
