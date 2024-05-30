using UnityEngine;

public class playercollision : MonoBehaviour
{
    public PMovement movement; 

    void OnCollisionEnter(Collision collideinfo){   //Unity inbuilt Function
        if(collideinfo.collider.tag=="Obstacle")
        {
            movement.enabled=false;
            FindObjectOfType<manager>().Endgame();
        }
    }
}
