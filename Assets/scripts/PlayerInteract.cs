using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    // code

    public float interactRange = 1f;
    public float maxLookDistance = 2f;

    private void Update() {


        if (GameState.Instance != null && GameState.Instance.currentPhase != GamePhase.InGame)
            return;
            
        if (Input.GetKeyDown(KeyCode.E)) {

            //collision "sphere" for player to detect nearby objects
            Collider[] colliderArray = Physics.OverlapSphere(transform.position, interactRange);
            //loops through each "hit" found within the collision "sphere"
            foreach (Collider collider in colliderArray) {
                //if object is interactable, call Interact()
                Interactable interactable = collider.GetComponent<Interactable>();
                if (interactable != null) {

                    //now we check if player is also concurrently looking at object
                    Ray ray = new Ray(Camera.main.transform.position, Camera.main.transform.forward);
                    if (Physics.Raycast(ray, out RaycastHit hit, maxLookDistance)) {
                        //double check looking at same object that is within collision "sphere"
                        if (hit.collider == collider) {
                            Debug.Log("Interacting with: " + collider.name);
                            interactable.Interact();
                            break;
                        } else { Debug.Log("Looking at sum else: " + hit.collider.name);}
                    }
                    
                }
            }
        }
        
    }


    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, interactRange);
    }
}
