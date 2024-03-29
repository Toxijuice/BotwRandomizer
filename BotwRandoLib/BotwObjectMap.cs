using System;
using System.Collections.Generic;

namespace BotwRandoLib {
    internal class BotwObjectMap {

        // Input item, output possible items it can randomize into
        public Dictionary<string, List<string>> map;

        private BotwObjects oLists;
        private Random random;

        public BotwObjectMap(Random random, BotwObjects oLists, Dictionary<string, int> randomizationIntSettings) {
            map = new Dictionary<string, List<string>>();

            this.oLists = oLists;
            this.random = random;

            GenerateWeaponMap(randomizationIntSettings["weaponVarietyInput"]);
            GenerateEnemyMap(randomizationIntSettings["enemyVarietyInput"]);
            GenerateMannequinMap();
            GenerateSmallAnimalMap(randomizationIntSettings["smallAnimalVarietyInput"]);
            GenerateAnimalMap(randomizationIntSettings["animalVarietyInput"]);
            GenerateMeatMap(4);
            GeneratePlantMap(randomizationIntSettings["plantVarietyInput"]);
            GenerateMaterialMap(randomizationIntSettings["materialVarietyInput"]);
        }

        public void AddItemToMap(string input, string output) {
            if (!map.ContainsKey(input)) {
                map.Add(input, new List<string>());
            }

            if (!map[input].Contains(output)) {
                map[input].Add(output);
            }
        }

        public string GetItemFromMap(string input) {
            if(map.ContainsKey(input)) return map[input][random.Next(map[input].Count)];

            return null;
        }

        private void AddPoolOfItemsToMap(List<string>[] itemLists) {
            // Declare lists
            List<string> items = new List<string>();
            List<string> inputs = new List<string>();
            List<string> outputs = new List<string>();

            // Get all items from pool lists into single list
            for (int i = 0; i < itemLists.Length; i++) {
                for (int j = 0; j < itemLists[i].Count; j++) {
                    items.Add(itemLists[i][j]);
                }
            }

            // Copy item list to inputs
            for (int i = 0; i < items.Count; i++) {
                inputs.Add(items[i]);
            }

            // Move items at random from item list to output list
            int rndIndex = 0;
            while (items.Count > 0) {
                rndIndex = random.Next(items.Count);
                Console.WriteLine("Adding to outputs: " + items[rndIndex]);
                outputs.Add(items[rndIndex]);
                items.RemoveAt(rndIndex);

            }

            // Map inputs to outputs
            for (int i = 0; i < inputs.Count; i++) {
                AddItemToMap(inputs[i], outputs[i]);
            }
        }

        private void GenerateWeaponMap(int amount = 1) {
            Console.WriteLine("Generating Weapon List");
            List<string>[] itemLists = {
                oLists.swordList,
                oLists.lSwordList,
                oLists.spearList,
                oLists.shieldList,
                oLists.bowList,
                oLists.singleArrowList,
                oLists.arrowBundle1List,
                oLists.arrowBundle2List
            };

            for(int i = 0; i < amount; i++) AddPoolOfItemsToMap(itemLists);
        }

        private void GenerateEnemyMap(int amount = 1) {
            Console.WriteLine("Generating Enemy List");
            List<string>[] itemLists = {
                oLists.enemyList,
                oLists.keeseList,
                oLists.keeseAllDayList,
                oLists.chuchulist,
                oLists.littleGolemsList,
                oLists.subBossList,
                oLists.lynelList,
                oLists.enemyGuardList,
                oLists.enemyGuardAmbushList,
                oLists.enemyTreehouseGuardList,
                oLists.wizzrobeList,
                oLists.sandwormList,
                oLists.staticGuardianList,
                oLists.movingGuardianList,
                oLists.miniGuardianList,
                oLists.octorokList
            };

            for(int i = 0; i < amount; i++) AddPoolOfItemsToMap(itemLists);
        }

        private void GenerateMannequinMap(int amount = 1) {
            Console.WriteLine("Generating Mannequin List");
            List<string>[] itemLists = {
                oLists.mannequinList
            };

            for(int i = 0; i < amount; i++) AddPoolOfItemsToMap(itemLists);
        }

        private void GenerateSmallAnimalMap(int amount = 1) {
            Console.WriteLine("Generating SmallAnimal List");
            List<string>[] itemLists = {
                oLists.insectList,
                oLists.frogList,
                oLists.fishList
            };

            for(int i = 0; i < amount; i++) AddPoolOfItemsToMap(itemLists);
        }

        private void GenerateAnimalMap(int amount = 1) {
            Console.WriteLine("Generating Animal List");
            List<string>[] itemLists = {
                oLists.AnimalList
            };

            for(int i = 0; i < amount; i++) AddPoolOfItemsToMap(itemLists);
        }

        private void GenerateMeatMap(int amount = 1) {
            Console.WriteLine("Generating Meat List");
            List<string>[] itemLists = {
                oLists.meatList
            };

            for(int i = 0; i < amount; i++) AddPoolOfItemsToMap(itemLists);
        }

        private void GeneratePlantMap(int amount = 1) {
            Console.WriteLine("Generating Plant List");
            List<string>[] itemLists = {
                oLists.plantList,
            };

            for(int i = 0; i < amount; i++) AddPoolOfItemsToMap(itemLists);
        }

        private void GenerateMaterialMap(int amount = 1) {
            Console.WriteLine("Generating Plant List");
            List<string>[] itemLists = {
                oLists.materialList,
                oLists.mushroomList,
                oLists.fruitList,
                oLists.oreList,
                oLists.rupeeList,
                oLists.mineralList
            };

            for(int i = 0; i < amount; i++) AddPoolOfItemsToMap(itemLists);
        }

    }
}