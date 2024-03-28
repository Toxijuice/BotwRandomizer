﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace BotwRandoLib
{
    internal class BotwRandoTable
    {
        private Dictionary<KeyValuePair<string, string>, int> ChestDropTable = new Dictionary<KeyValuePair<string, string>, int>();
        public List<KeyValuePair<string, string>> ChestItems = new List<KeyValuePair<string, string>>();

        public BotwRandoTable(int chestsCount)
        {
            ChestDropTable.Add(new KeyValuePair<string, string>("Obj_DungeonClearSeal", "Spirit Orb"), 200);

            ChestDropTable.Add(new KeyValuePair<string, string>("Obj_KorokNuts", "Korok Seed"), 100);

            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Bow_071", "Bow of Light"), 1);

            ChestDropTable.Add(new KeyValuePair<string, string>("PutRupee", "Green Rupee"), 10);
            ChestDropTable.Add(new KeyValuePair<string, string>("PutRupee_Blue", "Blue Rupee"), 8);
            ChestDropTable.Add(new KeyValuePair<string, string>("PutRupee_Red", "Red Rupee"), 6);
            ChestDropTable.Add(new KeyValuePair<string, string>("PutRupee_Purple", "Purple Rupee"), 5);
            ChestDropTable.Add(new KeyValuePair<string, string>("PutRupee_Silver", "Silver Rupee"), 3);
            ChestDropTable.Add(new KeyValuePair<string, string>("PutRupee_Gold", "Gold Rupee"), 3);

            ChestDropTable.Add(new KeyValuePair<string, string>("Obj_HeartUtuwa_A_01", "Heart Container"), 2);
            ChestDropTable.Add(new KeyValuePair<string, string>("Obj_StaminaUtuwa_A_01", "Stamina Vessel"), 10);

            ChestDropTable.Add(new KeyValuePair<string, string>("Obj_HeroSoul_Rito", "Revali's Gale"), 1);
            ChestDropTable.Add(new KeyValuePair<string, string>("Obj_HeroSoul_Gerudo", "Urbosa's Fury"), 1);
            ChestDropTable.Add(new KeyValuePair<string, string>("Obj_HeroSoul_Zora", "Mipha's Grace"), 1);
            ChestDropTable.Add(new KeyValuePair<string, string>("Obj_HeroSoul_Goron", "Daruk's Protection"), 1);

            ChestDropTable.Add(new KeyValuePair<string, string>("Armor_001_Head", ""), 1);
            ChestDropTable.Add(new KeyValuePair<string, string>("Armor_005_Head", ""), 1);
            ChestDropTable.Add(new KeyValuePair<string, string>("Armor_006_Head", ""), 1);
            ChestDropTable.Add(new KeyValuePair<string, string>("Armor_008_Head", ""), 1);
            ChestDropTable.Add(new KeyValuePair<string, string>("Armor_009_Head", ""), 1);
            ChestDropTable.Add(new KeyValuePair<string, string>("Armor_011_Head", ""), 1);
            ChestDropTable.Add(new KeyValuePair<string, string>("Armor_012_Head", ""), 1);
            ChestDropTable.Add(new KeyValuePair<string, string>("Armor_014_Head", ""), 1);
            ChestDropTable.Add(new KeyValuePair<string, string>("Armor_017_Head", ""), 1);
            ChestDropTable.Add(new KeyValuePair<string, string>("Armor_020_Head", ""), 1);
            ChestDropTable.Add(new KeyValuePair<string, string>("Armor_021_Head", ""), 1);
            ChestDropTable.Add(new KeyValuePair<string, string>("Armor_022_Head", ""), 1);
            ChestDropTable.Add(new KeyValuePair<string, string>("Armor_024_Head", ""), 1);
            ChestDropTable.Add(new KeyValuePair<string, string>("Armor_025_Head", ""), 1);
            ChestDropTable.Add(new KeyValuePair<string, string>("Armor_026_Head", ""), 1);
            ChestDropTable.Add(new KeyValuePair<string, string>("Armor_027_Head", ""), 1);
            ChestDropTable.Add(new KeyValuePair<string, string>("Armor_028_Head", ""), 1);
            ChestDropTable.Add(new KeyValuePair<string, string>("Armor_029_Head", ""), 1);
            ChestDropTable.Add(new KeyValuePair<string, string>("Armor_045_Head", ""), 1);
            ChestDropTable.Add(new KeyValuePair<string, string>("Armor_046_Head", ""), 1);
            ChestDropTable.Add(new KeyValuePair<string, string>("Armor_048_Head", ""), 1);
            ChestDropTable.Add(new KeyValuePair<string, string>("Armor_053_Head", ""), 1);
            ChestDropTable.Add(new KeyValuePair<string, string>("Armor_055_Head", ""), 1);
            ChestDropTable.Add(new KeyValuePair<string, string>("Armor_056_Head", ""), 1);
            ChestDropTable.Add(new KeyValuePair<string, string>("Armor_115_Head", ""), 1);
            ChestDropTable.Add(new KeyValuePair<string, string>("Armor_160_Head", ""), 1);
            ChestDropTable.Add(new KeyValuePair<string, string>("Armor_171_Head", ""), 1);
            ChestDropTable.Add(new KeyValuePair<string, string>("Armor_172_Head", ""), 1);
            ChestDropTable.Add(new KeyValuePair<string, string>("Armor_173_Head", ""), 1);
            ChestDropTable.Add(new KeyValuePair<string, string>("Armor_174_Head", ""), 1);
            ChestDropTable.Add(new KeyValuePair<string, string>("Armor_176_Head", ""), 1);
            ChestDropTable.Add(new KeyValuePair<string, string>("Armor_181_Head", ""), 1);
            ChestDropTable.Add(new KeyValuePair<string, string>("Armor_183_Head", ""), 1);
            ChestDropTable.Add(new KeyValuePair<string, string>("Armor_168_Head", ""), 1);
            ChestDropTable.Add(new KeyValuePair<string, string>("Armor_182_Head", ""), 1);
            ChestDropTable.Add(new KeyValuePair<string, string>("Armor_177_Head", ""), 1);
            ChestDropTable.Add(new KeyValuePair<string, string>("Armor_180_Head", ""), 1);
            ChestDropTable.Add(new KeyValuePair<string, string>("Armor_178_Head", ""), 1);
            ChestDropTable.Add(new KeyValuePair<string, string>("Armor_179_Head", ""), 1);
            ChestDropTable.Add(new KeyValuePair<string, string>("Armor_185_Head", ""), 1);
            ChestDropTable.Add(new KeyValuePair<string, string>("Armor_001_Lower", ""), 1);
            ChestDropTable.Add(new KeyValuePair<string, string>("Armor_005_Lower", ""), 1);
            ChestDropTable.Add(new KeyValuePair<string, string>("Armor_006_Lower", ""), 1);
            ChestDropTable.Add(new KeyValuePair<string, string>("Armor_008_Lower", ""), 1);
            ChestDropTable.Add(new KeyValuePair<string, string>("Armor_009_Lower", ""), 1);
            ChestDropTable.Add(new KeyValuePair<string, string>("Armor_011_Lower", ""), 1);
            ChestDropTable.Add(new KeyValuePair<string, string>("Armor_012_Lower", ""), 1);
            ChestDropTable.Add(new KeyValuePair<string, string>("Armor_014_Lower", ""), 1);
            ChestDropTable.Add(new KeyValuePair<string, string>("Armor_017_Lower", ""), 1);
            ChestDropTable.Add(new KeyValuePair<string, string>("Armor_020_Lower", ""), 1);
            ChestDropTable.Add(new KeyValuePair<string, string>("Armor_021_Lower", ""), 1);
            ChestDropTable.Add(new KeyValuePair<string, string>("Armor_043_Lower", ""), 1);
            ChestDropTable.Add(new KeyValuePair<string, string>("Armor_046_Lower", ""), 1);
            ChestDropTable.Add(new KeyValuePair<string, string>("Armor_048_Lower", ""), 1);
            ChestDropTable.Add(new KeyValuePair<string, string>("Armor_049_Lower", ""), 1);
            ChestDropTable.Add(new KeyValuePair<string, string>("Armor_053_Lower", ""), 1);
            ChestDropTable.Add(new KeyValuePair<string, string>("Armor_140_Lower", ""), 1);
            ChestDropTable.Add(new KeyValuePair<string, string>("Armor_160_Lower", ""), 1);
            ChestDropTable.Add(new KeyValuePair<string, string>("Armor_171_Lower", ""), 1);
            ChestDropTable.Add(new KeyValuePair<string, string>("Armor_174_Lower", ""), 1);
            ChestDropTable.Add(new KeyValuePair<string, string>("Armor_179_Lower", ""), 1);
            ChestDropTable.Add(new KeyValuePair<string, string>("Armor_185_Lower", ""), 1);
            ChestDropTable.Add(new KeyValuePair<string, string>("Armor_180_Lower", ""), 1);
            ChestDropTable.Add(new KeyValuePair<string, string>("Armor_001_Upper", ""), 1);
            ChestDropTable.Add(new KeyValuePair<string, string>("Armor_005_Upper", ""), 1);
            ChestDropTable.Add(new KeyValuePair<string, string>("Armor_006_Upper", ""), 1);
            ChestDropTable.Add(new KeyValuePair<string, string>("Armor_008_Upper", ""), 1);
            ChestDropTable.Add(new KeyValuePair<string, string>("Armor_009_Upper", ""), 1);
            ChestDropTable.Add(new KeyValuePair<string, string>("Armor_011_Upper", ""), 1);
            ChestDropTable.Add(new KeyValuePair<string, string>("Armor_012_Upper", ""), 1);
            ChestDropTable.Add(new KeyValuePair<string, string>("Armor_014_Upper", ""), 1);
            ChestDropTable.Add(new KeyValuePair<string, string>("Armor_017_Upper", ""), 1);
            ChestDropTable.Add(new KeyValuePair<string, string>("Armor_020_Upper", ""), 1);
            ChestDropTable.Add(new KeyValuePair<string, string>("Armor_021_Upper", ""), 1);
            ChestDropTable.Add(new KeyValuePair<string, string>("Armor_043_Upper", ""), 1);
            ChestDropTable.Add(new KeyValuePair<string, string>("Armor_044_Upper", ""), 1);
            ChestDropTable.Add(new KeyValuePair<string, string>("Armor_046_Upper", ""), 1);
            ChestDropTable.Add(new KeyValuePair<string, string>("Armor_048_Upper", ""), 1);
            ChestDropTable.Add(new KeyValuePair<string, string>("Armor_053_Upper", ""), 1);
            ChestDropTable.Add(new KeyValuePair<string, string>("Armor_116_Upper", ""), 1);
            ChestDropTable.Add(new KeyValuePair<string, string>("Armor_160_Upper", ""), 1);
            ChestDropTable.Add(new KeyValuePair<string, string>("Armor_170_Upper", ""), 1);
            ChestDropTable.Add(new KeyValuePair<string, string>("Armor_171_Upper", ""), 1);
            ChestDropTable.Add(new KeyValuePair<string, string>("Armor_174_Upper", ""), 1);
            ChestDropTable.Add(new KeyValuePair<string, string>("Armor_179_Upper", ""), 1);
            ChestDropTable.Add(new KeyValuePair<string, string>("Armor_185_Upper", ""), 1);
            ChestDropTable.Add(new KeyValuePair<string, string>("Armor_175_Upper", ""), 1);
            ChestDropTable.Add(new KeyValuePair<string, string>("Armor_180_Upper", ""), 1);

            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Sword_001", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Sword_002", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Sword_003", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Sword_004", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Sword_005", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Sword_006", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Sword_007", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Sword_008", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Sword_009", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Sword_013", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Sword_014", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Sword_015", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Sword_016", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Sword_017", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Sword_018", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Sword_019", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Sword_020", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Sword_021", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Sword_022", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Sword_023", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Sword_024", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Sword_025", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Sword_027", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Sword_029", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Sword_030", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Sword_031", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Sword_033", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Sword_034", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Sword_035", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Sword_040", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Sword_041", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Sword_043", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Sword_044", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Sword_047", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Sword_048", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Sword_049", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Sword_050", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Sword_051", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Sword_052", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Sword_053", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Sword_060", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Sword_061", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Sword_062", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Sword_073", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Lsword_001", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Lsword_002", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Lsword_003", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Lsword_004", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Lsword_005", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Lsword_006", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Lsword_010", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Lsword_011", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Lsword_012", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Lsword_013", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Lsword_014", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Lsword_015", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Lsword_016", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Lsword_017", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Lsword_018", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Lsword_019", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Lsword_020", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Lsword_023", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Lsword_024", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Lsword_027", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Lsword_029", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Lsword_030", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Lsword_031", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Lsword_032", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Lsword_033", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Lsword_034", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Lsword_035", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Lsword_036", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Lsword_037", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Lsword_038", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Lsword_041", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Lsword_045", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Lsword_047", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Lsword_051", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Lsword_054", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Lsword_055", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Lsword_056", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Lsword_074", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Spear_001", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Spear_002", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Spear_003", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Spear_004", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Spear_005", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Spear_006", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Spear_007", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Spear_008", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Spear_009", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Spear_010", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Spear_011", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Spear_012", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Spear_013", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Spear_014", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Spear_015", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Spear_016", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Spear_017", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Spear_018", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Spear_021", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Spear_022", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Spear_023", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Spear_024", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Spear_025", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Spear_027", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Spear_028", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Spear_029", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Spear_030", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Spear_031", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Spear_032", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Spear_033", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Spear_034", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Spear_035", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Spear_036", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Spear_037", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Spear_038", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Spear_047", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Spear_049", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Spear_050", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Shield_001", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Shield_002", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Shield_003", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Shield_004", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Shield_005", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Shield_006", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Shield_007", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Shield_008", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Shield_009", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Shield_013", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Shield_014", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Shield_015", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Shield_016", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Shield_017", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Shield_018", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Shield_021", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Shield_022", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Shield_023", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Shield_025", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Shield_026", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Shield_030", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Shield_031", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Shield_032", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Shield_033", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Shield_034", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Shield_035", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Shield_036", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Shield_037", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Shield_038", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Shield_040", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Shield_041", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Bow_001", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Bow_002", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Bow_003", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Bow_004", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Bow_006", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Bow_009", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Bow_011", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Bow_013", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Bow_014", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Bow_015", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Bow_016", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Bow_017", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Bow_023", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Bow_026", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Bow_027", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Bow_028", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Bow_029", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Bow_030", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Bow_032", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Bow_033", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Bow_035", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Bow_036", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Bow_038", ""), 4);
            ChestDropTable.Add(new KeyValuePair<string, string>("Weapon_Bow_040", ""), 4);

            ChestDropTable.Add(new KeyValuePair<string, string>("Item_Enemy_00", ""), 2);
            ChestDropTable.Add(new KeyValuePair<string, string>("Item_Enemy_01", ""), 2);
            ChestDropTable.Add(new KeyValuePair<string, string>("Item_Enemy_02", ""), 2);
            ChestDropTable.Add(new KeyValuePair<string, string>("Item_Enemy_03", ""), 2);
            ChestDropTable.Add(new KeyValuePair<string, string>("Item_Enemy_04", ""), 2);
            ChestDropTable.Add(new KeyValuePair<string, string>("Item_Enemy_05", ""), 2);
            ChestDropTable.Add(new KeyValuePair<string, string>("Item_Enemy_06", ""), 2);
            ChestDropTable.Add(new KeyValuePair<string, string>("Item_Enemy_07", ""), 2);
            ChestDropTable.Add(new KeyValuePair<string, string>("Item_Enemy_08", ""), 2);
            ChestDropTable.Add(new KeyValuePair<string, string>("Item_Enemy_12", ""), 2);
            ChestDropTable.Add(new KeyValuePair<string, string>("Item_Enemy_13", ""), 2);
            ChestDropTable.Add(new KeyValuePair<string, string>("Item_Enemy_14", ""), 2);
            ChestDropTable.Add(new KeyValuePair<string, string>("Item_Enemy_15", ""), 2);
            ChestDropTable.Add(new KeyValuePair<string, string>("Item_Enemy_16", ""), 2);
            ChestDropTable.Add(new KeyValuePair<string, string>("Item_Enemy_17", ""), 2);
            ChestDropTable.Add(new KeyValuePair<string, string>("Item_Enemy_18", ""), 2);
            ChestDropTable.Add(new KeyValuePair<string, string>("Item_Enemy_19", ""), 2);
            ChestDropTable.Add(new KeyValuePair<string, string>("Item_Enemy_20", ""), 2);
            ChestDropTable.Add(new KeyValuePair<string, string>("Item_Enemy_21", ""), 2);
            ChestDropTable.Add(new KeyValuePair<string, string>("Item_Enemy_24", ""), 2);
            ChestDropTable.Add(new KeyValuePair<string, string>("Item_Enemy_25", ""), 2);
            ChestDropTable.Add(new KeyValuePair<string, string>("Item_Enemy_26", ""), 2);
            ChestDropTable.Add(new KeyValuePair<string, string>("Item_Enemy_27", ""), 2);
            ChestDropTable.Add(new KeyValuePair<string, string>("Item_Enemy_28", ""), 2);
            ChestDropTable.Add(new KeyValuePair<string, string>("Item_Enemy_29", ""), 2);
            ChestDropTable.Add(new KeyValuePair<string, string>("Item_Enemy_30", ""), 2);
            ChestDropTable.Add(new KeyValuePair<string, string>("Item_Enemy_31", ""), 2);
            ChestDropTable.Add(new KeyValuePair<string, string>("Item_Enemy_32", ""), 2);
            ChestDropTable.Add(new KeyValuePair<string, string>("Item_Enemy_33", ""), 2);
            ChestDropTable.Add(new KeyValuePair<string, string>("Item_Enemy_34", ""), 2);
            ChestDropTable.Add(new KeyValuePair<string, string>("Item_Enemy_38", ""), 2);
            ChestDropTable.Add(new KeyValuePair<string, string>("Item_Enemy_39", ""), 2);
            ChestDropTable.Add(new KeyValuePair<string, string>("Item_Enemy_40", ""), 2);
            ChestDropTable.Add(new KeyValuePair<string, string>("Item_Enemy_41", ""), 2);
            ChestDropTable.Add(new KeyValuePair<string, string>("Item_Enemy_42", ""), 2);
            ChestDropTable.Add(new KeyValuePair<string, string>("Item_Enemy_43", ""), 2);
            ChestDropTable.Add(new KeyValuePair<string, string>("Item_Enemy_44", ""), 2);
            ChestDropTable.Add(new KeyValuePair<string, string>("Item_Enemy_45", ""), 2);
            ChestDropTable.Add(new KeyValuePair<string, string>("Item_Enemy_46", ""), 2);
            ChestDropTable.Add(new KeyValuePair<string, string>("Item_Enemy_47", ""), 2);
            ChestDropTable.Add(new KeyValuePair<string, string>("Item_Enemy_48", ""), 2);
            ChestDropTable.Add(new KeyValuePair<string, string>("Item_Enemy_49", ""), 2);
            ChestDropTable.Add(new KeyValuePair<string, string>("Item_Enemy_50", ""), 2);
            ChestDropTable.Add(new KeyValuePair<string, string>("Item_Enemy_51", ""), 2);
            ChestDropTable.Add(new KeyValuePair<string, string>("Item_Enemy_52", ""), 2);
            ChestDropTable.Add(new KeyValuePair<string, string>("Item_Enemy_53", ""), 2);
            ChestDropTable.Add(new KeyValuePair<string, string>("Item_Enemy_54", ""), 2);
            ChestDropTable.Add(new KeyValuePair<string, string>("Item_Enemy_55", ""), 2);
            ChestDropTable.Add(new KeyValuePair<string, string>("Item_Enemy_56", ""), 2);
            ChestDropTable.Add(new KeyValuePair<string, string>("Item_Enemy_57", ""), 2);

            ChestDropTable.Add(new KeyValuePair<string, string>("Item_Material_01", ""), 2);
            ChestDropTable.Add(new KeyValuePair<string, string>("Item_Material_02", ""), 2);
            ChestDropTable.Add(new KeyValuePair<string, string>("Item_Material_03", ""), 2);
            ChestDropTable.Add(new KeyValuePair<string, string>("Item_Material_04", ""), 2);
            ChestDropTable.Add(new KeyValuePair<string, string>("Item_Material_05", ""), 2);
            ChestDropTable.Add(new KeyValuePair<string, string>("Item_Material_06", ""), 2);
            ChestDropTable.Add(new KeyValuePair<string, string>("Item_Material_07", ""), 2);
            ChestDropTable.Add(new KeyValuePair<string, string>("Item_Material_08", ""), 2);

            ChestDropTable.Add(new KeyValuePair<string, string>("Item_Ore_A", ""), 2);
            ChestDropTable.Add(new KeyValuePair<string, string>("Item_Ore_B", ""), 2);
            ChestDropTable.Add(new KeyValuePair<string, string>("Item_Ore_C", ""), 2);
            ChestDropTable.Add(new KeyValuePair<string, string>("Item_Ore_D", ""), 2);
            ChestDropTable.Add(new KeyValuePair<string, string>("Item_Ore_E", ""), 2);
            ChestDropTable.Add(new KeyValuePair<string, string>("Item_Ore_F", ""), 2);
            ChestDropTable.Add(new KeyValuePair<string, string>("Item_Ore_G", ""), 2);
            ChestDropTable.Add(new KeyValuePair<string, string>("Item_Ore_H", ""), 2);
            ChestDropTable.Add(new KeyValuePair<string, string>("Item_Ore_I", ""), 2);
            ChestDropTable.Add(new KeyValuePair<string, string>("Item_Ore_J", ""), 2);

            ChestDropTable.Add(new KeyValuePair<string, string>("Obj_AncientArrow_A_01", ""), 6);
            ChestDropTable.Add(new KeyValuePair<string, string>("Obj_AncientArrow_B_01", ""), 6);
            ChestDropTable.Add(new KeyValuePair<string, string>("Obj_AncientArrow_C_01", ""), 6);
            ChestDropTable.Add(new KeyValuePair<string, string>("Obj_ArrowBundle_A_01", ""), 6);
            ChestDropTable.Add(new KeyValuePair<string, string>("Obj_ArrowBundle_A_02", ""), 6);
            ChestDropTable.Add(new KeyValuePair<string, string>("Obj_ArrowNormal_A_01", ""), 6);
            ChestDropTable.Add(new KeyValuePair<string, string>("Obj_BombArrow_A_01", ""), 6);
            ChestDropTable.Add(new KeyValuePair<string, string>("Obj_BombArrow_A_02", ""), 6);
            ChestDropTable.Add(new KeyValuePair<string, string>("Obj_BombArrow_A_03", ""), 6);
            ChestDropTable.Add(new KeyValuePair<string, string>("Obj_BombArrow_A_04", ""), 6);
            ChestDropTable.Add(new KeyValuePair<string, string>("Obj_ElectricArrow_A_01", ""), 6);
            ChestDropTable.Add(new KeyValuePair<string, string>("Obj_ElectricArrow_A_02", ""), 6);
            ChestDropTable.Add(new KeyValuePair<string, string>("Obj_ElectricArrow_A_03", ""), 6);
            ChestDropTable.Add(new KeyValuePair<string, string>("Obj_FireArrow_A_01", ""), 6);
            ChestDropTable.Add(new KeyValuePair<string, string>("Obj_FireArrow_A_02", ""), 6);
            ChestDropTable.Add(new KeyValuePair<string, string>("Obj_FireArrow_A_03", ""), 6);
            ChestDropTable.Add(new KeyValuePair<string, string>("Obj_IceArrow_A_01", ""), 6);
            ChestDropTable.Add(new KeyValuePair<string, string>("Obj_IceArrow_A_02", ""), 6);
            ChestDropTable.Add(new KeyValuePair<string, string>("Obj_IceArrow_A_03", ""), 6);

            for (int i = 0; i < ChestDropTable.Count; i++)
            {
                for (int j = 0; j < ChestDropTable.ElementAt(i).Value; j++)
                {
                    ChestItems.Add(ChestDropTable.ElementAt(i).Key);
                }
            }

            int missingChests = chestsCount - ChestItems.Count;
            // Console.WriteLine(missingChests);
        }
    }
}