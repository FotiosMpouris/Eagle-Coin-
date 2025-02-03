using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText;
    private float score;
    public int pointsToAdd;
    public float scoreCount;

    // Update is called once per frame
    void Update()
    {
        if(GameObject.FindGameObjectWithTag("Player") !=null)
        {
            score += 4 * Time.deltaTime;
            scoreText.text = ((int)score).ToString();
        }
    }

    public void AddScore (int pointsToAdd)
    {
        scoreCount += pointsToAdd;
    }
}
