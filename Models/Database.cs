namespace FinalProject.Models
{
    public class Database
    {
        private static Database _instance { get; } = new();

        public static Database GetInstance()
        {
            return _instance;
        }
        public List<Laptop> Laptops { get; set; } = new();

        public List<Brand> Brands { get; set; } = new();

        private Database()
        {
            InitializeData();
        }
        private void InitializeData()
        {
            #region Brands

            Brand Dell = new Brand(1, "Dell");
            Brand HP = new Brand(2, "HP");
            Brand Lenovo = new Brand(3, "Lenovo");
            Brand Asus = new Brand(4, "Asus");
            Brand Acer = new Brand(5, "Acer");
            Brand Microsoft = new Brand(6, "Microsoft");
            Brand Razer = new Brand(7, "Razer");
            Brand Apple = new Brand(8, "Apple");
            Brand LG = new Brand(9, "LG");
            Brand Samsung = new Brand(10, "Samsung");

            Brands.Add(Dell);
            Brands.Add(HP);
            Brands.Add(Lenovo);
            Brands.Add(Asus);
            Brands.Add(Acer);
            Brands.Add(Microsoft);
            Brands.Add(Razer);
            Brands.Add(Apple);
            Brands.Add(LG);
            Brands.Add(Samsung);


            #endregion Brands

            #region Laptops

            Laptop DellXPS = new Laptop(1, "XPS 15", Dell, 1499, 2020);
            Laptop DellInspiron = new Laptop(2, "Inspiron 15", Dell, 799, 2019);
            Laptop DellLatitude = new Laptop(3, "Latitude 7410", Dell, 2199, 2021);

            Laptop HPEnvy = new Laptop(4, "Envy x360", HP, 1099, 2020);
            Laptop HPElitebook = new Laptop(5, "Elitebook 840 G5", HP, 1499, 2019);
            Laptop HPProbook = new Laptop(6, "Probook 650 G4", HP, 899, 2021);

            Laptop LenovoThinkpad = new Laptop(7, "Thinkpad X1 Carbon", Lenovo, 1599, 2020);
            Laptop LenovoIdeapad = new Laptop(8, "Ideapad L340", Lenovo, 699, 2019);
            Laptop LenovoYoga = new Laptop(9, "Yoga C940", Lenovo, 1299, 2021);

            Laptop AsusZenbook = new Laptop(10, "Zenbook UX425", Asus, 1199, 2020);
            Laptop AsusROG = new Laptop(11, "ROG Zephyrus G14", Asus, 1999, 2019);
            Laptop AsusVivoBook = new Laptop(12, "VivoBook S15", Asus, 799, 2021);

            Laptop AcerSwift = new Laptop(13, "Swift 3", Acer, 999, 2020);
            Laptop AcerAspire = new Laptop(14, "Aspire 5", Acer, 699, 2019);
            Laptop AcerChromebook = new Laptop(15, "Chromebook Spin 311", Acer, 399, 2021);

            Laptop MicrosoftSurface = new Laptop(16, "Surface Laptop 4", Microsoft, 1499, 2020);
            Laptop MicrosoftSurfaceBook = new Laptop(17, "Surface Book 3", Microsoft, 1999, 2019);
            Laptop MicrosoftSurfacePro = new Laptop(18, "Surface Pro 7", Microsoft, 899, 2021);

            Laptop RazerBlade = new Laptop(19, "Blade Pro 17", Razer, 1999, 2020);
            Laptop RazerStealth = new Laptop(20, "Stealth 13", Razer, 1299, 2019);
            Laptop RazerBladeStudio = new Laptop(21, "Blade Studio", Razer, 1999, 2021);

            Laptop AppleMacBookPro = new Laptop(22, "MacBook Pro 16", Apple, 1999, 2020);
            Laptop AppleMacBookAir = new Laptop(23, "MacBook Air", Apple, 1299, 2019);
            Laptop AppleMacBook = new Laptop(24, "MacBook", Apple, 1099, 2021);

            Laptop LGGram = new Laptop(25, "gram 17", LG, 1499, 2020);
            Laptop LGSpectre = new Laptop(26, "Spectre x360", LG, 1299, 2019);
            Laptop LGUltra = new Laptop(27, "Ultra 15", LG, 999, 2021);

            Laptop SamsungNotebook = new Laptop(28, "Notebook 9 Pro", Samsung, 1499, 2020);

            Laptops.Add(DellXPS);
            Laptops.Add(DellInspiron);
            Laptops.Add(DellLatitude);

            Laptops.Add(HPEnvy);
            Laptops.Add(HPElitebook);
            Laptops.Add(HPProbook);

            Laptops.Add(LenovoThinkpad);
            Laptops.Add(LenovoIdeapad);
            Laptops.Add(LenovoYoga);

            Laptops.Add(AsusZenbook);
            Laptops.Add(AsusROG);
            Laptops.Add(AsusVivoBook);

            Laptops.Add(AcerSwift);
            Laptops.Add(AcerAspire);
            Laptops.Add(AcerChromebook);
            Laptops.Add(MicrosoftSurface);
            Laptops.Add(MicrosoftSurfaceBook);
            Laptops.Add(MicrosoftSurfacePro);
            Laptops.Add(RazerBlade);
            Laptops.Add(RazerStealth);
            Laptops.Add(RazerBladeStudio);
            Laptops.Add(AppleMacBookPro);
            Laptops.Add(AppleMacBookAir);
            Laptops.Add(AppleMacBook);
            Laptops.Add(LGGram);
            Laptops.Add(LGSpectre);
            Laptops.Add(LGUltra);
            Laptops.Add(SamsungNotebook);

            #endregion Laptops


        }
    }
}
