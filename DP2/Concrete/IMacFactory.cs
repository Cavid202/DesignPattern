using DP2.Abstract;

namespace DP2.Concrete
{
    public interface IMacFactory
    {
        Button CreateButton();
        Checkbox CreateCheckbox();
    }
}