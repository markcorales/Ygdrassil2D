// using System.Collections;
// using System.Collections.Generic;
// using Unity.VisualScripting;
// using UnityEngine;
// using UnityEngine.EventSystems;

// public class UpgradeUIHandler : MonoBehaviour,IPointerEnterHandler,IPointerExitHandler
// {
//    private bool mouse_over = false;

//     private void Update() {
//         if(mouse_over)
//         Debug.Log("Mouse Over");
//     }

//     public void OnPointerEnter(PointerEventData eventData)
//     { 
//         mouse_over = true; 
//         UIManager.main.SetHoveringState(true);
//     }
//     public void OnPointerExit(PointerEventData eventData)
//     { 
//         mouse_over = false;
//         UIManager.main.SetHoveringState(false);
//         gameObject.SetActive(false);
//     }
// }
