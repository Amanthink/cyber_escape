using UnityEngine;

public class EnvironmentManager : MonoBehaviour
{
    public float changeInterval = 30f;

    void Start()
    {
        InvokeRepeating("ChangeEnvironment", changeInterval, changeInterval);
    }

    void ChangeEnvironment()
    {
        // Logic to change the environment
        Debug.Log("Environment has changed!");
    }
}
