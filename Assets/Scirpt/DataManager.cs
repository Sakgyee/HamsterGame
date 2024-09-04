using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO; //파일과 데이터 스트림에 읽고 쓸 수 있게 하는 형식
using System; // [System.Serializable] 에 System.를 뺼 수 있음
// 상점 팬케이크,토핑,시럽 해금
[Serializable]
public class Menu
{
    public string name;
    public bool locked;
}
[Serializable]
public class Menus
{
    public List<Menu> menu;
}
[Serializable]
public class Pancake
{
    public string name;
    public bool locked;
}
[Serializable]
public class Pancakes
{
    public List<Pancake> pancakes;
}
[Serializable]
public class Topping
{
    public string name;
    public bool locked;
}
[Serializable]
public class Toppings
{
    public List<Topping> toppings;
}
[Serializable]
public class Syrup
{
    public string name;
    public bool locked;
}
[Serializable]
public class Syrups
{
    public List<Syrup> syrups;
}
//기술 업그레이드
[Serializable]
public class Upgrade
{
    public string name;
    public bool locked;
}
[Serializable]
public class Upgrades
{
    public List<Upgrade> upgrades;
}

[Serializable]
public class Furniture
{
    public string name;
    public bool locked;
}
[Serializable]
public class Furnitures
{
    public List<Furniture> furnitures;
}

[Serializable]
public class Encyclopedia
{
    public string name;
    public bool locked;
}
[Serializable]
public class Encyclopedias
{
    public List<Encyclopedia> encyclopedias;
}

public class DataManager : MonoBehaviour
{
    public static void InitializeUnlockedObjects()
    {
        Menus menuList = ReadUnlockedMenu();
        foreach (var menus in menuList.menu)
        {
            GameObject menuObject = GameObject.Find(menus.name); // Assuming your pancake object has the same name as the pancake in JSON
            if (menuObject != null)
            {
                menuObject.SetActive(menus.locked);
            }
        }
        Pancakes pancakeList = ReadUnlockedPancakes();
        foreach (var panmenu in pancakeList.pancakes)
        {
            GameObject pancakeObject = GameObject.Find(panmenu.name); // Assuming your pancake object has the same name as the pancake in JSON
            if (pancakeObject != null)
            {
                pancakeObject.SetActive(panmenu.locked);
            }
        }
        Toppings toppingList = ReadUnlockedToppings();
        foreach (var tomenu in toppingList.toppings)
        {
            GameObject toppingObject = GameObject.Find(tomenu.name); // Assuming your topping object has the same name as the topping in JSON
            if (toppingObject != null)
            {
                toppingObject.SetActive(tomenu.locked);
            }
        }
        Syrups syrupList = ReadUnlockedSyrups();
        foreach (var symenu in syrupList.syrups)
        {
            GameObject syrupObject = GameObject.Find(symenu.name); // Assuming your syrup object has the same name as the syrup in JSON
            if (syrupObject != null)
            {
                syrupObject.SetActive(symenu.locked);
            }
        }
        Upgrades upgradeList = ReadUnlockedUpgrades();
        foreach (var upmenu in upgradeList.upgrades)
        {
            GameObject upgradeObject = GameObject.Find(upmenu.name); // Assuming your syrup object has the same name as the syrup in JSON
            if (upgradeObject != null)
            {
                upgradeObject.SetActive(upmenu.locked);
            }
        }

        Furnitures furnitureList = ReadUnlockedFurnitures();
        foreach (var fumenu in furnitureList.furnitures)
        {
            GameObject furnitureObject = GameObject.Find(fumenu.name); // Assuming your syrup object has the same name as the syrup in JSON
            if (furnitureObject != null)
            {
                furnitureObject.SetActive(fumenu.locked);
            }
        }
        Encyclopedias encyclopediaList = ReadUnlockedEncyclopedias();
        foreach (var enmenu in encyclopediaList.encyclopedias)
        {
            GameObject encyclopediaObject = GameObject.Find(enmenu.name); // Assuming your furniture object has the same name as the topping in JSON
            if (encyclopediaObject != null)
            {
                Debug.Log("encyclopediaObject의 이름 " + encyclopediaObject);
                encyclopediaObject.SetActive(enmenu.locked);
            }
        }
    }
    public static Menus ReadUnlockedMenu()
    {
        string path = Path.Combine(Application.persistentDataPath, "Menu.json");
        if (File.Exists(path))
        {
            string jsonData = File.ReadAllText(path);
            return JsonUtility.FromJson<Menus>(jsonData);
        }
        else
        {
            TextAsset menuData = Resources.Load("Menu") as TextAsset;
            if (menuData == null)
            {
                Debug.LogError("Menu data not found in Resources");
                return new Menus { menu = new List<Menu>() };
            }
            return JsonUtility.FromJson<Menus>(menuData.text);
        }
    }

    public static Pancakes ReadUnlockedPancakes()
    {
        string path = Path.Combine(Application.persistentDataPath, "Pancakes.json");
        if (File.Exists(path))
        {
            string jsonData = File.ReadAllText(path);
            return JsonUtility.FromJson<Pancakes>(jsonData);
        }
        else
        {
            TextAsset pancakeData = Resources.Load("Pancakes") as TextAsset;
            if (pancakeData == null)
            {
                Debug.LogError("Pancake data not found in Resources");
                return new Pancakes { pancakes = new List<Pancake>() };
            }
            return JsonUtility.FromJson<Pancakes>(pancakeData.text);
        }
    }

    public static Toppings ReadUnlockedToppings()
    {
        string path = Path.Combine(Application.persistentDataPath, "Toppings.json");
        if (File.Exists(path))
        {
            string jsonData = File.ReadAllText(path);
            return JsonUtility.FromJson<Toppings>(jsonData);
        }
        else
        {
            TextAsset toppingData = Resources.Load("Toppings") as TextAsset;
            if (toppingData == null)
            {
                Debug.LogError("Topping data not found in Resources");
                return new Toppings { toppings = new List<Topping>() };
            }
            return JsonUtility.FromJson<Toppings>(toppingData.text);
        }
    }

    public static Syrups ReadUnlockedSyrups()
    {
        string path = Path.Combine(Application.persistentDataPath, "Syrups.json");
        if (File.Exists(path))
        {
            string jsonData = File.ReadAllText(path);
            return JsonUtility.FromJson<Syrups>(jsonData);
        }
        else
        {
            TextAsset syrupData = Resources.Load("Syrups") as TextAsset;
            if (syrupData == null)
            {
                Debug.LogError("Syrup data not found in Resources");
                return new Syrups { syrups = new List<Syrup>() };
            }
            return JsonUtility.FromJson<Syrups>(syrupData.text);
        }
    }

    public static Upgrades ReadUnlockedUpgrades()
    {
        string path = Path.Combine(Application.persistentDataPath, "Upgrade.json");
        if (File.Exists(path))
        {
            string jsonData = File.ReadAllText(path);
            return JsonUtility.FromJson<Upgrades>(jsonData);
        }
        else
        {
            TextAsset upgradeData = Resources.Load("Upgrade") as TextAsset;
            if (upgradeData == null)
            {
                Debug.LogError("Upgrade data not found in Resources");
                return new Upgrades { upgrades = new List<Upgrade>() };
            }
            return JsonUtility.FromJson<Upgrades>(upgradeData.text);
        }
    }

    public static Furnitures ReadUnlockedFurnitures()
    {
        string path = Path.Combine(Application.persistentDataPath, "Furniture.json");
        if (File.Exists(path))
        {
            string jsonData = File.ReadAllText(path);
            return JsonUtility.FromJson<Furnitures>(jsonData);
        }
        else
        {
            TextAsset furnitureData = Resources.Load("Furniture") as TextAsset;
            if (furnitureData == null)
            {
                Debug.LogError("Furniture data not found in Resources");
                return new Furnitures { furnitures = new List<Furniture>() };
            }
            return JsonUtility.FromJson<Furnitures>(furnitureData.text);
        }
    }
    public static Encyclopedias ReadUnlockedEncyclopedias()
    {
        string path = Path.Combine(Application.persistentDataPath + "Encyclopedia.json");
        if (File.Exists(path))
        {
            string jsonData = File.ReadAllText(path);
            return JsonUtility.FromJson<Encyclopedias>(jsonData);
        }
        else
        {
            TextAsset encyclopediaData = Resources.Load("Encyclopedia") as TextAsset;
            if (encyclopediaData == null)
            {
                Debug.LogError("Encyclopedia data not found in Resources");
                return new Encyclopedias { encyclopedias = new List<Encyclopedia>() };
            }
            return JsonUtility.FromJson<Encyclopedias>(encyclopediaData.text);
        }
    }
    //상점에서 구매 했을경우 판매종료
    public static void UnlockStoreMenu(string MenuName)
    {
        Menus menuList = ReadUnlockedMenu();
        foreach (var menus in menuList.menu)
        {
            if (menus.name == MenuName)
            {
                menus.locked = false;

                GameObject menuObject = GameObject.Find(menus.name); // Assuming your pancake object has the same name as the pancake in JSON
                if (menuObject != null)
                {
                    menuObject.SetActive(menus.locked);
                }
                break;
            }
        }
        SaveUnlockedMenu(menuList);
    }
    public static void UnlockPancake(string pancakeName)
    {
        Pancakes pancakeList = ReadUnlockedPancakes();
        foreach (var panmenu in pancakeList.pancakes)
        {
            if (panmenu.name == pancakeName)
            {
                panmenu.locked = false;

                GameObject pancakeObject = GameObject.Find(panmenu.name); // Assuming your pancake object has the same name as the pancake in JSON
                if (pancakeObject != null)
                {
                    pancakeObject.SetActive(panmenu.locked);
                }
                break;
            }
        }
        SaveUnlockedPancakes(pancakeList);
    }
    public static void UnlockTopping(string toppingName)
    {
        Toppings toppingList = ReadUnlockedToppings();
        foreach (var tomenu in toppingList.toppings)
        {
            if (tomenu.name == toppingName)
            {
                tomenu.locked = false;

                GameObject toppingObject = GameObject.Find(tomenu.name); // Assuming your topping object has the same name as the topping in JSON
                if (toppingObject != null)
                {
                    toppingObject.SetActive(tomenu.locked);
                }
                break;
            }

        }
        SaveUnlockedToppings(toppingList);
    }

    public static void UnlockSyrup(string syrupName)
    {
        Syrups syrupList = ReadUnlockedSyrups();
        foreach (var symenu in syrupList.syrups)
        {
            if (symenu.name == syrupName)
            {
                symenu.locked = false;

                GameObject syrupObject = GameObject.Find(symenu.name); 
                if (syrupObject != null)
                {
                    syrupObject.SetActive(symenu.locked);
                }
                break;
            }
        }
        SaveUnlockedSyrups(syrupList);
    }
    public static void UnlockUpgrade(string upgradeName)
    {
        Upgrades upgradeList = ReadUnlockedUpgrades();
        foreach (var upmenu in upgradeList.upgrades)
        {
            if (upmenu.name == upgradeName)
            {
                upmenu.locked = false;

                GameObject upgradeObject = GameObject.Find(upmenu.name); 
                if (upgradeObject != null)
                {
                    upgradeObject.SetActive(upmenu.locked);
                }
                break;
            }
        }
        SaveUnlockedUpgrades(upgradeList);
    }

    public static void UnlockFurniture(string furnitureName)
    {
        Furnitures furnitureList = ReadUnlockedFurnitures();
        foreach (var fumenu in furnitureList.furnitures)
        {
            if (fumenu.name == furnitureName)
            {
                fumenu.locked = true;

                GameObject furnitureObject = GameObject.Find(fumenu.name); 
                if (furnitureObject != null)
                {
                    furnitureObject.SetActive(fumenu.locked);
                }
                break;
            }
        }
        SaveUnlockedFurnitures(furnitureList);
    }

    public static void UnlockEncyclopedia(string encyclopediaName)
    {
        Encyclopedias encyclopediaList = ReadUnlockedEncyclopedias();
        foreach (var enmenu in encyclopediaList.encyclopedias)
        {
            if (enmenu.name == encyclopediaName)
            {
                enmenu.locked = false;
                GameObject encyclopediaObject = GameObject.Find(enmenu.name); 
                if (encyclopediaObject != null)
                {
                    encyclopediaObject.SetActive(enmenu.locked);
                }
                break;
            }
        }
        SaveUnlockedEncyclopedias(encyclopediaList);
    }
    private static void SaveUnlockedMenu(Menus menuList)
    {
        string jsonData = JsonUtility.ToJson(menuList, true);
        string path = Path.Combine(Application.persistentDataPath, "Menu.json");
        File.WriteAllText(path, jsonData);
    }

    private static void SaveUnlockedPancakes(Pancakes pancakeList)
    {
        string jsonData = JsonUtility.ToJson(pancakeList, true);
        string path = Path.Combine(Application.persistentDataPath, "Pancakes.json");
        File.WriteAllText(path, jsonData);
    }

    private static void SaveUnlockedToppings(Toppings toppingList)
    {
        string jsonData = JsonUtility.ToJson(toppingList, true);
        string path = Path.Combine(Application.persistentDataPath, "Toppings.json");
        File.WriteAllText(path, jsonData);
    }

    private static void SaveUnlockedSyrups(Syrups syrupList)
    {
        string jsonData = JsonUtility.ToJson(syrupList, true);
        string path = Path.Combine(Application.persistentDataPath, "Syrups.json");
        File.WriteAllText(path, jsonData);
    }

    private static void SaveUnlockedUpgrades(Upgrades upgradeList)
    {
        string jsonData = JsonUtility.ToJson(upgradeList, true);
        string path = Path.Combine(Application.persistentDataPath, "Upgrade.json");
        File.WriteAllText(path, jsonData);
    }

    private static void SaveUnlockedFurnitures(Furnitures furnitureList)
    {
        string jsonData = JsonUtility.ToJson(furnitureList, true);
        string path = Path.Combine(Application.persistentDataPath, "Furniture.json");
        File.WriteAllText(path, jsonData);
    }
    private static void SaveUnlockedEncyclopedias(Encyclopedias encyclopediaList)
    {
        string jsonData = JsonUtility.ToJson(encyclopediaList, true);
        string path = Path.Combine(Application.persistentDataPath + "Encyclopedia.json");
        File.WriteAllText(path, jsonData);
    }
}