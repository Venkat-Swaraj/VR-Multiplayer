using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FishNet.Connection;
using FishNet.Object;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.InputSystem.XR;


public class NetworkPlayer : NetworkBehaviour
{
    public GameObject LocomotionSystem;
    public AudioListener AudioListener;
    public TrackedPoseDriver Head;
    public ActionBasedController[] Controllers;
    public override void OnStartClient()
    {
        if (!base.IsOwner && base.IsClient)
        {
            // Do something
            /*Debug.Log("I am the owner of this object and I am a client");*/
            /*var clientMoveProvider = GetComponent<>*/
            
            var clientCamera = GetComponentInChildren<Camera>();
            /*var clientListener = GetComponentInChildren<AudioListener>();*/
            /*var clientHead = GetComponentInChildren<TrackedPoseDriver>();*/
            /*var clientControllers = GetComponentsInChildren<ActionBasedController>();*/
            
            LocomotionSystem.SetActive(false);
            clientCamera.enabled = false;
            Head.enabled = false;
            AudioListener.enabled = false;

            foreach (var controller in Controllers)
            {
                /*controller.enabled = false;*/
                controller.enableInputActions = false;
                controller.enableInputTracking = false;
            }
        }
    }
}
