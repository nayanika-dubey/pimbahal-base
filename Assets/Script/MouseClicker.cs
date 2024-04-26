using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class MouseClicker : MonoBehaviour
{
    // This code is based on the Unity example found here:
    // https://learn.unity.com/tutorial/onmousedown#63566bf3edbc2a0285856b5a
    [SerializeField]
    private Camera m_Camera;
    void Awake()
    {
        m_Camera = Camera.main;
    }
    // Start is called before the first frame update
    void Start()
    {
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        Mouse mouse = Mouse.current;
        if (mouse.leftButton.wasPressedThisFrame)
        {
            Vector3 mousePosition = mouse.position.ReadValue();
            Ray ray = m_Camera.ScreenPointToRay(mousePosition);
            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                Debug.Log("Clicked on: " + hit.collider.gameObject.name);
                GOInteraction aGOI = hit.collider.gameObject.GetComponent<GOInteraction>();
                if (aGOI)
                {
                    aGOI.Interaction = true;
                }
            }
        }
    }
}