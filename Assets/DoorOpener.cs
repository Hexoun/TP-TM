using System.Collections;
using UnityEngine;

public class DoorOpener : MonoBehaviour
{
    public float range = 10f;
    public GameObject door;
    public Camera fpsCam;
    private bool hasOpened = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) && !hasOpened)
        {
            TryOpenDoor();
        }
    }

    void TryOpenDoor()
    {
        if (fpsCam == null || door == null) return;

        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            Debug.Log("Hit: " + hit.transform.name);
            StartCoroutine(OpenDoor());
        }
    }

    IEnumerator OpenDoor()
    {
        if (door == null) yield break;

        Animator doorAnimator = door.GetComponent<Animator>();

        if (doorAnimator != null)
        {
            doorAnimator.Play("DoorOpen");
            yield return new WaitForSeconds(5.0f);
            doorAnimator.Play("New State");
        }
    }

}
