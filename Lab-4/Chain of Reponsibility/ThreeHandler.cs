namespace Chain_of_Reponsibility
{
    public class ThreeHandler : Handler
    {
        public override void Handle(int choice)
        {
            if (choice == 3)
            {
                Console.WriteLine("You have reached the transmission of meter readings for Heating");
                return;
            }
            else
            {
                base.HandleNext(choice);
            }
        }
    }
}
