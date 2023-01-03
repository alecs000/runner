using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    [SerializeField] float speedLeftRigt;
    [SerializeField] float speedForward;
    [SerializeField] CharacterController controller;
    Vector3 startPos;
    private void FixedUpdate()
    {
        controller.Move(speedForward* Time.deltaTime * Vector3.forward);
    }
     
    private void OnMouseDown()
    {
        startPos = Input.mousePosition;
    }
    private void OnMouseDrag()
    {
        var mousePos2D = startPos - Input.mousePosition;
        mousePos2D = new Vector3(mousePos2D.x, 0, 0);
        controller.Move(-mousePos2D.normalized*Time.deltaTime * speedLeftRigt);
    }
}
