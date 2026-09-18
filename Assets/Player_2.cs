using UnityEngine;

public class Player_2 : MonoBehaviour
{
    public AudioSource audioSource; // Reference to the AudioSource component
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W) ==true){

        if (transform.position.y < 8) {

            transform.Translate(-0.05f, 0f, 0f);
        } // End of if statement (Player 2 moves up)

    } // End of if statement (Player 2 presses W key)

    if (Input.GetKey(KeyCode.S) ==true){

        if (transform.position.y > -8) {

            transform.Translate(0.05f, 0f, 0f);
        } // End of if statement if (Player 2 moves down)

    } // End of if statement (Player 2 presses S key)
    
 


    } // End of Update


} // end of class Player_2
