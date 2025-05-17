using UnityEngine;

public class GolDetector : MonoBehaviour
{
    public GameMessageUI gameUI;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            Debug.Log("¡Gol!");
            if (gameUI != null)
                gameUI.ShowMessage("¡Gol!");

            Destroy(other.gameObject);
        }
    }
}

