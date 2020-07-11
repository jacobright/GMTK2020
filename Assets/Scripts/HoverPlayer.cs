using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoverPlayer : MonoBehaviour
{
    void OnMouseOver() {
        if (Input.GetMouseButton(0)) {
            transform.localScale = new Vector3(0.9f, 0.9f, 0.9f);
        }
        else {
            transform.localScale = new Vector3(1.1f, 1.1f, 1.1f);
        }
    }

    void OnMouseExit() {
        transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
    }
}
