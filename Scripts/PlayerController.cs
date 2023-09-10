using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float movementSpeed;
    private bool isGrounded; //player is touching ground

    private void Start()
    {
        isGrounded = false;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag.Equals("Platform"))
        {
            isGrounded = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        

        //Check if the player wants to move horizontally
        if (Input.GetAxis("Horizontal")!= 0.0f)
        {
            gameObject.transform.position +=
                new Vector3(Input.GetAxis("Horizontal") 
                * movementSpeed * Time.deltaTime, 0.0f, 0.0f);
        }

        //Jump on a button press (space button)
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {

            isGrounded = false;// player is now in the air
            //Debug.Log("Space Button Pressed");
            gameObject.GetComponent<Rigidbody2D>().AddForce(Vector3.up * 8.0f,ForceMode2D.Impulse);
            

        }

    }
}
