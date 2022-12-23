using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceBlock : MonoBehaviour
{
    public GameObject iceBlock;
    [SerializeField] SpriteRenderer spriteRenderer;


    private void Awake()
    {
        iceBlock = GameObject.Find("Block");
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void clickedFlip()
    {
        if (spriteRenderer.flipX) spriteRenderer.flipX = false;
        else spriteRenderer.flipX = true;
    }
}
