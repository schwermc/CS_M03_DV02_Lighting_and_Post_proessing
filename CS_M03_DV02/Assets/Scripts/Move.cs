using UnityEngine;

public class Move : MonoBehaviour
{
    public float movement = 0.01f;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += Vector3.back * movement;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += Vector3.forward * movement;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.right * movement;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.left * movement;
        }
    }
}
