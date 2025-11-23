using UnityEngine;

public class StaticSpotlight : MonoBehaviour
{
    public Transform playerTransform; // The player or VR camera to track

    void Update()
    {
        if (playerTransform != null)
        {
            // Make spotlight rotate to look at the player
            Vector3 targetDirection = playerTransform.position - transform.position;
            Quaternion targetRotation = Quaternion.LookRotation(targetDirection);

            // Smooth rotation (optional)
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * 2f);
        }
    }

}
