using UnityEngine;

public class endtrigger : MonoBehaviour
{
    public manager gamemanager;

    void OnTriggerEnter(){
        gamemanager.completelevel();
    }
}
