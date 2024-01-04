using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSetup : MonoBehaviour
{
    public Movement movement;
    public GameObject playerCamera;

    public void IsLocalPlayer()
    {
        movement.enabled = true;
        playerCamera.SetActive(true);
    }
}
