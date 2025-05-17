using UnityEngine;

public class BallDetector : MonoBehaviour
{
    public float detectionDistance = 0.2f;
    private bool checkedCollision = false;

    void Update()
    {
        if (checkedCollision) return;

        float distance = Vector3.Distance(transform.position, Camera.main.transform.position);

        if (distance < detectionDistance)
        {
            checkedCollision = true;

            if (Mathf.Abs(Input.acceleration.x) > 0.2f)
                Debug.Log("🎉 Atajada");
            else
                Debug.Log("🥅 Gol");

            Destroy(gameObject);
        }
    }
}
