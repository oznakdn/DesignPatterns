using Practice.Components;

namespace Practice.Factory
{
    public class GUIFactory : IGUIFactory
    {
        public IComponent CreateButton()
        {
            return new Button();
        }

        public IComponent CreateDataGridView()
        {
            return new DataGridView();
        }

        public IComponent CreateLabel()
        {
            return new Label();
        }
    }
}