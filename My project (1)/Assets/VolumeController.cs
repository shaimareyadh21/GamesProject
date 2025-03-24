using UnityEngine;
using UnityEngine.UI;
using TMPro; // Add this namespace for TextMeshPro

public class VolumeController : MonoBehaviour
{
    public Slider volumeSlider; // Reference to the UI Slider
    public TMP_Text volumeText; // Reference to the TextMeshPro text

    void Start()
    {
        // Check if references are assigned
        if (volumeSlider == null)
        {
            Debug.LogError("Volume Slider is not assigned in the Inspector!");
            return;
        }

        if (volumeText == null)
        {
            Debug.LogError("Volume Text (TextMeshPro) is not assigned in the Inspector!");
            return;
        }

        // Log initial slider value
        Debug.Log("Initial Slider Value: " + volumeSlider.value);

        // Initialize the slider value and text
        volumeSlider.onValueChanged.AddListener(OnVolumeChanged);
        OnVolumeChanged(volumeSlider.value); // Set initial text
    }

    public void OnVolumeChanged(float volume)
    {
        Debug.Log("Slider value changed to: " + volume); // Debug log

        // Update the text to show only the number
        if (volumeText != null)
        {
            volumeText.text = volume.ToString("0"); // Show only the number
        }
        else
        {
            Debug.LogError("Volume Text (TextMeshPro) is not assigned!");
        }
    }
}