using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpandDrop : MonoBehaviour
{
    [SerializeField] private Transform m_dest;
    private void OnMouseDown()
    {
        GetComponent<BoxCollider>().enabled = false;
        GetComponent<Rigidbody>().useGravity = false;
        GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ;
        this.transform.position = m_dest.position;
        this.transform.parent = GameObject.Find("PickUp Pos").transform;
    }
    private void OnMouseUp()
    {
        this.transform.parent = null;
        GetComponent<BoxCollider>().enabled = true;
        GetComponent<Rigidbody>().useGravity = true;
        GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
    }
}
