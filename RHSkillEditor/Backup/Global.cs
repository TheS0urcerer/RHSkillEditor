﻿using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace RHSkillEditor
{
    public static class Global
    {
        public const string SKILL_LVL_NAME = "skilllevel.bin";
        public const string SKILL_INFO_NAME = "skill.bin";
        public const string SKILL_TREE_NAME = "skilltree.bin";
        public static Dictionary<SkillIdx, Skill> SkillDict { get; set; } = new Dictionary<SkillIdx, Skill>();
        public static Dictionary<SkillIdx, SkillLevel> LevelDict { get; set; } = new Dictionary<SkillIdx, SkillLevel>();
    }




}