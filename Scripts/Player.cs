using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public MovementJoystick movementJoystick;

    private SpriteRenderer SpriteRenderer;
    public Sprite[] sprites;
    private int spriteIndex;
    public float playerSpeed;
    private Rigidbody2D rb;
    private Vector2 playerDirection;

    private void Awake()
    {
        SpriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); 

        InvokeRepeating(nameof(AnimateSprite), 0.05f, 0.05f);
    }

    // Update is called once per frame
    // void Update()
    // {
    //     float directionY = Input.GetAxisRaw("Vertical");
    //     playerDirection = new Vector2(0, directionY).normalized;
    // }

    void FixedUpdate()
    {
        if(movementJoystick.joystickVec.y != 0)
        {
            rb.velocity = new Vector2(movementJoystick.joystickVec.x * 0, movementJoystick.joystickVec.y * 15);

        }

        else
        {
          rb.velocity = Vector2.zero;  
        }

        // rb.velocity = new Vector2(0, playerDirection.y * playerSpeed);
    }

    private void AnimateSprite()
    {
        spriteIndex++;

        if (spriteIndex >= sprites.Length)
        {
            spriteIndex = 0;
        }

        SpriteRenderer.sprite = sprites[spriteIndex];
    }

    
}
