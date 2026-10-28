using Marten.Schema;

namespace Catalog.API.Data;

public class CatalogInitialData : IInitialData
{
    public async Task Populate(IDocumentStore store, CancellationToken cancellation)
    {
        using var session = store.LightweightSession();
        if (await session.Query<Product>().AnyAsync())
            return;

        session.Store<Product>(GetPreconfiguredProducts());
        await session.SaveChangesAsync();
    }

    private static IEnumerable<Product> GetPreconfiguredProducts() => new List<Product>()
        {
            new Product {
                Id = Guid.Parse("1a2b3c4d-5e6f-7a8b-9c0d-1e2f3a4b5c6d"),
                Name = "iPhone 15 Pro Max",
                Description = "The ultimate iPhone with a strong and light titanium design, featuring the groundbreaking A17 Pro chip, a customizable Action button, and the most powerful iPhone camera system ever.",
                ImageFile = "iphone-15-pro-max-1.png",
                Price = 1199.00m,
                Category = new List<string> { "Smartphone", "5G", "Premium", "Camera" }
            },
            new Product {
                Id = Guid.Parse("2b3c4d5e-6f7a-8b9c-0d1e-2f3a4b5c6d7e"),
                Name = "iPhone 15 Pro",
                Description = "Forged in titanium and featuring the A17 Pro chip, a customizable Action button, and a 48MP Main camera with advanced computational photography.",
                ImageFile = "iphone-15-pro-1.png",
                Price = 999.00m,
                Category = new List<string> { "Smartphone", "5G", "Premium", "Camera" }
            },
            new Product {
                Id = Guid.Parse("3c4d5e6f-7a8b-9c0d-1e2f-3a4b5c6d7e8f"),
                Name = "iPhone 15",
                Description = "A powerful lineup featuring the Dynamic Island, a 48MP Main camera, and USB-C, all in a durable color-infused glass and aluminum design.",
                ImageFile = "iphone-15-1.png",
                Price = 799.00m,
                Category = new List<string> { "Smartphone", "5G", "Camera" }
            },

            new Product {
                Id = Guid.Parse("6f7a8b9c-0d1e-2f3a-4b5c-6d7e8f9a0b1c"),
                Name = "Samsung Galaxy S24 Ultra",
                Description = "The new era of mobile AI is here. Features a built-in S Pen, a 200MP camera, and the powerful Snapdragon 8 Gen 3 processor for Galaxy.",
                ImageFile = "galaxy-s24-ultra-1.png",
                Price = 1299.00m,
                Category = new List<string> { "Smartphone", "5G", "Premium", "Camera", "AI" }
            },
            new Product {
                Id = Guid.Parse("0d1e2f3a-4b5c-6d7e-8f9a-0b1c2d3e4f5a"),
                Name = "Samsung Galaxy Z Flip 5",
                Description = "A compact, stylish foldable with a larger Cover Screen for quick replies, selfies, and using apps without unfolding.",
                ImageFile = "galaxy-z-flip5-1.png",
                Price = 999.00m,
                Category = new List<string> { "Smartphone", "5G", "Foldable", "Camera" }
            },
            new Product {
                Id = Guid.Parse("9c0d1e2f-3a4b-5c6d-7e8f-9a0b1c2d3e4f"),
                Name = "Samsung Galaxy Z Fold 5",
                Description = "The ultimate foldable smartphone that unfolds into a tablet-like experience, featuring a refined hinge and multitasking capabilities.",
                ImageFile = "galaxy-z-fold5-1.png",
                Price = 1799.00m,
                Category = new List<string> { "Smartphone", "5G", "Premium", "Foldable" }
            },

            new Product {
                Id = Guid.Parse("1e2f3a4b-5c6d-7e8f-9a0b-1c2d3e4f5a6b"),
                Name = "Xiaomi 14 Ultra",
                Description = "A photography powerhouse co-engineered with Leica, featuring a 1-inch type sensor, variable aperture, and flagship Snapdragon performance.",
                ImageFile = "xiaomi-14-ultra-1.png",
                Price = 1299.00m,
                Category = new List<string> { "Smartphone", "5G", "Premium", "Camera" }
            },
            new Product {
                Id = Guid.Parse("5c6d7e8f-9a0b-1c2d-3e4f-5a6b7c8d9e0f"),
                Name = "Xiaomi 13T Pro",
                Description = "Professional-grade Leica optics meet flagship performance, complete with IP68 dust and water resistance.",
                ImageFile = "xiaomi-13t-pro-1.png",
                Price = 649.00m,
                Category = new List<string> { "Smartphone", "5G", "Camera", "Premium" }
            },
            new Product {
                Id = Guid.Parse("3a4b5c6d-7e8f-9a0b-1c2d-3e4f5a6b7c8d"),
                Name = "Redmi Note 13 Pro+",
                Description = "Premium mid-range experience featuring a 200MP camera, 120W HyperCharge, and a stunning 1.5K curved AMOLED display.",
                ImageFile = "redmi-note-13-pro-plus-1.png",
                Price = 399.00m,
                Category = new List<string> { "Smartphone", "5G", "Camera", "Budget-Friendly" }
            },

            new Product {
                Id = Guid.Parse("1c2d3e4f-5a6b-7c8d-9e0f-1a2b3c4d5e6f"),
                Name = "OnePlus 12",
                Description = "Smooth beyond belief with the Snapdragon 8 Gen 3, a Hasselblad camera system, and blazing fast 100W SUPERVOOC charging.",
                ImageFile = "oneplus-12-1.png",
                Price = 799.00m,
                Category = new List<string> { "Smartphone", "5G", "Premium", "Gaming" }
            },
            new Product {
                Id = Guid.Parse("3e4f5a6b-7c8d-9e0f-1a2b-3c4d5e6f7a8b"),
                Name = "OnePlus Open",
                Description = "The most advanced foldable smartphone, featuring a virtually crease-free display, Hasselblad cameras, and open canvas multitasking.",
                ImageFile = "oneplus-open-1.png",
                Price = 1699.00m,
                Category = new List<string> { "Smartphone", "5G", "Premium", "Foldable" }
            },
            new Product {
                Id = Guid.Parse("4f5a6b7c-8d9e-0f1a-2b3c-4d5e6f7a8b9c"),
                Name = "OnePlus 11",
                Description = "A powerhouse device with the Snapdragon 8 Gen 2, 100W fast charging, and a triple-camera system tuned by Hasselblad.",
                ImageFile = "oneplus-11-1.png",
                Price = 699.00m,
                Category = new List<string> { "Smartphone", "5G", "Premium", "Camera" }
            },

            new Product {
                Id = Guid.Parse("6b7c8d9e-0f1a-2b3c-4d5e-6f7a8b9c0d1e"),
                Name = "Sony Xperia 1 VI",
                Description = "The ultimate creator's smartphone with a variable optical zoom lens, 4K 120Hz OLED display, and professional-grade video recording.",
                ImageFile = "sony-xperia-1vi-1.png",
                Price = 1399.00m,
                Category = new List<string> { "Smartphone", "5G", "Premium", "Camera" }
            },
            new Product {
                Id = Guid.Parse("9e0f1a2b-3c4d-5e6f-7a8b-9c0d1e2f3a4b"),
                Name = "Sony Xperia Pro-I",
                Description = "A smartphone with a 1.0-type image sensor, bringing Alpha camera technology to your pocket for unparalleled low-light performance.",
                ImageFile = "sony-xperia-pro-i-1.png",
                Price = 1799.00m,
                Category = new List<string> { "Smartphone", "5G", "Premium", "Camera" }
            },
            new Product {
                Id = Guid.Parse("8d9e0f1a-2b3c-4d5e-6f7a-8b9c0d1e2f3a"),
                Name = "Sony Xperia 10 V",
                Description = "Lightweight and durable with IP65/68 water resistance, a massive 5000mAh battery, and a triple-camera setup for everyday photography.",
                ImageFile = "sony-xperia-10-v-1.png",
                Price = 449.00m,
                Category = new List<string> { "Smartphone", "5G", "Budget-Friendly", "Camera" }
            },
        };
}
