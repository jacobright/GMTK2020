using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorPing : MonoBehaviour
{
    public void Ping() {
        GetComponent<Animator>().SetBool("doAnimation", true);
        GetComponent<AudioSource>().Play();
    }
}
