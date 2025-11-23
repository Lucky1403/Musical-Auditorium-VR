using System.Collections;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class KeyAnimator : MonoBehaviour
{
    public float pressDepth = 0.02f; // How far the key moves down
    public float pressDuration = 0.1f; // How fast it presses and resets

    private Vector3 originalPosition;
    private bool isAnimating = false;

    private void Start()
    {
        originalPosition = transform.localPosition;
    }

    public void AnimateKeyPress()
    {
        if (!isAnimating)
            StartCoroutine(PressAnimation());
    }

    private IEnumerator PressAnimation()
    {
        isAnimating = true;

        Vector3 targetPosition = originalPosition - new Vector3(0, pressDepth, 0);

        // Move down
        float t = 0;
        while (t < pressDuration)
        {
            transform.localPosition = Vector3.Lerp(originalPosition, targetPosition, t / pressDuration);
            t += Time.deltaTime;
            yield return null;
        }
        transform.localPosition = targetPosition;

        // Wait a moment
        yield return new WaitForSeconds(pressDuration);

        // Move back up
        t = 0;
        while (t < pressDuration)
        {
            transform.localPosition = Vector3.Lerp(targetPosition, originalPosition, t / pressDuration);
            t += Time.deltaTime;
            yield return null;
        }
        transform.localPosition = originalPosition;

        isAnimating = false;
    }
}
