namespace DA6.Api.Attributes
{

    [AttributeUsage(AttributeTargets.Property)]
    public class NotEmpty : Attribute
    {
    }

    [AttributeUsage(AttributeTargets.Property)]
    public class MaxLength : Attribute
    {
        public int Length { get; set; }
        public MaxLength(int length)
        {
            this.Length = length;
        }
    }
    [AttributeUsage(AttributeTargets.Property)]
    public class PrimaryKey : Attribute
    {

    }

    [AttributeUsage(AttributeTargets.Property)]
    public class CheckDuplicate : Attribute
    {

    }
    [AttributeUsage(AttributeTargets.Property)]
    public class PropertyName : Attribute
    {
        public string Name { get; set; }
        public PropertyName(string name)
        {
            this.Name = name;
        }
    }
    [AttributeUsage(AttributeTargets.Property)]
    public class checkDate : Attribute
    {

    }
}
