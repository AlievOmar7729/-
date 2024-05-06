namespace Chain_of_Reponsibility
{
    public class TwoHandler : Handler
    {
        public override void Handle(int choice)
        {
            if (choice == 2)
            {
                Console.WriteLine("You have reached the transmission of meter readings for Lights");
                return;
            }
            else
            {
                base.HandleNext(choice);
            }
        }
    }
}
