using Practice.Components;

namespace Practice.Factory
{
    public interface IGUIFactory
    {
        IComponent CreateButton();
        IComponent CreateDataGridView();
        IComponent CreateLabel();
    }
}