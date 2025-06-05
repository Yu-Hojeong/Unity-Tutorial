using UnityEngine;

public class ObjectMouseEvent : MonoBehaviour
{
    void OnMouseDown()
    {
        Debug.Log("down");
    }
    void OnMouseUp()
    {
        Debug.Log("up");
    }
    void OnMouseEnter()
    {
        Debug.Log("enter");
    }
    void OnMouseExit()
    {
        Debug.Log("exit");
    }
}


// using System;
// using UnityEngine;

// public class ObjectMouseEvent : MonoBehaviour
// {
//     void OnMouseEnter()
//     {
//         Debug.Log("Mouse Enter");
//     }
    
//     private void OnMouseOver()
//     {
//         Debug.Log("Mouse Over");
//     }
    
//     void OnMouseDown()
//     {
//         Debug.Log("Mouse Down");
//     }

//     void OnMouseDrag()
//     {
//         Debug.Log(Input.mousePosition);
        
//         Debug.Log("Mouse Drag");
//     }
    
//     void OnMouseUp()
//     {
//         Debug.Log("Mouse Up");
//     }

//     private void OnMouseUpAsButton()
//     {
//         Debug.Log("Mouse UpAsButton");
//     }

//     void OnMouseExit()
//     {
//         Debug.Log("Mouse Exit");
//     }
    
// }