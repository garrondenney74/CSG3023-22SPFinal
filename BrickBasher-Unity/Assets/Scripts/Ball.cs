/**** 
 * Created by: Bob Baloney
 * Date Created: April 20, 2022
 * 
 * Last Edited by: 
 * Last Edited:
 * 
 * Description: Controls the ball and sets up the intial game behaviors. 
****/

/*** Using Namespaces ***/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityUIText;


public class Ball : MonoBehaviour
{
    [Header("General Settings")]
    public int numberOfBalls;
    [Header("Ball Settings")]


//VARIABLES//

    //public Text ballTxt;
    //public Text scoreTxt;
    public bool isInPlay;
    public Rigidbody rb;
    public GameObject paddle;
    public int speed;
    public int score;
    public AudioSource audioSource;
    public int initialforce;





    //Awake is called when the game loads (before Start).  Awake only once during the lifetime of the script instance.
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        paddle = GetComponent<GameObject>();
        audioSource = GetComponent<AudioSource>();
    }//end Awake()


        // Start is called before the first frame update
        void Start()
    {
        SetStartingPos(); //set the starting position

    }//end Start()


    // Update is called once per frame
    void Update()
    {
       // ballTxt.text = "Balls: " + numberOfBalls;
       // scoreTxt.text = "Score: " + score;
        if(!isInPlay)
        {
            
            if(Input.GetKeyDown("Space"))
            {
                isInPlay = true;
               // Move();
            }
        }
    }//end Update()


    private void LateUpdate()
    {
        if(isInPlay)
        {
            Vector3 velocity = rb.velocity;
            rb.velocity = speed * velocity.normalized;
        }

    }//end LateUpdate()


    void SetStartingPos()
    {
        isInPlay = false;//ball is not in play
        rb.velocity = Vector3.zero;//set velocity to keep ball stationary
        Vector3 pos = new Vector3();
        pos.x = paddle.transform.position.x; //x position of paddel
        pos.y = paddle.transform.position.y + paddle.transform.localScale.y; //Y position of paddle plus it's height

        transform.position = pos;//set starting position of the ball 
    }//end SetStartingPos()




  //  public void Move()
   // {
   //     Vector3 force = (0, initialforce, 0);
   //         rb.AddForce(force);
   // }


   // public void OnCollisionEnter(Collision coll)
   // {
   //     GameObject coll = coll.gameObject;
   //     if(coll.tag == "Brick")
   //     {
    //        score += 100;
    //        Destroy(coll);
    //    }
   // }

 

}
