using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScipt : MonoBehaviour
{
    public Text MyscoreText;
    private int ScoreNum;
    public Text highScore;
    [SerializeField]
    private GameObject RedCrossHeart2;
    [SerializeField]
    private GameObject DollarSign;
    
    public AudioSource BatCollectSound;
    public AudioSource MonkeyHoot;
    
    
    // public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        ScoreNum = 0;
        MyscoreText.text = " " + ScoreNum;
        highScore.text = PlayerPrefs.GetInt("HighScore", 0).ToString();

        

        
        
        // anim = GetComponent<Animator>();
    }

   private void OnTriggerEnter2D(Collider2D Coin)
    {
        //if(Coin.tag == "MyCoin")
                          
        if (Coin.CompareTag("MyCoin"))
        {
         ScoreNum += 50;
          //BatCollectSound.Play();
            MonkeyHoot.Play();
             // anim.Play("RedCrossHeart");
            Instantiate(RedCrossHeart2, transform.position, Quaternion.identity);
            Destroy(Coin.gameObject);
         }
        else if (Coin.CompareTag("Illuminati"))
        {
            ScoreNum += 25;
            BatCollectSound.Play();
            //MonkeyHoot.Play();
            // anim.Play("RedCrossHeart");
            Instantiate(DollarSign, transform.position, Quaternion.identity);
            Destroy(Coin.gameObject);
    }

     MyscoreText.text = " " + ScoreNum;

            if(ScoreNum > PlayerPrefs.GetInt("HighScore", 0))
            {
                PlayerPrefs.SetInt("HighScore", ScoreNum);
                highScore.text = ScoreNum.ToString();
            }
    }
        public void Reset()
        {
            PlayerPrefs.DeleteKey("HighScore");
            highScore.text = "0";
        }

    
    
}
