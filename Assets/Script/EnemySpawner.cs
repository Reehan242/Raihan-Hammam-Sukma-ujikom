using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyCow;
    public GameObject enemyDeer;
    public GameObject enemyDog;
    public GameObject enemyHorse;
    public GameObject player;
    public Transform spawnPos;
    public TextMeshProUGUI timer;
    private int timerCount = 60;
    private int randomInt;
    public GameObject panel;
   
    private void Start()
    {
        spawn();
        updateTimer();
        panel.transform.localScale = Vector3.zero; 
        

    }
    private void spawn()
    {
        if(timerCount > 0)
        {
            randomInt = Random.Range(0, 4);
            switch (randomInt)
            {
                case 0:
                    Instantiate(enemyCow, new Vector3(Random.Range(-7, 7), spawnPos.position.y, spawnPos.position.z), spawnPos.rotation);
                    break;
                case 1:
                    Instantiate(enemyDeer, new Vector3(Random.Range(-7, 7), spawnPos.position.y, spawnPos.position.z), spawnPos.rotation);
                    break;
                case 2:
                    Instantiate(enemyDog, new Vector3(Random.Range(-7, 7), spawnPos.position.y, spawnPos.position.z), spawnPos.rotation);
                    break;
                case 3:
                    Instantiate(enemyHorse, new Vector3(Random.Range(-7, 7), spawnPos.position.y, spawnPos.position.z), spawnPos.rotation);
                    break;
                default:
                    Debug.Log("test");
                    break;
            }

            StartCoroutine(intervalSpawn());
        }
        else
        {
            endgame();
        }
        

    }
    private void endgame()
    {
        panel.transform.localScale = Vector3.one;
        Destroy(player);
    }
    public void retryGame()
    {
        SceneManager.LoadScene("MainScreen");
    }
    private void updateTimer()
    {
        if(timerCount > 0)
        {
            timerCount -= 1;
            timer.text = "Time : " + timerCount;
            StartCoroutine(timerDown());
        }
        
    }

    IEnumerator intervalSpawn()
    {
        yield return new WaitForSeconds(2);
        spawn();
    }
    IEnumerator timerDown()
    {
        yield return new WaitForSeconds(1);
        updateTimer();

    }
}
