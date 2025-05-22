using VideoGame.Inventory;

// Define players
Player player = new Player("Erik", 230, 1000, 1000, 80, 500, 500);

// Define items
Sword sword = new Sword("Obsidian sword", 1400, false, 2);
Bow bow = new Bow("Magic bow", 6550, true, 300, 12);
MagicPotion manaPotion = new MagicPotion("Energy drink", 40, false, 10, 10, 70);
HealingPotion healingPotion = new HealingPotion("Strawberry drink", 90, false, 8, 8, 100);
MagicWand magicWand = new MagicWand("Magic stick", 9880, false, 1500, "wooden magic!!");

// Add items to inventory (hotbar)
sword.Equip(player);
bow.Equip(player);
magicWand.Equip(player);

// Add items to inventory (main)
player.PlayerInventory.AddItem(manaPotion, false);
player.PlayerInventory.AddItem(healingPotion, false);

// Use some items
sword.Use(player);
bow.Use(player);
manaPotion.Use(player);
healingPotion.Use(player);
magicWand.Use(player);