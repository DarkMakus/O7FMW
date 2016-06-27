namespace Angkor.O7Framework.Web.Serializable
{
    public class O7CompanySerializable
    {
        public string Id { get; set; }
        public string Description { get; set; }
        public O7BranchSerializable[] O7BranchSerializables { get; set; }
    }
}