using System;
using System.Collections;
using System.Deployment.Internal;
using TheSlum.Characters;
using TheSlum.Items;

namespace TheSlum.GameEngine
{
    public class CustomGameEngine: Engine
    {
        protected override void CreateCharacter(string[] inputParams)
        {
            this.characterList.Add(GetCharacter(inputParams[1], inputParams[2], int.Parse(inputParams[3]), int.Parse(inputParams[4]), inputParams[5]));
        }

        protected override void ExecuteCommand(string[] inputParams)
        {
            switch (inputParams[0])
            {
                case "status":
                    this.PrintCharactersStatus(this.characterList);
                    break;
                case "create":
                    this.CreateCharacter(inputParams);
                    break;
                case "add":
                    this.AddItem(inputParams);
                    break;
            }
        }

        private new void AddItem(string[] inputParams)
        {
            this.GetCharacterById(inputParams[1]).AddToInventory(CreateItem(inputParams[2], inputParams[3]));
        }

        private Item CreateItem(string type, string name)
        {
            switch (type)
            {
                case "axe":
                    return new Axe(name);
                case "pill":
                    return new Pill(name);
                case "injection": 
                    return new Injection(name);
                case "shield":
                    return new Shield(name);
                default:
                    throw new InvalidOperationException("Item does not exist!");
            }
        }

        private Character GetCharacter(string type, string name, int x, int y, string team)
        {
            switch (type)
            {
                case "mage":
                    return new Mage(name, x, y, 150, 50, 300, GetTeam(team), 5);
                case "warrior":
                    return new Warrior(name, x, y, 200, 100, 150, GetTeam(team), 5);
                case "healer":
                    return new Healer(name, x, y, 75, 50, 60, GetTeam(team), 5);
                default:
                    throw new InvalidOperationException("Character not found in the game!");
            }
        }

        private Team GetTeam(string name)
        {
            return (Team)Enum.Parse(typeof(Team), name);
        }
        
    }
}
