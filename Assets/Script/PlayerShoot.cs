using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public float cd= 0.25f;
    private bool canShoot = true;
    public Transform shootPosition;
    public GameObject food;
    private AudioSource shoot;
    // Start is called before the first frame update
    void Start()
    {
        shoot = GetComponent<AudioSource>();    
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && canShoot == true)
        {
            canShoot = false;
            Instantiate(food,shootPosition.position,shootPosition.rotation);
            shoot.Play();
            StartCoroutine(cdShoot());
        }
    }
    IEnumerator cdShoot()
    {
        yield return new WaitForSeconds(cd);
        canShoot=true;
    }
}
