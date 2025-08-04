using TMPro;
using UnityEngine;

// Central manager for UI updates (supports abstraction)
public class UImanager : MonoBehaviour
{
    public static UImanager Instance; // Singleton instance

    public TextMeshProUGUI shapesText; // Reference to TextMesh object in the scene

    void Awake()
    {
        // Simple Singleton pattern
        if (Instance == null) Instance = this;
        else Destroy(gameObject);
    }

    // Abstraction: A high-level method to update UI
    public void ShowMessage(string message)
    {
        if (shapesText != null)
        {
            shapesText.text = message;
        }else{
            Debug.LogWarning("ShapesText is not assigned in UIManager!");
        }
    }
}
