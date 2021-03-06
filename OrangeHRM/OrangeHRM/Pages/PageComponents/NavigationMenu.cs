﻿using Allure.NUnit.Attributes;
using OpenQA.Selenium;
using OrangeHRM.FrameworkComponents;
using System;
using System.ComponentModel;

namespace OrangeHRM.Pages.PageComponents
{
    public class NavigationMenu : AbstractPage<Menu_Selectors>
    {
        public NavigationMenu(AppManager p) 
            : base(p, new Menu_Selectors()) {}

        public void SelectItem(string item)
        {
            appManager.UIInteraction.Click(Selectors.FirstLevelMenu(item));
        }

        public void MouseOverItem(string item)
        {
            appManager.UIInteraction.MouseOver(Selectors.FirstLevelMenu(item));
        }

        [AllureStep]
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
            appManager.UIInteraction.Click(Selectors.FirstLevelMenu(item));
        }

        private void FindSecondLevelItem(params string[] itemNames)
        {
            appManager.UIInteraction.MouseOver(Selectors.FirstLevelMenu(itemNames[0]));
            appManager.UIInteraction.Click(Selectors.SecondLevelMenu(itemNames[1]));
        }

        private void FindThirdLevelItem(params string[] itemNames)
        {
            appManager.UIInteraction.MouseOver(Selectors.FirstLevelMenu(itemNames[0]));
            appManager.UIInteraction.MouseOver(Selectors.SecondLevelMenu(itemNames[1]));
            appManager.UIInteraction.Click(Selectors.ThirdLevelMenu(itemNames[2]));
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
}
