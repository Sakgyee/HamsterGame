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

public class DataManager : MonoBehaviour
{
    private static string menuFilePath = "Assets/Resources/Menu.json";

    private static string pancakesFilePath = "Assets/Resources/Pancakes.json";
    private static string toppingsFilePath = "Assets/Resources/Toppings.json";
    private static string syrupsFilePath = "Assets/Resources/Syrups.json";

    private static string upgradeFilePath = "Assets/Resources/Upgrade.json";
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
    }
    public static Menus ReadUnlockedMenu()
    {
        string json = File.ReadAllText(menuFilePath);
        return JsonUtility.FromJson<Menus>(json);
    }
    public static Pancakes ReadUnlockedPancakes()
    {
        string json = File.ReadAllText(pancakesFilePath);
        return JsonUtility.FromJson<Pancakes>(json);
    }
    public static Toppings ReadUnlockedToppings()
    {
        string json = File.ReadAllText(toppingsFilePath);
        return JsonUtility.FromJson<Toppings>(json);
    }
    public static Syrups ReadUnlockedSyrups()
    {
        string json = File.ReadAllText(syrupsFilePath);
        return JsonUtility.FromJson<Syrups>(json);
    }
    public static Upgrades ReadUnlockedUpgrades()
    {
        string json = File.ReadAllText(upgradeFilePath);
        return JsonUtility.FromJson<Upgrades>(json);
    }
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
        string json = JsonUtility.ToJson(menuList);
        File.WriteAllText(menuFilePath, json);
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
        string json = JsonUtility.ToJson(pancakeList);
        File.WriteAllText(pancakesFilePath, json);
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
        string json = JsonUtility.ToJson(toppingList);
        File.WriteAllText(toppingsFilePath, json);
    }

    public static void UnlockSyrup(string syrupName)
    {
        Syrups syrupList = ReadUnlockedSyrups();
        foreach (var symenu in syrupList.syrups)
        {
            if (symenu.name == syrupName)
            {
                symenu.locked = false;

                GameObject syrupObject = GameObject.Find(symenu.name); // Assuming your topping object has the same name as the topping in JSON
                if (syrupObject != null)
                {
                    syrupObject.SetActive(symenu.locked);
                }
                break;
            }
        }
        string json = JsonUtility.ToJson(syrupList);
        File.WriteAllText(syrupsFilePath, json);
    }
    public static void UnlockUpgrade(string upgradeName)
    {
        Upgrades upgradeList = ReadUnlockedUpgrades();
        foreach (var upmenu in upgradeList.upgrades)
        {
            if (upmenu.name == upgradeName)
            {
                upmenu.locked = false;

                GameObject upgradeObject = GameObject.Find(upmenu.name); // Assuming your topping object has the same name as the topping in JSON
                if (upgradeObject != null)
                {
                    upgradeObject.SetActive(upmenu.locked);
                }
                break;
            }
        }
        string json = JsonUtility.ToJson(upgradeList);
        File.WriteAllText(upgradeFilePath, json);
    }
}