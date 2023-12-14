using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class EnemyHealth : MonoBehaviour
{
    public int health;
    public GameObject scoreCounter;
    public int scoreAdd;
    private AudioSource eat;
    // Start is called before the first frame update

    // Update is called once per frame
    private void Start()
    {
        eat = GetComponent<AudioSource>();  
        scoreCounter = GameObject.Find("ScoreCounter");
    }
    void Update()
    {
        if(health <= 0)
        {
            scoreCounter.GetComponent<ScoreCounter>().updateScore(scoreAdd);
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Food")
        {
            eat.Play();
            health -= 1;
        }
    }
}
