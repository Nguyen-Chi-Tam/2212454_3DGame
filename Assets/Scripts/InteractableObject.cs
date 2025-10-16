using UnityEngine;

public class InteractableObject : MonoBehaviour
{
    public string ItemName;

    public string GetItemName()
    {
        return ItemName;
    }
    public void Pickup()
    {
        Debug.Log("Item Added to Inventory: " + ItemName);
        Destroy(gameObject);
    }
}
