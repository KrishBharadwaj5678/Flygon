using UnityEngine;

public class SliderToggleManager : MonoBehaviour
{
    public GameObject scaleSlider;       // Reference to the scale slider GameObject
    public GameObject verticalSlider;    // Reference to the vertical adjustment slider GameObject

    void Start()
    {
        // Ensure both sliders are inactive at the start
        if (scaleSlider != null && verticalSlider != null)
        {
            scaleSlider.SetActive(false);
            verticalSlider.SetActive(false);
        }
        else
        {
            Debug.LogWarning("Slider references are not set.");
        }
    }

    // Method to toggle the scale slider
    public void ToggleScaleSlider()
    {
        if (scaleSlider != null && verticalSlider != null)
        {
            bool isActive = scaleSlider.activeSelf;
            // Deactivate both sliders
            scaleSlider.SetActive(false);
            verticalSlider.SetActive(false);
            // Toggle the scale slider
            scaleSlider.SetActive(!isActive);
        }
        else
        {
            Debug.LogWarning("Slider references are not set.");
        }
    }

    // Method to toggle the vertical adjustment slider
    public void ToggleVerticalSlider()
    {
        if (scaleSlider != null && verticalSlider != null)
        {
            bool isActive = verticalSlider.activeSelf;
            // Deactivate both sliders
            scaleSlider.SetActive(false);
            verticalSlider.SetActive(false);
            // Toggle the vertical slider
            verticalSlider.SetActive(!isActive);
        }
        else
        {
            Debug.LogWarning("Slider references are not set.");
        }
    }
}
