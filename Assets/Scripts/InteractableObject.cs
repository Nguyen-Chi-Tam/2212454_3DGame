using UnityEngine;

public class InteractableObject : MonoBehaviour
{
    public bool playerInRange;
    public string ItemName;

    public string GetItemName()
    {
        return ItemName;
    }
    public void Pickup()
    {
        if (!InventorySystem.Instance.CheckFull())
        {
            InventorySystem.Instance.AddToInventory(ItemName);
            Destroy(gameObject);
        } else{
            Debug.Log("Inventory is full");
        }
    }
}
