
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    //collectable coins - score count
    //speed increase as you go further 
    //random placement of objects
    //fire rings - take health
    //ramp/jump



    public Rigidbody rb;
    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;
    public PlayerMovement movement;



    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0,0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d") )
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }

    }

    private void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }

}
