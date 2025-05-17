using UnityEngine;

public class BallShooter : MonoBehaviour
{
    public GameObject ballPrefab;
    public Transform spawnPoint;
    public float speed = 7f;
    public float randomness = 0.2f; // qué tanto se desvía

    public void ShootBall()
    {
        GameObject ball = Instantiate(ballPrefab, spawnPoint.position, Quaternion.identity);
        Rigidbody rb = ball.GetComponent<Rigidbody>();

        Vector3 direction = (Camera.main.transform.position - spawnPoint.position).normalized;

        // Añadir desviación aleatoria
        direction += new Vector3(
            Random.Range(-randomness, randomness),
            Random.Range(-randomness * 0.5f, randomness * 0.5f), // menor desviación vertical
            Random.Range(-randomness, randomness)
        );

        direction.Normalize();

        rb.AddForce(direction * speed, ForceMode.Impulse);
        Destroy(ball, 5f);
    }
}
