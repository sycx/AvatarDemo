using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverlayShowHide : MonoBehaviour {

    public OVROverlay overlay;
	
	void Update () {
        if (OVRInput.GetUp(OVRInput.Button.One)) {
            overlay.enabled = !overlay.enabled;
        }
	}
}
