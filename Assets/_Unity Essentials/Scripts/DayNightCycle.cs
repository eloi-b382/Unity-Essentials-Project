using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    [Tooltip("The time in seconds for a full day to pass.")]
    public float dayDuration = 60f; // Default to 60 seconds for a full day cycle

    private float elapsedTime = 0f;

    void Update()
    {
        // Increment elapsed time based on the time that has passed since the last frame
        elapsedTime += Time.deltaTime;

        // Calculate the rotation angle based on the elapsed time and day duration
        float rotationAngle = (elapsedTime / dayDuration) * 360f;

        // Apply the rotation to the light
        transform.rotation = Quaternion.Euler(rotationAngle, 0, 0);

        // Reset elapsed time to prevent overflow and to loop the cycle
        if (elapsedTime >= dayDuration)
        {
            elapsedTime -= dayDuration;
        }
    }
}

