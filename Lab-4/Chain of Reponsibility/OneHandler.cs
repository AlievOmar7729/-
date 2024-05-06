namespace Chain_of_Reponsibility
{
    public class OneHandler : Handler
    {
        public override void Handle(int choice)
        {
            if (choice == 1)
            {
                Console.WriteLine("You have reached the transmission of meter readings for Gas");
                return;
            }
            else
            {
                base.HandleNext(choice);
            }
        }
    }
}
