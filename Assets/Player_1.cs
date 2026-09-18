using UnityEngine;

public class MyComponent : MonoBehaviour
{
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         if (Input.GetKey(KeyCode.UpArrow) ==true)
        {
           
            if (transform.position.y < 8) {

            transform.Translate(-0.05f, 0f, 0f);
            } // End of if statement (Player 1 moves up)
           
        } // end of if statement (Player 1 presses up arrow) 
        
        if (Input.GetKey(KeyCode.DownArrow) ==true)
        {
           
            if (transform.position.y > -8) {

            transform.Translate(0.05f, 0f, 0f);
            } // End of if statement (Player 1 moves down)

    } // End of if statement (Player 1 presses down arrow)
        


    
} // End of Update



} // end of class MyComponent