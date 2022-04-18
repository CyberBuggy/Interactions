using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CyberBuggy
{
    public class DemoInteractable : MonoBehaviour, IInteractable
    {
        public void Interact()
        {
            Debug.Log($"Interacted with {this}");
        }
    }
}
