using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experimentalism
{
    [Serializable]
    class ExpAPI_Post : ExpAPI
    {
        int SkillHash;
        int TerrainHash;

        public ExpAPI_Post()
        {
            Init_Start();
            Init_End();
        }

        private void Init_Start()
        {
            Console.WriteLine("API Initializing Started");
            var title = Console.Title;
            Console.WriteLine("Stacktrace: " + title);
            Init_Skills();
            Console.WriteLine("Skill Initialized");
            Console.WriteLine("Skill Hash Value:" + SkillHash);
            Init_Terrains();
            Console.WriteLine("Terrain Initialized");
            Console.WriteLine("Terrain Hash Value:" + TerrainHash);
        }

        private void Init_End()
        {
            Console.WriteLine("API Initializing Ended");
            Console.WriteLine();
        }

        private void Init_Terrains()
        {
            char[] Terrain = new char[100];
            Terrain[0] = ' ';
            Terrain[1] = 'D';
            Terrain[2] = '^';
            Terrain[3] = 'S';
            TerrainHash = Terrain.GetHashCode();
        }

        private void Init_Skills()
        {
            string[] Skill = new string[100];
            Skill[0] = "Miner";
            Skill[1] = "Smith";
            Skill[2] = "Tree Cutter";
            Skill[3] = "Vein Prospector";
            Skill[4] = "Swordman";
            Skill[5] = "Archer";
            Skill[6] = "Woodworker";
            Skill[7] = "Engineer";
            SkillHash = Skill.GetHashCode();
        }
    }
}