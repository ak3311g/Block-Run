using UnityEngine;

public class PMovement : MonoBehaviour
{

    public Rigidbody rb;
    public float forwardforce = 800f;
    public float sideforce = 50f;

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(forwardforce * Time.deltaTime,0,0);  //Add forward force to the object

        if(Input.GetKey("a")||Input.GetKey("left"))
        {
            rb.AddForce(0,0,sideforce * Time.deltaTime,ForceMode.VelocityChange);
        }

        if(Input.GetKey("d")||Input.GetKey("right"))
        {
            rb.AddForce(0,0,-sideforce * Time.deltaTime,ForceMode.VelocityChange);
        }

        if(rb.position.y < -1f)
        {
            FindObjectOfType<manager>().Endgame();
        }
    }
}
