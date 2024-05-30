using UnityEngine;
using UnityEngine.SceneManagement;

public class manager : MonoBehaviour
{
    public float restartdelay = 1f;

    bool hasEnded = false;

    public GameObject completelevelui;

      public void completelevel()
    {
        completelevelui.SetActive(true);
    }

    public void Endgame(){
        if(hasEnded==false)
        {
            hasEnded=true;
            Debug.Log("GAme over");
            Invoke("restart",restartdelay);
        }
    }

    void restart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
