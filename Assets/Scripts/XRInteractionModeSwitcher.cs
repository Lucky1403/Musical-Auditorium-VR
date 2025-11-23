using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class XRInteractionModeSwitcher : MonoBehaviour
{
    public GameObject leftDirectHand;
    public GameObject rightDirectHand;

    public GameObject leftRayHand;
    public GameObject rightRayHand;

    private XRRayInteractor leftRayInteractor;
    private XRRayInteractor rightRayInteractor;
    private XRInteractorLineVisual leftLineVisual;
    private XRInteractorLineVisual rightLineVisual;

    private void Start()
    {
        // Pre-fetch ray interactor components since ray hands are active in the editor
        leftRayInteractor = leftRayHand.GetComponent<XRRayInteractor>();
        rightRayInteractor = rightRayHand.GetComponent<XRRayInteractor>();
        leftLineVisual = leftRayHand.GetComponent<XRInteractorLineVisual>();
        rightLineVisual = rightRayHand.GetComponent<XRInteractorLineVisual>();

        EnableDirectMode(); // Start in direct interaction
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("OnTriggerEnter called with: " + other.gameObject.name); // Debugging line
        if (IsController(other))
        {
            EnableRayMode();
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (IsController(other))
        {
            EnableRayMode();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (IsController(other))
        {
            EnableDirectMode();
        }
    }

    private bool IsController(Collider other)
    {
        bool isController = other.GetComponent<XRController>() != null || other.CompareTag("PlayerController");
        //Debug.Log("IsController check: " + isController + ", Object name: " + other.gameObject.name); // Debugging line
        return isController;
    }

    private void EnableRayMode()
    {
        Debug.Log("Switched to Ray Mode");

        leftRayInteractor.enabled = true;
        rightRayInteractor.enabled = true;
        leftLineVisual.enabled = true;
        rightLineVisual.enabled = true;

        leftRayHand.SetActive(true);
        rightRayHand.SetActive(true);

        leftDirectHand.SetActive(false);
        rightDirectHand.SetActive(false);
    }

    private void EnableDirectMode()
    {
        Debug.Log("Switched to Direct Mode");

        leftRayInteractor.enabled = false;
        rightRayInteractor.enabled = false;
        leftLineVisual.enabled = false;
        rightLineVisual.enabled = false;

        leftRayHand.SetActive(true);   // Keep ray hands active, just disable interactor
        rightRayHand.SetActive(true);

        leftDirectHand.SetActive(true);
        rightDirectHand.SetActive(true);
    }
}
