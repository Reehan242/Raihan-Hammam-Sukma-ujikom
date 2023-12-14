using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodBullet : MonoBehaviour
{
    public float speed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody>().velocity = new Vector3(0f, 0f, 1f * speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.transform.tag == "Border")
        {
            Destroy(gameObject);
        }
        if(other.transform.tag == "Enemy")
        {
            Destroy(gameObject);
        }
    }
}
