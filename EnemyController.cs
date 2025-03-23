using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed = 5f;
    public Transform target;

    void Update()
    {
        ChasePlayer();
    }

    void ChasePlayer()
    {
        if (target != null)
        {
            Vector3 direction = (target.position - transform.position).normalized;
            transform.position += direction * speed * Time.deltaTime;
        }
    }
}
