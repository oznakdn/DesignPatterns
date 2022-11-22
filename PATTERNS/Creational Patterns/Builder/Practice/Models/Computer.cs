namespace Practice.Models
{
    public class Computer
    {

        public Ram SetRam(Ram ram)
        {
            return ram = new Ram();
        }
        
        public Cpu SetCpu(Cpu cpu)
        {
            return cpu = new Cpu();

        }

        public HardDrive SetHardDrive(HardDrive hardDrive)
        {
            return hardDrive = new HardDrive();
        }

        public GraphicCard SetGraphicCard(GraphicCard graphicCard)
        {
            return graphicCard = new GraphicCard();
        }


        public Display SetDisplay(Display display)
        {
            return display = new Display();
        }

        public string Start()
        {
            return "Computer was started.)";
        }

    }
}