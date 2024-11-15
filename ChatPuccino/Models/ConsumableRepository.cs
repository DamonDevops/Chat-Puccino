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
            Image = "Consumables/placeholder.jpg",
            Name = "L'Irvine",
            Description = "3 couleurs, 3 saveurs, la douceur du chocolat blanc se mêle à l'amertume du chocolat noir, avec une touche pétillante de chocolat noisette (option marshmallow!)",
            Ingredients = { "Chocolat 65%", "Chocolat noisette 40%", "Chocolat Blanc", "lait", "Cacao", "Maïzena", "Canelle", "Muscade", "Clou de Girofle", "Gingembre", "Vanille"},
            Price = 6.00,
            IsPromoted = false,
            IsStocked = true,
            AvailableUntil = null
        },
        new Consumable
        {
            Id = 1,
            Type = Enums.ProductType.HotDrink,
            Image = "Consumables/placeholder.jpg",
            Name = "Le Meau",
            Description = "Besoin de paresser un peu? Ce délice à base de chocolat blanc et d'amandes vous rendra aussi épanoui que ce petit teuteu",
            Ingredients = {"Lait entier", "Chocolat blanc", "Crème entière", "Chantilly", "Cacao"},
            Price = 5.50,
            IsPromoted = false,
            IsStocked = true,
            AvailableUntil = null
        },
        new Consumable
        {
            Id = 2,
            Type = Enums.ProductType.HotDrink,
            Image = "Consumables/placeholder.jpg",
            Name = "L'Artifilou",
            Description = "Un petit concentré de saveur explosif, avec ses pépites de caramel se chamaillant dans un chocolat crèmeux à souhait",
            Ingredients = {"Lait", "Cacao", "Cassonnade", "Pépites de caramel", "Fleur de sel", "Vanille", "Chocolat mi-sucré"},
            Price = 5.50,
            IsPromoted = false,
            IsStocked = true,
            AvailableUntil = null
        },
        new Consumable
        {
            Id = 3,
            Type = Enums.ProductType.HotDrink,
            Image = "Consumables/placeholder.jpg",
            Name = "Le Bouboule",
            Description = "Aussi gourmand que la boule de poil d'où il tire son nom, ce chocolat crémeux à souhait est accompagné de bâtonnets de chocolat, et d'une délicieuse crème fraîche",
            Ingredients = {"Chocolat 40%", "Chantilly", "Crème cuisson", "Lait", "Cassonade", "Fécule de maïs", "Oeuf", "Sucre"},
            Price = 6.50,
            IsPromoted = true,
            IsStocked = true,
            AvailableUntil = null
        },
        new Consumable
        {
            Id = 4,
            Type = Enums.ProductType.HotDrink,
            Image = "Consumables/placeholder.jpg",
            Name = "Le Yukafé",
            Description = "Prenez le temps de vous détendre accompagné de cette chaleureuse revisite du Capuccino",
            Ingredients = {"Lait", "Sucre", "Chocolat 65%", "Café (expresso)", "Oeuf", "Crème entière"},
            Price = 4.20,
            IsPromoted = false,
            IsStocked = true,
            AvailableUntil = null
        },
        new Consumable
        {
            Id = 5,
            Type = Enums.ProductType.HotDrink,
            Image = "Consumables/placeholder.jpg",
            Name = "Le Chat-Puccino",
            Description = "Un petit plateau découverte maison: Un chocolat chaud au choix, accompagné de 2 cookies maisons aux choix",
            Ingredients = {"Dépendant des produits choisis"},
            Price = 8.00,
            IsPromoted = true,
            IsStocked = true,
            AvailableUntil = new DateTime(2024, 12, 31)
        },
        new Consumable
        {
            Id = 6,
            Type = Enums.ProductType.HotDrink,
            Image = "Consumables/placeholder.jpg",
            Name = "La Théière",
            Description = "Assortiment de thé au choix (en feuilles: Macha, Menthe, Jasmin | sachets: Citron, Mangue, Thé vert,...), servi dans une théière",
            Ingredients = { "Selon le produit choisi" },
            Price = 4.00,
            IsPromoted = false,
            IsStocked = true,
            AvailableUntil = null
        },
        new Consumable
        {
            Id = 7,
            Type = Enums.ProductType.HotDrink,
            Image = "Consumables/placeholder.jpg",
            Name = "Le Café",
            Description = "Serré, Expresso, ou comme nos chats: Allongé (Moulu sur place)",
            Ingredients = {"Selon le produit choisi"},
            Price = 3.50,
            IsPromoted = false,
            IsStocked = true,
            AvailableUntil = null
        },
        #endregion
        #region Food
        new Consumable
        {
            Id = 8,
            Type = Enums.ProductType.Food,
            Image = "Consumables/placeholder.jpg",
            Name = "Le CrocMollet",
            Description = "Deux délicieuses tartines de pain grillé, du jambon de dinde, 4 fromages et un oeuf par dessus, accompagné d'une petite salade rafraîchissante",
            Ingredients = {"Pain de mie", "Jambon de dinde", "Parmesan", "Gruillère", "Mozzarella", "Moutarde", "Boursin", "Oeuf", "Salade", "Vinaigre balsamique", "Asperge"},
            Price = 9.50,
            IsPromoted = false,
            IsStocked = true,
            AvailableUntil = null
        },
        new Consumable
        {
            Id = 9,
            Type = Enums.ProductType.Food,
            Image = "Consumables/placeholder.jpg",
            Name = "Le Soupisoupe",
            Description = "Une délicieuse soupe maison, selon la saison, servie avec du pain et du beurre (et fromage +1€)",
            Ingredients = {"selon la saison", "pain", "beurre"},
            Price = 5.50,
            IsPromoted = false,
            IsStocked = true,
            AvailableUntil = null
        },
        new Consumable
        {
            Id = 10,
            Type = Enums.ProductType.Food,
            Image = "Consumables/placeholder.jpg",
            Name = "Les 3 potis chats",
            Description = "Plateau apéritif composé d'une portion de saucisson, de fromage et de 2 variété de chips (options Vegan +0,20€, légumes croquants et tomates séchées)",
            Ingredients = {"Selon les choix"},
            Price = 13.00,
            IsPromoted = false,
            IsStocked = true,
            AvailableUntil = null
        },
        #endregion
        #region Snacks
        new Consumable
        {
            Id = 11,
            Type = Enums.ProductType.Snacks,
            Image = "Consumables/placeholder.jpg",
            Name = "L'Elena",
            Description = "Un cookie croustillant aux 2 chocolats",
            Ingredients = {"Selon les choix"},
            Price = 4.00,
            IsPromoted = false,
            IsStocked = true,
            AvailableUntil = null
        },
        new Consumable
        {
            Id = 12,
            Type = Enums.ProductType.Snacks,
            Image = "Consumables/placeholder.jpg",
            Name = "Le Raquna",
            Description = "Un cookie méleangeant astucieusement noisette et amandes",
            Ingredients = {"Selon les choix"},
            Price = 4.00,
            IsPromoted = false,
            IsStocked = true,
            AvailableUntil = null
        },
        new Consumable
        {
            Id = 13,
            Type = Enums.ProductType.Snacks,
            Image = "Consumables/placeholder.jpg",
            Name = "Le poti chat perdu",
            Description = "2 copieuses tranches de pain perdu, sucrées, ravie de se faire adopter par vos papilles!",
            Ingredients = {"Selon les choix"},
            Price = 5.50,
            IsPromoted = false,
            IsStocked = true,
            AvailableUntil = null
        },
        new Consumable
        {
            Id = 14,
            Type = Enums.ProductType.Snacks,
            Image = "Consumables/placeholder.jpg",
            Name = "Le Brownies",
            Description = "Un délicieux brownies au noix de pécan, accompagné d'une boule de sorbet/glace",
            Ingredients = {"Selon les choix"},
            Price = 5.50,
            IsPromoted = false,
            IsStocked = true,
            AvailableUntil = null
        },
        #endregion
        #region Other
        new Consumable
        {
            Id = 15,
            Type = Enums.ProductType.Snacks,
            Image = "Consumables/placeholder.jpg",
            Name = "Jus de pomme",
            Description = "50cl",
            Ingredients = {""},
            Price = 5.20,
            IsPromoted = false,
            IsStocked = true,
            AvailableUntil = null
        },
        new Consumable
        {
            Id = 16,
            Type = Enums.ProductType.Snacks,
            Image = "Consumables/placeholder.jpg",
            Name = "Jus de cerise",
            Description = "50cl",
            Ingredients = {""},
            Price = 5.20,
            IsPromoted = false,
            IsStocked = true,
            AvailableUntil = null
        },
        new Consumable
        {
            Id = 17,
            Type = Enums.ProductType.Snacks,
            Image = "Consumables/placeholder.jpg",
            Name = "Spa pétillante",
            Description = "50cl",
            Ingredients = {""},
            Price = 4.00,
            IsPromoted = false,
            IsStocked = true,
            AvailableUntil = null
        },
        new Consumable
        {
            Id = 18,
            Type = Enums.ProductType.Snacks,
            Image = "Consumables/placeholder.jpg",
            Name = "Spa plate",
            Description = "50cl",
            Ingredients = {""},
            Price = 4.00,
            IsPromoted = false,
            IsStocked = true,
            AvailableUntil = null
        },
        new Consumable
        {
            Id = 19,
            Type = Enums.ProductType.Snacks,
            Image = "Consumables/placeholder.jpg",
            Name = "Limonade Mangue",
            Description = "50cl",
            Ingredients = {""},
            Price = 4.50,
            IsPromoted = false,
            IsStocked = true,
            AvailableUntil = null
        },
        new Consumable
        {
            Id = 20,
            Type = Enums.ProductType.Snacks,
            Image = "Consumables/placeholder.jpg",
            Name = "Coca-cola",
            Description = "50cl",
            Ingredients = {""},
            Price = 5.00,
            IsPromoted = false,
            IsStocked = true,
            AvailableUntil = null
        }
        #endregion
    };
}