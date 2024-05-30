using UnityEngine;

public class camfollow : MonoBehaviour
{
    public Transform playerpos;
    public Vector3 offset;
    // Update is called once per frame
    void Update()
    {
        transform.position=playerpos.position + offset;
    }
}
