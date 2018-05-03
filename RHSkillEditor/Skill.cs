using FreeImageAPI;
using RohanFile;
using System;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;


namespace RHSkillEditor
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct SkillStruct
    {
        public SkillIdx skillIdx;                                    // unsigned __int16 nIdx;
        public ushort pad;
        public int enable;                                              // int bEnable;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
        public string korName;                                        // char szKorName[50];
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
        public string engName;                                        // char szEngName[50];
        public SkillType type;                                          // int nType;
        public SkillSubType subType;                                    // int nSubType;
        public SkillTarget target;                                  // int nTarget;
        public int range;                                               // int nRange;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
        public string description;                                   // char szDescription[128];
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 30)]
        public string iconFileName;                                   // char szIconFileName[30];
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 30)]
        public string iconPushFileName;                               // char szIconPushFileName[30];
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 30)]
        public string iconSmallFileName;                              // char szIconSmallFileName[30];
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 30)]
        public string iconLargeFileName;                              // char szIconLargeFileName[30];
        public int countinuousAttack;                                   // int bCountinuous_Attack;
        public int assistance;                                          // int bAssistance;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 30)]
        public string iconAffectFileName;                             // char szIconAffectFileName[30];
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
        public string affectDescription;                             // char szAffectDescription[128];
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 30)]
        public string iconSmallAffectFile;                            // char szIconSmallAffectFile[30];
        public byte addPoint;                                           // char nAddPoint;
        public byte p2;
        public ushort p3;
        public int addPointProbability;                                 // int nAddPointProbability;
        public int addPointProbability2;                                // int nAddPointProbability2;
        public uint timeFlag;                                   // unsigned int nTimeFlag;
    }

    public class Skill : IBinItem<SkillStruct>
    {
        public SkillStruct data;
        public Bitmap icon { get; set; }
        public SkillIdx skillIdx { get; set; }
        public ushort pad { get; set; }
        public int enable { get; set; }
        public string korName { get; set; }
        public string engName { get; set; }
        public SkillType type { get; set; }
        public SkillSubType subType { get; set; }
        public SkillTarget target { get; set; }
        public int range { get; set; }
        public string description { get; set; }
        public string iconFileName { get; set; }
        public string iconPushFileName { get; set; }
        public string iconSmallFileName { get; set; }
        public string iconLargeFileName { get; set; }
        public int countinuousAttack { get; set; }
        public int assistance { get; set; }
        public string iconAffectFileName { get; set; }
        public string affectDescription { get; set; }
        public string iconSmallAffectFile { get; set; }
        public byte addPoint { get; set; }
        public byte p2 { get; set; }
        public ushort p3 { get; set; }
        public int addPointProbability { get; set; }
        public int addPointProbability2 { get; set; }
        public uint timeFlag { get; set; }

        public SkillLevel skillLevel { get; set; }

        public Skill(SkillStruct data, bool fake=false)
        {
            this.data = data;
            if (!fake)
            {
                skillIdx = data.skillIdx;
                pad = data.pad;
                enable = data.enable;
                korName = data.korName;
                engName = data.engName;
                type = data.type;
                subType = data.subType;
                target = data.target;
                range = data.range;
                description = data.description;
                iconFileName = data.iconFileName;
                iconPushFileName = data.iconPushFileName;
                iconSmallFileName = data.iconSmallFileName;
                iconLargeFileName = data.iconLargeFileName;
                countinuousAttack = data.countinuousAttack;
                assistance = data.assistance;
                iconAffectFileName = data.iconAffectFileName;
                affectDescription = data.affectDescription;
                iconSmallAffectFile = data.iconSmallAffectFile;
                addPoint = data.addPoint;
                p2 = data.p2;
                p3 = data.p3;
                addPointProbability = data.addPointProbability;
                addPointProbability2 = data.addPointProbability2;
                timeFlag = data.timeFlag;

                // load the icon bitmap
                if (iconFileName.Contains(".gtx"))
                {
                    string imageFile = iconFileName.Replace(".gtx", ".jpg");
                    imageFile = Path.Combine(Properties.Settings.Default.ImagesTargetDir, imageFile);
                    if (File.Exists(imageFile))
                    {
                        FreeImageBitmap fbm = FreeImageBitmap.FromFile(imageFile);
                        icon = fbm.ToBitmap();
                    }
                    else
                        icon = Properties.Resources.noIcon;  // place holder if there is no icon available
                }

            }
            else
            {
                skillIdx = SkillIdx.SKILL_NULL;
                pad = data.pad;
                enable = 0;
                korName = "null skill";
                engName = "null skill";
                type = SkillType.SKILLTYPE_NULL;
                subType = SkillSubType.SKILLSUB_DEFAULT;
                target = SkillTarget.TARGET_SELF;
                range = 0;
                description = "";
                iconFileName = "";
                iconPushFileName = "";
                iconSmallFileName = "";
                iconLargeFileName = "";
                countinuousAttack = 0;
                assistance = 0;
                iconAffectFileName = "";
                affectDescription = "";
                iconSmallAffectFile = "";
                addPoint = 0;
                p2 = 0;
                p3 = 0;
                addPointProbability = 0;
                addPointProbability2 = 0;
                timeFlag = 0;

                // load the icon bitmap
                icon = Properties.Resources.noIcon;  // place holder if there is no icon available
            }
        }

        public override string ToString()
        {
            return korName;
        }

        public SkillStruct toStruct()
        {
            SkillStruct data = new SkillStruct();
            data.skillIdx = skillIdx;
            data.pad = pad;
            data.enable = enable;
            data.korName = korName;
            data.engName = engName;
            data.type = type;
            data.subType = subType;
            data.target = target;
            data.range = range;
            data.description = description;
            data.iconFileName = iconFileName;
            data.iconPushFileName = iconPushFileName;
            data.iconSmallFileName = iconSmallFileName;
            data.iconLargeFileName = iconLargeFileName;
            data.countinuousAttack = countinuousAttack;
            data.assistance = assistance;
            data.iconAffectFileName = iconAffectFileName;
            data.affectDescription = affectDescription;
            data.iconSmallAffectFile = iconSmallAffectFile;
            data.addPoint = addPoint;
            data.p2 = p2;
            data.p3 = p3;
            data.addPointProbability = addPointProbability;
            data.addPointProbability2 = addPointProbability2;
            data.timeFlag = timeFlag;
            return data;
        }

        public void save()
        {
            data = toStruct();
        }

        public void revert()
        {
            if (skillIdx != SkillIdx.SKILL_NULL)
            {
                skillIdx = data.skillIdx;
                pad = data.pad;
                enable = data.enable;
                korName = data.korName;
                engName = data.engName;
                type = data.type;
                subType = data.subType;
                target = data.target;
                range = data.range;
                description = data.description;
                iconFileName = data.iconFileName;
                iconPushFileName = data.iconPushFileName;
                iconSmallFileName = data.iconSmallFileName;
                iconLargeFileName = data.iconLargeFileName;
                countinuousAttack = data.countinuousAttack;
                assistance = data.assistance;
                iconAffectFileName = data.iconAffectFileName;
                affectDescription = data.affectDescription;
                iconSmallAffectFile = data.iconSmallAffectFile;
                addPoint = data.addPoint;
                p2 = data.p2;
                p3 = data.p3;
                addPointProbability = data.addPointProbability;
                addPointProbability2 = data.addPointProbability2;
                timeFlag = data.timeFlag;

                // load the icon bitmap
                if (iconFileName.Contains(".gtx"))
                {
                    string imageFile = iconFileName.Replace(".gtx", ".jpg");
                    imageFile = Path.Combine(Properties.Settings.Default.ImagesTargetDir, imageFile);
                    if (File.Exists(imageFile))
                    {
                        FreeImageBitmap fbm = FreeImageBitmap.FromFile(imageFile);
                        icon = fbm.ToBitmap();
                    }
                    else
                        icon = Properties.Resources.noIcon;  // place holder if there is no icon available
                }
            }
            else
            {
                skillIdx = SkillIdx.SKILL_NULL;
                pad = data.pad;
                enable = 0;
                korName = "null skill";
                engName = "null skill";
                type = SkillType.SKILLTYPE_NULL;
                subType = SkillSubType.SKILLSUB_DEFAULT;
                target = SkillTarget.TARGET_SELF;
                range = 0;
                description = "";
                iconFileName = "";
                iconPushFileName = "";
                iconSmallFileName = "";
                iconLargeFileName = "";
                countinuousAttack = 0;
                assistance = 0;
                iconAffectFileName = "";
                affectDescription = "";
                iconSmallAffectFile = "";
                addPoint = 0;
                p2 = 0;
                p3 = 0;
                addPointProbability = 0;
                addPointProbability2 = 0;
                timeFlag = 0;
                // load the icon bitmap
                icon = Properties.Resources.noIcon;  // place holder if there is no icon available
            }
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() == typeof(Skill))
                return ((Skill)obj).skillIdx == skillIdx;

            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return skillIdx.GetHashCode();
        }
    }
}
