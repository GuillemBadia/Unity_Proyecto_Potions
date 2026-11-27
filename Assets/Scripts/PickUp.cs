using UnityEngine;
using UnityEngine.InputSystem;

public class PickUp : MonoBehaviour
{
    public float distance = 3f;
    public LayerMask Pickup;

    public Inventory inventario;

    void Update()
    {
        RaycastHit hit;

        Debug.DrawRay(transform.position, transform.forward * distance, Color.red);

        if (Mouse.current != null &&
            Mouse.current.leftButton.wasPressedThisFrame)
        {
            if (Physics.Raycast(transform.position, transform.forward, out hit, distance, Pickup, QueryTriggerInteraction.Collide))
            {
                Debug.Log("Has recojido un " + hit.collider.name);

                Ingredientes ingrediente = hit.collider.GetComponent<Ingredientes>();

                if (ingrediente != null)
                {
                    ingrediente.Recoger(inventario);
                }
            }
        }
    }
}