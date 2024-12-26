using UnityEngine;
using UnityEngine.UI;

public class DragonSizeController : MonoBehaviour
{
    public Slider sizeSlider; // Reference to the UI Slider
    private Vector3 initialScale; // Initial scale of the dragon

    void Start()
    {
        // Store the initial scale
        initialScale = transform.localScale;

        // Set the slider's min and max values
        sizeSlider.minValue = 0.5f; // Minimum scale factor
        sizeSlider.maxValue = 2f;   // Maximum scale factor

        // Initialize the slider's value to 1 (original size)
        sizeSlider.value = 1f;

        // Add a listener to the slider to call the UpdateSize method when the value changes
        sizeSlider.onValueChanged.AddListener(UpdateSize);
    }

    // Method to update the dragon's scale
    public void UpdateSize(float value)
    {
        // Scale the dragon uniformly based on the slider's value
        transform.localScale = initialScale * value;
    }
}
