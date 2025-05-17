using UnityEngine;
using Vuforia;

public class TargetTracker : MonoBehaviour
{
    public static bool isTargetVisible = false;

    void Start()
    {
        var observer = GetComponent<ObserverBehaviour>();
        if (observer)
        {
            observer.OnTargetStatusChanged += OnTargetStatusChanged;
        }
    }

    void OnTargetStatusChanged(ObserverBehaviour behaviour, TargetStatus status)
    {
        isTargetVisible = status.Status == Status.TRACKED || status.Status == Status.EXTENDED_TRACKED;
    }
}
