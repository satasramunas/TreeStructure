namespace TreeStructure
{
    public class Branch
    {
        public List<Branch> branches;

        public Branch AddNewBranch()
        {
            Branch branch = new()
            {
                branches = new List<Branch>()
            };

            return branch;
        }

        public void CreateTree()
        {
            Branch branch = AddNewBranch();

            branch.branches.Add(AddNewBranch());
            branch.branches.Add(AddNewBranch());
            branch.branches.Add(AddNewBranch());
            branch.branches[0].branches.Add(AddNewBranch());
            branch.branches[0].branches.Add(AddNewBranch());
            branch.branches[1].branches.Add(AddNewBranch());
            branch.branches[2].branches.Add(AddNewBranch());
            branch.branches[2].branches.Add(AddNewBranch());
            branch.branches[0].branches[1].branches.Add(AddNewBranch());
            branch.branches[0].branches[1].branches.Add(AddNewBranch());
            branch.branches[0].branches[1].branches.Add(AddNewBranch());
            branch.branches[2].branches[1].branches.Add(AddNewBranch());
            branch.branches[2].branches[1].branches.Add(AddNewBranch());

            Console.Write("The depth of this structure is {0}", GetDepthOfTree(branch) + "\n");
        }

        public int GetDepthOfTree(Branch branch)
        {
            if (branch == null)
            {
                return 0;
            }

            int maxDepth = 0;

            foreach (Branch child in branch.branches)
            {
                maxDepth = Math.Max(maxDepth, GetDepthOfTree(child));
            }

            return maxDepth + 1;
        }

        public void PrintStructure()
        {
            Console.WriteLine(" _____________________\n" +
                              "|          O          |\n" +
                              "|        / | \\        |\n" +
                              "|       O  O  O       |\n" +
                              "|      /|  |  |\\      |\n" +
                              "|     O O  O  O O     |\n" +
                              "|      /|\\     / \\    |\n" +
                              "|     O O O   O   O   |\n" +
                              "|_____________________|\n");
        }
    }
}
