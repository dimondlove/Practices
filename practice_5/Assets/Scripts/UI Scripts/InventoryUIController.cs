using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Serialization;

public class InventoryUIController : MonoBehaviour
{
    [FormerlySerializedAs("chestPanel")] public DynamicInventoryDisplay invenotryPanel;
    public DynamicInventoryDisplay playerBackpackPanel;

    private void Awake()
    {
        invenotryPanel.gameObject.SetActive(false);
        playerBackpackPanel.gameObject.SetActive(false);
    }

    private void OnEnable()
    {
        InventoryHolder.OnDynamicInventoryDisplayRequested += DisplayInventory;
    }

    private void OnDisable()
    {
        InventoryHolder.OnDynamicInventoryDisplayRequested -= DisplayInventory;
    }

    void Update()
    {
        if (invenotryPanel.gameObject.activeInHierarchy && Keyboard.current.escapeKey.wasPressedThisFrame)
            invenotryPanel.gameObject.SetActive(false);

        if (playerBackpackPanel.gameObject.activeInHierarchy && Keyboard.current.escapeKey.wasPressedThisFrame)
            playerBackpackPanel.gameObject.SetActive(false);
    }

    void DisplayInventory(InventorySystem invToDisplay, int offset)
    {
        invenotryPanel.gameObject.SetActive(true);
        invenotryPanel.RefreshDynamicInventory(invToDisplay, offset);
    }
}
