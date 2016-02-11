namespace Blobs.Core.Factories
{
    using Interfaces;
    using Blobs.Models.Behaviors;

    public class BehaviorFactory : IBehaviorFactory
    {
        private const string ExceptionMessage = "Unknown behaviors type";

        public IBehavior Create(string behaviorName)
        {
            switch (behaviorName) {
                case "Aggressive":
                    return new Aggressive();
                case "Inflated":
                    return new Inflated();
                default:
                    throw new ArgumentException(ExceptionMessage);
            }
        }
    }
}
