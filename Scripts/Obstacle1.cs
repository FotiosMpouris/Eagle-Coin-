using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle1 : MonoBehaviour
{
    private GameObject player;
    // private GameObject playerB;
    private SpriteRenderer SpriteRenderer;
    public Sprite[] sprites;
    private int spriteIndex;
    // [SerializeField]
    // private GameObject InfectedBat;
    [SerializeField]
    private GameObject DownArrow;
    public AudioSource WesterNativeFlute;
    
    // Start is called before the first frame update
    
    private void Awake()
    {
        SpriteRenderer = GetComponent<SpriteRenderer>();
    }
    
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        // playerB = GameObject.FindGameObjectWithTag("PlayerB");
        
        InvokeRepeating(nameof(AnimateSprite), 0.5f, 0.5f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Border")
        {
            Destroy(this.gameObject);
        }

        else if(collision.tag == "Player")
        {
            Instantiate(DownArrow, transform.position, Quaternion.identity);
            WesterNativeFlute.Play();
            Destroy(player.gameObject);
        }

        // else if(collision.tag == "PlayerB")
        // {
        //     Instantiate(InfectedDragoon, transform.position, Quaternion.identity);
        //     BatDeathSound.Play();
        //     Destroy(player.gameObject);
        // }
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
