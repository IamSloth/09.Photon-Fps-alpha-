using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class MenuManger : MonoBehaviour
{
    public static MenuManger Instance;
    [SerializeField] Menu[] menus;

    void Awake()
    {
        Instance = this;
    }

    public void OpenMenu(string menuName)
    {
        Debug.Log("hi" + menus.Length);
        for (int i = 0; i < menus.Length; i++)
        {
            
            if (menus[i].menuName == menuName)
            {
                
                menus[i].Open();
            }
            else if (menus[i].open)
            {
                CloseMenu(menus[i]);
            }
        }
    }

    public void OpenMenu(Menu menu)
    {
        for (int i = 0; i < menus.Length; i++)
        {
            if (menus[i].open)
            {
                CloseMenu(menus[i]);
            }
        }
        menu.Open();
    }
    
    public void CloseMenu(Menu menu)
    {
        menu.Close();
    }
}
