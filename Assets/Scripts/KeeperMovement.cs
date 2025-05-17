using UnityEngine;

public class KeeperMovement : MonoBehaviour
{
    void Update()
    {
        Vector3 accel = Input.acceleration;

        if (accel.x > 0.2f)
        {
            Debug.Log("Portero va a la derecha");
        }
        else if (accel.x < -0.2f)
        {
            Debug.Log("Portero va a la izquierda");
        }
    }
}
