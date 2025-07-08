using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public float speed = 5;

    private void Update()
    {
        float movement = 0;

        if (Input.GetKey(KeyCode.W))
        {
            movement = 1;
        }

        if (Input.GetKey(KeyCode.S))
        {
            movement = -1;
        }

        transform.Translate(0, movement * speed * Time.deltaTime, 0);
    }
}
