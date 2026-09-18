using UnityEngine;

public class Hit_Fly : MonoBehaviour
{

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
    } // End of Start Function

    // Update is called once per frame
    void Update()
    {
    } // End of Update Function

    void OnCollisionEnter2D(Collision2D collision){
        GetComponent<AudioSource>().Play();
    } // End of OnCollisionEnter2D Function
} // End of Hit_Fly Class
