using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMover : MonoBehaviour {
    void Update() {
        transform.position += transform.forward * Input.GetAxis("Vertical") * 0.1f;
        transform.position += transform.right * Input.GetAxis("Horizontal") * 0.1f;
    }
}

