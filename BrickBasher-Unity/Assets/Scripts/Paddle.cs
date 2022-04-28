/**** 
 * Created by: Bob Baloney
 * Date Created: April 20, 2022
 * 
 * Last Edited by: 
 * Last Edited:
 * 
 * Description: Paddle controler on Horizontal Axis
****/

/*** Using Namespaces ***/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    public float speed = 10; //speed of paddle
    


    // Update is called once per frame
    void Update()
    {
        GameObject paddle = GetComponent<GameObject>();
        Vector3 POS = paddle.transform.position;
        POS.x = Input.GetAxis("Horizontal") * speed;

    }//end Update()
}
