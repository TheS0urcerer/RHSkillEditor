
using RohanFile;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace RHSkillEditor
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    public struct SkillTreeStruct
    {
        public JobName job;
        public SkillIdx skillIdx;
        public SkillIdx childSkillIdx;
        public byte point;
        public byte reqPoint;
    }




    public class SkillTreeItem : IBinItem<SkillTreeStruct>
    {
        SkillTreeStruct data;
        public JobName job { get; set; }
        public SkillIdx skillIdx { get; set; }
        public Skill skill { get; set; }
        public SkillIdx childSkillIdx { get; set; }
        public Skill childSkill { get; set; }
        public byte point { get; set; }
        public byte reqPoint { get; set; }
        public bool hasParent { get; set; } = false;
        public List<SkillTreeItem> children = new List<SkillTreeItem>();

        public SkillTreeItem(SkillTreeStruct data, bool fake = false)
        {
            this.data = data;
            revert(fake);
        }

        public void save() => data = toStruct();      // make the dtructure match the instance data;

        public SkillTreeStruct toStruct()
        {
            SkillTreeStruct data = new SkillTreeStruct();
            data.job = job;
            data.skillIdx = skillIdx;
            data.childSkillIdx = childSkillIdx;
            data.point = point;
            data.reqPoint = reqPoint;
            return data;
        }

        public void revert(bool fake = false)
        {
            job = data.job;
            skillIdx = data.skillIdx;
            childSkillIdx = data.childSkillIdx;
            point = data.point;
            reqPoint = data.reqPoint;
            Skill aSkill;
            if (Global.SkillDict.TryGetValue(skillIdx, out aSkill))
                skill = aSkill;
            if (childSkillIdx != SkillIdx.SKILL_NULL)
            {
                if (Global.SkillDict.TryGetValue(childSkillIdx, out aSkill))
                    childSkill = aSkill;
                else
                    childSkill = new Skill(new SkillStruct(), true);
            }
            else
                childSkill = new Skill(new SkillStruct(), true);
        }

        public override string ToString()
        {
            return skillIdx.ToString();
        }
    }

    // A SkillTreeNode is a tree element particle that can have 0 or more parent elements and 0 or more child elements 
    public class SkillTreeNode 
    {
        public SkillTreeItem treeItem { get; set; }
        public List<SkillTreeNode> parents { get; set; } = new List<SkillTreeNode>();
        public List<SkillTreeNode> children { get; set; } = new List<SkillTreeNode>();

        public bool hasParent { get; set; } = false;
        public SkillTreeNode(SkillTreeItem item)
        {
            treeItem = item;
        }
        public void addParent(SkillTreeNode aNode)
        {
            if (!parents.Contains(aNode))
                parents.Add(aNode);
        }
        public void addChild(SkillTreeNode aNode)
        {
            if (!children.Contains(aNode))
                children.Add(aNode);
        }

        public bool hasParents() => (parents.Count > 0);

        public bool hasChildren() => (children.Count > 0);

        public override string ToString() => treeItem.skillIdx.ToString();

        public override bool Equals(object obj)
        {
            if (obj.GetType() != typeof(SkillTreeNode))
                return false;
            return (((SkillTreeNode)obj).treeItem.skillIdx == treeItem.skillIdx);
        }

        public override int GetHashCode() => treeItem.skillIdx.ToString().GetHashCode();
    }

    public class SkillTree
    {

        public List<SkillTreeNode> jobItems { get; set; } = new List<SkillTreeNode>();
        public List<SkillTreeNode> consolidated { get; set; } = new List<SkillTreeNode>();
        public Dictionary<SkillIdx, SkillTreeNode> jobSkillsDict { get; set; } = new Dictionary<SkillIdx, SkillTreeNode>();
        private List<SkillTreeNode> roots { get; set; } = new List<SkillTreeNode>();

        public SkillTree(JobName j1)
        {

        }

        public SkillTree(JobName job, bool build = true)
        {
            // start with a clean slate
            roots.Clear();
            jobItems.Clear();
            // collect all the job related items
            foreach (SkillTreeItem item in RHSkillEditor.skillTreeFile.content)
            {
                if (item.job == job)
                {
                    SkillTreeNode stn = new SkillTreeNode(item);
                    jobItems.Add(stn);
                    if (build)
                        jobSkillsDict.TryAdd(item.skillIdx, stn);
                }
            }
            if (build)
                buildTree();
        }

        /* 
         * build a tree of skills (current and child nodes
         * goal is to have a list of parent-less tree nodes that can be added to a single root node 
         */
        private void buildTree()
        {

            // first, make all of the parent/child linkages
            consolidateJobItems();
        }

        private void consolidateJobItems()
        {
            consolidated.Clear();
            foreach (SkillTreeNode node in jobItems)
            {
                if (jobSkillsDict.TryGetValue(node.treeItem.skillIdx, out SkillTreeNode existNode))
                {
                    // add this child's node to the one found in the dictionary
                    if (node.treeItem.childSkillIdx != SkillIdx.SKILL_NULL)
                    {
                        if (jobSkillsDict.TryGetValue(node.treeItem.childSkillIdx, out SkillTreeNode childNode))
                        {
                            if (!existNode.children.Contains(childNode))
                            {
                                existNode.children.Add(childNode);
                                childNode.addParent(existNode);
                            }
                        }
                    }
                } 
                else // current node being linked not in the dictionary. should not happen. is an error if it does!
                {
                    Console.WriteLine($"Error linking skill node {node}. Not found in the job skills dictionary");
                }
            }
        }

        TreeNode buildTree(SkillTreeNode stn)
        {
            //List<TreeNode> nodes = new List<TreeNode>();
            TreeNode thisTNode = new TreeNode(stn.treeItem.skill.korName);
            thisTNode.Tag = stn;
            foreach (SkillTreeNode aNode in stn.children)
                thisTNode.Nodes.Add(buildTree(aNode));
            return thisTNode;
        }

        public TreeNode[] buildTrees()
        {
            roots.Clear();
            getRoots();
            List<TreeNode> treeNodes = new List<TreeNode>();
            foreach(SkillTreeNode node in roots)
                treeNodes.Add(buildTree(node));
            return treeNodes.ToArray();
        }

        private void getRoots()
        {
            roots.Clear();
            foreach (SkillTreeNode stn in jobSkillsDict.Values)
            {
                if (!stn.hasParents())
                    roots.Add(stn);
            }
        }
    }
}
