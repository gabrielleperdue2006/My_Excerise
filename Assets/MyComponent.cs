using UnityEngine;
using UnityEngine.UIElements;

public class MyComponent : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow) ==true)
        {
           
        if (transform.position.x<18) {

         transform.Translate(0.1f, 0f, 0f);
            } // end of if statement for left ending position
           
        } // end of if statement for right arrow 
         if(Input.GetKey(KeyCode.LeftArrow)==true) // when user presses left arrow
        {
            if (transform.position.x > -18)
            {
                transform.Translate(-0.1f, 0f, 0f);
            }
        } // end of  if statement for left arrow

       //ebug.Log(transform.position.x)

        if(Input.GetKey(KeyCode.Space) == true) // if the player is pressing the space key
        {
            GetComponent<AudioSource>().Play(); // get a reference to my AudioSource component and play it
        } // end of if statement
    } // end of update function 

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("I've been hit!");
    }
    
}