using Inventory.Types;

namespace Inventory;

public abstract class Repository
{
    public static readonly IQueryable<InventoryItem> Inventory = new List<InventoryItem>
    {
        // Product 1
        new() { Id = "inventory_item/1", Name = "InventoryItem1", ProductId = "product/1" },
        new() { Id = "inventory_item/2", Name = "InventoryItem2", ProductId = "product/1" },
        new() { Id = "inventory_item/3", Name = "InventoryItem3", ProductId = "product/1" },

        // Product 2
        new() { Id = "inventory_item/4", Name = "InventoryItem4", ProductId = "product/2" },
        new() { Id = "inventory_item/5", Name = "InventoryItem5", ProductId = "product/2" },

        // Product 3
        new() { Id = "inventory_item/6", Name = "InventoryItem6", ProductId = "product/3" },

        // Product 4
        new() { Id = "inventory_item/7", Name = "InventoryItem7", ProductId = "product/4" },
        new() { Id = "inventory_item/8", Name = "InventoryItem8", ProductId = "product/4" },
        new() { Id = "inventory_item/9", Name = "InventoryItem9", ProductId = "product/4" },
        new() { Id = "inventory_item/10", Name = "InventoryItem10", ProductId = "product/4" },
        new() { Id = "inventory_item/11", Name = "InventoryItem11", ProductId = "product/4" },

        // No inventory for Product 5
    }.AsQueryable();
}
