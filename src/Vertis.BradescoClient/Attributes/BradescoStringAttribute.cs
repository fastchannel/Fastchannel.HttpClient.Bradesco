namespace Vertis.BradescoClient.Attributes
{
    public class BradescoStringAttribute : BradescoAttribute
    {
        public int MinLenght { get; set; }
        public int MaxLength { get; set; }
        public bool OnlyNumbers { get; set; }
    }
}
