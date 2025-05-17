using TMPro;
using UnityEngine;

public class GameMessageUI : MonoBehaviour
{
    public TextMeshProUGUI messageText;
    public TextMeshProUGUI saveCounterText;

    private int saves = 0;

    public void ShowMessage(string message)
    {
        messageText.text = message;
        CancelInvoke(nameof(ClearMessage));
        Invoke(nameof(ClearMessage), 2f);
    }

    public void IncrementSave()
    {
        saves++;
        UpdateSaveText();
    }

    private void UpdateSaveText()
    {
        if (saveCounterText != null)
            saveCounterText.text = "Atajadas: " + saves;
    }

    private void ClearMessage()
    {
        messageText.text = "";
    }
}
