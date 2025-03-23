using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10f;
    public float hackCooldown = 5f;
    private float nextHackTime = 0f;

    void Update()
    {
        Move();
        if (Input.GetKeyDown(KeyCode.H) && Time.time >= nextHackTime)
        {
            Hack();
            nextHackTime = Time.time + hackCooldown;
        }
    }

    void Move()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        transform.position += movement * speed * Time.deltaTime;
    }

    void Hack()
    {
        // Implement hacking logic here
        Debug.Log("Hacking the system!");
    }
}
