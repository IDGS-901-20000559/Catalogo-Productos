using Microsoft.AspNetCore.Mvc;
using ProductosApi.Models;

namespace ProductosApi.Controllers
{
    [ApiController]
    [Route("Products")]
    public class ProductosController : ControllerBase
    {

        private static readonly Producto[] Productos = new[]
        {
            new Producto
            {
                Id = 1,
                Nombre = "iPhone 9",
                Descripcion = "An apple mobile which is nothing like apple",
                Precio = 549,
                DescuentoPorcentaje = 12.96,
                Rating = 4.69,
                Stock = 94,
                Marca = "Apple",
                Categoria = "smartphones",
                Imagen = "https://i.dummyjson.com/data/products/1/thumbnail.jpg",
                Imagenes = new string[]
                {
                    "https://i.dummyjson.com/data/products/1/1.jpg",
                    "https://i.dummyjson.com/data/products/1/2.jpg",
                    "https://i.dummyjson.com/data/products/1/3.jpg",
                    "https://i.dummyjson.com/data/products/1/4.jpg",
                    "https://i.dummyjson.com/data/products/1/thumbnail.jpg"
                }
            },
            new Producto
            {
                Id = 2,
                Nombre = "iPhone X",
                Descripcion = "SIM-Free, Model A19211 6.5-inch Super Retina HD display with OLED technology A12 Bionic chip with ...",
                Precio = 899,
                DescuentoPorcentaje = 17.94,
                Rating = 4.44,
                Stock = 34,
                Marca = "Apple",
                Categoria = "smartphones",
                Imagen = "https://i.dummyjson.com/data/products/2/thumbnail.jpg",
                Imagenes = new string[]
                {
                    "https://i.dummyjson.com/data/products/2/1.jpg",
                    "https://i.dummyjson.com/data/products/2/2.jpg",
                    "https://i.dummyjson.com/data/products/2/3.jpg",
                    "https://i.dummyjson.com/data/products/2/thumbnail.jpg"
                }
            },
            new Producto { Id = 3,
                Nombre = "Samsung Universe 9",
                           Descripcion = "Samsung's new variant which goes beyond Galaxy to the Universe",
                           Precio = 1249,
                           DescuentoPorcentaje = 15.46,
                           Rating = 4.09,
                           Stock = 36,
                           Marca = "Samsung",
                           Categoria = "smartphones",
                           Imagen = "https://i.dummyjson.com/data/products/3/thumbnail.jpg",
                           Imagenes = new string[]
                           {
                    "https://i.dummyjson.com/data/products/3/1.jpg"
                }
            },
            new Producto() { 
                Id = 4,
                Nombre = "OPPOF19",
                Descripcion = "OPPO F19 is officially announced on April 2021.",
                Precio = 280,
                DescuentoPorcentaje = 17.91,
                Rating = 4.3,
                Stock = 123,
                Marca = "OPPO",
                Categoria = "smartphones",
                Imagen = "https://i.dummyjson.com/data/products/4/thumbnail.jpg",
                Imagenes = new string[]
                {
                    "https://i.dummyjson.com/data/products/4/1.jpg",
                    "https://i.dummyjson.com/data/products/4/2.jpg",
                    "https://i.dummyjson.com/data/products/4/3.jpg",
                    "https://i.dummyjson.com/data/products/4/4.jpg",
                    "https://i.dummyjson.com/data/products/4/thumbnail.jpg"
                }
            },
            new Producto()
            {
                Id = 5,
                Nombre = "Huawei P30",
                Descripcion = "Huawei’s re-badged P30 Pro New Edition was officially unveiled yesterday in Germany and now the device has made its way to the UK.",
                Precio = 499,
                DescuentoPorcentaje = 10.58,
                Rating = 4.09,
                Stock = 32,
                Marca = "Huawei",
                Categoria = "smartphones",
                Imagen = "https://i.dummyjson.com/data/products/5/thumbnail.jpg",
                Imagenes = new string[]
                {
                    "https://i.dummyjson.com/data/products/5/1.jpg",
                    "https://i.dummyjson.com/data/products/5/2.jpg",
                    "https://i.dummyjson.com/data/products/5/3.jpg"
                }
            },
            new Producto()
            {
                Id = 6,
                Nombre = "MacBook Pro",
                Descripcion = "MacBook Pro 2021 with mini-LED display may launch between September, November",
                Precio = 1749,
                DescuentoPorcentaje = 11.02,
                Rating = 4.57,
                Stock = 83,
                Marca = "Apple",
                Categoria = "laptops",
                Imagen = "https://i.dummyjson.com/data/products/6/thumbnail.png",
                Imagenes = new string[]
                {
                    "https://i.dummyjson.com/data/products/6/1.png",
                    "https://i.dummyjson.com/data/products/6/2.jpg",
                    "https://i.dummyjson.com/data/products/6/3.png",
                    "https://i.dummyjson.com/data/products/6/4.jpg"
                }
            },
            new Producto() { 
                Id = 7,
                Nombre = "Samsung Galaxy Book",
                Descripcion = "Samsung Galaxy Book S (2020) Laptop With Intel Lakefield Chip, 8GB of RAM Launched",
                Precio = 1499,
                DescuentoPorcentaje = 4.15,
                Rating = 4.25,
                Stock = 50,
                Marca = "Samsung",
                Categoria = "laptops",
                Imagen = "https://i.dummyjson.com/data/products/7/thumbnail.jpg",
                Imagenes = new string[]
                {
                    "https://i.dummyjson.com/data/products/7/1.jpg",
                    "https://i.dummyjson.com/data/products/7/2.jpg",
                    "https://i.dummyjson.com/data/products/7/3.jpg",
                    "https://i.dummyjson.com/data/products/7/thumbnail.jpg"
                }
            },
            new Producto()
            {
                Id = 8,
                Nombre = "Microsoft Surface Laptop 4",
                Descripcion = "Style and speed. Stand out on HD video calls backed by Studio Mics. Capture ideas on the vibrant touchscreen.",
                Precio = 1499,
                DescuentoPorcentaje = 10.23,
                Rating = 4.43,
                Stock = 68,
                Marca = "Microsoft Surface",
                Categoria = "laptops",
                Imagen = "https://i.dummyjson.com/data/products/8/thumbnail.jpg",
                Imagenes = new string[]
                {
                    "https://i.dummyjson.com/data/products/8/1.jpg",
                    "https://i.dummyjson.com/data/products/8/2.jpg",
                    "https://i.dummyjson.com/data/products/8/3.jpg",
                    "https://i.dummyjson.com/data/products/8/4.jpg",
                    "https://i.dummyjson.com/data/products/8/thumbnail.jpg"
                }
            },
            new Producto() { 
                Id = 9,
                Nombre = "Infinix INBOOK",
                Descripcion = "Infinix Inbook X1 Ci3 10th 8GB 256GB 14 Win10 Grey – 1 Year Warranty",
                Precio = 1099,
                DescuentoPorcentaje = 11.83,
                Rating = 4.54,
                Stock = 96,
                Marca = "Infinix",
                Categoria = "laptops",
                Imagen = "https://i.dummyjson.com/data/products/9/thumbnail.jpg",
                Imagenes = new string[]
                {
                    "https://i.dummyjson.com/data/products/9/1.jpg",
                    "https://i.dummyjson.com/data/products/9/2.png",
                    "https://i.dummyjson.com/data/products/9/3.png",
                    "https://i.dummyjson.com/data/products/9/4.jpg",
                    "https://i.dummyjson.com/data/products/9/thumbnail.jpg"
                }
            },
            new Producto() { 
                Id = 10,
                Nombre = "HP Pavilion 15-DK1056WM",
                Descripcion = "HP Pavilion 15-DK1056WM Gaming Laptop 10th Gen Core i5, 8GB, 256GB SSD, GTX 1650 4GB, Windows 10",
                Precio = 1099,
                DescuentoPorcentaje = 6.18,
                Rating = 4.43,
                Stock = 89,
                Marca = "HP Pavilion",
                Categoria = "laptops",
                Imagen = "https://i.dummyjson.com/data/products/10/thumbnail.jpeg",
                Imagenes = new string[]
                {
                    "https://i.dummyjson.com/data/products/10/1.jpg",
                    "https://i.dummyjson.com/data/products/10/2.jpg",
                    "https://i.dummyjson.com/data/products/10/3.jpg",
                    "https://i.dummyjson.com/data/products/10/thumbnail.jpeg"
                }
            },
            new Producto() { 
                Id = 11,
                Nombre = "perfume Oil",
                Descripcion = "Mega Discount, Impression of Acqua Di Gio by GiorgioArmani concentrated attar perfume Oil",
                Precio = 13,
                DescuentoPorcentaje = 8.4,
                Rating = 4.26,
                Stock = 65,
                Marca = "Impression of Acqua Di Gio",
                Categoria = "fragrances",
                Imagen = "https://i.dummyjson.com/data/products/11/thumbnail.jpg",
                Imagenes = new string[]
                {
                    "https://i.dummyjson.com/data/products/11/1.jpg",
                    "https://i.dummyjson.com/data/products/11/2.jpg",
                    "https://i.dummyjson.com/data/products/11/3.jpg",
                    "https://i.dummyjson.com/data/products/11/thumbnail.jpg"
                }
            },
            new Producto() { 
                Id = 12,
                Nombre = "Brown Perfume",
                Descripcion="Royal_Mirage Sport Brown Perfume for Men & Women - 120ml",
                Precio = 40,
                DescuentoPorcentaje = 15.66,
                Rating = 4,
                Stock = 52,
                Marca = "Royal_Mirage",
                Categoria = "fragrances",
                Imagen = "https://i.dummyjson.com/data/products/12/thumbnail.jpg",
                Imagenes = new string[]
                {
                    "https://i.dummyjson.com/data/products/12/1.jpg",
                    "https://i.dummyjson.com/data/products/12/2.jpg",
                    "https://i.dummyjson.com/data/products/12/3.png",
                    "https://i.dummyjson.com/data/products/12/4.jpg",
                    "https://i.dummyjson.com/data/products/12/thumbnail.jpg"
                }
            },
            new Producto() { 
                Id = 13,
                Nombre = "Fog Scent Xpressio Perfume",
                Descripcion = "",
                Precio = 13,
                DescuentoPorcentaje = 8.14,
                Rating = 4.59,
                Stock = 61,
                Marca = "Fog Scent Xpressio",
                Categoria = "fragrances",
                Imagen = "https://i.dummyjson.com/data/products/13/thumbnail.webp",
                Imagenes = new string[]
                {
                    "https://i.dummyjson.com/data/products/13/1.jpg",
                    "https://i.dummyjson.com/data/products/13/2.png",
                    "https://i.dummyjson.com/data/products/13/3.jpg",
                    "https://i.dummyjson.com/data/products/13/4.jpg",
                    "https://i.dummyjson.com/data/products/13/thumbnail.webp"
                }
            },
            new Producto() { 
                Id = 14,
                Nombre = "Non-Alcoholic Concentrated Perfume Oil",
                Descripcion = "Original Al Munakh® by Mahal Al Musk | Our Impression of Climate | 6ml Non-Alcoholic Concentrated Perfume Oil",
                Precio = 120,
                DescuentoPorcentaje = 15.6,
                Rating = 4.21,
                Stock = 114,
                Marca = "Al Munakh",
                Categoria = "fragrances",
                Imagen = "https://i.dummyjson.com/data/products/14/thumbnail.jpg",
                Imagenes = new string[]
                {
                    "https://i.dummyjson.com/data/products/14/1.jpg",
                    "https://i.dummyjson.com/data/products/14/2.jpg",
                    "https://i.dummyjson.com/data/products/14/3.jpg",
                    "https://i.dummyjson.com/data/products/14/thumbnail.jpg"
                }
            },
            new Producto() { 
                Id = 15,
                Nombre = "Eau De Perfume Spray",
                Descripcion = "Genuine  Al-Rehab spray perfume from UAE/Saudi Arabia/Yemen High Quality",
                Precio = 30,
                DescuentoPorcentaje = 10.99,
                Rating = 4.7,
                Stock = 105,
                Marca = "Lord - Al-Rehab",
                Categoria = "fragrances",
                Imagen = "https://i.dummyjson.com/data/products/15/thumbnail.jpg",
                Imagenes = new string[]
                {
                    "https://i.dummyjson.com/data/products/15/1.jpg",
                    "https://i.dummyjson.com/data/products/15/2.jpg",
                    "https://i.dummyjson.com/data/products/15/3.jpg",
                    "https://i.dummyjson.com/data/products/15/4.jpg",
                    "https://i.dummyjson.com/data/products/15/thumbnail.jpg"
                }
                },
            new Producto(){
                Id = 16,
                Nombre = "Hyaluronic Acid Serum",
                Descripcion = "L'Oreal Paris introduces Hyaluron Expert Replumping Serum formulated with 1.5% Hyaluronic Acid",
                Precio = 19,
                DescuentoPorcentaje = 13.31,
                Rating = 4.83,
                Stock = 110,
                Marca = "L'Oreal Paris",
                Categoria = "skincare",
                Imagen = "https://i.dummyjson.com/data/products/16/thumbnail.jpg",
                Imagenes = new string[]
                {
                    "https://i.dummyjson.com/data/products/16/1.png",
                    "https://i.dummyjson.com/data/products/16/2.webp",
                    "https://i.dummyjson.com/data/products/16/3.jpg",
                    "https://i.dummyjson.com/data/products/16/4.jpg",
                    "https://i.dummyjson.com/data/products/16/thumbnail.jpg"
                }
                },
            new Producto()
            {
                Id = 17,
                Nombre = "Tree Oil 30ml",
                Descripcion = "Tea tree oil contains a number of compounds, including terpinen-4-ol, that have been shown to kill certain bacteria,",
                Precio = 12,
                DescuentoPorcentaje = 4.09,
                Rating = 4.52,
                Stock = 78,
                Marca = "Hemani Tea",
                Categoria = "skincare",
                Imagen = "https://i.dummyjson.com/data/products/17/thumbnail.jpg",
                Imagenes = new string[]
                {
                    "https://i.dummyjson.com/data/products/17/1.jpg",
                    "https://i.dummyjson.com/data/products/17/2.jpg",
                    "https://i.dummyjson.com/data/products/17/3.jpg",
                    "https://i.dummyjson.com/data/products/17/thumbnail.jpg"
                }
             },
            new Producto()
            {
                Id = 18,
                Nombre = "Oil Free Moisturizer 100ml",
                Descripcion = "Dermive Oil Free Moisturizer with SPF 20 is specifically formulated with ceramides, hyaluronic acid & sunscreen.",
                Precio = 40,
                DescuentoPorcentaje = 13.1,
                Rating = 4.56,
                Stock = 88,
                Marca = "Dermive",
                Categoria = "skincare",
                Imagen = "https://i.dummyjson.com/data/products/18/thumbnail.jpg",
                Imagenes = new string[]
                {
                    "https://i.dummyjson.com/data/products/18/1.jpg",
                    "https://i.dummyjson.com/data/products/18/2.jpg",
                    "https://i.dummyjson.com/data/products/18/3.jpg",
                    "https://i.dummyjson.com/data/products/18/4.jpg",
                    "https://i.dummyjson.com/data/products/18/thumbnail.jpg"
                }
            },
            new Producto()
            {
                Id = 19,
                Nombre = "Skin Beauty Serum.",
                Descripcion = "Product name: rorec collagen hyaluronic acid white face serum riceNet weight: 15 m",
                Precio = 46,
                DescuentoPorcentaje = 10.68,
                Rating = 4.42,
                Stock = 54,
                Marca = "ROREC White Rice",
                Categoria = "skincare",
                Imagen = "https://i.dummyjson.com/data/products/19/thumbnail.jpg",
                Imagenes = new string[]
                {
                    "https://i.dummyjson.com/data/products/19/1.jpg",
                    "https://i.dummyjson.com/data/products/19/2.jpg",
                    "https://i.dummyjson.com/data/products/19/3.png",
                    "https://i.dummyjson.com/data/products/19/thumbnail.jpg"
                }
            },
            new Producto
            {
                Id = 20,
                Nombre = "Freckle Treatment Cream- 15gm",
                Descripcion = "Fair & Clear is Pakistan's only pure Freckle cream which helpsfade Freckles, Darkspots and pigments. Mercury level is 0%, so there are no side effects.",
                Precio = 70,
                DescuentoPorcentaje = 16.99,
                Rating = 4.06,
                Stock = 140,
                Marca = "Fair & Clear",
                Categoria = "skincare",
                Imagen = "https://i.dummyjson.com/data/products/20/thumbnail.jpg",
                Imagenes = new string[]
                {
                    "https://i.dummyjson.com/data/products/20/1.jpg",
                    "https://i.dummyjson.com/data/products/20/2.jpg",
                    "https://i.dummyjson.com/data/products/20/3.jpg",
                    "https://i.dummyjson.com/data/products/20/4.jpg",
                    "https://i.dummyjson.com/data/products/20/thumbnail.jpg"
                }
            },
            new Producto
            {
                Id = 21,
                Nombre = "- Daal Masoor 500 grams",
                Descripcion = "Fine quality Branded Product Keep in a cool and dry place",
                Precio = 20,
                DescuentoPorcentaje = 4.81,
                Rating = 4.44,
                Stock = 133,
                Marca = "Saaf & Khaas",
                Categoria = "groceries",
                Imagen = "https://i.dummyjson.com/data/products/21/thumbnail.png",
                Imagenes = new string[]
                {
                    "https://i.dummyjson.com/data/products/21/1.png",
                    "https://i.dummyjson.com/data/products/21/2.jpg",
                    "https://i.dummyjson.com/data/products/21/3.jpg"
                }
            },
            new Producto
            {
                Id = 22,
                Nombre = "Elbow Macaroni - 400 gm",
                Descripcion = "Product details of Bake Parlor Big Elbow Macaroni - 400 gm",
                Precio = 14,
                DescuentoPorcentaje = 15.58,
                Rating = 4.57,
                Stock = 146,
                Marca = "Bake Parlor Big",
                Categoria = "groceries",
                Imagen = "https://i.dummyjson.com/data/products/22/thumbnail.jpg",
                Imagenes = new string[]
                {
                    "https://i.dummyjson.com/data/products/22/1.jpg",
                    "https://i.dummyjson.com/data/products/22/2.jpg",
                    "https://i.dummyjson.com/data/products/22/3.jpg"
                }
            },
            new Producto
            {
                Id = 23,
                Nombre = "Orange Essence Food Flavou",
                Descripcion = "Specifications of Orange Essence Food Flavour For Cakes and Baking Food Item",
                Precio = 14,
                DescuentoPorcentaje = 8.04,
                Rating = 4.85,
                Stock = 26,
                Marca = "Baking Food Items",
                Categoria = "groceries",
                Imagen = "https://i.dummyjson.com/data/products/23/thumbnail.jpg",
                Imagenes = new string[]
                {
                    "https://i.dummyjson.com/data/products/23/1.jpg",
                    "https://i.dummyjson.com/data/products/23/2.jpg",
                    "https://i.dummyjson.com/data/products/23/3.jpg",
                    "https://i.dummyjson.com/data/products/23/4.jpg",
                    "https://i.dummyjson.com/data/products/23/thumbnail.jpg"
                }
            },
            new Producto
            {
                Id = 24,
                Nombre = "cereals muesli fruit nuts",
                Descripcion = "original fauji cereal muesli 250gm box pack original fauji cereals muesli fruit nuts flakes breakfast cereal break fast faujicereals cerels cerel foji fouji",
                Precio = 46,
                DescuentoPorcentaje = 16.8,
                Rating = 4.94,
                Stock = 113,
                Marca = "fauji",
                Categoria = "groceries",
                Imagen = "https://i.dummyjson.com/data/products/24/thumbnail.jpg",
                Imagenes = new string[]
                {
                    "https://i.dummyjson.com/data/products/24/1.jpg",
                    "https://i.dummyjson.com/data/products/24/2.jpg",
                    "https://i.dummyjson.com/data/products/24/3.jpg",
                    "https://i.dummyjson.com/data/products/24/4.jpg",
                    "https://i.dummyjson.com/data/products/24/thumbnail.jpg"
                }
            },
            new Producto
            {
                Id = 25,
                Nombre = "Gulab Powder 50 Gram",
                Descripcion = "Dry Rose Flower Powder Gulab Powder 50 Gram • Treats Wounds",
                Precio = 70,
                DescuentoPorcentaje = 13.58,
                Rating = 4.87,
                Stock = 47,
                Marca = "Dry Rose",
                Categoria = "groceries",
                Imagen = "https://i.dummyjson.com/data/products/25/thumbnail.jpg",
                Imagenes = new string[]
                {
                    "https://i.dummyjson.com/data/products/25/1.png",
                    "https://i.dummyjson.com/data/products/25/2.jpg",
                    "https://i.dummyjson.com/data/products/25/3.png",
                    "https://i.dummyjson.com/data/products/25/4.jpg",
                    "https://i.dummyjson.com/data/products/25/thumbnail.jpg"
                }
            },
            new Producto
            {
                Id = 26,
                Nombre = "Plant Hanger For Home",
                Descripcion = "Boho Decor Plant Hanger For Home Wall Decoration Macrame Wall Hanging Shelf",
                Precio = 41,
                DescuentoPorcentaje = 17.86,
                Rating = 4.08,
                Stock = 131,
                Marca = "Boho Decor",
                Categoria = "home-decoration",
                Imagen = "https://i.dummyjson.com/data/products/26/thumbnail.jpg",
                Imagenes = new string[]
                {
                    "https://i.dummyjson.com/data/products/26/1.jpg",
                    "https://i.dummyjson.com/data/products/26/2.jpg",
                    "https://i.dummyjson.com/data/products/26/3.jpg",
                    "https://i.dummyjson.com/data/products/26/4.jpg",
                    "https://i.dummyjson.com/data/products/26/5.jpg",
                    "https://i.dummyjson.com/data/products/26/thumbnail.jpg"
                }
            }, 
            new Producto
            {
                Id = 27,
                Nombre = "Flying Wooden Bird",
                Descripcion = "Package Include 6 Birds with Adhesive Tape Shape: 3D Shaped Wooden Birds Material: Wooden MDF, Laminated 3.5mm",
                Precio = 51,
                DescuentoPorcentaje = 15.58,
                Rating = 4.41,
                Stock = 17,
                Marca = "Flying Wooden",
                Categoria = "home-decoration",
                Imagen = "https://i.dummyjson.com/data/products/27/thumbnail.webp",
                Imagenes = new string[]
                {
                    "https://i.dummyjson.com/data/products/27/1.jpg",
                    "https://i.dummyjson.com/data/products/27/2.jpg",
                    "https://i.dummyjson.com/data/products/27/3.jpg",
                    "https://i.dummyjson.com/data/products/27/4.jpg",
                    "https://i.dummyjson.com/data/products/27/thumbnail.webp"
                }
            },
            new Producto
            {
                Id = 28,
                Nombre = "3D Embellishment Art Lamp",
                Descripcion = "3D led lamp sticker Wall sticker 3d wall art light on/off button  cell operated (included)",
                Precio = 20,
                DescuentoPorcentaje = 16.49,
                Rating = 4.82,
                Stock = 54,
                Marca = "LED Lights",
                Categoria = "home-decoration",
                Imagen = "https://i.dummyjson.com/data/products/28/thumbnail.jpg",
                Imagenes = new string[]
                {
                    "https://i.dummyjson.com/data/products/28/1.jpg",
                    "https://i.dummyjson.com/data/products/28/2.jpg",
                    "https://i.dummyjson.com/data/products/28/3.png",
                    "https://i.dummyjson.com/data/products/28/4.jpg",
                    "https://i.dummyjson.com/data/products/28/thumbnail.jpg"
                }
            },
            new Producto
            {
                Id = 29,
                Nombre = "Handcraft Chinese style",
                Descripcion = "Handcraft Chinese style art luxury palace hotel villa mansion home decor ceramic vase with brass fruit plate",
                Precio = 60,
                DescuentoPorcentaje = 15.34,
                Rating = 4.44,
                Stock = 7,
                Marca = "luxury palace",
                Categoria = "home-decoration",
                Imagen = "https://i.dummyjson.com/data/products/29/thumbnail.webp",
                Imagenes = new string[]
                {
                    "https://i.dummyjson.com/data/products/29/1.jpg",
                    "https://i.dummyjson.com/data/products/29/2.jpg",
                    "https://i.dummyjson.com/data/products/29/3.webp",
                    "https://i.dummyjson.com/data/products/29/4.webp",
                    "https://i.dummyjson.com/data/products/29/thumbnail.webp"
                }
            },
            new Producto
            {
                Id = 30,
                Nombre = "Key Holder",
                Descripcion = "Attractive DesignMetallic materialFour key hooksReliable & DurablePremium Quality",
                Precio = 30,
                DescuentoPorcentaje = 2.92,
                Rating = 4.92,
                Stock = 54,
                Marca = "Golden",
                Categoria = "home-decoration",
                Imagen = "https://i.dummyjson.com/data/products/30/thumbnail.jpg",
                Imagenes = new string[]
                {
                    "https://i.dummyjson.com/data/products/30/1.jpg",
                    "https://i.dummyjson.com/data/products/30/2.jpg",
                    "https://i.dummyjson.com/data/products/30/3.jpg",
                    "https://i.dummyjson.com/data/products/30/thumbnail.jpg"
                }
            }
        };

        [HttpGet ("GetAll", Name = "GetAll")]
        public IEnumerable<Producto> GetAll()
        {
            return Productos;
        }

        // Metodo de busqueda por nombre
        [HttpGet ("search/{nombre}", Name = "GetByName")]
        public IEnumerable<Producto> GetByName(string nombre)
        {
            return Productos.Where(p => p.Nombre.ToLower().Contains(nombre.ToLower()));
        }

        // Metodo para obtener un producto por id
        [HttpGet ("Get/{id}", Name = "GetById")]
        public ActionResult<Producto> GetById(int id)
        {
            // Buscamos el producto por id
            // Si no existe, retornamos un 404
            var producto = Productos.FirstOrDefault(p => p.Id == id);

            if (producto == null)
            {
                return NotFound();
            }

            return producto;
        }
    }
}
