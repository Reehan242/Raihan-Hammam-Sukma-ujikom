using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    Vector3 arahHorizontal;

    private void FixedUpdate()
    {
        arahHorizontal = new Vector3(Input.GetAxisRaw("Horizontal"), 0f, 0f);
        
        transform.Translate(arahHorizontal * Time.deltaTime * speed);
        transform.rotation = Quaternion.Euler(Vector3.zero);
        
    }
}
