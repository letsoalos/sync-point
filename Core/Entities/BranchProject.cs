using Core.Entities._LookUps;

namespace Core.Entities
{
    public class BranchProject(int branchId, int projectId) : BaseEntity
    {
        public int BranchId { get; set; } = branchId;
        public int ProjectId { get; set; } = projectId;

        public required Branch Branch { get; set; }
        public required Project Project { get; set; }
    }
}
