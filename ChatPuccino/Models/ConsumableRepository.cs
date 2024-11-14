using UIKit;

namespace ChatPuccino.Models;

public static class ConsumableRepository
{
    public static List<Consumable> AllConsumables => new List<Consumable>
    {
        #region Hot Drinks
        new Consumable
        {
            Id = 0,
            Type = Enums.ProductType.HotDrink,
            Image = "",
            Name = "L'Irvine",
            Description = "3 couleurs, 3 saveurs, la douceur du chocolat blanc se mêle à l'amertume du chocolat noir, avec une touche pétillante de chocolat noisette (option marshmallow!)",
            Ingredients = { "Chocolat 65%", "Chocolat noisette 40%", "Chocolat Blanc", "lait", "Cacao", "Maïzena", "Canelle", "Muscade", "Clou de Girofle", "Gingembre", "Vanille"},
            Price = 5.00,
            IsPromoted = false,
            IsStocked = true,
            AvailableUntil = null
        },
        new Consumable
        {
            Id = 1,
            Type = Enums.ProductType.HotDrink,
            Image = "",
            Name = "Le Meau",
            Description = "Besoin de paresser un peu? Ce délice à base de chocolat blanc et d'amandes vous rendra aussi épanoui que ce petit teuteu",
            Ingredients = {"Lait entier", "Chocolat blanc", "Crème entière", "Chantilly", "Cacao"},
            Price = 0.00,
            IsPromoted = false,
            IsStocked = true,
            AvailableUntil = null
        },
        new Consumable
        {
            Id = 2,
            Type = Enums.ProductType.HotDrink,
            Image = "",
            Name = "L'Artifilou",
            Description = "Un petit concentré de saveur explosif, avec ses pépites de caramel se chamaillant dans un chocolat crèmeux à souhait",
            Ingredients = {"Lait", "Cacao", "Cassonnade", "Pépites de caramel", "Fleur de sel", "Vanille", "Chocolat mi-sucré"},
            Price = 0.00,
            IsPromoted = false,
            IsStocked = true,
            AvailableUntil = null
        },
        new Consumable
        {
            Id = 3,
            Type = Enums.ProductType.HotDrink,
            Image = "",
            Name = "Le Bouboule",
            Description = "Aussi gourmand que la boule de poil d'où il tire son nom, ce chocolat crémeux à souhait est accompagné de bâtonnets de chocolat, et d'une délicieuse crème fraîche",
            Ingredients = {"Chocolat 40%", "Chantilly", "Crème cuisson", "Lait", "Cassonade", "Fécule de maïs", "Oeuf", "Sucre"},
            Price = 0.00,
            IsPromoted = true,
            IsStocked = true,
            AvailableUntil = null
        },
        new Consumable
        {
            Id = 4,
            Type = Enums.ProductType.HotDrink,
            Image = "",
            Name = "Le Yukafé",
            Description = "Prenez le temps de vous détendre accompagné de cette chaleureuse revisite du Capuccino",
            Ingredients = {"Lait", "Sucre", "Chocolat 65%", "Lait", "Café (expresso)", "Oeuf", "Crème entière"},
            Price = 0.00,
            IsPromoted = false,
            IsStocked = true,
            AvailableUntil = null
        },
        new Consumable
        {
            Id = 5,
            Type = Enums.ProductType.HotDrink,
            Image = "",
            Name = "Le Chat-Puccino",
            Description = "Un petit plateau découverte maison: Un chocolat chaud au choix, accompagné de 2 cookies maisons aux choix (y compris Vegan)",
            Ingredients = {"Dépendant des produits choisis"},
            Price = 0.00,
            IsPromoted = true,
            IsStocked = true,
            AvailableUntil = new DateTime(2024, 12, 31)
        },
        new Consumable
        {
            Id = 6,
            Type = Enums.ProductType.HotDrink,
            Image = "",
            Name = "La Théière",
            Description = "Assortiment de thé au choix (en feuilles: Macha, Menthe, Jasmin | sachets: Citron, Mangue, Thé vert,...), servi dans une théière",
            Ingredients = { "Selon le produit choisi" },
            Price = 5.00,
            IsPromoted = false,
            IsStocked = true,
            AvailableUntil = null
        },
        new Consumable
        {
            Id = 7,
            Type = Enums.ProductType.HotDrink,
            Image = "",
            Name = "Le Café",
            Description = "Serré, Expresso, ou comme nos chats: Allongé (Moulu sur place)",
            Ingredients = {"Selon le produit choisi"},
            Price = 5.00,
            IsPromoted = false,
            IsStocked = true,
            AvailableUntil = null
        },
        #endregion
        #region Food
        new Consumable
        {
            Id = 0,
            Type = Enums.ProductType.Food,
            Image = "",
            Name = "Le CrocMollet",
            Description = "Une délicieuse tartine de pain grillé, du jambon de dinde, 4 fromages et un oeuf par dessus, accompagné d'une petite salade rafraîchissante",
            Ingredients = {"Pain de mie", "Jambon de dinde", "Parmesan", "Gruillère", "Mozzarella", "Moutarde", "Boursin", "Oeuf", "Salade", "Vinaigre balsamique", "Asperge"},
            Price = 5.00,
            IsPromoted = false,
            IsStocked = true,
            AvailableUntil = null
        },

        #endregion
    };
}
