using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetPermission : MonoBehaviour {

	void Start() {
        
        if( !UniAndroidPermission.IsPermitted(AndroidPermission.CAMERA) ) UniAndroidPermission.RequestPermission(AndroidPermission.CAMERA, OnAllow, OnDeny, OnDenyAndNeverAskAgain);

    }

    void Update() {
    }

    private void OnAllow(){
    }

    private void OnDeny() {
    }

    private void OnDenyAndNeverAskAgain() {
    }

}
