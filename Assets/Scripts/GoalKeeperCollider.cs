using UnityEngine;

public class GoalKeeperCollider : MonoBehaviour
{
    public GameMessageUI gameUI;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            Destroy(other.gameObject); // ← ¡Se destruye de inmediato!

            if (gameUI != null)
            {
                gameUI.ShowMessage("¡Atajada!");
                gameUI.IncrementSave();
            }
        }
    }
}
