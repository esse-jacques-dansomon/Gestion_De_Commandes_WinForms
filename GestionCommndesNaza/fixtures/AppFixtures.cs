using GestionCommndesNaza.models;
using GestionCommndesNaza.utils;
using PasswordHashing;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace GestionCommndesNaza.fixtures
{
    public class AppFixtures
    {

        string passwordHash = PasswordHasher.Hash("passer@1234");

        public string PasswordHash { get => passwordHash; set => passwordHash = value; }

        public AppFixtures()
        {

        }

        //User Fixtures
        //Deliver Fixtures
        public static void MakeFixtures()
        {
            Model1Container manager = new Model1Container();
            List<string> roles = new List<String>();
            List<User> users = new List<User>();
            roles.Add("ROLE_ADMIN");
            roles.Add("ROLE_MANAGER");
            roles.Add("ROLE_COMPTABLE");
            roles.Add("ROLE_SECRETAIRE");
            //User Fixtures
            foreach (String role in roles)
            {
                User user = new User
                {
                    Role = role,
                    Firstname = Faker.Name.First(),
                    Lastname = Faker.Name.Last(),
                    Login = role.Replace("ROLE_", "").ToLower() + "@gmail.com",
                    Password = PasswordHasher.Hash("passer@123"),
                    CreatedAt = DateTime.Now,
                };
                Console.WriteLine(user.Lastname);
                users.Add(user);
            }
            manager.Users.AddRange(users);
            manager.SaveChanges();

            List<Deliver> delivers = new List<Deliver>();

            for (int i = 1; i < 15; i++)
            {
                Deliver user = new Deliver
                {
                    Role = "ROLE_DELIVER",
                    Firstname = Faker.Name.First(),
                    Lastname = Faker.Name.Last(),
                    Login = "deviler" + i + "@gmail.com",
                    Password = PasswordHasher.Hash("passer@123"),
                    Phone = Faker.Phone.Number(),
                    CreatedAt = DateTime.Now,
                    Matricule = Faker.Identification.UkPassportNumber(),
                };
                Console.WriteLine(user.Lastname);
                delivers.Add(user);
            }
            manager.Users.AddRange(delivers);
            manager.SaveChanges();
        }


        //Categories Fixtures
        //Product Fixtures
        //Images Fixtures
        public static void MakeStoreFixture()
        {
            Model1Container manager = new Model1Container();
            string defaultImage = @"C:\Users\essed\OneDrive\Bureau\PROJETS_A_RENDRE\CSharpL3\code\GestionCommndesNaza\ressouces\img\defaut-product.jpg";
            byte[] image = ImageUtils.convertImageToByte(defaultImage);

            string[] categories =
                { "BATEAUX", "FUSEE", "AVIONS", "BOAT AIR FORCE ONE",
                    "METEORITE", "PLANET 500", "MACHINES TP05" };

            //CATEGORIES FIXTURES
            foreach (string cat in categories)
            {
                Category category = new Category()
                {
                    Libelle = cat,
                    Description = Faker.Lorem.Paragraph(2),
                    Image = image,
                };
                manager.Categories.Add(category);
            }
            manager.SaveChanges();

            //PRODUCT FIXTURES (20 products/cat)
            DbSet<Category> cats = manager.Categories;
            foreach (var cat in cats)
            {
                for (int i = 0; i < 21; i++)
                {
                    Product product = new Product()
                    {
                        Libelle = Faker.Company.Name(),
                        Price = Faker.RandomNumber.Next(10000, 150000),
                        Stock = Faker.RandomNumber.Next(10, 100),
                        QuantitySeuil = Faker.RandomNumber.Next(3, 10),
                        Description = Faker.Lorem.Paragraph(6),
                    };

                    product.Category = cat;
                    manager.Products.Add(product);
                }
            }
            manager.SaveChanges();

            //FIxtures Images
            DbSet<Product> products = manager.Products;
            List<Picture> pictures = new List<Picture>();
            foreach (Product product1 in products.Take(5))
            {
                List<byte[]> images = new List<byte[]> {
                   ImageUtils.convertImageToByte( "C:\\Users\\essed\\OneDrive\\Bureau\\PROJETS_A_RENDRE\\CSharpL3\\code\\GestionCommndesNaza\\ressouces\\img\\defaut-product.jpg"),
                   ImageUtils.convertImageToByte( "C:\\Users\\essed\\OneDrive\\Bureau\\PROJETS_A_RENDRE\\CSharpL3\\code\\GestionCommndesNaza\\ressouces\\img\\beautiful-african-woman-with-big-curly-afro-and-flowers-in-her-hair.jpg"),
                   ImageUtils.convertImageToByte( "C:\\Users\\essed\\OneDrive\\Bureau\\PROJETS_A_RENDRE\\CSharpL3\\code\\GestionCommndesNaza\\ressouces\\img\\cropped-tous-les-verts-test-banniere-5.png"),
                   ImageUtils.convertImageToByte( "C:\\Users\\essed\\OneDrive\\Bureau\\PROJETS_A_RENDRE\\CSharpL3\\code\\GestionCommndesNaza\\ressouces\\img\\femmmmme-300x194.png"),
                   ImageUtils.convertImageToByte( "C:\\Users\\essed\\OneDrive\\Bureau\\PROJETS_A_RENDRE\\CSharpL3\\code\\GestionCommndesNaza\\ressouces\\img\\portrait-of-beautiful-black-woman-doing-her-skin-care-routine.jpg"),
                   ImageUtils.convertImageToByte( "C:\\Users\\essed\\OneDrive\\Bureau\\PROJETS_A_RENDRE\\CSharpL3\\code\\GestionCommndesNaza\\ressouces\\img\\___n.jpg"),
                   ImageUtils.convertImageToByte( "C:\\Users\\essed\\OneDrive\\Bureau\\PROJETS_A_RENDRE\\CSharpL3\\code\\GestionCommndesNaza\\ressouces\\img\\portrait-of-beautiful-black-woman-with-mysterious-shadows.jpg"),
                   ImageUtils.convertImageToByte( "C:\\Users\\essed\\OneDrive\\Documents\\NOISY\\GobalPorteties\\Ressources\\IMG_1056.png"),
                };
                for (int q = 0; q < 3; q++)
                {
                    byte[] nmImge = images[Faker.RandomNumber.Next(0, 7)];

                    Picture picture = new Picture()
                    {
                        Image = nmImge,
                        Product = product1,
                        ProductId = product1.Id,
                    };
                    pictures.Add(picture);
                }
            }
            manager.Pictures.AddRange(pictures);
            manager.SaveChanges();

        }


        //Client Fixtures
        //Adresse Fixtures

        public static void MakeClientsFixture()
        {
            Model1Container manager = new Model1Container();
            List<Client> clients = new List<Client>();
            List<Address> addresses = new List<Address>();

            for (int i = 1; i < 20; i++)
            {
                Client user = new Client
                {
                    Role = "ROLE_CLIENT",
                    Firstname = Faker.Name.First(),
                    Lastname = Faker.Name.Last(),
                    Login = "client" + i + "@gmail.com",
                    Password = PasswordHasher.Hash("passer@1234"),
                    Phone = Faker.Phone.Number(),
                    CreatedAt = DateTime.Now,
                    Solde = 0,
                };

                //Creation d'adresse
                for (int k = 0; k < 2; k++)
                {
                    Address address = new Address
                    {
                        City = Faker.Address.City(),
                        Country = Faker.Country.Name(),
                        Zone = Faker.Address.StreetAddress(),
                        PostCode = Faker.Address.ZipCode(),
                        Client = user,
                        ClientId = user.Id,
                    };
                    addresses.Add(address);
                }
                clients.Add(user);

            }

            manager.Users.AddRange(clients);
            manager.Addresses.AddRange(addresses);
            manager.SaveChanges();
        }

        public static void seeder()
        {
            AppFixtures.MakeFixtures();
            AppFixtures.MakeStoreFixture();
            AppFixtures.MakeClientsFixture();
        }
    }

}
