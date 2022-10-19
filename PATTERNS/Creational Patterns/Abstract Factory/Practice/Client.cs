using Practice.Components;
using Practice.Factory;

namespace Practice
{
    public class Client
    {
        public Client(IGUIFactory factory)
    {
        IComponent button = factory.CreateButton();
        button.Paint();

        IComponent dataGridView = factory.CreateDataGridView();
        dataGridView.Paint();

        IComponent label = factory.CreateLabel();
        dataGridView.Paint();
    }
    }
}