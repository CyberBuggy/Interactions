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
            _currentInteractable = other.GetComponent<IInteractable>();
        }
        private void OnTriggerExit2D(Collider2D other)
        {
            if (other.GetComponent<IInteractable>() == _currentInteractable)
                _currentInteractable = null;
        }

        private void OnInteract()
        {
            _currentInteractable?.Interact();
        }
    }
}
