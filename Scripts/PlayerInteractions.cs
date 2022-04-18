using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CyberBuggy
{
    public class PlayerInteractions : MonoBehaviour
    {
        [SerializeField] private Collider2D _collider;
        private IInteractable _currentInteractable;
        private void OnTriggerEnter2D(Collider2D other)
        {
            this._currentInteractable = other.GetComponent<IInteractable>();
        }
        private void OnTriggerExit2D(Collider2D other)
        {
            if (other.GetComponent<IInteractable>() == this._currentInteractable)
                this._currentInteractable = null;
        }

        private void OnInteract()
        {
            _currentInteractable?.Interact();
        }
    }
}
