using System;

public class InventoryItem
{
    // Properties
    public string ItemName { get; set; }
    public int ItemId { get; set; }
    public double Price { get; set; }
    public int QuantityInStock { get; set; }

    // Constructor
    public InventoryItem(string itemName, int itemId, double price, int quantityInStock)
    {
        ItemName = itemName;
        ItemId = itemId;
        Price = price;
        QuantityInStock = quantityInStock;
    }

    // Methods

    // Update the price of the item
    public void UpdatePrice(double newPrice)
    {
        // TODO: Update the item's price with the new price.
        Price = newPrice;
        Console.WriteLine($"\n{ItemName} price updated to {Price:C}");
    }

    // Restock the item
    public void RestockItem(int additionalQuantity)
    {
        // TODO: Increase the item's stock quantity by the additional quantity.
        QuantityInStock += additionalQuantity;
        Console.WriteLine($"\n{additionalQuantity} {ItemName}(s) added to stock... Total: {QuantityInStock}");
    }

    // Sell an item
    public void SellItem(int quantitySold)
    {
        // TODO: Decrease the item's stock quantity by the quantity sold.
        if (QuantityInStock >= quantitySold)
        {
            QuantityInStock -= quantitySold;
            Console.WriteLine($"\n{quantitySold} {ItemName}(s) sold... Remaining stock: {QuantityInStock}");
        }
        else
        {
            Console.WriteLine($"\nNot enough {ItemName} in stock to sell {quantitySold}");
        }
    }

    // Check if an item is in stock
    public bool IsInStock()
    {
        return QuantityInStock > 0;
    }

    // Print item details
    public void PrintDetails()
    {
        Console.WriteLine($"\nItem Name: {ItemName}");
        Console.WriteLine($"\nItem ID: {ItemId}");
        Console.WriteLine($"\nPrice: {Price:C}");
        Console.WriteLine($"\nQuantity in Stock: {QuantityInStock}");
        //Console.WriteLine();
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creating instances of InventoryItem
        InventoryItem item1 = new InventoryItem("Laptop", 101, 1200.50, 10);
        InventoryItem item2 = new InventoryItem("Smartphone", 102, 800.30, 15);

        // Example tasks:
        // 1. Print details of all items.
        Console.WriteLine("Initial Inventory Details:");
        Console.WriteLine("==========================");
        Console.WriteLine("\nItem1:");
        Console.WriteLine("--------");
        item1.PrintDetails();
        Console.WriteLine("\nItem2:");
        Console.WriteLine("--------");
        item2.PrintDetails();

        // Update the price of the item
        Console.WriteLine("\nUpdating Prices:");
        Console.WriteLine("------------------");
        item1.UpdatePrice(1350.75);
        item2.UpdatePrice(900.50);

        // 2. Sell some items and then print the updated details.
        item1.SellItem(3);
        item2.SellItem(5);
        Console.WriteLine("\nInventory Details after selling:");
        Console.WriteLine("\nItem1:");
        Console.WriteLine("--------");
        item1.PrintDetails();
        Console.WriteLine("\nItem2:");
        Console.WriteLine("--------");
        item2.PrintDetails();

        // 3. Restock an item and print the updated details.
        item1.RestockItem(5);
        Console.WriteLine("\nInventory Details after restocking:");
        Console.WriteLine("\nItem1:");
        Console.WriteLine("--------");
        item1.PrintDetails();
        Console.WriteLine("\nItem2:");
        Console.WriteLine("--------");
        item2.PrintDetails();

        // 4. Check if an item is in stock and print a message accordingly.
        //Console.WriteLine($"\nIs {item2.ItemName} in stock? {item2.IsInStock()}");
        Console.WriteLine("\nCheck the item stock is available or not...");
        Console.WriteLine($"\n{item1.ItemName} is {(item1.IsInStock() ? "in stock" : "out of stock")}");
        Console.WriteLine($"{item2.ItemName} is {(item2.IsInStock() ? "in stock" : "out of stock")}");
    }
}
