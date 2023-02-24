using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ShopKeeper : MonoBehaviour, IInteractable
{
    [SerializeField] private ShopItemList _shopItemsHeld;
    [SerializeField] private ShopSystem _shopSystem;

    public static UnityAction<ShopSystem, PlayerInventoryHolder> OnShopWindowRequest;

    private void Awake()
    {
        _shopSystem = new ShopSystem(_shopItemsHeld.Items.Count, _shopItemsHeld.MaxAllowedGold, 
            _shopItemsHeld.BuyMarkUp, _shopItemsHeld.SellMarkUp);

        foreach (var item in _shopItemsHeld.Items)
        {
            Debug.Log($"{item.ItemData.DisplayName}: {item.Amount}");
            _shopSystem.AddToShop(item.ItemData, item.Amount);
        }
    }

    public UnityAction<IInteractable> OnItneractionComplete { get; set; }

    public void Interact(Interactor interactor, out bool interactSuccessful)
    {
        var playerInv = interactor.GetComponent<PlayerInventoryHolder>();

        if (playerInv != null)
        {
            OnShopWindowRequest?.Invoke(_shopSystem, playerInv);
            interactSuccessful = true;
        }
        else
        {
            interactSuccessful = false;
            Debug.LogError("Player inventory not found");
        }
    }

    public void EndInteractaion()
    {
        
    }
}
