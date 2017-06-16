namespace Chapter25.DefinitionCompletion
{
    public class Machine
    {
        public void Work()
        {
            // ...
        }
    }
}

//namespace Chapter25.DefinitionCompletion_1_2_3_4_5_6
//{
//    // Header.cs
//    public class Machine
//    {
//        public void Work();
//    }

//    // Source.cs
//    public void Machine::Work()
//    {
//        // ...
//    }

//    // Test.cs
//    <includes Header.cs>

//        void Machine::Work()
//    { };

//    void Work_XXX_XXX()
//    {
//        // Arrange
//        var machine = new Machine();

//        // Acr
//        machine.Work();
//    }
//}