﻿using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OrangeHRMTests;
using System;
using System.ComponentModel;

namespace OrangeHRM.Pages
{
    public class Menu : AbstractPage<Menu_Selectors>
    {
        public Menu(Pages p) 
            : base(p, new Menu_Selectors()) {}

        public void SelectItem(string item)
        {
            pages.Click(Selectors.FirstLevelMenu(item));
        }

        public void MouseOverItem(string item)
        {
            pages.MouseOver(Selectors.FirstLevelMenu(item));
        }

        public void ExpandMenuTreeAndSeectItem(params string[] itemNames)
        {
            int levelsAmount = itemNames.Length;

            switch (levelsAmount)
            {
                case 1:
                    FindFirstLevelItem(itemNames[0]);
                    break;

                case 2:
                    FindSecondLevelItem(itemNames[0], itemNames[1]);
                    break;

                case 3:
                    FindThirdLevelItem(itemNames[0], itemNames[1], itemNames[2]);
                    break;

                default:
                    throw new Exception($"Invalid level {levelsAmount}");
            }
        }

        private void FindFirstLevelItem(string item)
        {
            pages.Click(Selectors.FirstLevelMenu(item));
        }

        private void FindSecondLevelItem(params string[] itemNames)
        {
            pages.MouseOver(Selectors.FirstLevelMenu(itemNames[0]));
            pages.Click(Selectors.SecondLevelMenu(itemNames[1]));
        }

        private void FindThirdLevelItem(params string[] itemNames)
        {
            pages.MouseOver(Selectors.FirstLevelMenu(itemNames[0]));
            pages.MouseOver(Selectors.SecondLevelMenu(itemNames[1]));
            pages.Click(Selectors.ThirdLevelMenu(itemNames[2]));
        }
    }

    public class Menu_Selectors
    {
        public By FirstLevelMenu(string item) => By.XPath($"//*[@class='firstLevelMenu']/b[text()='{item}']");
        public By SecondLevelMenu(string item) => By.XPath($"//a[text()='{item}']");
        public By ThirdLevelMenu(string item) => By.XPath($"//a[text()='{item}']");
    }

    public enum FirstLevelMenu
    {
        [Description("Admin")]
        Admin,
        [Description("PIM")]
        PIM,
        [Description("Leave")]
        Leave,
        [Description("Time")]
        Time,
        [Description("Recruitment")]
        Recruitment,
        [Description("Performance")]
        Performance,
        [Description("Dashboard")]
        Dashboard,
        [Description("Directory")]
        Directory,
        [Description("Maintenance")]
        Maintenance,
    }

    public enum MenuLevel
    {
        First,
        Second,
        Third
    }
}
