using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewPlayerController : MonoBehaviour
{

    public float speed;
    public float rotationSpeed;
    public float size;
    public GameObject fire;

    // Start is called before the first frame update
    void Start()
    {
        size = 0.02f;
    }

    public void makebigger(float amount)
    {
        size += amount;
        fire.transform.localScale = new Vector3 (size, size, size);
        


    }
  


    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");


        
        Vector3 movementDirection = new Vector3(horizontalInput, 0, verticalInput);
        movementDirection.Normalize();
        transform.Translate(movementDirection * speed * Time.deltaTime, Space.World);

      
/*
        if (Input.GetKeyDown("space"))
        {
            spacepress = false;
        }
*/

        if (movementDirection != Vector3.zero)
        {
            Quaternion toRoatation = Quaternion.LookRotation(movementDirection, Vector3.up);

            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRoatation, rotationSpeed * Time.deltaTime);
        }

    }
}


