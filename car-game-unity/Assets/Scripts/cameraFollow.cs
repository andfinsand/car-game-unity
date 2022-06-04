
using UnityEngine;

public class cameraFollow : MonoBehaviour
{
    public Transform Porsche;
    public Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        transform.position = Porsche.position + offset;
    }
}
