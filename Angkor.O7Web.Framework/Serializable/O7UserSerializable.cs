namespace Angkor.O7Framework.Web.Serializable
{
    public class O7UserSerializable
    {
        public string NickName { get; set; }
        public string Password { get; set; }
        public O7CompanySerializable O7CompanySerializable { get; set; }
        public O7BranchSerializable BranchSerializable { get; set; }
    }
}