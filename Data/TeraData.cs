﻿using System.IO;
using Tera.Game;

namespace Data
{
    public class TeraData
    {
        internal TeraData(BasicTeraData basicData, string region)
        {
            SkillDatabase = new SkillDatabase(Path.Combine(BasicTeraData.Instance.ResourceDirectory, "data/skills/"));
            OpCodeNamer =
                new OpCodeNamer(Path.Combine(basicData.ResourceDirectory,
                    $"data/opcodes-{region}.txt"));
        }

        public OpCodeNamer OpCodeNamer { get; private set; }
        public SkillDatabase SkillDatabase { get; private set; }
    }
}