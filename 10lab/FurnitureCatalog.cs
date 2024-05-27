namespace ConsoleApplication1
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json;

    public partial class FurnitureCatalog : IFurnitureCatalog
    {
        protected List<FurnitureItem> Catalog = new List<FurnitureItem>();
        public List<FurnitureItem> catalog { get { return Catalog; } }

        public void AddItem(FurnitureItem item)
        {
            item.SetPrice();
            Catalog.Add(item);
        }

        public void RemoveItem(FurnitureItem item)
        {
            Catalog.Remove(item);
        }

        public void AddItem(FurnitureItem[] items)
        {
            foreach (var item in items)
            {
                item.SetPrice();
                Catalog.Add(item);
            }
        }

        public void RemoveItem(FurnitureItem[] items)
        {
            foreach (var item in items)
            {
                Catalog.Remove(item);
            }
        }

        public void DisplayCatalog()
        {
            foreach (var item in Catalog)
            {
                Console.WriteLine(item);
            }
        }
    }

    public partial class FurnitureCatalog
    {
        public void Sort()
        {
            for (int i = 0; i < Catalog.Count; i++)
            {
                var item = Catalog[i];
                for (int j = i - 1; j >= 0;)
                {
                    if (item.price > Catalog[j].price)
                    {
                        Catalog[j + 1] = Catalog[j];
                        Catalog[j] = item;
                        j--;
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }

        private JsonSerializer jsonSerializer = new JsonSerializer();
        string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

        public void SaveCatalogToJson(string filename)
        {
            string fullPath = Path.Combine(path, filename);
            jsonSerializer.SerializeToFile(this.Catalog, fullPath);
        }

        public void LoadCatalogFromJson(string filename)
        {
            string fullPath = Path.Combine(path, filename);
            Catalog = jsonSerializer.DeserializeFromFile<List<FurnitureItem>>(fullPath);
        }
    }
    public partial class FurnitureCatalog // Задание 1
    {
        public void PrioritySort()
        {
            for (int i = 0; i < Catalog.Count; i++)
            {
                for (int j = i + 1; j < Catalog.Count; j++)
                {
                    int flag_brand = String.Compare(Catalog[i].brand, Catalog[j].brand);
                    int flag_model = String.Compare(Catalog[i].model, Catalog[j].model);
                    if ((flag_brand == -1) || (flag_brand == 0) && (flag_model == -1))
                    {
                        FurnitureItem tmp = Catalog[i];
                        Catalog[i] = Catalog[j];
                        Catalog[j] = tmp;
                    }
                }
            }
        }
    }
}